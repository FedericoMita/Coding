package testmySQL;
import java.sql.*;
import java.util.Scanner;

public class Main {
	
	public static void main(String[] args) throws InstantiationException, IllegalAccessException, ClassNotFoundException, SQLException {
		
		Database db = new Database ("com.mysql.cj.jdbc.Driver", "jdbc:mysql://localhost:3306/library", "root", "PIPPOpappoPOPPO1969");
		
		Scanner sc = new Scanner(System.in);
		String option;
		Boolean running = true;
		Boolean invalid;
		
		while (running) {
			
			invalid = false;
			
			System.out.println("-------------------Library Application-------------------");
			System.out.println("Select from the following options:");
			System.out.println("   1: Show all users");
			System.out.println("   2: Show all books");
			System.out.println("   3: Show all users that have books loaned");
			System.out.println("   4: Show all books that are loaned by users");
			System.out.println("   5: Show all loaned books and the users who loaned them");
			System.out.println("   6: Show all overdue books");
			System.out.println("   7: Custom query");
			System.out.println("   8: Exit this program");
			System.out.print(">> ");
			
			option = sc.nextLine();
			
			switch (option) {
			
			case "1":
				db.query("SELECT * FROM Users;");
				break;
			case "2":
				db.query("SELECT * FROM Books;");
				break;
			case "3":
				db.query("SELECT l.user_id_loaned, u.First_Name, u.Last_Name FROM Loaned l JOIN Users u ON l.user_id_loaned=u.user_id;");
				break;
			case "4":
				db.query("SELECT l.ISBN_loaned, b.title, b.author_1, b.author_2, b.author_3, b.author_4, b.author_5, b.author_6, b.author_7, b.author_8, b.author_9, b.author_10 FROM Loaned l JOIN Books b on l.ISBN_loaned=b.ISBN;");
				break;
			case "5":
				db.query("SELECT l.user_id_loaned, u.First_Name, u.Last_Name, l.ISBN_loaned, b.title, b.author_1, b.author_2, b.author_3, b.author_4, b.author_5, b.author_6, b.author_7, b.author_8, b.author_9, b.author_10 FROM Loaned l JOIN users u ON l.user_id_loaned=u.user_id JOIN Books b on b.ISBN=l.ISBN_loaned");
				break;
			case "6":
				db.query("SELECT l.user_id_loaned, u.First_Name, u.Last_Name, b.title, b.author_1, b.author_2, b.author_3, b.author_4, b.author_5, b.author_6, b.author_7, b.author_8, b.author_9, b.author_10, l.due_date FROM Loaned l JOIN users u ON l.user_id_loaned=u.user_id JOIN Books b ON b.ISBN=l.ISBN_loaned WHERE due_date<CURDATE();");
				break;
			case "7":
				System.out.println("Please enter your query number:");
				db.query(sc.nextLine());
				break;
			case "8":
				running = false;
				break;
			}
			db.printResults();

		}
		
		
// Below it's the previous code used to test the db connection
//		
//		Statement stmt = null;
//		ResultSet rs = null;
//		
//		try {
//			Class.forName("com.mysql.cj.jdbc.Driver");
//			Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/library", "root", "PIPPOpappoPOPPO1969");
//			
//			stmt = conn.createStatement();
//			rs = stmt.executeQuery("SELECT * FROM Users;");
//			
//			while(rs.next()) {
//				System.out.println(rs.getInt("user_id") + " " + rs.getString("First_Name"));
//			}
//		} catch (SQLException e) {
//			e.printStackTrace();
//		}
	}

}

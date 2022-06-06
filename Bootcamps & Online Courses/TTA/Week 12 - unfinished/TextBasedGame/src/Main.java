import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Character player = new Character("Mario", 10, "It'sa Me, a-Mario");
		System.out.println(player.getCatchPhrase());
		System.out.println(player.getName());
		
		Map m = new Map(10,10);
		m.setCurrentX((int) Math.floor(Math.random()*10));
		m.setCurrentY((int) Math.floor(Math.random()*10));
		
		System.out.println();		

		try (Scanner sc = new Scanner(System.in)) {
			String direction;
			
			while (true) {
				System.out.println("Please enter a direction:");
				direction = sc.nextLine();
				m.move(direction.strip());

				if (m.getCurrentX() == 5 && m.getCurrentY() == 5) {
					System.out.println("Well done you have won!");
					break;
				}
			}
		}
		
	}

}

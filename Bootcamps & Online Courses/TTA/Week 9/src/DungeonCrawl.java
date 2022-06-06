import java.util.HashMap;
import java.util.Scanner;

public class DungeonCrawl {

	public static void main(String[] args) {
		//When you run this game, it will ask you two things: the name of your Character
		//and your Character's Alignment. To know what an alignment is visit http://www.easydamus.com/alignment.html
		//and choose one. Remember: it may change your options, choices and outcomes during the game.
		PlayingCharacter protagonist = new PlayingCharacter(20, 20, 15, 6);
		Scanner myScanner;
		myScanner = new Scanner(System.in);
		String name;
		System.out.println("Please enter your Character name:");
		name = myScanner.nextLine();
		System.out.println("Please enter the two initials, in capital letters, of your Character's Alignment:");
		String alignment;
		alignment = myScanner.nextLine();
		System.out.println("\n§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§");
		System.out.println("\n\t\tThe name of your character is " + name);
		System.out.println("\t\tYour maximum Health Score is " + protagonist.getMaxHealth());
		System.out.println("\t\tYour current Health Points are " + protagonist.getCurrentHealth());
		System.out.println("\t\tYour Attack Score is " + protagonist.getAttack());
		System.out.println("\t\tYour Defense Score is " + protagonist.getDefense());
		System.out.println("\t\tYour Alignment is " + alignment);
		System.out.println("\n§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§");

		
		System.out.println("\nChoose a direction to explore:\n\t\tN for North\n\t\tE for East\n\t\tS for South\n\t\tW for West");
		HashMap<String, String> directions = new HashMap<String, String>();//combining HashMap and Scanner to have single-letter input but the full word output
        int currentX = (int) (Math.random() * 11);
        int currentY = (int) (Math.random() * 11);
		Map nwse = new Map(10, 10, currentX, currentY);
		System.out.println("You are at line " + currentX + " and row " + currentY);
		do {
		directions.put("N", "North");
		directions.put("E", "East");
		directions.put("S", "South");
		directions.put("W", "West");
		String boh = myScanner.nextLine();
		nwse.move(boh);
		System.out.println("You are at line " + nwse.getCurrentX() + " and row " + nwse.getCurrentY());
		System.out.println("While walking " + directions.get(boh) + ", you encounter...");
		//below is a bit of code I never got to finish
		//switch (nwse.getCurrentX(), nwse.getCurrentY()) {
		//case(nwse.getCurrentX() == 8 && nwse.getCurrentY() ==8):
		//	System.out.println("\nThis was supposed to be a combat, but alas I had no time left");
		
		//}

		} while (!(nwse.getCurrentX() == 5 && nwse.getCurrentY() == 5));
		System.out.println("\nCongratulations, you escaped the dungeon!");
	}
}



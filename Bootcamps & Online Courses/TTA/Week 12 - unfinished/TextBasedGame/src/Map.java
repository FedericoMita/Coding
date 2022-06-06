import org.junit.Test;

public class Map {
	private int x; // Max x distance
	private int y; // Max y distance
	
	private int currentX; // Represents the player's x position
	private int currentY; // Represents the player's y position
	
	public Map(int x, int y) {
		this.x = x;
		this.y = y;
	}

	@Test
	public int getCurrentX() {
		return currentX;
	}

	@Test
	public void setCurrentX(int currentX) {
		this.currentX = currentX;
	}

	@Test
	public int getCurrentY() {
		return currentY;
	}

	@Test
	public void setCurrentY(int currentY) {
		this.currentY = currentY;
	}

	@Test
	public int getX() {
		return x;
	}

	@Test
	public int getY() {
		return y;
	}
	
	@Test
	public void move(String direction) {
		//"N", "S", "E", or "W"
		System.out.println(":" + direction + ":");
		switch (direction) {
			case "N":
				if (this.currentX == this.x) {
					this.currentX = 0;
				} else {
					setCurrentX(this.currentX + 1);
				}
				break;
			case "E":
				if (this.currentY == this.y) {
					this.currentY = 0;
				} else {
					this.currentY = this.currentY + 1;
				}
				break;
			case "S":
				if (this.currentX == 0) {
					this.currentX = this.x;
				} else {
					this.currentX = this.currentX - 1;
				}
				break;
			case "W":
				if (this.currentY == 0) {
					this.currentY = this.y;
				} else {
					this.currentY = this.currentY - 1;
				}
				break;
			default:
				System.out.println("That was not a recognised direction");
				break;
		}
		System.out.println("X:" + this.currentX + " Y:" + this.currentY);
	}
	
}

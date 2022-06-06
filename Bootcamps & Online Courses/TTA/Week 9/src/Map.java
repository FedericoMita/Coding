
public class Map {
	private int x, y, currentX, currentY;

	public Map(int x, int y, int currentX, int currentY) {
		this.x = x;
		this.y = y;
		this.currentX = currentX;
		this.currentY = currentY;
	}

	public int getX() {
		return this.x;
	}
	
	public int getY() {
		return this.y;
	}
	
	public int getCurrentX() {
		return this.currentX;
	}
	
	public int getCurrentY() {
		return this.currentY;
	}
	
	public void move(String direction) {
		if (direction.equals("N")) {
			if (this.currentX == this.x) {
				this.currentX = 0;
			} else {
				this.currentX = this.currentX +1;
			}
		} else if (direction.equals("E")) {
			if (this.currentY == this.y) {
				this.currentY = 0;
			} else {
				this.currentY = this.currentX +1;
			}		
		} else if (direction.equals("S")) {
			if (this.currentX == this.x) {
				this.currentX = 0;
			} else {
				this.currentX = this.currentX -1;
			}
		} else if (direction.equals("W")) {
			if (this.currentY == this.y) {
				this.currentY = 0;
			} else {
				this.currentY = this.currentY -1;
			}
		}
	}

	}

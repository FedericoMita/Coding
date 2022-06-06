import org.junit.Test;

public class Character {

	private String name;
	private int health;
	private String catchPhrase;
	
	public Character(String name, int health, String catchPhrase) {
		this.name = name;
		this.health = health;
		this.catchPhrase = catchPhrase;
	}

	@Test
	public int getHealth() {
		return health;
	}

	@Test
	public void setHealth(int health) {
		this.health = health;
	}

	@Test
	public String getName() {
		return name;
	}

	@Test
	public String getCatchPhrase() {
		return catchPhrase;
	}
	
}

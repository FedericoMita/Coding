
public class PlayingCharacter {
	private int maxHealth;
	private int currentHealth;
	private int attack;
	private int defense;
	
	public PlayingCharacter(int currentHealth, int maxHealth, int attack, int defense) {
		this.currentHealth = currentHealth;
		this.maxHealth = maxHealth;
		this.attack = attack;
		this.defense = defense;
	}
	
	public int getMaxHealth() {
		return maxHealth;
	}

	public void setMaxHealth(int maxHealth) {
		this.maxHealth = maxHealth;
	}
	
	public int getCurrentHealth() {
		return currentHealth;
	}

	public void setCurrentHealth(int currentHealth) {
		this.currentHealth = currentHealth;
	}
	
	public int getAttack() {
		return attack;
	}

	public void setAttack(int attack) {
		this.attack = attack;
	}

	public int getDefense() {
		return defense;
	}

	public void setDefense(int defense) {
		this.defense = defense;
	}
	
}

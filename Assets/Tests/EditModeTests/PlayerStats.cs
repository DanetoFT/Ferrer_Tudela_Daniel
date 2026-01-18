public class PlayerStats
{
    public int health;

    public PlayerStats(int initialHealth)
    {
        health = initialHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}

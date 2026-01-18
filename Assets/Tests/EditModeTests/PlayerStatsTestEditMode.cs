using NUnit.Framework;

public class PlayerStatsTestsEditMode
{
    [Test]
    public void TakeDamage_ReducesHealth()
    {
        PlayerStats player = new PlayerStats(100);

        player.TakeDamage(20);

        Assert.AreEqual(80, player.health);
    }

    [Test]
    public void Constructor_SetsInitialHealth()
    {
        // Arrange
        int initialHealth = 50;

        // Act
        PlayerStats player = new PlayerStats(initialHealth);

        // Assert
        Assert.AreEqual(50, player.health);
    }

    [Test]
    public void TakeDamage_CanGoBelowZero()
    {
        // Arrange
        PlayerStats player = new PlayerStats(10);

        // Act
        player.TakeDamage(20);

        // Assert
        Assert.Less(player.health, 0);
    }
}

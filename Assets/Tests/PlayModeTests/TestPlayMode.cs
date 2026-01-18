using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Collections;

public class TestPlayMode
{
    [UnityTest]
    public System.Collections.IEnumerator Player_CanBeCreated()
    {
        GameObject player = new GameObject();

        yield return null;

        Assert.IsTrue(player.activeInHierarchy);
    }

    [UnityTest]
    public IEnumerator GameObject_CanAddComponent()
    {
        // Arrange
        GameObject player = new GameObject("Player");

        // Act
        player.AddComponent<BoxCollider>();

        yield return null;

        // Assert
        Assert.IsNotNull(player.GetComponent<BoxCollider>());
    }

    [UnityTest]
    public IEnumerator GameObject_CanBeActivatedAndDeactivated()
    {
        // Arrange
        GameObject player = new GameObject("Player");
        player.SetActive(false);

        yield return null;

        // Act
        player.SetActive(true);

        yield return null;

        // Assert
        Assert.IsTrue(player.activeSelf);
    }
}

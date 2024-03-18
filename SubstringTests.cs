using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expected = "The quick brown jumps over the lazy dog";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "Hello";
        string input = "Hello, my name is Diana.";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expected = ", my name is Diana.";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = ", friendship, love, and loss";
        string input = "The story follows a young prince who visits various planets, including Earth, and addresses themes of loneliness, friendship, love, and loss.";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expected = "The story follows a young prince who visits various planets, including Earth, and addresses themes of loneliness.";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "The";
        string input = "The  quick brown fox    jumps    over the    lazy dog";
        string expected = "quick brown fox jumps over lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "Test a given method which takes in an array of strings";
        string[] bennedWords = new string[] { "no", "yes", "banned words" };

        // Act
        string actual = TextFilter.Filter(bennedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string text = "Test a given method which takes in an array of strings";
        string[] bennedWords = new string[] { "given", "an", "strings" };
        string expected = "Test a ***** method which takes in ** array of *******";

        // Act
        string actual = TextFilter.Filter(bennedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {   // Arrange
        string text = "Test a given method which takes in an array of strings";
        string[] bennedWords = new string[] { };
        string expected = text;

        // Act
        string actual = TextFilter.Filter(bennedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string text = "Test a given method which takes in an array of strings";
        string [] bennedWords = new string[] { "Test a given", "an", "strings" };
        string expected = "************ method which takes in ** array of *******";

        // Act
        string actual = TextFilter.Filter(bennedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

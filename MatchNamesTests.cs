using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchNamesTests
{
    [TestCase("John Smith and Alice Johnson", "John Smith Alice Johnson")]
    [TestCase("Diana Rangelova is here", "Diana Rangelova")]
    [TestCase("Hello, Ralitsa Lazarova", "Ralitsa Lazarova")]
    public void Test_Match_ValidNames_ReturnsMatchedNames(string input, string expected)
    {
        // Act
        string result = MatchNames.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("Hello, Pepi my friend", "")]
    [TestCase("Pepi", "")]
    [TestCase("diana Rangelova", "")]
    [TestCase("diana rangelova", "")]
    [TestCase("Diana rangelova", "")]
    [TestCase("Diana-Rangelova", "")]
    public void Test_Match_NoValidNames_ReturnsEmptyString(string input, string expected)
    {
        // Act
        string result = MatchNames.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("", "")]
    public void Test_Match_EmptyInput_ReturnsEmptyString(string input, string expected)
    {
        // Act
        string result = MatchNames.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    [TestCase("+359-2-124-5678, +359 2 986 5432, +359-2-555-5555",
        "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555")]

    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers(string input, string expected)
    {
        // Act
        string result = MatchPhoneNumbers.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("+042-2-124-5678, +444 2 986 5432, +358-2-555-5555", "")]
    [TestCase("+359-2-555-555", "")]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString(string input, string expected)
    {
        // Act
        string result = MatchPhoneNumbers.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("", "")]
    public void Test_Match_EmptyInput_ReturnsEmptyString(string input, string expected)
    {
        // Act
        string result = MatchPhoneNumbers.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("+042-2-124-5678, +444 2 986 5432, +359-2-555-5555", "+359-2-555-5555")]
    [TestCase("+359-2-124-567, +359 2 986 5432, +359-2-555-5555",
        "+359 2 986 5432, +359-2-555-5555")]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers(string input, string expected)
    {
        // Act
        string result = MatchPhoneNumbers.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

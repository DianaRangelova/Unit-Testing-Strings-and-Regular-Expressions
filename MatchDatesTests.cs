using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    [TestCase("31-Dec-2022", "Day: 31, Month: Dec, Year: 2022")]
    [TestCase("31.Dec.2022", "Day: 31, Month: Dec, Year: 2022")]
    [TestCase("31/Dec/2022", "Day: 31, Month: Dec, Year: 2022")]
    public void Test_Match_ValidDate_ReturnsExpectedResult(string input, string expected)
    {
        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("31-Dec/2022", "")]
    [TestCase("31-Dec.2022", "")]
    [TestCase("31 Dec-2022", "")]
    
    public void Test_Match_NoMatch_ReturnsEmptyString(string input, string expected)
    {
        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("12/Sep/2022 24-Noe-2024", "Day: 12, Month: Sep, Year: 2022")]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch(string input, string expected)
    {
        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("", "")]
    public void Test_Match_EmptyString_ReturnsEmptyString(string input, string expected)
    {
        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("", null)]
    public void Test_Match_NullInput_ThrowsArgumentException(string input, string expected)
    {
        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.Throws<ArgumentException>(() => MatchDates.Match(expected));
    }
}

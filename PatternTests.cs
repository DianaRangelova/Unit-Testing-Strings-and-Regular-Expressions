using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("abc", 3, "aBcaBcaBc")]
    [TestCase("ab", 3, "aBaBaB")]
    [TestCase("z", 3, "zzz")]
    [TestCase("123", 1, "123")]
    [TestCase("1", 1, "1")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("another", -10)]
    [TestCase("", 10)]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException(string input, int repetitionFactor)
    {
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input,repetitionFactor));
    }

    [TestCase("valid", 0)]
    [TestCase("some", -1)]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException(string input, int repetitionFactor)
    {
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [TestCase(null, 10)]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException(string input, int repetitionFactor)
    {
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }
}

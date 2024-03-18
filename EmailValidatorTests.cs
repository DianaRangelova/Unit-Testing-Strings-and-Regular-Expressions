using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("diana.rangelova@gmail.com")]
    [TestCase("diana_rangelova@gmail.com")]
    [TestCase("diana_rangelova@abv.bg")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("diana.rangelova.com")]
    [TestCase("diana.rangelova%gmail.com")]
    [TestCase("diana_rangelova@gmailcom")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}

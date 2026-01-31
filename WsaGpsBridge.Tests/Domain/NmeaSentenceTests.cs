using WsaGpsBridge.Core.Domain.Entities;

namespace WsaGpsBridge.Tests.Domain;

[TestFixture]
public class NmeaSentenceTests
{
    [Test]
    public void Should_Be_Valid_When_Content_Starts_With_Dollar_Sign()
    {
        // Arrange
        var rawNmea = "$GPGGA,123519,4807.038,N,01131.000,E,1,08,0.9,545.4,M,46.9,M,,*47";

        // Act
        var sentence = new NmeaSentence(rawNmea);

        Assert.Multiple(() =>
        {
            // Assert
            Assert.That(sentence.IsValid, Is.True);
            Assert.That(sentence.ToString(), Is.EqualTo(rawNmea));
        });
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase("   ")]
    [TestCase("Hello World")]
    [TestCase("!GPGGA")]
    public void Should_Be_Invalid_When_Content_Is_Incorrect(string? badInput)
    {
        // Act
        var sentence = new NmeaSentence(badInput);

        Assert.Multiple(() =>
        {
            // Assert
            Assert.That(sentence.IsValid, Is.False);
            Assert.That(sentence.ToString(), Is.Empty, "Invalid sentence should return empty string");
        });
    }
}

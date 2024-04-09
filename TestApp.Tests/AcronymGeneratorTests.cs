using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class AcronymGeneratorTests
{
    [Test]
    public void Test_GenerateAcronym_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GenerateAcronym_SingleWord_ReturnsUpperCaseFirstLetter()
    {
        // Arrange
        string input = "dimityr";
        string expected = "D";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GenerateAcronym_MultipleWords_ReturnsUpperCaseFirstLetters()
    {
        // Arrange
        string input = "Dimityr Robertov";
        string expected = "DR";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

        [Test]
    public void Test_GenerateAcronym_WordsWithNonLetters_ReturnsAcronymWithoutNonLetters()
    {
        // Arrange
        string input = "86d Dimityr Robertov";
        string expected = "DR";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GenerateAcronym_PhraseWithSpecialCharacters_ReturnsUpperCaseFirstLetters()
    {
        // Arrange
        string input = "Dimityr, Robertov!";
        string expected = "DR";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}

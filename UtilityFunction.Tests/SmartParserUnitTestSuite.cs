using Farrellsoft.UtilityFunctions.Parsers;

namespace UtilityFunction.Tests;

public class SmartParserUnitTestSuite
{
    [Fact]
    public void ValidIntNumericStringParsedToValue()
    {
        // arrange
        var strValue = "86";
        
        // act
        var intValue = strValue.AsInt();
        
        // assert
        Assert.Equal(86, intValue);
    }

    [Fact]
    public void InvalidIntNumericStringReturnsMinValByDefault()
    {
        // arrange
        var strValue = "abc";
        
        // act
        var intValue = strValue.AsInt();
        
        // assert
        Assert.Equal(int.MinValue, intValue);
    }

    [Fact]
    public void InvalidIntNumericStringWithReturnsGivenDefaultValue()
    {
        // arrange
        var strValue = "abc";
        
        // act
        var intValue = strValue.AsInt(86);
        
        // assert
        Assert.Equal(86, intValue);
    }

    [Fact]
    public void ValidLongNumericStringParsedToValue()
    {
        // arrange
        var strValue = (long.MaxValue - 1).ToString();
        
        // act
        var longValue = strValue.AsLong();
        
        // assert
        Assert.Equal(long.MaxValue - 1, longValue);
    }

    [Fact]
    public void InvalidLongNumericStringReturnsMinValByDefault()
    {
        // arrange
        var strValue = "abc";
        
        // act
        var longValue = strValue.AsLong();
        
        // assert
        Assert.Equal(long.MinValue, longValue);
    }

    [Fact]
    public void InvalidLongNumericStringWithReturnsGivenDefaultValue()
    {
        // arrange
        var strValue = "abc";
        
        // act
        var longValue = strValue.AsLong(long.MaxValue - 1);
        
        // assert
        Assert.Equal(long.MaxValue - 1, longValue);
    }

    [Fact]
    public void ValidFloatNumericStringParsedToValue()
    {
        // arrange
        var strValue = (float.MaxValue - 1).ToString();
        
        // act
        var floatValue = strValue.AsFloat();
        
        // arrange
        Assert.Equal(float.MaxValue - 1, floatValue);
    }

    [Fact]
    public void InvalidFloatNumericStringReturnsMinValByDefault()
    {
        // arrange
        var strValue = "abc";
        
        // act
        var floatValue = strValue.AsFloat();
        
        // assert
        Assert.Equal(float.MinValue, floatValue);
    }

    [Fact]
    public void InvalidFloatNumericStringWithReturnsGivenDefaultValue()
    {
        // arrange
        var strValue = "abc";
        
        // act
        var floatValue = strValue.AsFloat(float.MaxValue);
        
        // assert
        Assert.Equal(float.MaxValue, floatValue);
    }

    [Fact]
    public void ValidDoubleNumericStringParsedToValue()
    {
        // arrange
        var strValue = (double.MaxValue - 1).ToString();
        
        // act
        var doubleValue = strValue.AsDouble();
        
        // assert
        Assert.Equal(double.MaxValue - 1, doubleValue);
    }

    [Fact]
    public void InvalidDoubleNumericStringReturnsMinValByDefault()
    {
        // arrange
        var strValue = "abc";
        
        // act
        var doubleValue = strValue.AsDouble();
        
        // assert
        Assert.Equal(double.MinValue, doubleValue);
    }

    [Fact]
    public void InvalidDoubleNumericStringWithReturnsGivenDefaultValue()
    {
        // arrange
        var strValue = "abc";
        
        // act
        var doubleValue = strValue.AsDouble(double.MaxValue - 1);
        
        // assert
        Assert.Equal(double.MaxValue - 1, doubleValue);
    }
}
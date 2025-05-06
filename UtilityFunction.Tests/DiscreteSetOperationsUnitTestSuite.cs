using Farrellsoft.UtilityFunctions;

namespace UtilityFunction.Tests;

public class DiscreteSetOperationsUnitTestSuite
{
    [Fact]
    public void SymmetricDifferenceWithSourceSetMatchingOther()
    {
        // arrange
        var set1 = new List<int> { 1, 2, 3 };
        var set2 = new List<int> { 1, 2, 3 };
        
        // act
        var difference = set1.SymmetricDifference(set2);
        
        // assert
        Assert.Empty(difference);
    }
}
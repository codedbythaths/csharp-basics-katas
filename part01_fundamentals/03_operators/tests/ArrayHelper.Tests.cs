using Operators;
using NUnit.Framework;

namespace Operators.Tests;

[TestFixture]
public class ArrayHelperTests
{
    [Test]
    public void Max_ReturnsLargestNumer()
    {
        var number = new[] { 1, 2, 3, 4, 5 };
        var result = ArrayHelper.FindMax(number);
        Assert.That(result, Is.EqualTo(5));
    }
}
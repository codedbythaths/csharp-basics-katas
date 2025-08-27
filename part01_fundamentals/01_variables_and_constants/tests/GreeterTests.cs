using NUnit.Framework; // this is my test framework namespace, brings in NUnit's attributes ([Test], [TestFixture], ect.) and assertions (Assert.That).
using VariablesAndConstants; // this is my classlib namespace

namespace VariablesAndConstants.Tests; // this is my test namespace, These are tests for the VariablesAndConstants csproj.

[TestFixture]
public class GreeterTests
{
    private Greeter greeter;

    [SetUp]
    public void Setup()
    {
        greeter = new Greeter();
    }

    [Test] // Marks this method as a test method, [Test] tells NUnit this is an individual test case.
    public void SayHello_ReturnsHelloWorld()
    {
        var result = greeter.SayHello();
        Assert.That(result, Is.EqualTo("Hello world")); // This test checks that the SayHello method returns the expected string, Assert.That(actual, constraint) → NUnit syntax for assertions.
    }
}

using NUnit.Framework;
using Operators;

namespace Operators.Tests;

public class TrafficLightSimulatorTests
{
    private TrafficLightSimulator _simulator;
    [SetUp]
    public void Setup()
    {
        _simulator = new TrafficLightSimulator(); // Initialize a new instance before each test
    }

    [Test]
    public void StartsAt_Red()
    {
        Assert.That(_simulator.CurrentLight, Is.EqualTo(TrafficLight.Red));
    }

    [Test]
    public void ChangesFrom_Red_To_Green()
    {
        _simulator.ChangeLight(); // 1 step: Red -> Green
        Assert.That(_simulator.CurrentLight, Is.EqualTo(TrafficLight.Green));
    }

    [Test]
    public void ChangesFrom_Green_To_Yellow()
    {
        _simulator.ChangeLight(); // Red -> Green (1st)
        _simulator.ChangeLight(); // Green -> Yellow (2nd)
        Assert.That(_simulator.CurrentLight, Is.EqualTo(TrafficLight.Yellow));
    }

    [Test]
    public void ChangesFrom_Yellow_To_Red()
    {
        _simulator.ChangeLight(); // Red -> Green (1st)
        _simulator.ChangeLight(); // Green -> Yellow (2nd)
        _simulator.ChangeLight(); // Yellow -> Red (3rd)
        Assert.That(_simulator.CurrentLight, Is.EqualTo(TrafficLight.Red));
    }
}

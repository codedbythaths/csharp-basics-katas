using System;

namespace Operators
{
    public enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    public class TrafficLightSimulator
    {
        public TrafficLight CurrentLight { get; private set; } // Property to get the current traffic light with private setter

        public TrafficLightSimulator() // Constructor this runs when you create a new TrafficLightSimulator
        {
            CurrentLight = TrafficLight.Red; // Initialize the current light to Red
        }

        public void ChangeLight() // Method to change the traffic light with switch expression
        {
            var before = CurrentLight;
            CurrentLight = CurrentLight switch // Switch expression to determine the next traffic light
            {
                TrafficLight.Red => TrafficLight.Green, // If CurrentLight is TrafficLight.Red, the result will be TrafficLight.Green.
                TrafficLight.Green => TrafficLight.Yellow,
                TrafficLight.Yellow => TrafficLight.Red,
                _ => TrafficLight.Red // Default case, should never be hit
            };
            Console.WriteLine($"Changed: {before} -> {CurrentLight}");
        }
    }
}
using DvtElevatorChallenge;

namespace DvtElevator
{
    internal class Program
    {
        private const int MAX_ALPHABET_SIZE = 26; // max number of elevators ; corresponds to the alphabet size in this case
        private const int MAX_NUMBER_OF_FLOORS = 160; // setup a constant for maximum number of floors , int this case 160 floor maximum
        private const int MAX_NUMBER_OF_PEOPLE = 80; // this is a constant for the maximum number of people that can wait for the elevator on each floor
        static void Main(string[] args)
        {
            // Initialize the building with 8 elevators in this case, each with a capacity of 10 persons 
            // The maximum number of floors for this building is 25 in this case
            List<char> elevatorsList = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};
            int maximumCapacity = 10;
            FloorType type = new FloorType(22,2); // the building is going to have 23(above+ground floor) floors and 2 undeground ones
            int numberOfFloors = type.AbovegroundFloors + type.UndergroundFloors+1;
            Building building = new Building(ref elevatorsList, maximumCapacity, type, numberOfFloors, MAX_ALPHABET_SIZE, MAX_NUMBER_OF_FLOORS,MAX_NUMBER_OF_PEOPLE);
            // Simulate elevator calls
            building.CallElevator(5, 4, 0);
            building.CallElevator(7, 3, 2);
        }
    }
}
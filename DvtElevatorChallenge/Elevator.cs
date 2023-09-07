using DvtElevatorChallenge.Enums;
using DvtElevatorChallenge.Interfaces;

namespace DvtElevatorChallenge
{
    public class Elevator : IElevator
    {
        public char Identificator { get; set; } // the identificator is going to be a letter from the alphabet like A, B, C ....
        public int CurrentFloor { get; private set; }
        public Direction CurrentDirection { get; private set; }
        public ElevatorStatus Status { get; private set; }
        public int Capacity { get; private set; }
        public int Occupancy { get; private set; }

        public Elevator(char name, int capacity)
        {
            Identificator = name;
            CurrentFloor = 0; // Starting at the ground floor
            CurrentDirection = Direction.Idle;
            Status = ElevatorStatus.Stopped;
            Capacity = capacity;
            Occupancy = 0;
        }

        public void MoveToFloor(int targetFloor)
        {
            if (targetFloor > CurrentFloor)
            {
                CurrentDirection = Direction.Up;
            }
            else if (targetFloor < CurrentFloor)
            {
                CurrentDirection = Direction.Down;
            }
            else
            {
                CurrentDirection = Direction.Idle;
            }

            Status = ElevatorStatus.Moving;
            Console.WriteLine($"Elevator moving {CurrentDirection} to floor {targetFloor}");
            CurrentFloor = targetFloor;
            Status = ElevatorStatus.Stopped;
        }

        public void LoadPeople(int peopleCount)
        {
            if (Occupancy + peopleCount <= Capacity)
            {
                Occupancy += peopleCount;
                Console.WriteLine($"{peopleCount} people loaded. Occupancy: {Occupancy}/{Capacity}");
            }
            else
            {
                Console.WriteLine("Elevator is at capacity. Cannot load more people.");
            }
        }

        public void UnloadPeople(int peopleCount)
        {
            if (Occupancy >= peopleCount)
            {
                Occupancy -= peopleCount;
                Console.WriteLine($"{peopleCount} people unloaded. Occupancy: {Occupancy}/{Capacity}");
            }
            else
            {
                Console.WriteLine($"Invalid request. Trying to unload more people than inside the elevator.");
            }
        }
    }
}

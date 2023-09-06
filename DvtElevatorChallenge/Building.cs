using DvtElevatorChallenge.Enums;
using DvtElevatorChallenge.Interfaces;

namespace DvtElevatorChallenge
{
    // Building class to manage multiple elevators and floors
    public class Building : IBuilding
    {
        // list of elevators that are presented in the building
        private List<Elevator>? elevators;
        // list containing the number of people waiting for the elevator on each floor of the building
        private List<int>? peopleWaitingForTheElevator;
        // stores the list of available elevators from the building ( those who are idle )
        private List<Elevator>? availableElevators;
        private FloorType buildingsFloorType;

        public Building(ref List<char> elevatorNamesList,
                        int elevatorCapacity,
                        FloorType floorType,                // stores the type of floor underground of above it
                        int buildingsMaxNumberOfFloors,
                        int elevatorsListMaxSize,
                        int maxNumberOfFloors,
                        int maxNumberOfPeopleOnEachFloor)
        {
            if (elevatorNamesList.Count <= elevatorsListMaxSize || (buildingsMaxNumberOfFloors > 0 && buildingsMaxNumberOfFloors < maxNumberOfFloors))
            {
                elevators = new List<Elevator>(elevatorNamesList.Count);
                availableElevators = new List<Elevator>();
                peopleWaitingForTheElevator = new List<int>();
                buildingsFloorType = floorType;
                for (int i = 0; i < elevatorNamesList.Count; i++)
                    elevators.Add(new Elevator(elevatorNamesList[i], elevatorCapacity));
                peopleWaitingForTheElevator = RandomGenerator.GenerateRandInts(buildingsMaxNumberOfFloors, maxNumberOfPeopleOnEachFloor);
            }
        }

        public string DisplayStatusAboutNumberOfElevators() 
        {
            string status = string.Empty;
            if (elevators != null && elevators.Count > 0)
                status = "This building has " + elevators.Count + "elevators.";
            else
                status = "This building has no elevators."; // you have to take the stairs

            return status;
        }

        public void CallElevator(int targetFloor, int peopleToLoadCount, int peopleToUnloadCount) // we have 2 parameters
        {                                                                                         // peopleToLoadCount - number of people to get into the elevator
            Elevator? nearestElevator = FindNearestElevator(targetFloor);                         // peopleToUnloadCount - number of people to get into the elevator

            if (nearestElevator != null && targetFloor >= (0-buildingsFloorType.UndergroundFloors) && targetFloor < buildingsFloorType.AbovegroundFloors - 1)
            {
                nearestElevator.MoveToFloor(targetFloor);
                if (nearestElevator.HasPeopleToUnload == true && peopleToUnloadCount <= nearestElevator.Occupancy)  // we have to check if the people to unload <= total number of persons
                                                                                                                    // that are into the elevator at that specific time 
                    nearestElevator.UnloadPeople(peopleToUnloadCount);                                        
                nearestElevator.LoadPeople(peopleToLoadCount);
            }
            else
                Console.WriteLine("No available elevator.");
        }

        private List<Elevator>? GetAvailableElevators(ref List<Elevator> elevators)  // this returns available elevators
        {
            
            if (elevators.Count > 0 && availableElevators != null) 
            {
                availableElevators.Clear();
                foreach (Elevator e in elevators)
                    if (e.Status.Equals(ElevatorStatus.Stopped))
                        availableElevators.Add(e);
            }
            
            return availableElevators;
        }

        private Elevator? FindNearestElevator(int targetFloor)   // find nearest elevator available
        { 
            Elevator? closestElevator = null;
            if (elevators != null) 
            {
                var availableElevators = GetAvailableElevators(ref elevators);
                if(availableElevators != null)
                    closestElevator =  availableElevators.OrderBy(e => Math.Abs(e.CurrentFloor - targetFloor)).FirstOrDefault();
            }
           
            return closestElevator;
        }
    }
}

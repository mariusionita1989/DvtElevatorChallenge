using DvtElevatorChallenge.Interfaces;

namespace DvtElevatorChallenge.Tests
{
    public class BuildingTests
    {
        [Fact]
        public void CallElevator_WithValidInputs_ElevatorMoves()
        {
            // Arrange
            List<char> elevatorNames = new List<char> { 'A', 'B', 'C' };
            int elevatorCapacity = 10;
            FloorType floorType = new FloorType(2,7);
            int maxNumberOfFloors = 10;
            int elevatorsListMaxSize = 3;
            int maxNumberOfPeopleOnEachFloor = 20;
            Building building = new Building(ref elevatorNames, elevatorCapacity, floorType, maxNumberOfFloors, elevatorsListMaxSize, maxNumberOfFloors, maxNumberOfPeopleOnEachFloor);

            // Act
            building.CallElevator(5,3,0);

            // Assert
            Assert.Equal("This building has " + elevatorNames.Count + "elevators.", building.DisplayStatusAboutNumberOfElevators());
        }

        [Fact]
        public void CallElevator_WithNoAvailableElevators_ReturnsNoAvailableElevatorMessage()
        {
            // Arrange
            List<char> elevatorNames = new List<char>();
            int elevatorCapacity = 10;
            FloorType floorType = new FloorType();
            int maxNumberOfFloors = 10;
            int elevatorsListMaxSize = 1;
            int maxNumberOfPeopleOnEachFloor = 20;
            Building building = new Building(ref elevatorNames, elevatorCapacity, floorType, maxNumberOfFloors, elevatorsListMaxSize, maxNumberOfFloors, maxNumberOfPeopleOnEachFloor);

            // Assert
            Assert.Equal("This building has no elevators.", building.DisplayStatusAboutNumberOfElevators());
        }

        [Fact]
        public void CallElevator_WithInvalidInputs_ElevatorMoves()
        {
            // Arrange
            List<char> elevatorNames = new List<char> { 'A', 'B', 'C' };
            int elevatorCapacity = 10;
            FloorType floorType = new FloorType(2, 7);
            int maxNumberOfFloors = 10;
            int elevatorsListMaxSize = 3;
            int maxNumberOfPeopleOnEachFloor = 20;
            Building building = new Building(ref elevatorNames, elevatorCapacity, floorType, maxNumberOfFloors, elevatorsListMaxSize, maxNumberOfFloors, maxNumberOfPeopleOnEachFloor);

            // Act
            bool status = building.CallElevator(5,-3,-1);

            // Assert
            Assert.False(status);
        }
    }
}
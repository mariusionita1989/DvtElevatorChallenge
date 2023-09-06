using DvtElevatorChallenge.Interfaces;

namespace DvtElevatorChallenge.Tests
{
    public class ElevatorTests
    {
        [Fact]
        public void MoveToFloor_MoveUp_ElevatorMovesUp()
        {
            // Arrange
            char elevatorName = 'A';
            int elevatorCapacity = 10;
            Elevator elevator = new Elevator(elevatorName, elevatorCapacity);

            // Act
            elevator.MoveToFloor(5);

            // Assert
            Assert.Equal("Up", elevator.CurrentDirection.ToString());
        }

        [Fact]
        public void LoadPeople_WithinCapacity_PeopleLoaded()
        {
            // Arrange
            char elevatorName = 'A';
            int elevatorCapacity = 10;
            int peopleCount = 3;
            Elevator elevator = new Elevator(elevatorName, elevatorCapacity);

            // Act
            elevator.LoadPeople(peopleCount);

            // Assert
            Assert.Equal(peopleCount.ToString(), elevator.Occupancy.ToString());
        }

        [Fact]
        public void LoadPeople_ExceedsCapacity_CannotLoadMorePeopleMessage()
        {
            // Arrange
            char elevatorName = 'A';
            int elevatorCapacity = 10;
            int peopleCount = 12;
            Elevator elevator = new Elevator(elevatorName, elevatorCapacity);

            // Act
            elevator.LoadPeople(peopleCount);

            // Assert
            Assert.NotEqual(peopleCount, elevator.Capacity);
        }

        [Fact]
        public void UnloadPeople_ValidRequest_PeopleUnloaded()
        {
            // Arrange
            char elevatorName = 'A';
            int elevatorCapacity = 10;
            int peopleCount = 5;
            int unloadedPeopleCount = 3;
            Elevator elevator = new Elevator(elevatorName, elevatorCapacity);
            elevator.LoadPeople(peopleCount);

            // Act
            elevator.UnloadPeople(unloadedPeopleCount);

            // Assert
            Assert.Equal(peopleCount-unloadedPeopleCount, elevator.Occupancy);
        }

        [Fact]
        public void UnloadPeople_InvalidRequest_TryingToUnloadMorePeopleMessage()
        {
            // Arrange
            char elevatorName = 'A';
            int elevatorCapacity = 10;
            int unloadedPeopleCount = 3;
            Elevator elevator = new Elevator(elevatorName, elevatorCapacity);

            // Act
            elevator.UnloadPeople(unloadedPeopleCount);

            // Assert
            Assert.NotEqual(unloadedPeopleCount, elevator.Occupancy);
        }
    }
}

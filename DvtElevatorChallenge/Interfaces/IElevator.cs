namespace DvtElevatorChallenge.Interfaces
{
    public interface IElevator
    {
        void MoveToFloor(int targetFloor);
        void LoadPeople(int peopleCount);
        void UnloadPeople(int peopleCount);
    }

}

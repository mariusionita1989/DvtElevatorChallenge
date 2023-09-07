namespace DvtElevatorChallenge.Interfaces
{
    public interface IBuilding
    {
        string DisplayStatusAboutNumberOfElevators();
        bool CallElevator(int targetFloor, int peopleCount, int peopleToUnloadCount);
    }

}

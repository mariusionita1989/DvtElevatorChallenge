namespace DvtElevatorChallenge.Interfaces
{
    public interface IBuilding
    {
        string DisplayStatusAboutNumberOfElevators();
        void CallElevator(int targetFloor, int peopleCount, int peopleToUnloadCount);
    }

}

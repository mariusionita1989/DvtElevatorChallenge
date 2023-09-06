namespace DvtElevatorChallenge
{
    public struct FloorType
    {
        public FloorType(int above, int undeground)
        {
            AbovegroundFloors = above;
            UndergroundFloors = undeground;
        }

        public int AbovegroundFloors { get; set; } = 0; // number of floors above ground
        public int UndergroundFloors { get; set; } = 0; // number of floors underground
        // we can find out how many floors the building has by adding them (sum the above and underground floor and add 1)
    }
}

namespace MyHomeProject
{
    internal class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
        {
            this.doorDescription = doorDescription;
        }

        string doorDescription;
        public string DoorDescription { get { return doorDescription; } }

        public Location DoorLocation { get; set; }

        public override string Description { get { return base.Description + " You see " + doorDescription + ".\r\n"; } }
    }
}

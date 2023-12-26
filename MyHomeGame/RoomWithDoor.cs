namespace MyHomeGame
{
    internal class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration, "Atrás da Porta")
        {
            this.doorDescription = doorDescription;
        }

        string doorDescription;
        public string DoorDescription { get { return doorDescription; } }

        public Location DoorLocation { get; set; }

        public override string Description { get { return base.Description + " You see " + doorDescription + ".\r\n"; } }
    }
}

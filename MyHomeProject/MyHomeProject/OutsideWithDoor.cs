namespace MyHomeProject
{
    internal class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            this.doorDescription = doorDescription;
        }

        string doorDescription;
        public string DoorDescription { get { return doorDescription; } }

        public Location DoorLocation { get; set; }

        public override string Description { get { return base.Description + " You see " + doorDescription + ".\r\n"; } }
    }
}

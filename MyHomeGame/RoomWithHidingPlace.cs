namespace MyHomeGame
{
    internal class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(name, decoration)
        {
            this.hidingPlaceName = hidingPlace;
        }

        private string hidingPlaceName;
        public string HidingPlaceName { get { return hidingPlaceName; } }
    }
}

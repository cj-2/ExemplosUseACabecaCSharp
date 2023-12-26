namespace MyHomeGame
{
    internal class OutsideWithHidingPlace: Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace) : base(name, hot)
        {
            this.hidingPlaceName = hidingPlace;
        }

        private string hidingPlaceName;
        public string HidingPlaceName { get { return hidingPlaceName; } }

    }
}

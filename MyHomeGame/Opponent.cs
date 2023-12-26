using System;

namespace MyHomeGame
{
    internal class Opponent
    {
        public Opponent(Location location)
        {
            myLocation = location;
            random = new Random();
        }

        private Location myLocation;
        private Random random;

        public void Move()
        {
            if (myLocation is IHasExteriorDoor && random.Next(2) == 1)
                myLocation = (myLocation as IHasExteriorDoor).DoorLocation;

            myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
            if (!(myLocation is IHidingPlace)) Move();
        }

        public bool Check(Location checkLocation)
        {
            return (checkLocation.Name == myLocation.Name);
        }
    }
}

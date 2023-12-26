using System;
using System.Windows.Forms;

namespace MyHomeProject
{
    public partial class Form1 : Form
    {
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;

        Room dinningRoom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;

        Outside garden;

        Location currentLocation;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door");

            dinningRoom = new Room("Dinning Room", "a crystal chandelier");

            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");

            garden = new Outside("Garden", false);

            livingRoom.Exits = new Location[] { dinningRoom, frontYard };
            dinningRoom.Exits = new Location[] { kitchen, livingRoom };
            kitchen.Exits = new Location[] { backYard, dinningRoom };
            backYard.Exits = new Location[] { garden, kitchen };
            garden.Exits = new Location[] { frontYard, backYard };
            frontYard.Exits = new Location[] { livingRoom, garden };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

        }

        void MoveToANewLocation(Location location)
        {
            currentLocation = location;
            exits.Items.Clear();

            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);

            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description;
            goThroughTheDoor.Visible = currentLocation is IHasExteriorDoor ? true : false;
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            if (currentLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor locationWithDoor = currentLocation as IHasExteriorDoor;
                MoveToANewLocation(locationWithDoor.DoorLocation);
            }
        }
    }
}

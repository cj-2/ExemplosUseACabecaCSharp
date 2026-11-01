using System;
using System.Windows.Forms;

namespace MyHomeGame
{
    public partial class GameForm : Form
    {
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;

        Room escadas;
        Room dinningRoom;
        Room hallSuperior;
        Room quartoPrincipal;
        Room quartoSecundario;
        Room banheiro;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;

        Outside garden;
        Outside calcada;

        Location currentLocation;
        Opponent opponent;
        bool gameStarted;
        int moves;

        public GameForm()
        {
            InitializeComponent();
            RedrawForm();
        }

        void StartGame()
        {
            CreateObjects();

            opponent = new Opponent(garden);
            gameStarted = true;
            moves = 0;
        }

        void RedrawForm()
        {
            exits.Visible = gameStarted;
            goHere.Visible = gameStarted;
            hide.Visible = !gameStarted;
            goThroughTheDoor.Visible = currentLocation is IHasExteriorDoor && gameStarted ? true : false;


            if (currentLocation is IHidingPlace && gameStarted)
            {
                check.Visible = true;
                check.Text = "Procurar em " + (currentLocation as IHidingPlace).HidingPlaceName;
            }
            else check.Visible = false;

            if (!gameStarted) return;

            if (exits.Visible && currentLocation != null)
            {
                exits.Items.Clear();

                for (int i = 0; i < currentLocation.Exits.Length; i++)
                    exits.Items.Add(currentLocation.Exits[i].Name);

                exits.SelectedIndex = 0;

            }

            if (currentLocation != null) description.Text = currentLocation.Description + "\r\nMovimentos: " + moves;
        }

        void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Sala de Estar", "an antique carpet", "an oak door with a brass knob");
            kitchen = new RoomWithDoor("Cozinha", "stainless steel appliances", "a screen door");

            dinningRoom = new Room("Sala de Jantar", "a crystal chandelier");
            escadas = new Room("Escadas", "Corrimão de madeira");

            hallSuperior = new RoomWithHidingPlace("Hall Superior", "Quadro de um cachorro", "Armário");
            quartoPrincipal = new RoomWithHidingPlace("Quarto Principal", "Cama grande", "Cama");
            quartoSecundario = new RoomWithHidingPlace("Quarto Secundário", "Cama pequena", "Cama");
            banheiro = new RoomWithHidingPlace("Banheiro", "Pia e vaso sanitário", "Chuveiro");

            frontYard = new OutsideWithDoor("Quintal da Frente", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Quintal dos Fundos", true, "a screen door");

            garden = new OutsideWithHidingPlace("Jardim", false, "Galpão");
            calcada = new OutsideWithHidingPlace("Calçada", false, "Garagem");

            livingRoom.Exits = new Location[] { dinningRoom, frontYard, escadas };
            dinningRoom.Exits = new Location[] { kitchen, livingRoom };
            kitchen.Exits = new Location[] { backYard, dinningRoom };
            backYard.Exits = new Location[] { calcada, garden, kitchen };
            garden.Exits = new Location[] { frontYard, backYard };
            frontYard.Exits = new Location[] { calcada, garden, livingRoom };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

            escadas.Exits = new Location[] { hallSuperior, livingRoom };

            hallSuperior.Exits = new Location[] { quartoPrincipal, quartoSecundario, banheiro, escadas };

            quartoPrincipal.Exits = new Location[] { hallSuperior };
            quartoSecundario.Exits = new Location[] { hallSuperior };
            banheiro.Exits = new Location[] { hallSuperior };

            calcada.Exits = new Location[] { frontYard, backYard };
        }

        void MoveToANewLocation(Location location, bool countMovment = true)
        {
            if(countMovment) moves++;
            currentLocation = location;
            RedrawForm();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;
            description.Text = "";

            StartGame();

            for (int i = 0; i < 10; i++)
            {
                description.Text = (i + 1) + "";
                Application.DoEvents();
                opponent.Move();
                System.Threading.Thread.Sleep(500);
            }

            description.Text = "Pronto ou não, la vou eu!";
            Application.DoEvents();

            System.Threading.Thread.Sleep(1000);
            MoveToANewLocation(garden, false);
        }

        private void check_Click(object sender, EventArgs e)
        {
            moves++;

            if (opponent.Check(currentLocation))
            {
                description.Text = "Você me achou em " + moves + " movimentos!";

                gameStarted = false;
            }

            RedrawForm();
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

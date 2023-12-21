namespace MyHomeProject
{
    internal abstract class Location
    {
        public Location(string name) {
            this.name = name;
        }

        private string name;
        public string Name { get { return name; } }

        public Location[] Exits;

        public virtual string Description {
            get {
                string description = "Você está em: " + Name + "\r\n\r\n";
                description += "You see exits to the following places:\r\n";

                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " - " + Exits[i].Name + "\r\n";
                }

                description += "\r\n";

                return description;
            }
        }
    }
}

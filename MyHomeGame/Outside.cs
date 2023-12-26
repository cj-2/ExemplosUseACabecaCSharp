namespace MyHomeGame
{
    internal class Outside : Location
    {
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        protected bool hot;
        public bool Hot { get { return hot; } }

        public override string Description
        {
            get
            {
                return base.Description + (Hot ? " It's very hot here!\r\n" : "");
            }
        }
    }
}
namespace QueenBee2
{
    internal class RoboBee : Robot, IWorker
    {
        private int shiftsToWork;
        private int shiftsWorked;

        public string CurrentJob { get; set; }

        public int ShiftsLeft { get { return shiftsToWork - shiftsWorked; } }

        public bool DoThisJob(string job, int shifts)
        {
            return true;
        }

        public bool WorkOneShift()
        {
            return true;
        }
    }
}

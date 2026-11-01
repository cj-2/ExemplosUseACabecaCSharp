namespace QueenBee2
{
    internal class Queen : Bee
    {

        public Queen(Worker[] workers) : base(275)
        {
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber = 0;
        private int beeWorking = 0;
        private int biggerShiftsBee = 0;
        public override int ShiftsLeft { get { return biggerShiftsBee; } }

        public bool AssignWork(string job, int shift)
        {
            bool jobAssigned = false;
            for (int i = 0; i < workers.Length; i++)
            {
                bool matchBee = workers[i].DoThisJob(job, shift);

                if (matchBee)
                {
                    jobAssigned = true;
                    goto endAssignWork;
                }
            }

        endAssignWork:
            return jobAssigned;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Report of Shift #" + shiftNumber + "\r\n";
            double honeyConsumption = 0;

            beeWorking = 0;
            biggerShiftsBee = 0;

            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumption += workers[i].GetHoneyConsumption();

                report += "Bee #" + (i + 1);
                if (workers[i].WorkOneShift()) // true caso seja o último turno.
                {
                    report += " acabou seu trabalho,";
                }

                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    report += " não está trabalhando -> " + workers[i].GetHoneyConsumption() + " u\r\n";
                    continue;
                }

                if (workers[i].ShiftsLeft > 0)
                {
                    report += " estará trabalhando '" + workers[i].CurrentJob + "' por mais " + workers[i].ShiftsLeft + " turnos";
                }
                else
                {
                    report += " terminará com '" + workers[i].CurrentJob + "' depois desse turno.";
                }

                report += " -> " + workers[i].GetHoneyConsumption() + " u\r\n";

                beeWorking++;
                if (workers[i].ShiftsLeft > biggerShiftsBee) biggerShiftsBee = workers[i].ShiftsLeft;
            }

            honeyConsumption += GetHoneyConsumption();
            report += "\r\nA rainha está consumindo " + GetHoneyConsumption() + " u\r\n";
            report += "Consumo total de mel: " + honeyConsumption + " unidades.\r\n";
            return report;
        }

        public override double GetHoneyConsumption()
        {
            double honeyConsumption = ShiftsLeft > 0 ? ShiftsLeft + 9 : 7.5D;
            honeyConsumption += beeWorking > 2 ? 30 : 20;
            return honeyConsumption;
        }
    }
}

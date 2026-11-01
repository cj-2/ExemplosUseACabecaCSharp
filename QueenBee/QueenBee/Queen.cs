namespace QueenBee
{
    internal class Queen
    {
        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber = 0;

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

            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift()) // true caso seja o último turno.
                {
                    report += "Worker #" + (i + 1) + " fineshed the job\r\n";
                }

                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                    continue;
                }

                if (workers[i].ShiftsLeft > 0)
                {
                    report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob + "' for " + workers[i].ShiftsLeft + " more shifts\r\n";
                }
                else
                {
                    report += "Worker #" + (i + 1) + " will be done with '" + workers[i].CurrentJob + "' after this shifts\r\n";
                }
            }

            return report;
        }
    }
}

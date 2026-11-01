using System;

namespace QueenBee2
{
    internal class Worker : Bee, IWorker
    {
        public Worker(string[] jobsICanDo, int miligrams) : base(miligrams)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public string CurrentJob { get; set; }
        public override int ShiftsLeft { get { return shiftsToWork - shiftsWorked; } }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;


        public bool DoThisJob(string job, int shift)
        {
            bool canDoTheJob = false;

            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (!string.IsNullOrEmpty(CurrentJob)) goto endDoThisJob;

                if (jobsICanDo[i] == job)
                {
                    canDoTheJob = true;
                    CurrentJob = jobsICanDo[i];
                    shiftsWorked = 0;
                    shiftsToWork = shift;

                    goto endDoThisJob;
                }
            }

        endDoThisJob:
            return canDoTheJob;
        }

        public bool WorkOneShift()
        {
            bool lastShiftOfWorker = false;
            if (String.IsNullOrEmpty(CurrentJob)) return lastShiftOfWorker;

            shiftsWorked++;

            if (shiftsWorked > shiftsToWork)
            {
                lastShiftOfWorker = true;

                shiftsWorked = 0;
                shiftsToWork = 0;
                CurrentJob = "";
            }

            return lastShiftOfWorker;
        }
    }
}
namespace QueenBee2
{
    internal interface IWorker
    {
        string CurrentJob { get;  set; }

        int ShiftsLeft { get; }

        bool DoThisJob(string job, int shifts);

        bool WorkOneShift();
    }
}

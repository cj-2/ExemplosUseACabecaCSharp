using System;
using System.Windows.Forms;

namespace QueenBee
{
    public partial class QueenControl : Form
    {
        private Queen queen;
        public QueenControl()
        {
            InitializeComponent();

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });

            queen = new Queen(workers);
        }

        private void assignWorkButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(workerBeeJob.Text))
            {
                MessageBox.Show("Select a Bee Job!", "Dev says...");
                return;
            }

            bool jobAssigned = queen.AssignWork(workerBeeJob.Text, (int)shifts.Value);
            if (jobAssigned) MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in " + shifts.Value + " shifts.", "The queen bee says...");
            else MessageBox.Show("No workers are available to do the job '" + workerBeeJob.Text + "'", "The queen bee says...");
        }

        private void workTheNextShiftButton_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
using System;
using System.Windows.Forms;

namespace QueenBee2
{
    public partial class QueenControl : Form
    {
        private Queen queen;
        public QueenControl()
        {
            InitializeComponent();

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 155);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beeee!!!", "Foi o que ela disse...");
        }
    }
}
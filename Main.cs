using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTimer
{
    public partial class Main : Form
    {
        private Stopwatch stopWatch;

        public Main()
        {
            InitializeComponent();
            NextTask();
        }

        private Process Browser;

        private void StartTask()
        {
            StartTaskButton.Enabled = false;
            CompleteTaskButton.Enabled = true;
            StudyTask CurrentTask = Program.TaskList[Program.CurrentTaskIndex];
            Browser = System.Diagnostics.Process.Start(CurrentTask.TaskURL); //open web browser
            //SetBrowserSize(Browser); //no easy way to set browser size right now, ignoring
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        private void FinishTask()
        {
            stopWatch.Stop();

            DialogResult dialogResult = MessageBox.Show("Are you sure you believe you have finished?", "Finished?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                StudyTask CurrentTask = Program.TaskList[Program.CurrentTaskIndex];
                CurrentTask.TimeSpentOnTask = stopWatch.ElapsedMilliseconds;
                CurrentTask.Completed = true;
                NextTask();
            }
            else if (dialogResult == DialogResult.No)
            {
                stopWatch.Start(); //start the stopwatch back up again, and continue as we were.
            }
        }

        private void NextTask()
        {
            Program.CurrentTaskIndex++;
            if (Program.CurrentTaskIndex == Program.TaskList.Count)
            { //this is the end, show dialogue and close
                MessageBox.Show("Thank you for your participation!");
                Application.Exit();
            }
            else
            {

                TasksCheckedBox.DataSource = Program.TaskList;
                TasksCheckedBox.DisplayMember = "Title";
                for (int i = 0; i < Program.TaskList.Count; i++)
                {
                    TasksCheckedBox.SetItemChecked(i, Program.TaskList[i].Completed);
                }
                TasksCheckedBox.SelectedIndex = Program.CurrentTaskIndex;

                StudyTask CurrentTask = Program.TaskList[Program.CurrentTaskIndex];
                TaskInstructionLabel.Text = CurrentTask.Instructions;
                StartTaskButton.Enabled = true;
                CompleteTaskButton.Enabled = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            int FormWidth = 300;
            this.Size = new Size(FormWidth, workingRectangle.Height);
            this.SetDesktopLocation(workingRectangle.Width - FormWidth, 0);
        }

        private void StartTaskButton_MouseClick(object sender, MouseEventArgs e)
        {
            StartTask();
        }

        private void CompleteTaskButton_MouseClick(object sender, MouseEventArgs e)
        {
            FinishTask();
        }
    }
}

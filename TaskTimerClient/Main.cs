using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace TaskTimer
{
    public partial class Main : Form
    {
        private Stopwatch stopWatch;
        Screen WorkingScreen;

        public Main()
        {
            InitializeComponent();
            NextTask();
        }

        private Process Browser;

        private void StartTask()
        {
            StartTaskButton.Enabled = false;
            TaskAnswerRichTextBox.Enabled = true;
            TaskAnswerRichTextBox.Text = null;
            CompleteTaskButton.Enabled = true;
            
            StudyTask CurrentTask = Program.TaskList[Program.CurrentTaskIndex];
            GiveUpButton.Enabled = CurrentTask.ShouldShowFailedQuestion;

            Browser = Process.Start(CurrentTask.TaskURL); //open web browser
            //SetBrowserSize(Browser); //no easy way to set browser size right now, ignoring
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        private byte[] GetScreenshotAsPNG()
        {
            Rectangle captureRectangle = WorkingScreen.Bounds;
            Bitmap captureBitmap = new Bitmap(captureRectangle.Width, captureRectangle.Height, PixelFormat.Format32bppArgb);
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            MemoryStream ms = new MemoryStream();
            captureBitmap.Save(ms, ImageFormat.Png);
            byte[] pngBytes = ms.GetBuffer();
            return pngBytes;
        }

        private void FinishTask(bool GivingUp = false)
        {
            stopWatch.Stop();
            byte[] TaskScreenshotPNG = GetScreenshotAsPNG();
            DialogResult FinishedDialogResult;

            if (!GivingUp)
            {
                FinishedDialogResult = MessageBox.Show("Are you sure you believe you have finished?", "Finished?", MessageBoxButtons.YesNo);
            }
            else
            {
                FinishedDialogResult = MessageBox.Show("Are you sure you want to give up on this task?", "Finished?", MessageBoxButtons.YesNo);
            }
            
            if (FinishedDialogResult == DialogResult.Yes)
            {
                CompleteTaskButton.Enabled = false;
                GiveUpButton.Enabled = false;
                StudyTask CurrentTask = Program.TaskList[Program.CurrentTaskIndex];
                if (CurrentTask.ShouldShowFailedQuestion && !GivingUp)
                {
                    DialogResult SucessfulDialogResult = MessageBox.Show("Do you believe you have finished the task successfully?", "Task successful?", MessageBoxButtons.YesNo);
                    if (SucessfulDialogResult == DialogResult.Yes)
                    {
                        CurrentTask.ParticipantBelievesSuccess = true;
                    }
                    else
                    {
                        CurrentTask.ParticipantBelievesSuccess = false;
                    }
                }
                else
                {
                    CurrentTask.ParticipantBelievesSuccess = GivingUp;
                }
                CurrentTask.TimeSpentOnTask = stopWatch.ElapsedMilliseconds;
                CurrentTask.ScreenshotPNG = TaskScreenshotPNG;
                CurrentTask.Answer = TaskAnswerRichTextBox.Text;
                CurrentTask.Completed = true;
                DataPoster.SendData(CurrentTask);
                Program.SaveEverythingToDisk();
                TaskAnswerRichTextBox.Text = null;
                NextTask();
            }
            else if (FinishedDialogResult == DialogResult.No)
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
                TaskInstructionLabel.Text = CreateFullInstructions(CurrentTask);
                StartTaskButton.Enabled = true;
                TaskAnswerRichTextBox.Enabled = false;
                CompleteTaskButton.Enabled = false;
                GiveUpButton.Enabled = false;
            }
        }

        private string CreateFullInstructions(StudyTask Task)
        {
            return Task.Instructions + 
                Environment.NewLine + 
                Environment.NewLine + 
                "Pressing the start task button will open " + 
                Task.TaskURL + 
                " , which you should use to complete the task.";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            WorkingScreen = Screen.PrimaryScreen;
            Rectangle workingRectangle = WorkingScreen.WorkingArea;
            int FormWidth = 300;
            this.Size = new Size(FormWidth, workingRectangle.Height);
            this.SetDesktopLocation(workingRectangle.Width - FormWidth, 0);

            MessageBox.Show(InitialInstructions(), "Hello", MessageBoxButtons.OK);
        }

        private string InitialInstructions()
        {
            return "Hello, and once again thank you for participation in my research. " + Environment.NewLine +
                "This system will guide you through completing a number of tasks using two systems. " + Environment.NewLine +
                "Before starting each task, read the task instructions at the bottom of the panel to understand what you need to do." + Environment.NewLine +
                "Before completing each task, make sure your proof of completion is *on screen* " +
                "because a screenshot of the entire screen will be saved, " +
                "which is to allow me to see weither you actually completed the task or failed to complete the task" +
                "If there is no proof of completion on screen, then I may erroneously believe you failed to complete the task." + Environment.NewLine +
                "If at any point you wish to give up a task, just press complete task.";
        }

        private void StartTaskButton_MouseClick(object sender, MouseEventArgs e)
        {
            StartTask();
        }

        private void CompleteTaskButton_MouseClick(object sender, MouseEventArgs e)
        {
            FinishTask(false);
        }

        private void GiveUpButton_Click(object sender, EventArgs e)
        {
            FinishTask(true);
        }
    }
}

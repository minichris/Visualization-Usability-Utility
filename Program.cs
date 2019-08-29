using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskTimer
{
    class Program
    {
        public static List<StudyTask> TaskList = new List<StudyTask>()
        {
            new StudyTask()
            {
                Title = "test",
                Instructions = "Instructions Instructions InstructionsInstructions InstructionsInstructions vInstructionsInstructionsInstructions Instructions",
                TaskURL = "http://topbanter.net/vgtropes"
            },
            new StudyTask()
            {
                Title = "test2",
                Instructions = "Instructions Instructions InstructionsInstructions InstructionsInstructions vInstructionsInstructionsInstructions Instructions",
                TaskURL = "http://topbanter.net/vgtropes"
            },
            new StudyTask()
            {
                Title = "test3",
                Instructions = "Instructions Instructions InstructionsInstructions InstructionsInstructions vInstructionsInstructionsInstructions Instructions",
                TaskURL = "http://topbanter.net/vgtropes"
            }
        };

        public static int CurrentTaskIndex = -1;

        [STAThread]
        static void Main(string[] args)
        {


            Application.EnableVisualStyles();
            Application.Run(new Main());
        }
    }
}

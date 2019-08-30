using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskTimer
{
    class Program
    {
        public static List<StudyTask> NewSystemTaskList = new List<StudyTask>()
        {
            new StudyTask()
            {
                Title = "Giving a brief description of a Pattern",
                Instructions = "Find a brief description of the Pattern “Artifact-Location Proximity”. " +
                "When you have the description highlighted, press the complete task button.",
                TaskURL = "http://topbanter.net/vgtropes2"
            },
            new StudyTask()
            {
                Title = "Finding a Pattern from a brief description",
                Instructions = "Find the pattern that meets the following description " +
                "“Being in control over who can move within an area in the game world or having access to actions linked to locations in the game world.”" +
                "When you have found this pattern's page and are viewing it, press the complete task button.",
                TaskURL = "http://topbanter.net/vgtropes2"
            },
            new StudyTask()
            {
                Title = "Finding Patterns from a category",
                Instructions = "Find 5 patterns from the category “Interface Patterns”" +
                "Open notepad.exe from the start menu and write down the patterns. " +
                "Make sure notepad is on the screen when you press the complete task button.",
                TaskURL = "http://topbanter.net/vgtropes2"
            },
            new StudyTask()
            {
                Title = "Finding examples of games which make use of a specific pattern",
                Instructions = "Find the names of 5 games which make use of the “Critical Hits” pattern. " +
                "Don’t include categories in your response." + 
                "Open notepad.exe from the start menu and write down the games. " +
                "Make sure notepad is on the screen when you press the complete task button.",
                TaskURL = "http://topbanter.net/vgtropes2"
            }
        };

        public static List<StudyTask> TaskList = new List<StudyTask>();

        public static int CurrentTaskIndex = -1;

        [STAThread]
        static void Main(string[] args)
        {
            TaskList.AddRange(NewSystemTaskList);

            Application.EnableVisualStyles();
            Application.Run(new Main());
        }
    }
}

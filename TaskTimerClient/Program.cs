using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace TaskTimer
{
    class Program
    {
        public static string ParticipantIdentifier = "Participant1";

        public static string VGTropesURL = ConfigurationManager.AppSettings["VGTropesURL"];
        public static string GDPWikiURL = ConfigurationManager.AppSettings["GDPWikiURL"];
        public static string ReverseMode = ConfigurationManager.AppSettings["ReverseMode"];

        public static string getParticipantIdentifier()
        {
            return Program.ParticipantIdentifier;
        }

        public static List<StudyTask> OldSystemTaskList = new List<StudyTask>()
        {
            new StudyTask()
            {
                Title = "Giving a brief description of a Pattern",
                DisplayTitle = "Task 1A",
                Instructions = "Find a brief description of the Pattern “Enforced Player Anonymity”. " +
                "When you have the description highlighted, press the complete task button.",
                TaskURL = Program.GDPWikiURL
            },
            new StudyTask()
            {
                Title = "Finding a Pattern from a brief description",
                DisplayTitle = "Task 2A",
                Instructions = "Find the pattern that meets the following description " +
                "“Waiting time players have to experience during game sessions.” " +
                "When you have found this pattern's page and are viewing it, press the complete task button.",
                TaskURL = Program.GDPWikiURL
            },
            new StudyTask()
            {
                Title = "Finding Patterns from a category",
                DisplayTitle = "Task 3A",
                Instructions = "Find 5 patterns from the category “Gameplay Arc Patterns”. " +
                "Write, or copy and paste the patterns you find into the Task Answer Box below. " +
                "When you have 5 patterns in the box, press the task complete button.",
                TaskURL = Program.GDPWikiURL
            },
            new StudyTask()
            {
                Title = "Finding examples of games which make use of a specific pattern",
                DisplayTitle = "Task 4A",
                Instructions = "Find the names of 5 games which make use of the “Abilities” pattern. " +
                "Don’t include categories in your response. " +
                "Write, or copy and paste the games you find into the Task Answer Box below. " +
                "When you have 5 games in the box, press the task complete button.",
                TaskURL = Program.GDPWikiURL
            },
            new StudyTask()
            {
                Title = "Post-Wiki System Use Questionnaire",
                DisplayTitle = "Task 5A",
                Instructions = "Fill in the following questionnaire. For the question 'Which of the systems did you just use?', select 'Gameplay Design Patterns Wiki'.",
                TaskURL = "https://unioflincoln.eu.qualtrics.com/jfe/form/SV_aUXwBVYTaC0wklL",
                ShouldShowFailedQuestion = false
            }
        };

        public static List<StudyTask> NewSystemTaskList = new List<StudyTask>()
        {
            new StudyTask()
            {
                Title = "Giving a brief description of a Pattern",
                DisplayTitle = "Task 1B",
                Instructions = "Find a brief description of the Pattern “Artifact-Location Proximity”. " +
                "When you have the description highlighted, press the complete task button.",
                TaskURL = Program.VGTropesURL + "?participantid=*"
            },
            new StudyTask()
            {
                Title = "Finding a Pattern from a brief description",
                DisplayTitle = "Task 2B",
                Instructions = "Find the pattern that meets the following description " +
                "“Being in control over who can move within an area in the game world or having access to actions linked to locations in the game world.” " +
                "When you have found this pattern's page and are viewing it, press the complete task button.",
               TaskURL = Program.VGTropesURL + "?participantid=*"
            },
            new StudyTask()
            {
                Title = "Finding Patterns from a category",
                DisplayTitle = "Task 3B",
                Instructions = "Find 5 patterns from the category “Interface Patterns”. " +
                "Write, or copy and paste the patterns you find into the Task Answer Box below. " +
                "When you have 5 patterns in the box, press the task complete button.",
                TaskURL = Program.VGTropesURL + "?participantid=*"
            },
            new StudyTask()
            {
                Title = "Finding examples of games which make use of a specific pattern",
                DisplayTitle = "Task 4B",
                Instructions = "Find the names of 5 games which make use of the “Critical Hits” pattern. " +
                "Don’t include categories in your response. " +
                "Write, or copy and paste the games you find into the Task Answer Box below. " +
                "When you have 5 games in the box, press the task complete button.",
                TaskURL = Program.VGTropesURL + "?participantid=*"
            },
            new StudyTask()
            {
                Title = "Post-VGTropes Use Questionnaire",
                DisplayTitle = "Task 5B",
                Instructions = "Fill in the following questionnaire. For the question 'Which of the systems did you just use?', select 'VGTropes'.",
                TaskURL = "https://unioflincoln.eu.qualtrics.com/jfe/form/SV_aUXwBVYTaC0wklL",
                ShouldShowFailedQuestion = false
            }
        };

        public static StudyTask PreQuestionnaire = new StudyTask() {
            Title = "Pre-Study Questionnaire",
            DisplayTitle = "Task 0",
            Instructions = "Fill in the following questionnaire about yourself.",
            TaskURL = "https://unioflincoln.eu.qualtrics.com/jfe/form/SV_8JrKQnFk0jktjU1",
            ShouldShowFailedQuestion = false
        };

        public static String RemoteServerLocation = ConfigurationManager.AppSettings["RemoteServer"];

    public static List<StudyTask> TaskList = new List<StudyTask>();

        public static int CurrentTaskIndex = -1;

        //for when saving to server goes horribly wrong
        public static void SaveEverythingToDisk()
        {
            if (!Directory.Exists(ParticipantIdentifier))
            {
                Directory.CreateDirectory(ParticipantIdentifier);
            }
            string TasksString = JsonConvert.SerializeObject(TaskList);
            for(int i = 0; i < TaskList.Count; i++)
            {
                if (TaskList[i].ScreenshotPNG != null)
                {
                    File.WriteAllBytes(ParticipantIdentifier + "/task" + i + "screenshot.png", TaskList[i].ScreenshotPNG);
                }
            }
            File.WriteAllText(ParticipantIdentifier + "/tasks.json", TasksString);
        }

        [STAThread]
        static void Main(string[] args)
        {
            Random rnd = new Random();
            if (Program.ReverseMode != "true")
            {
                TaskList.Add(PreQuestionnaire);
                TaskList.AddRange(OldSystemTaskList);
                TaskList.AddRange(NewSystemTaskList);
            }
            else
            {
                TaskList.Add(PreQuestionnaire);
                TaskList.AddRange(NewSystemTaskList);
                TaskList.AddRange(OldSystemTaskList);
            }

            Application.EnableVisualStyles();
            Application.Run(new IDEntry());
            Application.Run(new Main());
            SaveEverythingToDisk();
        }
    }
}

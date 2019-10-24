using RestSharp;
using System;

namespace TaskTimer
{
    class DataPoster
    {
        public static IRestResponse SendData(StudyTask Task)
        {
            var client = new RestClient(Program.RemoteServerLocation);
            var request = new RestRequest("tasks", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("Title", Task.Title);
            request.AddParameter("System", Task.TaskURL);
            request.AddParameter("Answer", Task.Answer);
            request.AddParameter("TimeSpent", Task.TimeSpentOnTask);
            request.AddParameter("Timestamp", Task.Timestamp);
            request.AddParameter("BelievesSuccess", Task.ParticipantBelievesSuccess);
            request.AddParameter("Screenshot", System.Convert.ToBase64String(Task.ScreenshotPNG));

            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}

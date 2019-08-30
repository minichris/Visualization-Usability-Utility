using RestSharp;

namespace TaskTimer
{
    class DataPoster
    {
        public static void SendData(StudyTask Task)
        {
            var client = new RestClient("https://webhook.site/1b903b14-cb31-455c-a7e0-059356b6896c");
            var request = new RestRequest("post", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddFileBytes("Screenshot", Task.ScreenshotPNG, "Screenshot.png", "image/png");

            //request.AddParameter("Screenshot", System.Convert.ToBase64String(Task.ScreenshotPNG));
            request.AddParameter("Title", Task.Title);
            request.AddParameter("System", Task.TaskURL);
            request.AddParameter("TimeSpent", Task.TimeSpentOnTask);
            request.AddParameter("BelievesSuccess", Task.ParticipantBelievesSuccess);

            var response = client.Execute(request);
        }
    }
}

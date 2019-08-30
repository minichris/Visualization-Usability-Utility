using RestSharp;

namespace TaskTimer
{
    class DataPoster
    {
        public static void SendData(StudyTask Task)
        {
            var client = new RestClient("http://ptsv2.com/t/envyx-1567121410/");
            var request = new RestRequest("post", Method.POST);
            request.RequestFormat = DataFormat.Json;

            string filevalue = System.Convert.ToBase64String(Task.ScreenshotPNG);
            request.AddParameter("Screenshot", filevalue);
            request.AddParameter("Title", Task.Title);
            request.AddParameter("TimeSpent", Task.TimeSpentOnTask);

            var response = client.Execute(request);
        }
    }
}

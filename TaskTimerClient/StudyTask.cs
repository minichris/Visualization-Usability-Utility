using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTimer
{
    class StudyTask
    {
        public String Title { get; set; }
        public String Instructions { get; set; }
        public long TimeSpentOnTask;
        public bool Completed { get; set; }
        public bool ParticipantBelievesSuccess { get; set; }
        public String TaskURL { get; set; }
        public byte[] ScreenshotPNG { get; set; }
    }
}

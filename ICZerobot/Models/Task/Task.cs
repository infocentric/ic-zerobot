using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICZerobot.Models.Task
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<byte[]> Attachements { get; set; }
        public string Priority { get; set; }
        public string Creator { get; set; }  
        public string Project { get; set; }
        public string System { get; set; }
        public string TaskType { get; set; }
        public string Estimate { get; set; }
        public DateTime DueDate { get; set; }
        public Dictionary<string, string> AdditionalParameters { get; set; }

    }

}
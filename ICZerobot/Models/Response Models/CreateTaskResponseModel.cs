using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ICZerobot.Models
{
    public class CreateTaskResponseModel
    {
        public Task Task { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ICZerobot.Models;
using ICZerobot.Services;
using Newtonsoft.Json;

namespace ICZerobot.Controllers
{
    public class TasksController : ApiController
    {
        JiraAdapterService _jiraService;
        public TasksController() {
            _jiraService = new JiraAdapterService();
        }
        [HttpGet]
        public IHttpActionResult Tasks()
        {
            var result = new CreateTaskResponseModel()
            {
                Status = 1,
                Message = "Success",
                Task = null
            };

            return Json(result);

        }

        [HttpPost]
        public IHttpActionResult Tasks(Task task)
        {
            var result = _jiraService.CreateJiraTask(task);
            return Json(result);
        }
    }
}

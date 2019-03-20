using ICZerobot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ICZerobot.Enums;
using ICZerobot.Helper;
using System.Configuration;

namespace ICZerobot.Repos
{
    public class JiraRepo : IJiraRepo
    {
        private RestClientHelper<TaskRequestModel, CreateTaskResponseModel> _client;
        public JiraRepo() {
            _client = new RestClientHelper<TaskRequestModel, CreateTaskResponseModel>();
        }
        public CreateTaskResponseModel CreateTask(Task task) {


            string baseURL = ConfigurationManager.AppSettings["JiraAdapterEndpoint"];
            string apiCall = "api/tasks";
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "Content-type", "application/json" }
            };
            TaskRequestModel TRModel = new TaskRequestModel
            {
                Task = task
            };

            var result = _client.Post(baseURL, apiCall, headers, TRModel);
            return result;
        }

    }
}
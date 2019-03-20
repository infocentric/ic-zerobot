using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using ICZerobot.Models;
using RestSharp;
using ICZerobot.Repos;

namespace ICZerobot.Services
{
    public class JiraAdapterService
    {
        private IJiraRepo _jiraRepo;

        public JiraAdapterService() {
            _jiraRepo = new JiraRepo();
        }
        public CreateTaskResponseModel CreateJiraTask(Task task)
        {
            var result = _jiraRepo.CreateTask(task);
            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace ICZerobot.Helper
{
    public class RestClientHelper<T, K> where K : new()
    {
        public K Post(string baseURL, string apiCall, Dictionary<string, string> headers, T requestModel) {

            var client = new RestClient(baseURL);

            foreach (string name in headers.Keys) {
                client.AddDefaultHeader(name, headers[name]);
            }
            
            var request = new RestRequest(apiCall, Method.POST);
            
            request.AddJsonBody(requestModel);
            var response = client.Execute<K>(request);
            
            return response.Data;
        }
    }
}
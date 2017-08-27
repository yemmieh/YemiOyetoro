using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Yemi.Data
{
    public class RestsharpTest
    {
       // public RestClient client = new RestClient("http://services.groupkt.com/state/get/");
        public List<State> getState(string d)
        {
            List<State> allStae = new List<State>();
            RestClient client = new RestClient("http://services.groupkt.com/state/get/usa/all");
            RestRequest request = new RestRequest("/", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            //request.AddUrlSegment("id", d);
            IRestResponse<List<State>> response = client.Execute<List<State>>(request);

            //IRestResponse response = client.Execute(request);
            foreach(State s in response.Content)
            {
                State ss = new State();
                ss.abbr = s.abbr;
                ss.area = s.area;
                ss.capital = s.capital;
                ss.country = s.country;
                ss.largest_city = s.largest_city;
                ss.name = s.name;
                allStae.Add(ss);
            }
            return allStae;
        }
    }
}

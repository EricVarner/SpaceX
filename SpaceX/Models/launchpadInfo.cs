using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
//used for DataContract and DataMember
using System.Runtime.Serialization;
using System.Web;

namespace SpaceX.Models
{
    [DataContract]
    public static class launchpadInfo
    {
        public static HttpClient APIClient { get; set; } 

        //method to initialize the API
        public static void initializeAPI()
        {
            APIClient = new HttpClient();
            APIClient.BaseAddress =new Uri("https://api.spacexdata.com/v3/launchpads");
            APIClient.DefaultRequestHeaders.Accept.Clear();
            //requesting json
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
    public class launchpadModel
    {       
        //stores strings for the ID, Name, and Location of the launchpads

        public string ID { get; set; }
        public string Full_Name { get; set; }
        public string Location { get; set; }
    }
}
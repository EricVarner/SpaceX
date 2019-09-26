using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;
using SpaceX.Models;

namespace SpaceX.Controllers
{
    public class APIProcessor
    {

        public async Task<launchpadModel> getLaunchpadInfo()
        {
            string url = "https://api.spacexdata.com/v3/launchpads";

            //memory management to close all ports after use - closes everything down related to this response
            using (HttpResponseMessage response = await launchpadInfo.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    //uses json converter to convert to the type given
                    launchpadModel launchpad = await response.Content.ReadAsAsync<launchpadModel>();

                    return launchpad;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
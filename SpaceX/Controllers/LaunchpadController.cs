using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SpaceX.Models;

namespace SpaceX.Controllers
{
    public class LaunchpadController : ApiController
    {
        // GET: api/Launchpad
        public IEnumerable<launchpadInfo> Get()
        {
            launchpadInfo.initializeAPI();
            var launchpadInfList = new List<launchpadInfo>();
            //get first 10 items
            for(int i=0; i<10;i++)
            {
                var LaunchpadInfo = new launchpadInfo
                {
                    LPLocation = $"LPLocation {i}",
                    LPName = $"LPName {i}", 
                    LPID = $"ID {i}"
                };
                //add data from above loop into the list
                launchpadInfList.Add(LaunchpadInfo);
            }
            return launchpadInfList;
        }

        // GET: api/Launchpad/5
        public launchpadInfo Get(int id)
        {
            return new launchpadInfo
            {
                LPLocation = $"LPLocation {id}",
                LPName = $"LPName {id}",
                LPID = $"ID {id}"
            };
        }
    }
}

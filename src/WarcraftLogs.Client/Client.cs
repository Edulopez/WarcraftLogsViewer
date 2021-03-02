using System;
using System.Collections.Generic;
using System.Text;
using WarcraftLogsViewer.Core;

namespace WarcraftLogs.Client
{
    public class Client: IWarcraftLogsClient
    {
        public readonly string RunId;
        public Client(string id)
        {
            RunId = id;
        }

        public void GetFights()
        {
            
        }


        public void GetAllEcounterKills()
        {

        }
    }
}

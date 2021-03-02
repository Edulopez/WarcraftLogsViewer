using System;
using System.Collections.Generic;
using System.Text;
using WarcraftLogsViewer.Core.Dtos;

namespace WarcraftLogsViewer.Core
{
    public class WCLinkCreator
    {
        private readonly PinsConfiguration configuration;
        private readonly string RunId;
        private readonly IWarcraftLogsClient Client;
        public WCLinkCreator(PinsConfiguration conf, 
            IWarcraftLogsClient client,
            string runId)
        {
            configuration = conf;
            RunId = runId;
            Client = client;
        }

        public string CreateRunSummary()
        {
            return null;
        }

        private string GetGeneralPins()
        {
            var pins = new StringBuilder();
            for (int i = 0; i < configuration.Pins.Generals.Count; i++)
            {
                string item = configuration.Pins.Generals[i];
                pins.Append(item);
            }

            return pins.ToString();
        }

        private string GetFightPins(string FightName)
        {
            var pins = new StringBuilder();

            foreach (var item in configuration.Pins.Specifics)
            {
                if (!FightName.Contains(item.Name))
                    continue;

                foreach (var pin in item.Pins)
                {
                    pins.Append(pin);
                }
            }

            return pins.ToString();
        }
        public List<string> CreateRunFights()
        {
            var fights = Client.GetFights(RunId);


            for (int i = 0; i < fights.Count; i++)
            {

            }
            return null;
        }
    }
}

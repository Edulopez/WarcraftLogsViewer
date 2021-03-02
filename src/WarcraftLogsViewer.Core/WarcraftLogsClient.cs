using System;
using System.Collections.Generic;
using System.Text;

namespace WarcraftLogsViewer.Core
{
    public class WarcraftLogsClient : IWarcraftLogsClient
    {
        public List<string> GetFights(string runId)
        {
            return null;
        }

        public string GetAllEcounterKills(string runId)
        {
            return null;
        }
    }

    public interface IWarcraftLogsClient
    {
        List<string> GetFights(string runId);
        string GetAllEcounterKills(string runId);
    }
}

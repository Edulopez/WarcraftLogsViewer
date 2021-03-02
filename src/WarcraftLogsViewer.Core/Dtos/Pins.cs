using System;
using System.Collections.Generic;
using System.Text;

namespace WarcraftLogsViewer.Core.Dtos
{
    public class Pins
    {
        public List<string> Generals { get; set; }
        public List<SpecificPin> Specifics { get; set; }
    }
}

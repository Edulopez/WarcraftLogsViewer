using System;
using System.Diagnostics;

namespace WarcraftLogsViewer.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var id = "pG4Yh2JQByCaq3Hn";
            var fight = "18";
            var target = $"https://www.warcraftlogs.com/reports/{id}#pins=0$Separate$#909049$damage$1$0.0.0.Any$0.0.0.Any$true$0.0.0.Any$false$0%5E0%24Separate%24%23a04D8A%24healing%240%240.0.0.Any%24185746568.0.0.Priest%7C166320654.0.0.Druid%7C166946249.0.0.Priest%24true%240.0.0.Any%24false%240%5E0%24Separate%24%23a04D8A%24healing%240%240.0.0.Any%24185746568.0.0.Priest%24true%240.0.0.Any%24false%24114908%5E0%24Separate%24rgb(78%25,%2061%25,%2043%25)%24damage%241%240.0.0.Any%240.0.0.Any%24true%240.0.0.Any%24false%24329455%7C334523&fight={fight}&playermetric=hps&type=summary";
            var psi = new ProcessStartInfo
            {
                FileName = target,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace PegarPrecoAcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString("https://query1.finance.yahoo.com/v8/finance/chart/PETR3.SA?period1=1598922000&period2=1604005200&interval=1d");
                Console.WriteLine(json);
                Console.ReadKey();
            }
        }
    }
}

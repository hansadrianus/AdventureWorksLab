using Cr8ive_AlbertusSandhy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr8ive_AlbertusSandhy
{
    public static class HelperStatic
    {
        public static void AnalyzeWtdDataFromStaticClass(List<PerformanceData> dataList)
        {
            List<double> wtdList = new List<double>();
            wtdList = dataList.Select(data =>
            {
                if (double.TryParse(data.Wtd, out double result))
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }).ToList();
            Console.WriteLine($"Data WTD Maximum: {wtdList.Max()}.");
            Console.WriteLine($"Data WTD Minimun: {wtdList.Min()}.");
            Console.WriteLine($"Data WTD Median: {(wtdList.Max() + wtdList.Min()) / 2}.");
        }
    }
}

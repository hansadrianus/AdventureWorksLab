using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr8ive_AlbertusSandhy.Models
{
    public class DurationData : PerformanceData
    {
        public DurationData()
        {
            PerformanceData performance = new PerformanceData();
            performance.Ini_Adalah_Public();
            Ini_Adalah_Protected();
        }

        public DateTime DateStart { get; set; }
        public TimeSpan TimeStart { get; set; }
        public DateTime DateEnd { get; set; }
        public TimeSpan TimeEnd { get; set; }
    }
}

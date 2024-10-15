using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cr8ive_AlbertusSandhy.Models
{
    public class PerformanceData
    {
        public PerformanceData()
        {
            Ini_Adalah_Private();
        }

        public string Identifier { get; set; }
        public string ParamId { get; set; }
        public string PlantId { get; set; }
        public string CategoryId { get; set; }
        public string Week { get; set; }
        public string Year { get; set; }
        public string Wtd { get; set; }
        public string Mtd { get; set; }
        public string Qtd { get; set; }
        public string Ytd { get; set; }


        public int ParamId_int
        {
            get
            {
                return int.Parse(ParamId);
            }
        }
        public int? PlantId_int
        {
            get
            {
                if (int.TryParse(PlantId, out int plantId))
                {
                    return plantId;
                }
                else
                {
                    return null;
                }
            }
        }
        public int CategoryId_int
        {
            get
            {
                return int.Parse(CategoryId);
            }
        }
        public int Week_int
        {
            get
            {
                return int.Parse(Week);
            }
        }
        public int Year_int
        {
            get
            {
                return int.Parse(Year);
            }
        }
        public decimal Wtd_dec
        {
            get
            {
                return decimal.Parse(Wtd);
            }
        }
        public decimal Mtd_dec
        {
            get
            {
                return decimal.Parse(Mtd);
            }
        }
        public decimal Qtd_dec
        {
            get
            {
                return decimal.Parse(Qtd);
            }
        }
        public decimal Ytd_dec
        {
            get
            {
                return decimal.Parse(Ytd);
            }
        }

        public string Ini_Adalah_Public()
        {
            return "Public method";
        }

        protected string Ini_Adalah_Protected()
        {
            return "Protected method";
        }

        private string Ini_Adalah_Private()
        {
            return "Private method";
        }
    }
}

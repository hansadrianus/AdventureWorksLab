using ConsoleTables;
using Cr8ive_AlbertusSandhy.Models; //Internal package (yang dibuat sendiri)
using Newtonsoft.Json; //External package
using System.Data;
using System.Data.SqlClient;
using System.Globalization; //Native package (yang sudah ada di dalam framework yg digunakan)

namespace Cr8ive_AlbertusSandhy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Connection to Database
            //string connString = "workstation id=AdventureWorks_Cr8tive.mssql.somee.com;packet size=4096;user id=hansadrianus_SQLLogin_1;pwd=t1zom6zmkj;data source=AdventureWorks_Cr8tive.mssql.somee.com;persist security info=False;initial catalog=AdventureWorks_Cr8tive;TrustServerCertificate=True";
            //SqlConnection sqlConn = new SqlConnection(connString);

            //Globalization
            //CultureInfo.CurrentCulture = new CultureInfo("en-US");

            //Membaca file data.json
            //string dataFile = File.ReadAllText(Path.Combine("../../../data.json"));
            //List<PerformanceData> dataList = new List<PerformanceData>();
            //dataList = JsonConvert.DeserializeObject<List<PerformanceData>>(dataFile);

            #region Comment
            ////Mengolah data
            //Console.WriteLine($"Jumlah data: {dataList.Count}.");

            ////Void method
            //AnalyzeWtdData(dataList);

            //double sumWtd = SumAllWtdData(dataList);
            //Console.WriteLine($"Total all WTD: {sumWtd}.");

            ////Next Logic.....

            //#region Next Pertemuan
            //var helper = new HelperClass();
            //helper.AnalyzeWtdDataFromClass(dataList);

            //HelperStatic.AnalyzeWtdDataFromStaticClass(dataList);
            //#endregion

            //DurationData duration = new DurationData();
            //duration.Ini_Adalah_Public();


            //PerformanceDataPlantGrouping(dataList);

            //string star = "";
            //for (int i = 0; i < 10; i++)
            //{
            //    star = star + "*";
            //    Console.WriteLine(star);
            //}

            //List<string> listPlant = new List<string>();
            //foreach (PerformanceData data in dataList)
            //{
            //    if (!listPlant.Contains(data.PlantId))
            //    {
            //        listPlant.Add(data.PlantId);
            //        Console.WriteLine(data.PlantId);
            //    }
            //}

            //while (listPlant.Count > 0)
            //{
            //    Console.WriteLine($"Ada beberapa plant list sejumlah {listPlant.Count}");
            //    Console.WriteLine($"Apakah akan looping lagi jika saya clear? Jika iya akan print beberapa plant list lg");
            //    listPlant.Clear();
            //}

            //do
            //{
            //    Console.WriteLine($"Ini adalah do-while looping");
            //    Console.WriteLine($"Tercatat listPlant setelah loop sebelumnya ada {listPlant.Count} total plant.");
            //    Console.WriteLine($"Apakah akan looping lagi?");
            //} while (listPlant.Count > 0);
            #endregion

            //sqlConn.Open();
            //string stringQueryFormat = "insert into Training_Hans (Identifier, ParamId, PlantId, CategoryId, Week, Year, Wtd, Mtd, Qtd, Ytd) values {0}";
            //string queryValues = "";
            //SqlCommand cmd = sqlConn.CreateCommand();
            //int count = 0;
            //foreach (PerformanceData data in dataList)
            //{
            //    if (count == 1000)
            //    {
            //        cmd.CommandText = string.Format(stringQueryFormat, queryValues.TrimEnd(','));
            //        cmd.ExecuteScalar();
            //        queryValues = "";
            //        count = 0;
            //    }

            //    //ParamId, PlantId, Week, Year
            //    data.Identifier = string.Join("|", data.ParamId, data.CategoryId, data.PlantId, data.Week, data.Year);
            //    queryValues += $"('{data.Identifier}', '{data.ParamId}', '{data.PlantId}', '{data.CategoryId}', '{data.Week}', '{data.Year}', '{data.Wtd}', '{data.Mtd}', '{data.Qtd}', '{data.Ytd}'),";

            //    count++;
            //}
            //cmd.CommandText = string.Format(stringQueryFormat, queryValues.TrimEnd(','));
            //cmd.ExecuteScalar();
            //sqlConn.Close();

            //Get All Data From Training_Albertus
            //sqlConn.Open();
            //var dataTrainingAlbertus = GetAllDataTrainingAlbertus(sqlConn);
            //sqlConn.Close();

            //Console.WriteLine(dataTrainingAlbertus.Sum(q =>
            //{
            //    if (decimal.TryParse(q.Wtd, out decimal result))
            //    {
            //        return result;
            //    }
            //    else
            //    {
            //        return 0;
            //    }
            //}));

            //DataTable dt = PopulateTrainingDataToDataTable(dataTrainingAlbertus);
            //var table = ConsoleTable.From(dt);
            //table.Write();


            //Looping 50x menampilkan bilangan kelipatan 3 = Beep, 5 = Bop, 5 dan 3 = Beep Bop, selainnya tampilkan angka
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Beep Bop");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Bop");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Beep");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static DataTable PopulateTrainingDataToDataTable(List<PerformanceData> dataTrainingAlbertus)
        {
            DataTable dt = new DataTable("Data");
            dt.Columns.Add("Identifier");
            dt.Columns.Add("ParamId");
            dt.Columns.Add("PlantId");
            dt.Columns.Add("CategoryId");
            dt.Columns.Add("Week");
            dt.Columns.Add("Year");
            dt.Columns.Add("Wtd");
            dt.Columns.Add("Mtd");
            dt.Columns.Add("Qtd");
            dt.Columns.Add("Ytd");

            foreach (var item in dataTrainingAlbertus)
            {
                DataRow row = dt.NewRow();
                row["Identifier"] = item.Identifier;
                row["ParamId"] = item.ParamId;
                row["PlantId"] = item.PlantId;
                row["CategoryId"] = item.CategoryId;
                row["Week"] = item.Week;
                row["Year"] = item.Year;
                row["Wtd"] = item.Wtd;
                row["Mtd"] = item.Mtd;
                row["Qtd"] = item.Qtd;
                row["Ytd"] = item.Ytd;

                dt.Rows.Add(row);
            }

            return dt;
        }
        public static void PerformanceDataPlantGrouping(List<PerformanceData> dataList)
        {
            //Looping For
            for (int i = 0; i < 100; i++)
            {
                //Logic....
            }
        }
        static void AnalyzeWtdData(List<PerformanceData> dataList)
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
        static double SumAllWtdData(List<PerformanceData> dataList)
        {
            double sum = 0;
            sum = dataList.Sum(data =>
            {
                if (double.TryParse(data.Wtd, out double result))
                {
                    return result;
                }
                else { return 0; }
            });

            return sum;
        }
        static List<PerformanceData> GetAllDataTrainingAlbertus(SqlConnection sqlConn)
        {
            List<PerformanceData> data = new List<PerformanceData>();
            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandText = "select * from dbo.Training_Albertus";

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    PerformanceData performanceData = new PerformanceData();
                    performanceData.Identifier = Convert.ToString(reader["Identifier"]);
                    performanceData.ParamId = Convert.ToString(reader[1]);
                    performanceData.PlantId = Convert.ToString(reader[2]);
                    performanceData.CategoryId = Convert.ToString(reader[3]);
                    performanceData.Week = Convert.ToString(reader[4]);
                    performanceData.Year = Convert.ToString(reader[5]);
                    performanceData.Wtd = Convert.ToString(reader[6]);
                    performanceData.Mtd = Convert.ToString(reader[7]);
                    performanceData.Qtd = Convert.ToString(reader[8]);
                    performanceData.Ytd = Convert.ToString(reader[9]);

                    data.Add(performanceData);
                }
            }

            return data;
        }
    }
}

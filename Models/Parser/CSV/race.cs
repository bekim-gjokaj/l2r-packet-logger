using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kamael.Packets.CSV
{
    internal class raceheader
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }

    internal class race
    {
        private static IEnumerable<raceheader> _records;

        public static string RaceName(int intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                //using (StreamReader sr = new StreamReader(@"CSV\Race_Name.csv"))
                //{
                //    CsvReader csv = new CsvReader(sr);
                //    _records = csv.GetRecords<raceheader>().ToList();
                //}
            }

        IDSearch:
            foreach (raceheader r in _records)
            {
                if (r.Id == id)
                {
                    result = r.Name;
                    break;
                }
            }
            if (result.Length > 0 && result.Substring(0, 1) == "@")
            {
                id = (result.Substring(1, (result.Length - 1)));
                goto IDSearch;
            }
            return result;
        }
    }
}
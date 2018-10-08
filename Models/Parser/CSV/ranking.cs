using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kamael.Packets.CSV
{
    internal class rankingheader
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
    }

    internal class Ranking
    {
        private static IEnumerable<rankingheader> _records;

        public static string rankingName(int intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                using (StreamReader sr = new StreamReader(@"CSV\Ranking_Name.csv"))
                {
                    CsvReader csv = new CsvReader(sr);
                    _records = csv.GetRecords<rankingheader>().ToList();
                }
            }

        IDSearch:
            foreach (rankingheader r in _records)
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
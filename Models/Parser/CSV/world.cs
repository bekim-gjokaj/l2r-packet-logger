using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kamael.Packets.CSV
{
    internal class worldheader
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    internal class world
    {
        private static IEnumerable<worldheader> _records;

        public static string worldName(int intID)
        {
            string result = "";
            string id = intID.ToString();

            if (_records == null)
            {
                using (StreamReader sr = new StreamReader(@"CSV\World_Name.csv"))
                {
                    CsvReader csv = new CsvReader(sr);
                    _records = csv.GetRecords<worldheader>().ToList();
                }
            }

        IDSearch:

            foreach (worldheader r in _records)
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
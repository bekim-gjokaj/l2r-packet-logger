using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kamael.Packets.CSV
{
    internal class itemOptionheader
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }

    internal class itemOption
    {
        private static List<itemOptionheader> _records;

        public static string itemOptionName(int intID)
        {
            string id = intID.ToString();
            string result = string.Empty;

        IDSearch:

            if (_records == null)
            {
                using (StreamReader sr = new StreamReader(@"CSV\ItemOption_Name.csv"))
                {
                    CsvReader csv = new CsvReader(sr);
                    _records = csv.GetRecords<itemOptionheader>().ToList();
                }
            }

            foreach (itemOptionheader r in _records)
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
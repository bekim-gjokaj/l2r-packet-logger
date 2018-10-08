using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kamael.Packets.CSV
{
    internal class MonsterBookheader
    {
        public string Id { get; set; }
        public string BookLevel { get; set; }
        public string GroupId { get; set; }
        public string MonsterId { get; set; }
        public string CardBorder { get; set; }
        public string SlotImage { get; set; }
        public string BeadImage { get; set; }
        public string UseLargeBeadImage { get; set; }
        public string CardImage { get; set; }
        public string MonsterCoreItemId { get; set; }
        public string RequiredQuantity { get; set; }
        public string StatusIcon { get; set; }
        public string EffectType2 { get; set; }
        public string EffectParam { get; set; }
        public string HuntType { get; set; }
        public string HuntingSpotId { get; set; }
        public string NameDirection { get; set; }
    }

    internal class MonsterBook
    {
        private static IEnumerable<MonsterBookheader> _records;

        public static string MonsterBookCores(ushort intID, ushort intLevel)
        {
            string result = string.Empty;
            string id = intID.ToString();
            string level = intLevel.ToString();

            if (_records == null)
            {
                using (StreamReader sr = new StreamReader(@"CSV\MonsterBook.csv"))
                {
                    CsvReader csv = new CsvReader(sr);
                    _records = csv.GetRecords<MonsterBookheader>().ToList();
                }
            }

        IDSearch:
            foreach (MonsterBookheader r in _records)
            {
                if (r.Id == id & r.BookLevel == level)
                {
                    result = r.RequiredQuantity;
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
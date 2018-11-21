using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kamael.Packets.CSV
{
    public class skillheader
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EffectDescription { get; set; }
        public string SkillDialogue { get; set; }
    }

    public class skill
    {
        private static IEnumerable<skillheader> _records;

        public static string skillName(int intID)
        {
            string result = "";
            string id = intID.ToString();

            if (_records == null)
            {
                using (StreamReader sr = new StreamReader(@"CSV\Skill_Name.csv"))
                {
                    CsvReader csv = new CsvReader(sr);
                    _records = csv.GetRecords<skillheader>().ToList();
                }
            }

        IDSearch:
            foreach (skillheader r in _records)
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
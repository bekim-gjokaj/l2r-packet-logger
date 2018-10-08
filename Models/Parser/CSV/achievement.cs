using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kamael.Packets.CSV
{
    internal class achievementheader
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string RequiredId { get; set; }
        public string GroupType { get; set; }
        public string Param1 { get; set; }
        public string TaskType { get; set; }
        public string TaskCondition { get; set; }
        public string CompleteNotifyType { get; set; }
        public string AchievementGroupId { get; set; }
        public string TaskCount { get; set; }
        public string RewardPoint { get; set; }
        public string Reward { get; set; }
    }

    internal class achievement
    {
        private static IEnumerable<achievementheader> _records;

        // Grab Name
        public static string achievementName(uint intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                using (StreamReader sr = new StreamReader(@"CSV\Achievement_Custom.csv"))
                {
                    CsvReader csv = new CsvReader(sr);
                    _records = csv.GetRecords<achievementheader>().ToList();
                }
            }

        IDSearch:
            foreach (achievementheader r in _records)
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

        // Grab Desc
        public static string achievementDesc(uint intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                using (StreamReader sr = new StreamReader(@"CSV\Achievement_Custom.csv"))
                {
                    CsvReader csv = new CsvReader(sr);
                    _records = csv.GetRecords<achievementheader>().ToList();
                }
            }

        IDSearch:
            foreach (achievementheader r in _records)
            {
                if (r.Id == id)
                {
                    result = r.Desc;
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

        // Grab TaskCount
        public static string achievementTaskCount(uint intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                using (StreamReader sr = new StreamReader(@"CSV\Achievement_Custom.csv"))
                {
                    CsvReader csv = new CsvReader(sr);
                    _records = csv.GetRecords<achievementheader>().ToList();
                }
            }

        IDSearch:
            foreach (achievementheader r in _records)
            {
                if (r.Id == id)
                {
                    result = r.TaskCount;
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

        // Grab Grouptype
        public static string achievementGroupType(uint intID)
        {
            string result = string.Empty;
            string id = intID.ToString();

            if (_records == null)
            {
                using (StreamReader sr = new StreamReader(@"CSV\Achievement_Custom.csv"))
                {
                    CsvReader csv = new CsvReader(sr);
                    _records = csv.GetRecords<achievementheader>().ToList();
                }
            }

        IDSearch:
            foreach (achievementheader r in _records)
            {
                if (r.Id == id)
                {
                    result = r.GroupType;
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
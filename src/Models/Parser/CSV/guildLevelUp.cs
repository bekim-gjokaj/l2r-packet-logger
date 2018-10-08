using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kamael.Packets.CSV
{
    internal class guildLevelUpheader
    {
        public int Lv { get; set; }
        public int MaximumGuildMemberCount { get; set; }
        public int GuildWarehouseCount { get; set; }
        public string NextLevelNeedExp { get; set; }
        public int AssignableAssistantMaster { get; set; }
        public int AssignableKnightsLeader { get; set; }
        public int AssignableRoyalGuardLeader { get; set; }
        public int PresentCount { get; set; }
        public int PrizeCount { get; set; }
    }

    internal class guildLevelUp
    {
        private static IEnumerable<guildLevelUpheader> _records;

        public static uint guildLevelUpExp(uint Lv)
        {
            if (_records == null)
            {
                using (StreamReader sr = new StreamReader(@"CSV\GuildLevelUp.csv"))
                {
                    CsvReader csv = new CsvReader(sr);
                    _records = csv.GetRecords<guildLevelUpheader>().ToList();
                }
            }

            foreach (guildLevelUpheader r in _records)
            {
                if (r.Lv == Lv)
                {
                    return Convert.ToUInt32(r.NextLevelNeedExp);
                }
            }

            return 0;
        }
    }
}
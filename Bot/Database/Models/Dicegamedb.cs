﻿#nullable disable

namespace ApuDoingStuff.Database.Models
{
    public partial class Dicegamedb
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int? Points { get; set; }
        public bool? PingMe { get; set; }
        public string Rank { get; set; }
        public string Accessoire { get; set; }
        public string EmoteNr { get; set; }
        public string AcsNr { get; set; }
    }
}

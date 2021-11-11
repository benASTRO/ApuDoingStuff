﻿using ApuDoingStuff.Database.Models;
using System.Linq;

namespace ApuDoingStuff.Database
{
    public class DbController
    {
        public static Dicegamedb GetFirstOrDefault(string username)
        {
            BotdbContext database = new();
            return database.Dicegamedbs.FirstOrDefault(d => d.UserName == username);
        }

        public static void AddPoints(string username, int points)
        {
            BotdbContext database = new();
            database.Dicegamedbs.FirstOrDefault(d => d.UserName == username).Points += points;
            database.SaveChanges();
        }

        public static void SubPoints(string username, int points)
        {
            BotdbContext database = new();
            database.Dicegamedbs.FirstOrDefault(d => d.UserName == username).Points -= points;
            database.SaveChanges();
        }

        public static void AddEmoteNr(string username, string emoteNr)
        {
            BotdbContext database = new();
            database.Dicegamedbs.FirstOrDefault(d => d.UserName == username).EmoteNr += emoteNr;
            database.SaveChanges();
        }

        public static void AddLocker(string username, string name)
        {
            BotdbContext database = new();
            database.Dicegamedbs.FirstOrDefault(d => d.UserName == username).Locker += name;
            database.SaveChanges();
        }

        public static void SetRank(string username, string emote)
        {
            BotdbContext database = new();
            database.Dicegamedbs.FirstOrDefault(d => d.UserName == username).Rank = emote;
            database.SaveChanges();
        }
    }
}

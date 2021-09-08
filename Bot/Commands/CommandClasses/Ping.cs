﻿using ApuDoingStuff.Twitch;
using TwitchLib.Client.Models;

namespace ApuDoingStuff.Commands.CommandClasses
{
    public static class Ping
    {
        public static void Handle(TwitchBot twitchBot, ChatMessage chatMessage)
        {
            twitchBot.Send(chatMessage.Channel, $"/me ApuSpin PONG! | {twitchBot.GetRuntime()} | {twitchBot.GetChannelInfo()} |");

        }

    }
}

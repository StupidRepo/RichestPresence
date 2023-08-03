using System;
using System.Threading;
using Discord;
using Activity = Discord.Activity;

namespace RichestPresence
{
    public static class Program
    {
        private static Discord.Discord discord;
        private static void UpdateDiscordActivityTitleText(Discord.Discord discordLol, string state, string details)
        {
            var activity = new Activity
            {
                State = state,
                Details = details,
                Assets =
                {
                },
                Instance = true,
            };

            discordLol.GetActivityManager().UpdateActivity(activity, (result) =>
            {
                if(result != Result.Ok) Console.WriteLine("Failed to update RPC!");
            });
        }

        private static void WaitForExit()
        {
            Console.WriteLine("Type 'exit' to exit the program.");
            while (true)
            {
                var input = Console.ReadLine();
                if (input != null && input.ToLower() == "exit")
                {
                    discord.Dispose();
                    Environment.Exit(0);
                }
            }
        }

        private static void Main()
        {
            discord = new Discord.Discord(1092044587016667166, (ulong)CreateFlags.Default);

            Console.WriteLine("Enter game details:");
            var details = Console.ReadLine() ?? "Error!";

            Console.WriteLine("Enter game state:");
            var state = Console.ReadLine() ?? "Error!";

            UpdateDiscordActivityTitleText(discord, state, details);

            var exitThread = new Thread(WaitForExit);
            exitThread.Start();

            while (true)
            {
                discord.RunCallbacks();
            }
        }
    }
}

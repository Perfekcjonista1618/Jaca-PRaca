using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib;
using TwitchLib.Models.API;
namespace KonsolowySzczur
{
    class Program
    {
        private static TwitchAPI api = new TwitchLib.TwitchAPI("o9atkbd9c8z95a2955e8zs1vv8pp7o", "qn73zxxaxf7pggww2uv3l3mtjy77he");
        static void Main(string[] args)
        {
            //private static TwitchLib.TwitchAPI api;
            Connect();
            Console.ReadLine();
        }
        public static async void Connect()
        {
            var id = await api.Channels.v5.GetChannelAsync();
            var channelFollowers = await api.Channels.v5.GetChannelFollowersAsync(id.Id);
            Console.WriteLine(channelFollowers.Total.ToString());
            Console.ReadLine();
        }
    }
}

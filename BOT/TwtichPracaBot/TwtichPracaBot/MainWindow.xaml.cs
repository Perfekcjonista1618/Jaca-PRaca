using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TwitchLib;
using TwitchLib.Models.API;

namespace TwtichPracaBot
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private static TwitchLib.TwitchAPI api;
        //private static 
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Connect();
            //Task t = Task.Run(async () =>
            //{
            //    //api = new TwitchLib.TwitchAPI("rxz5pppetn8rety2xl0jq6ighu8h4m", "pmnj871u2ddlmovup6ousnflfboqka");

            //    var channel = await api.Channels.v5.GetChannelAsync();
            //    var allSubscriptions = await api.Channels.v5.GetAllSubscribersAsync(channel.Id);
            //    bool isStreaming = await api.Streams.v5.BroadcasterOnlineAsync(channel.Id);
            //    MessageBox.Show(isStreaming.ToString());
            //    //foreach (var item in allSubscriptions)
            //    //{
            //    //    Console.WriteLine("Uzytkownik {0}, ID: {1}",item.User.Name, item.Id);
            //    //}
            //});
            //t.Wait();
        }
        public async void Connect()
        {
            TwitchAPI api = new TwitchLib.TwitchAPI("o9atkbd9c8z95a2955e8zs1vv8pp7o", "qn73zxxaxf7pggww2uv3l3mtjy77he");
            var id = await api.Channels.v5.GetChannelAsync();
            MessageBox.Show(id.Followers.ToString(),"Korona Kielce Kurwa Widelce" ,MessageBoxButton.OK);
  
        }
    }
}

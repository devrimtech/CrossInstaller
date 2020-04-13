using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Reactive.Linq;
using System.IO;
using System;
using System.Net;
using FirebaseAdmin.Auth;
using Firebase.Database;
using Firebase;
using FirebaseAdmin;
using Firebase.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Api;
using Google.Apis;

namespace CrossInstaller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Auth auth = new Auth();
            string clientUrl = auth.clientUrl;
            string token = auth.token;

            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.GetApplicationDefault(),
            });

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(auth.clientUrl+"/apps/github/download.json");
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            Console.WriteLine(objStream);

            TextBox txtb = new TextBox();
            txtb.Height = 500;
            txtb.Width = 200;
            txtb.Margin = new Thickness(0, 440, 836, 40);
        }


    }
}
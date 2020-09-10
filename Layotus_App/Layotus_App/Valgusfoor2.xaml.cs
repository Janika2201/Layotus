using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layotus_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        Label punane, kollane, roheline;
        Frame pun, kol, roh;
        Button sisse, valja;
        private bool tootab = false;


        public Valgusfoor2()
        {
            //InitializeComponent();
            punane = new Label()
            {
                Text = "Punane",
                TextColor = Color.FromRgb(204, 0, 0),
                FontSize = 30,
                FontAttributes = FontAttributes.Bold

            };
            pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
            };
            kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            kol = new Frame()
            {
                BackgroundColor = Color.FromRgb(255, 255, 0),
                Content = kollane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0),
            };
            roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            valja = new Button()
            {
                Text = "off",
                BackgroundColor = Color.Gold,
                HorizontalOptions = LayoutOptions.StartAndExpand

            };
            sisse = new Button()
            {
                Text = "on",
                BackgroundColor = Color.Gold,
                HorizontalOptions = LayoutOptions.EndAndExpand


            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, kol, roh }
            };
            stackLayout.Orientation = StackOrientation.Vertical;

            StackLayout stackLayout1 = new StackLayout()
            {
                Children = { valja, sisse }
            };
            stackLayout1.Orientation = StackOrientation.Horizontal;

            StackLayout stack = new StackLayout()
            {
                Children = { stackLayout, stackLayout1 }
            };

            Content = stack;

            sisse.Clicked += Sisse_Clicked;
            valja.Clicked += Valja_Clicked;


            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap);
            kol.GestureRecognizers.Add(tap);
            roh.GestureRecognizers.Add(tap);

        }
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if ((fr == pun) && (tootab == true))
            {
                punane.Text = "Seisa ja oota!!";
            }
            else if ((fr == kol) && (tootab == true))
            {
                kollane.Text = "Oota!!";
            }
            else if ((fr == roh) && (tootab == true))
            {
                roheline.Text = "Oota!!";
            }
            else if ((fr == pun) && (tootab == false))
            {
                punane.Text = "käivitage foor!";

            }
            else if ((fr == kol) && (tootab == false))
            {
                kollane.Text = "käivitage foor!";

            }
            else if ((fr == roh) && (tootab == false))
            {
                roheline.Text = "käivitage foor!";

            }
        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            tootab = false;
            pun.BackgroundColor = Color.FromRgb(100, 100, 100);
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.FromHex("#aaaaaa");
        }
        Random rnd = new Random();
<<<<<<< HEAD
        
        private  void Sisse_Clicked(object sender, EventArgs e)
=======

        private async void Sisse_Clicked(object sender, EventArgs e)
>>>>>>> 7d10a9db0205936f6ca96229e8f8003c13495315
        {
            tootab = true;
            int c = rnd.Next(1, 4);
            if (c == 1)
<<<<<<< HEAD
            {
                pun.BackgroundColor = Color.Red;
                kol.BackgroundColor = Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Color.FromRgb(62, 62, 62);

            }
            else if (c == 2)
            {
                pun.BackgroundColor = Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Color.Yellow;
                roh.BackgroundColor = Color.FromRgb(62, 62, 62);
            }
            else if (c == 3)
            {
                pun.BackgroundColor = Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Color.Green;
=======
            {
                pun.BackgroundColor = Color.Red;
                kol.BackgroundColor = Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Color.FromRgb(62, 62, 62);
>>>>>>> 7d10a9db0205936f6ca96229e8f8003c13495315

            }
            else if (c == 2)
            {
                pun.BackgroundColor = Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Color.Yellow;
                roh.BackgroundColor = Color.FromRgb(62, 62, 62);
            }
            else if (c == 3)
            {
                pun.BackgroundColor = Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Color.Green;
            }
          }
    }
}

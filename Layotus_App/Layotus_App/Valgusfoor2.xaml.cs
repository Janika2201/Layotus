using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layotus_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label punane = new Label()
            {
                Text = "Punane",
                TextColor = Color.White,
                FontSize=30,
                FontAttributes=FontAttributes.Bold
            };
            Frame pun = new Frame()
            {
                BackgroundColor=Color.Red,
                Content=punane,
                CornerRadius=90,
                Margin =new Thickness(80,0,80,0)
            };
            Label kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            Label roheline = new Label()
            {
                Text = "Roheline",
                TextColor= Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            Button off = new Button()
            {
                Text = "off",
                BackgroundColor=Color.Red
                
            };
            Button on = new Button()
            {
                Text = "on",
                BackgroundColor = Color.Red

            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, kol, roh}
            };
            stackLayout.Orientation = StackOrientation.Vertical;
            Content = stackLayout;
            StackLayout stackLayout1 = new StackLayout()
            {
                Children = { on, off }
            };

            stackLayout1.Orientation = StackOrientation.Horizontal;
            Content = stackLayout1;
        }
    }
}

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
    public partial class Valgustoor : ContentPage
    {
        public Valgustoor()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
    private void off_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.FromRgb(100, 100, 100);
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.FromHex("#aaaaaa");
        }

        private void on_Clicked(object sender, EventArgs e)
        {
            int c=rnd.Next(1, 4);
            if (c==1)
            {
                pun.BackgroundColor = Color.Red;
                kol.BackgroundColor = Color.FromRgb(62,62,62);
                roh.BackgroundColor = Color.FromRgb(62, 62, 62);

            }
            else if(c==2)
            {
                pun.BackgroundColor = Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Color.Yellow;
                roh.BackgroundColor = Color.FromRgb(62, 62, 62);
            }
            else if(c==3)
            {
                pun.BackgroundColor = Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Color.Green;
            }
        }   
    }
}
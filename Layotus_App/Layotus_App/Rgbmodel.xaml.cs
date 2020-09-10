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
    public partial class Rgbmodel : ContentPage
    {
        public Rgbmodel()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private void REDSlider_ValueChanged_1(object sender, ValueChangedEventArgs args)
        {
            if (sender == redSlider)
            {
                redLabel.Text = String.Format("Red = {0:X2}", (int)args.NewValue);
            }
            else if (sender == greenSlider)
            {
                greenLabel.Text = String.Format("Green = {0:X2}", (int)args.NewValue);
            }
            else if (sender == blueSlider)
            {
                blueLabel.Text = String.Format("Blue = {0:X2}", (int)args.NewValue);
            }

            boxView.Color = Color.FromRgb((int)redSlider.Value,
                                          (int)greenSlider.Value,
                                          (int)blueSlider.Value);
        }
        Random rnd = new Random();
        private void RandomBtn_Clicked(object sender, EventArgs e)
        {
            int R = rnd.Next(0, 255);
            int G = rnd.Next(0, 255);
            int B = rnd.Next(0, 255);
            redSlider.Value = R;
            greenSlider.Value = G;
            blueSlider.Value = B;
            Btn.BackgroundColor = Color.FromRgb(R, G, B);
            boxView.BackgroundColor = Color.FromRgb(R, G, B);
        }
    }
} 
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
        Random random = new Random();
        private void RandomBtn_Clicked(object sender, EventArgs e)
        {
            int Red = random.Next(0, 255);
            int Green = random.Next(0, 255);
            int Blue = random.Next(0, 255);
            redSlider.Value = Red;
            greenSlider.Value = Green;
            blueSlider.Value = Blue;
            Btn.BackgroundColor = Color.FromRgb(Red, Green, Blue);
            boxView.BackgroundColor = Color.FromRgb(Red, Green, Blue);
        }
    }
} 

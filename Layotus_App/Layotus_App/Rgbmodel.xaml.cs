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

        private void redSlider_ValueChanged(object sender, ValueChangedEventArgs args)
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
        public partial class LabelPage : ContentPage
        {

        }
    }
}
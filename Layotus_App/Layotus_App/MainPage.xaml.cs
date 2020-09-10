using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Layotus_App
{
    public partial class MainPage : ContentPage
    {
        private Label header;

        public MainPage()
        {
                header = new Label
                {
                    Text = "Slider",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    HorizontalOptions = LayoutOptions.Center
                };

                Slider slider = new Slider { Minimum = 0, Maximum = 50, Value = 30 };
                slider.ValueChanged += slider_ValueChanged;

                this.Content = new StackLayout { Children = { header, slider } };
            }

            void slider_ValueChanged(object sender, ValueChangedEventArgs e)
            {
                header.Text = String.Format("Выбрано: {0:F1}", e.NewValue);
            }
        }
    }


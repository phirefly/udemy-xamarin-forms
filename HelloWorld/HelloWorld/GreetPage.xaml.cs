using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            // Set the initial value of the slider
            greetingSlider.Value = 0.5;
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            greetingLabel.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}
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
            // Code version of the xaml code
            // Content = new Label
            // {
            //     HorizontalOptions = LayoutOptions.Center,
            //     VerticalOptions = LayoutOptions.Center,
            //     Text = "Hello World from code"
            // };
        }
    }
}
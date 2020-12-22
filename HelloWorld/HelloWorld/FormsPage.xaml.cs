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
    public partial class FormsPage : ContentPage
    {
        public FormsPage()
        {
            InitializeComponent();
        }

        private void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
            conditionalContent.IsVisible = e.Value;
        }
    }
}
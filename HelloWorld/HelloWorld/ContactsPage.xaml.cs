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
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
            contactsListView.ItemsSource = new List<Contact>()
            {
                new Contact
                {
                    Name = "George Jetson", Status = "Pending",
                    ImageUrl = "https://via.placeholder.com/150?text=Judy+Jetson"
                },
                new Contact
                {
                    Name = "Elroy Jetson", Status = "Pending",
                    ImageUrl = "https://via.placeholder.com/150?text=Judy+Jetson"
                },
                new Contact
                {
                    Name = "Judy Jetson", Status = "Pending",
                    ImageUrl = "https://via.placeholder.com/150?text=Judy+Jetson"
                }
            };
        }
    }
}
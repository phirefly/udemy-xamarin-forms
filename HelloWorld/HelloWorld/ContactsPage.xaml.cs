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
                    ImageUrl = "https=//via.placeholder.com/728x90.png?text=George+Jetson"
                },
                new Contact
                {
                    Name = "Elroy Jetson", Status = "Pending",
                    ImageUrl = "https=//via.placeholder.com/728x90.png?text=Elroy+Jetson"
                },
                new Contact
                {
                    Name = "Judy Jetson", Status = "Pending",
                    ImageUrl = "https=//via.placeholder.com/728x90.png?text=Judy+Jetson"
                }
            };
        }
    }
}
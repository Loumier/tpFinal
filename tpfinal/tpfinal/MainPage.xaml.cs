using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tpfinal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //new NavigationPage(new View.Book.addBook());

            
        }

        async void addBookButton(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new View.Book.addBook());
        }

        async void listBooksButton(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new View.Book.ListBook());
        }

        async void locationButton(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new View.Book.location());
        }
    }
}

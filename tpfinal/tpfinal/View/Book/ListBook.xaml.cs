using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tpfinal.View.Book
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListBook : ContentPage
	{
		public ListBook ()
		{
            //Model.Book bookUnit = new Model.Book();
            List<Model.Book> bookList = new List<Model.Book>();

			InitializeComponent ();

            void listBooks()
            {

            }


		}
	}
}
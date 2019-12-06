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
            //List<Model.Book> bookList = new List<Model.Book>();
            List<Model.getConnection> bookList;

			InitializeComponent ();

		}

        async void deleteBookButton(int id, string bookName)
        {
            await DisplayAlert("Excluir", "Deseja excluir o livro" + bookName + "?", "Sim", "Não");
            //Implementar interação com o popup para confirmar a exclusão

            string sql = "delete from books where id like " + id;
        }
	}
}
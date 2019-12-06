
using Android.Util;
using App.Crud_Xamarin.Resources.Model;
using SQLite;
using System.Collections.Generic;
using System.Linq;
namespace App.Crud_Xamarin.Resources.DataBaseHelper
{
    public class DataBase
    {
        string pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public bool createDatabase()
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Books.db")))
                {
                    conexao.CreateTable<Library>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public bool insertBook(Book book)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Books.db")))
                {
                    conexao.Insert(book);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public List<Book> GetBooks()
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Books.db")))
                {
                    return conexao.Table<Book>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }

        public bool updateBook(Book book)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Books.db")))
                {
                    conexao.Query<Book>("UPDATE Library set Nome=?,Autor=?, Email=?, Isbn=? Where Id=?", book.Name, book.Author, book.email, book.isbn);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public bool deleteBook(Aluno aluno)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Books.db")))
                {
                    conexao.Delete(book);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

        public bool getBook(int Id)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Books.db")))
                {
                    conexao.Query<Aluno>("SELECT * FROM Library Where Id=?", Id);
                    //conexao.Update(aluno);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

    }
}
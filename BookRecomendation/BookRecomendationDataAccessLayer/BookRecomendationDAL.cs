using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using BookRecomendationDTO;

namespace BookRecomendationDataAccessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class BookRecomendationDAL
    {

        SqlConnection conObj;
        SqlCommand cmdObj;
        BookRecomendationContext Context;
        public BookRecomendationDAL()
        {
            conObj = new SqlConnection(ConfigurationManager.ConnectionStrings["BookRecomendationConnectionstr"].ConnectionString);
            Context = new BookRecomendationContext();
        }
        public int ConnectionToDB()
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["BookRecomendationConnectionstr"].ConnectionString;
                SqlConnection conObj = new SqlConnection(ConnectionString);
                conObj.Open();
                if (conObj.State.ToString() == "Open")
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

        public List<BookDTO> FetchReviewsForBook()
        {
        try
        {
            List<Books> ObjDB = Context.Books.ToList();
            List<BookDTO> Objdt = new List<BookDTO>();
            foreach (var bk in ObjDB)
            {
                Objdt.Add(new BookDTO()
                {
                    book_isbn = bk.book_isbn,
                    title = bk.title,
                    author_id = bk.author_id,
                    book_edition = bk.book_edition
                });
            }
            return Objdt;


        }
        catch (Exception ex)
        {

            throw;
        }
        }

        public void SaveReviewForBookToDB()
        {
        }

}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookRecomendationDataAccessLayer;
using BookRecomendationDTO;

namespace BookRecomendationBusinessLayer
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required. 
    public class BookRecomendationBL
    {
        BookRecomendationDAL Objdal;
        public BookRecomendationBL()
        {
            Objdal = new BookRecomendationDAL();
        }
        public int ConnectToDB()
        {
            try
            {

                return Objdal.ConnectionToDB();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<BookDTO> ShowReviewsForBook()
        {
            try
            {
                List<BookDTO> Objbl = Objdal.FetchReviewsForBook();
                return Objbl;
 
    }
            catch (Exception ex)
            {

                throw;
            };


        }


        public int AddReviewForBook(BookDTO DTOObj, out int newbook_isbn)
        {
            if (String.IsNullOrEmpty(DTOObj.title))
            {
                newbook_isbn = 0;
                return -1;
            }
            else if (string.IsNullOrEmpty(DTOObj.author_name))
            {
                newbook_isbn = 0;
                return -2;
            }
            else
                return Objdal.SaveReviewForBookToDB(DTOObj, out newbook_isbn);
        }
        

        

    }
}

using BookRecomendationDTO;
using BookRecomendationBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookReviewsAPI.Controllers
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class BookReviewsController : ApiController
    {
        BookRecomendationBL Objbl;
        public BookReviewsController()
        {
            Objbl = new BookRecomendationBL();
        }

        [HttpGet]
        public HttpResponseMessage GetRatingsForBook()
        {
            List<BookDTO> ObjApi = Objbl.ShowReviewsForBook();

            try
            {
                if (ObjApi.Count > 0)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.OK, ObjApi);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.OK, "No Book Deatils ");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.OK,"Something Error");
            }
        }

    }
}

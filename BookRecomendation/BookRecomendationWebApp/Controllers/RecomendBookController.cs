using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BookRecomendationBusinessLayer;
using BookRecomendationDTO;
using BookRecomendationWebApp.Models;
using Newtonsoft.Json;

namespace BookRecomendationWebApp.Controllers
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class RecomendBookController : Controller
    {
        // GET: RecomendBook
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult AddReviews()
        {
            try
            {
                BookRecomendationBL Objbl = new BookRecomendationBL();
                List<BookDTO> ObjPL = Objbl.ShowReviewsForBook();
                List<BookViewModel> ObjModel = new List<BookViewModel>();
                foreach (var bk in ObjPL)
                {
                    ObjModel.Add(new BookViewModel()
                    {

                        book_isbn = bk.book_isbn,
                        title = bk.title,
                        author_id = bk.author_id,
                        book_edition = bk.book_edition
                    });
                }
                return View(ObjModel);
            }

            catch (Exception ex)
            {

                return View("Error");
            }
            }
        }

        public void DisplayResultsUsingWebAPI(BookDTO Objnew)
        {
           if(Objnew ! = null)
        {
            BookRecomendationBL Objbl = new BookRecomendationBL();
            BookDTO ObjDTO = new BookDTO();
            ObjDTO.author_name = Objnew.author_name;
            ObjDTO.book_edition = Objnew.book_edition;
            ObjDTO.author_id = Objnew.author_id;
            ObjDTO.title = Objnew.title;
            int newbook_isbn = 0;
            
        }
        }
    }


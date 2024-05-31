using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcTemplateDemo.Models;

namespace MvcTemplateDemo.Controllers
{
    public class MovieController : Controller
    {
        //<input>

         //<label for="search" > Search </label>




        // GET: MovieController
        public ActionResult Index()
        {
            var model = from m in _movieList
                        orderby m.Id
                        select m;
            return View(model);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            var model = _movieList.FirstOrDefault(s => s.Id == id);
            return View(model);
             
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {

            var movitem = new Movie();
            return View(movitem);
        }



        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie newmovie)
        {
            try
            {
                _movieList.Add(newmovie);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            var record = _movieList.Single(m => m.Id == id);

            return View(record);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Movie mov)
        {
            var record = _movieList.Single(m=>m.Id == id);

            try
            {
                record.MName = mov.MName;
                record.MRating = mov.MRating;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(record);
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            var record = _movieList.Single(m => m.Id == id);

            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var record = _movieList.Single(m => m.Id == id);

            try
            {
                _movieList.Remove(record);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(record);
            }
        }

        static List<Movie> _movieList = new List<Movie>()
        {

        new Movie{
            Id=1,
            MName = "3 Idiots",
            MStar = "Aamir",
            MRating = 9
            },

        new Movie{
            Id=2,
            MName = "KGF",
            MStar = "Rocky",
            MRating = 7
            },

        new Movie
        {
            Id = 3,
            MName = "Robot",
            MStar = "Rajni",
            MRating = 5
        },

        new Movie
        {
            Id = 4,
            MName = "Kick",
            MStar = "Randeep",
            MRating = 8
        }

        };

        static List<MovDetails> _movdetails = new List<MovDetails>()
        {
            new MovDetails
            {
                Id=1,
                MName = "3 Idiots",
                MStar = "Aamir",
                MRating = 9
            
            },

            new MovDetails
            {
                Id=2,
                MName = "KGF",
                MStar = "Rocky",
                MRating = 7
            },

            new MovDetails
            {
                Id = 3,
                MName = "Robot",
                MStar = "Rajni",
                MRating = 5
            },

            new MovDetails
            {
                Id = 4,
                MName = "Kick",
                MStar = "Randeep",
                MRating = 8

            }





        };


    }
}

using game_store_demo.Data;
using game_store_demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace game_store_demo.Controllers
{
    public class VideoGameController : Controller
    {
        private readonly GameStoreDbContext _db;

        public VideoGameController(GameStoreDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<VideoGame> objList = _db.VideoGame;            
            return View(objList);
        }

        //GET 
        public IActionResult Create()
        {           
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VideoGame obj)
        {

            _db.VideoGame.Add(obj);
            _db.SaveChanges();
            //we go back to index so we can go back to see all videogames
            return RedirectToAction("Index");
         
        }

        //GET EDIT
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.VideoGame.Find(id);
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(VideoGame obj)
        {
            _db.VideoGame.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.VideoGame.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.VideoGame.Find(id);
            if (id == null)
            {
                return NotFound();
            }
            _db.VideoGame.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

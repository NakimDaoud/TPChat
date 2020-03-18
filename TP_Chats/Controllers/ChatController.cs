using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;

namespace TP_Chats.Controllers
{
    public class ChatController : Controller
    {

        private static List<Chat> Chats;

        public ChatController() {
            Chats = new List<Chat> {
                new Chat{Age =3, Couleur="roux", Id=1,Nom="Felix"},
                new Chat{Age =1, Couleur="noire", Id=2,Nom="Minette"},
                new Chat{Age =10, Couleur="blanche", Id=3,Nom="Miss"},
                new Chat{Age =6, Couleur="gris", Id=4,Nom="Garfield"},
                new Chat{Age =4, Couleur="fauve", Id=5,Nom="Chatran"},
                new Chat{Age =2, Couleur="blanc", Id=6,Nom="Minou"},
                new Chat{Age =12, Couleur="rousse", Id=7,Nom="Bichette"}
            };
        }
        // GET: Chat
        public ActionResult Index()
        {
            return View(Chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {

            var chat = Chats.FirstOrDefault(c => c.Id == id);

            return View(chat);
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            var chat = Chats.FirstOrDefault(c => c.Id == id);

            return View(chat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using OdafHesapProgrami.DTO;
using OdafHesapProgrami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdafHesapProgrami.Controllers
{
    public class ProjeGenelController : Controller
    {


        private Model db = new Model();
        private ResultMessage resultMessage;
        public int PageNumber = 10;
        public ActionResult Index(int sayfa = 0,string arananTrafoNo=null)
        {
            List<ProjeGenel> projeGenel = new List<ProjeGenel>();
            if (arananTrafoNo != null)
            {
                projeGenel = db.ProjeGenel.Where(x => x.TrafoNo == arananTrafoNo).ToList();
            }
            else
            {
                projeGenel = db.ProjeGenel.OrderByDescending(X => X.ProjeID).Skip(PageNumber / 1 * sayfa).Take(PageNumber).ToList();
            }

            PageDTO<ProjeGenel> Result = new PageDTO<ProjeGenel>
            {

                Entity = projeGenel,
                ActivePage= sayfa,
                TotalCount= db.ProjeGenel.Count()
            };
            return View(Result);
        }

        [Authorize]
        [HttpGet]
        public ActionResult ProjeEkle(string id=null)
        {
            ProjeGenel projeGenel = new ProjeGenel();
            try{
                int projeGenelId = Convert.ToInt32(id);
                projeGenel = db.ProjeGenel.Where(x => x.ProjeID == projeGenelId).FirstOrDefault();
            }
            catch {}
            return View(projeGenel);
        }

        [HttpPost]
        public JsonResult ProjeEklee(ProjeGenel projeGenel)
        {
            try
            {
                projeGenel.RootID = 1;
                db.ProjeGenel.Add(projeGenel);
               var gg =  db.SaveChanges();

                if (gg == 1)
                {
                    resultMessage = new ResultMessage
                    {
                        Message = "Başarı ile kaydedildi",
                        Success = true,
                        ReturnUrl = "/ProjeGenel/Index"
                    };
                }
                else {
                    resultMessage = new ResultMessage
                    {
                        Message = "Bir Hata Oluştu",
                        Success = false,
                    };
                }
               
               return Json(resultMessage);
            }
            catch (Exception ex)
            {
                resultMessage = new ResultMessage
                {
                    Message = ex.Message,
                    Success = false
                };
               return Json(resultMessage);
            }

        }

        [HttpGet]
        public ActionResult ProjeEkleTest()
        {
            return View();
        }
        [HttpGet]
        public ActionResult TestListe()
        {
            return View();
        }
    }
}
using FirstSQL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstSQL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Slider> sliders = new List<Slider>
            {
                new Slider()
                {
                    ID = 1,
                    Order=1,
                    Image = "1.jpg",
                    Title = "The Best Business Information",
                    Info = "We're In The Business Of Helping You Start Your Businesses",
                    RedirectUrl = "https://www.gumroad.com"
                },
                new Slider()
                {
                    ID = 2,
                    Order = 2,
                    Image = "2.jpg",
                    Title = "At vero eos et accusamus",
                    Info = "Helping Business Security & Peace of Mind for Your Families",
                    RedirectUrl = "https://www.github.com"
                },
                new Slider()
                {
                    ID = 3,
                    Order =3,
                    Image = "3.jpg",
                    Title = "Temporibus autem quibusdam",
                    Info = "Beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptateme",
                    RedirectUrl = "https://www.gitguardian.com"
                }
            };
            return View(sliders);
        }
    }
}

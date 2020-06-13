using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BusinessPhone.Controllers
{
   [AllowAnonymous]
   
  
    public class DefaultController:Controller
    {
        [AllowAnonymous]
        public ActionResult Index(){
            return Redirect("Home");
        }
    }
}
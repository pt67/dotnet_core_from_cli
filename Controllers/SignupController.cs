using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcSignup.Controllers
{
    public class SignupController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        public string Create(){
            return "created";
        }

    }
}

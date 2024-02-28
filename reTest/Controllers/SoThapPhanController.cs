using Microsoft.AspNetCore.Mvc;

namespace reTest.Controllers
{
    [Route("[controller]")]
    public class SoThapPhanController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("NhapSo")]
        public IActionResult NhapSo() 
        {
            return View();
        }

        [HttpGet("JsonLearn")]
        public IActionResult JsonLearn()
        {
            return View();
        }
        [HttpPost("CheckSoTP/{so}")]
        public IActionResult CheckSoTP(string so) 
        {
            if (decimal.TryParse(so, out decimal result) && so.Contains('.'))
            {
                return Json(new {message = "Số bạn vừa nhập là số thập phân!"});
            }
            else
            {
                return Json(new { message = "Số bạn vừa nhập không phải là số thập phân!" });
            }
        }
    }
}

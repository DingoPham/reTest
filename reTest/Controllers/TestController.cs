using Microsoft.AspNetCore.Mvc;

namespace reTest.Controllers
{
    [Route("[controller]")]
    public class TestController : Controller
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("User")]
        public IActionResult User()
        {
            return View();
        }

        [HttpGet("Yap")]
        public IActionResult Yap()
        {
            return View();
        }
        [HttpGet("Event")]
        public IActionResult Event()
        {
            return View();
        }
        [HttpGet("Event2")]
        public IActionResult New_Event() 
        {
            return View();
        }
        [HttpGet("BT1")]
        public IActionResult BT1() 
        {
            return View();
        }

        [HttpPost("about")]
        public IActionResult Post_Test([FromQuery] string a, [FromQuery] string b)
        {
            if (!int.TryParse(a, out int A) || !int.TryParse(b, out int B)) {
                return BadRequest("Nhập sai, hãy nhập lại!");
            }
            int result = A + B;
            return Ok($"{A} + {B} = {result}");
        }

        [HttpPut("about")]
        public IActionResult Put_Test([FromQuery] string a, [FromQuery] string b)
        {
            if (!int.TryParse(a, out int A) || !int.TryParse(b, out int B))
            {
                return BadRequest("Nhập sai, hãy nhập lại!");
            }
            int result = A - B;
            return Ok($"{A} - {B} = {result}");
        }

        [HttpDelete("about")]
        public IActionResult Del_Test([FromQuery] string a, [FromQuery] string b)
        {
            if (!int.TryParse(a, out int A) || !int.TryParse(b, out int B))
            {
                return BadRequest("Nhập sai, hãy nhập lại!");
            }
            int result = A * B;
            return Ok($"{A} * {B} = {result}");
        }

        [HttpGet("about")]
        public IActionResult Get_Test([FromQuery] string a, [FromQuery] string b)
        {
            if (!int.TryParse(a, out int A) || !int.TryParse(b, out int B))
            {
                return BadRequest("Nhập sai, hãy nhập lại!");
            }
            int result = A / B;
            return Ok($"{A} / {B} = {result}");
        }

        [HttpPost("Maytinh/{tienhanh}")]
        public IActionResult Maytinh(int so1, int so2, string tienhanh)
        {
            int result = 0;

            switch (tienhanh) 
            {
                case "cong":
                    result = so1 + so2;
                    break;
                case "tru":
                    result = so1 - so2;
                    break;
                case "nhan":
                    result = so1 * so2;
                    break;
                case "chia":
                    if(so2 != 0)
                    {
                        result = so1 / so2;
                    }
                    if(so2 == 0)
                    {
                        result = 0;
                    }
                    break;
                    
            }
            return Json(result);
        }

        [HttpPut("Guidata/{nhan}")]
        public IActionResult Guidata(string nhan)
        {
            if (!string.IsNullOrEmpty(nhan))
            {
                int soCount = nhan.Length;

                return Json(new { message = $"Chuỗi có {soCount} ký tự" });
            }
            else
            {
                return BadRequest("Dữ liệu nhập không hợp lệ");
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitnerBox.Controllers
{
    [ApiController]
    [Route("/api/LeitnerBox/[controller]/[Action]")]
    internal class LeitnerBoxController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok();
        }
    }
}

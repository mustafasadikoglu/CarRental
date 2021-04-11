using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindexsController : ControllerBase
    {
        IFindexService _findexService;

        public FindexsController(IFindexService findexService)
        {
            _findexService = findexService;
        }

        [HttpGet("getfindexbyuserid")]
        public IActionResult Get(int id)
        {
            var result = _findexService.GetFindexByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

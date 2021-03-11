using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundsController : ControllerBase
    {

        IFundService _fundService;

        public FundsController(IFundService fundService)
        {
            _fundService = fundService;
        }

        [HttpGet("getfundsbyuserid")]
        public IActionResult GetFundsByUserId(int userId)
        {
            var result = _fundService.GetFundsByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Fund fund)
        {
            var result = _fundService.Add(fund);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Fund fund)
        {
            var result = _fundService.Delete(fund);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(Fund fund)
        {
            var result = _fundService.Update(fund);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}

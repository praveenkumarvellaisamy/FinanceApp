using CoimbatoreFinanceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CoimbatoreFinanceAPI.Controllers
{
    [Route("api")]
    [Authorize]
    public class LineController : ApiController
    {
        [HttpPost]
       [AllowAnonymous]
        [Route("api/LineAPI/LineInsert")]
        public IHttpActionResult LineInsert([FromBody] LineModel Params)
        {
            try
            {
                LineInsert RIU = new LineInsert(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/LineAPI/LineUpdate")]
        public IHttpActionResult LineUpdate([FromBody] LineModel Params)
        {
            try
            {
                LineUpdate RIU = new LineUpdate(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [AllowAnonymous]
        [Route("api/LineAPI/GetLineList")]
        public IHttpActionResult GetLineList([FromBody] LineModel Params)
        {
            try
            {

                LineList RL = new LineList(Params);

                return Ok(RL);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/LineAPI/LineDelete")]
        public IHttpActionResult LineDelete([FromBody] LineModel Params)
        {
            try
            {

                LineDelete ED = new LineDelete(Params);

                return Ok("Success");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}
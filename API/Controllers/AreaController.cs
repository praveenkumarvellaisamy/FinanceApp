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
    public class AreaController : ApiController
    {
        [HttpPost]
       [AllowAnonymous]
        [Route("api/AreaAPI/AreaInsert")]
        public IHttpActionResult AreaInsert([FromBody] AreaModel Params)
        {
            try
            {
                AreaInsert RIU = new AreaInsert(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/AreaAPI/AreaUpdate")]
        public IHttpActionResult AreaUpdate([FromBody] AreaModel Params)
        {
            try
            {
                AreaUpdate RIU = new AreaUpdate(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [AllowAnonymous]
        [Route("api/AreaAPI/GetAreaList")]
        public IHttpActionResult GetAreaList([FromBody] AreaModel Params)
        {
            try
            {

                AreaList RL = new AreaList(Params);

                return Ok(RL);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/AreaAPI/AreaDelete")]
        public IHttpActionResult AreaDelete([FromBody] AreaModel Params)
        {
            try
            {

                AreaDelete ED = new AreaDelete(Params);

                return Ok("Success");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}
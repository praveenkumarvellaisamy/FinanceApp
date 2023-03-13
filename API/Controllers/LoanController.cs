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
    public class LoanController : ApiController
    {
        [HttpPost]
       [AllowAnonymous]
        [Route("api/LoanAPI/LoanInsert")]
        public IHttpActionResult LoanInsert([FromBody] LoanModel Params)
        {
            try
            {
                LoanInsert RIU = new LoanInsert(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/LoanAPI/LoanUpdate")]
        public IHttpActionResult LoanUpdate([FromBody] LoanModel Params)
        {
            try
            {
                LoanUpdate RIU = new LoanUpdate(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [AllowAnonymous]
        [Route("api/LoanAPI/GetLoanList")]
        public IHttpActionResult GetLoanList([FromBody] LoanModel Params)
        {
            try
            {

                LoanList RL = new LoanList(Params);

                return Ok(RL);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/LoanAPI/LoanDelete")]
        public IHttpActionResult LoanDelete([FromBody] LoanModel Params)
        {
            try
            {

                LoanDelete ED = new LoanDelete(Params);

                return Ok("Success");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}
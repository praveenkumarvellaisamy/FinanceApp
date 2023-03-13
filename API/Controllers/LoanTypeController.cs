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
    public class LoanTypeTypeController : ApiController
    {
        [HttpPost]
       [AllowAnonymous]
        [Route("api/LoanTypeAPI/LoanTypeInsert")]
        public IHttpActionResult LoanTypeInsert([FromBody] LoanTypeModel Params)
        {
            try
            {
                LoanTypeInsert RIU = new LoanTypeInsert(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/LoanTypeAPI/LoanTypeUpdate")]
        public IHttpActionResult LoanTypeUpdate([FromBody] LoanTypeModel Params)
        {
            try
            {
                LoanTypeUpdate RIU = new LoanTypeUpdate(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [AllowAnonymous]
        [Route("api/LoanTypeAPI/GetLoanTypeList")]
        public IHttpActionResult GetLoanTypeList([FromBody] LoanTypeModel Params)
        {
            try
            {

                LoanTypeList RL = new LoanTypeList(Params);

                return Ok(RL);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/LoanTypeAPI/LoanTypeDelete")]
        public IHttpActionResult LoanTypeDelete([FromBody] LoanTypeModel Params)
        {
            try
            {

                LoanTypeDelete ED = new LoanTypeDelete(Params);

                return Ok("Success");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}
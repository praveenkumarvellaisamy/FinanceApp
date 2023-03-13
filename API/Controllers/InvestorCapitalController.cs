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
    public class InvestorCapitalController : ApiController
    {
        [HttpPost]
       [AllowAnonymous]
        [Route("api/InvestorCapitalAPI/InvestorCapitalInsert")]
        public IHttpActionResult InvestorCapitalInsert([FromBody] InvestorCapitalModel Params)
        {
            try
            {
                InvestorCapitalInsert RIU = new InvestorCapitalInsert(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/InvestorCapitalAPI/InvestorCapitalUpdate")]
        public IHttpActionResult InvestorCapitalUpdate([FromBody] InvestorCapitalModel Params)
        {
            try
            {
                InvestorCapitalUpdate RIU = new InvestorCapitalUpdate(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [AllowAnonymous]
        [Route("api/InvestorCapitalAPI/GetInvestorCapitalList")]
        public IHttpActionResult GetInvestorCapitalList([FromBody] InvestorCapitalModel Params)
        {
            try
            {

                InvestorCapitalList RL = new InvestorCapitalList(Params);

                return Ok(RL);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/InvestorCapitalAPI/InvestorCapitalDelete")]
        public IHttpActionResult InvestorCapitalDelete([FromBody] InvestorCapitalModel Params)
        {
            try
            {

                InvestorCapitalDelete ED = new InvestorCapitalDelete(Params);

                return Ok("Success");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}
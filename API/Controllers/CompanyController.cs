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
    public class CompanyController : ApiController
    {
        [HttpPost]
       [AllowAnonymous]
        [Route("api/CompanyAPI/CompanyInsert")]
        public IHttpActionResult CompanyInsert([FromBody] CompanyModel Params)
        {
            try
            {
                CompanyInsert RIU = new CompanyInsert(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/CompanyAPI/CompanyUpdate")]
        public IHttpActionResult CompanyUpdate([FromBody] CompanyModel Params)
        {
            try
            {
                CompanyUpdate RIU = new CompanyUpdate(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [AllowAnonymous]
        [Route("api/CompanyAPI/GetCompanyList")]
        public IHttpActionResult GetCompanyList([FromBody] CompanyModel Params)
        {
            try
            {

                CompanyList RL = new CompanyList(Params);

                return Ok(RL);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/CompanyAPI/CompanyDelete")]
        public IHttpActionResult CompanyDelete([FromBody] CompanyModel Params)
        {
            try
            {

                CompanyDelete ED = new CompanyDelete(Params);

                return Ok("Success");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}
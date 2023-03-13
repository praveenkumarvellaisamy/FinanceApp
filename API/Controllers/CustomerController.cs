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
    public class CustomerController : ApiController
    {
        [HttpPost]
       [AllowAnonymous]
        [Route("api/CustomerAPI/CustomerInsert")]
        public IHttpActionResult CustomerInsert([FromBody] CustomerModel Params)
        {
            try
            {
                CustomerInsert RIU = new CustomerInsert(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/CustomerAPI/CustomerUpdate")]
        public IHttpActionResult CustomerUpdate([FromBody] CustomerModel Params)
        {
            try
            {
                CustomerUpdate RIU = new CustomerUpdate(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [AllowAnonymous]
        [Route("api/CustomerAPI/GetCustomerList")]
        public IHttpActionResult GetCustomerList([FromBody] CustomerModel Params)
        {
            try
            {

                CustomerList RL = new CustomerList(Params);

                return Ok(RL);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost]
       [AllowAnonymous]
        [Route("api/CustomerAPI/CustomerDelete")]
        public IHttpActionResult CustomerDelete([FromBody] CustomerModel Params)
        {
            try
            {

                CustomerDelete ED = new CustomerDelete(Params);

                return Ok("Success");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}
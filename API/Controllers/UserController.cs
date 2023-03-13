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
    public class UserController : ApiController
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("api/UserAPI/UserInsert")]
        public IHttpActionResult UserInsert([FromBody] UserModel Params)
        {
            try
            {
                UserInsert RIU = new UserInsert(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/UserAPI/UserUpdate")]
        public IHttpActionResult UserUpdate([FromBody] UserModel Params)
        {
            try
            {
                UserUpdate RIU = new UserUpdate(Params);

                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [AllowAnonymous]
        [Route("api/UserAPI/GetUserList")]
        public IHttpActionResult GetUserList([FromBody] UserModel Params)
        {
            try
            {

                UserList RL = new UserList(Params);

                return Ok(RL);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/UserAPI/UserDelete")]
        public IHttpActionResult UserDelete([FromBody] UserModel Params)
        {
            try
            {

                UserDelete ED = new UserDelete(Params);

                return Ok("Success");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}
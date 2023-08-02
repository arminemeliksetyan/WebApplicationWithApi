using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSocialMediaApi.Models;

namespace WebApplicationSocialMediaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public ActionResult CreaateUser(UserAdd userAdd)
        {
            try
            {
                int x = 12;
                int y = 13;
            }
            catch (Exception e)
            {

                throw;
            }
            return Ok();
        }

        [HttpGet]
        public ActionResult FindUser(int id)
        {
            try
            {
                Dictionary<int, string> users = new Dictionary<int, string>();
                users.Add(0, "Arine");
                users.Add(1, "Armine");
                users.Add(2, "Ann");
                users.Add(3, "Albert");
                if (users.ContainsKey(id))
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);   
                throw;
            }
        }

        [HttpDelete("DeleteThis")]
        public ActionResult DeleteUser(int id)
        {
            try
            {
                Dictionary<int, string> users = new Dictionary<int, string>();
                users.Add(0, "Arine");
                users.Add(1, "Armine");
                users.Add(2, "Ann");
                users.Add(3, "Albert");
                if (users.ContainsKey(id))
                {
                    users.Remove(id);
                    return Ok($"User id {id}");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

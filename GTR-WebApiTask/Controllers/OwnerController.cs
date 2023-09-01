using GTR_WebApiTask.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTR_WebApiTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        [Route("GetData")]
        public string GetData()
        {
            return "Authenticated with jwt";
        }

        [HttpGet]
        [Route("Details")]
        public string Details()
        {
            return "Authenticated with jwt";
        }

        [HttpPost]
        [Authorize]
        
        public string AddUser(Users user)
        {
            return "User added with username" + user.Username;
        }

    }
}

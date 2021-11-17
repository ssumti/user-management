using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Repository.Repositories;
using api.Repository.Interfaces;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        public UsersController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpPost("createUser_")]
        public ActionResult createUser(User user)
        {
            userRepository.createUser(user);
            return Ok();
        }
        [HttpGet("getUser_/{id}")]
        public ActionResult getUserById(Guid id)
        {
            return Ok(userRepository.getUserById(id));
        }
        [HttpGet("getUser_/{name}")]
        public ActionResult getUserByName(string name)
        {
            return Ok(userRepository.getUserByName(name));
        }
        [HttpDelete("deleteUser_/{id}")]
        public ActionResult deleteUserById(Guid id)
        {
            userRepository.deleteUserById(id);
            return Ok();
        }
        [HttpDelete("deleteUser_/{name}")]
        public ActionResult deleteUserByName(string name)
        {
            userRepository.deleteUserByName(name);
            return Ok();
        }
        [HttpPut("updateUser_/{id}")]
        public ActionResult updateUser(Guid id, User user)
        {
            userRepository.updateUser(user, id);
            return Ok();
        }
    }
}

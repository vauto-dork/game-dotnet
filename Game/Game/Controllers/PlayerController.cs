using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Game.Data;

namespace Game.Controllers
{
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        private readonly GameContext _gameContext;

        public PlayerController(GameContext gameContext)
        {
            _gameContext = gameContext;
        }

        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_gameContext.Player.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(Guid id)
        {
            return Json(_gameContext.Player.SingleOrDefault(player => player.Id == id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]PlayerDto playerDto)
        {
            var newPlayer = new Player {
                Id = Guid.NewGuid(),
                FirstName = playerDto.FirstName,
                LastName = playerDto.LastName,
                NickName = playerDto.NickName,
                CustomInitials = playerDto.CustomInitials,
                Active = true
            };

            _gameContext.Add(newPlayer);
            _gameContext.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

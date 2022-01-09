using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    //qeky routi kallzon qysh mu qas qetij api dmth /api/emriKontrollerit
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }
        //i merr krejt userat
        [HttpGet]
        public async Task<ActionResult <IEnumerable<AppUser>>> GetUsers(){
            return await  _context.Users.ToListAsync();

   
        }
        // api/users/3
        // i merr userat nbaz te ID qe ja qon klienti ne API
        [HttpGet("{id}")]
        public async Task<ActionResult <AppUser>> GetUser(int id){
             
            return await _context.Users.FindAsync(id);
        }
    }
}
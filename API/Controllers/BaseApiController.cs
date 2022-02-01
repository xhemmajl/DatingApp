using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    //qeky routi kallzon qysh mu qas qetij api dmth /api/emriKontrollerit
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        
    }
}
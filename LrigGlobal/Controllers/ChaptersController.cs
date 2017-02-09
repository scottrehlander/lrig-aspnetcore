using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LrigGlobal.Models;
using LrigGlobal.Repositories;

namespace LrigGlobal.Controllers
{
    [Route("api/[controller]")]
    public class ChaptersController : BasicCrudController<Chapter>
    {
        public ChaptersController(ChaptersRepository chapterRepository) : base(chapterRepository) { }
    }
}

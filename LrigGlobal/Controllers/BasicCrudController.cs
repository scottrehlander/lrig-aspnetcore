using LrigGlobal.Models;
using LrigGlobal.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LrigGlobal.Controllers
{
    public class BasicCrudController<T> : Controller where T : LrigBaseModel
    {
        private readonly BasicRepository<T> _repository;

        public BasicCrudController(BasicRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet("[action]")]
        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}

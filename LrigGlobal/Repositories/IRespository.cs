using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LrigGlobal.Models;

namespace LrigGlobal.Repositories
{
    public interface IRepository<T> where T : LrigBaseModel
    {
        IEnumerable<T> GetAll();

        T GetById(ObjectId id);

        void Add(T item);

        void Update(T item);

        bool Remove(ObjectId id);
    }
}

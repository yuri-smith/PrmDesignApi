using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PrmDesignApi.Models;

namespace PrmDesignApi.Repositories
{
    public class DimsRepository : IRepository<Dim>
    {
        private PrmDesignContext db;

        public DimsRepository(PrmDesignContext context)
        {
            this.db = context;
        }

        public IEnumerable<Dim> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dim GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Dim item)
        {
            throw new NotImplementedException();
        }

        public void Update(Dim item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

    }
}

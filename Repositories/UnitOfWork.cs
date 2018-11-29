using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PrmDesignApi.Models;
using PrmDesignApi.Repositories;

namespace PrmDesignApi.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private PrmDesignContext db = new PrmDesignContext();
        private DimsRepository dimsRepository;

        public DimsRepository Dims
        {
            get
            {
                if (dimsRepository == null)
                    dimsRepository = new DimsRepository(db);
                return dimsRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}

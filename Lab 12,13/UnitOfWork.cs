using _12_lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_lab
{
    class UnitOfWork
    {
        private Context db = new Context();
        private OwnerRepository ownerRepository;
        private AccRepository accRepository;

        public OwnerRepository Owners
        {
            get
            {
                if (ownerRepository == null)
                    ownerRepository = new OwnerRepository(db);
                return ownerRepository;
            }
        }

        public AccRepository Orders
        {
            get
            {
                if (accRepository == null)
                    accRepository = new AccRepository(db);
                return accRepository;
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

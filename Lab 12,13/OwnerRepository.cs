using _12_lab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_lab
{
    class OwnerRepository : IRepository<Owner>
    {
        private Context db;

        public OwnerRepository(Context context)
        {
            this.db = context;
        }

        public IEnumerable<Owner> GetList()
        {
            return db.Owners;
        }

        public Owner GetItem(int id)
        {
            return db.Owners.Find(id);
        }

        public void Create(Owner owner)
        {
            db.Owners.Add(owner);
        }

        public void Update(Owner owner)
        {
            db.Entry(owner).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Owner owner = db.Owners.Find(id);
            if (owner != null)
                db.Owners.Remove(owner);
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
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    class AccRepository : IRepository<Account>
    {
        private Context db;

        public AccRepository(Context context)
        {
            this.db = context;
        }

        public IEnumerable<Account> GetList()
        {
            return db.Accounts;
        }

        public Account GetItem(int id)
        {
            return db.Accounts.Find(id);
        }

        public void Create(Account acc)
        {
            db.Accounts.Add(acc);
        }

        public void Update(Account acc)
        {
            db.Entry(acc).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Account acc = db.Accounts.Find(id);
            if (acc != null)
                db.Accounts.Remove(acc);
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
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

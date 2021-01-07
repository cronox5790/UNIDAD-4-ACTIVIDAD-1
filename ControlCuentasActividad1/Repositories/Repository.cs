using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlCuentasActividad1.Models;

namespace ControlCuentasActividad1.Repositories
{
    public class Repository<T> where T : class
    {
        public controlcuentasContext Context { get; set; }

        public Repository(controlcuentasContext ctx)
        {
            Context = ctx;
        }
        public T Get(object id)
        {
            return Context.Find<T>(id);
        }

        public virtual void Insert(T entidad)
        {
            if (Validar(entidad))
            {
                Context.Add(entidad);
                Context.SaveChanges();
            }
        }
        public virtual void Update(T entidad)
        {
            if (Validar(entidad))
            {
                Context.Update<T>(entidad);
                Context.SaveChanges();
            }
        }

        public virtual void Delete(T entidad)
        {
            Context.Remove<T>(entidad);
            Context.SaveChanges();
        }

        public virtual bool Validar(T entidad)
        {

            return true;
        }
    }
}

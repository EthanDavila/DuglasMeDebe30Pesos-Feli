﻿using Core;
using Core.Poco;
using Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private RAFContext context;
        private readonly int SIZE = 388;

        public SupplierRepository()
        {
            context = new RAFContext("Supplier", SIZE);
        }

        public void Create(Supplier t)
        {
            context.Create<Supplier>(t);
        }

        public bool Delete(Supplier t)
        {
            if (context.Get<Product>(t.Id) == null)
            {
                throw new ArgumentException($"Supplier with Id {t.Id} does not exists.");
            }
            return context.Delete(t.Id);
        }

        public IEnumerable<Supplier> Find(Expression<Func<Supplier, bool>> where)
        {
            return context.Find(where);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return context.GetAll<Supplier>();
        }

        public int Update(Supplier t)
        {
            return 0;
        }
    }
}

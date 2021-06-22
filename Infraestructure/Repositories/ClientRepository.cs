﻿using Core;
using Core.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class ClientRepository : IClientRepository
    {
        private RAFContext context;
        private readonly int SIZE = 228;

        public ClientRepository()
        {
            context = new RAFContext("Client",SIZE);
        }

        public void Create(Client t)
        {
            context.Create<Client>(t);
        }

        public bool Delete(Client t)
        {
            if (context.Get<Product>(t.Id) == null)
            {
                throw new ArgumentException($"Supplier with Id {t.Id} does not exists.");
            }
            return context.Delete(t.Id);
        }

        public IEnumerable<Client> Find(Expression<Func<Client, bool>> where)
        {
            return context.Find(where);
        }

        public IEnumerable<Client> GetAll()
        {
            return context.GetAll<Client>();
        }

        public int Update(Client t)
        {
            return 0;
        }
    }
}

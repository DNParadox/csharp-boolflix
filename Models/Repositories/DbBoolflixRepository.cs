﻿using csharp_boolfix.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.SqlServer.Server;

namespace csharp_boolfix.Models.Repositories
{
    public class DbBoolflixRepository : IBoolflixRepository
    {
        private BoolflixDbContext db;

        public DbBoolflixRepository(BoolflixDbContext _db)
        {
            db = _db;
        }

        // Profile
        public List<Profilo> All()
        {
            return db.Profili.ToList();
        }

        public Profilo GetById(int Id)
        {
            return db.Profili.FirstOrDefault();
        }
    }
}
using System.Collections.Generic;
using TestExampleForAviscloud.Model.Storage.Entities;
using TestExampleForAviscloud.Model.Storage.Repositories.Abstract;

namespace TestExampleForAviscloud.Model.Storage.Repositories.LINQ
{
    public class LINQGendersRepository : IGendersRepository
    {
        private readonly StorageContext _context;

        public LINQGendersRepository(StorageContext context)
        {
            _context = context;
        }

        public Dictionary<Gender, string> GetGenders()
        {
            return _context.Genders;
        }
    }
}

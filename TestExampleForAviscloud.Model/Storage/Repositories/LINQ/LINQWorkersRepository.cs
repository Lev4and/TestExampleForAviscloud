using System;
using System.Collections.Generic;
using System.Linq;
using TestExampleForAviscloud.Model.Storage.Entities;
using TestExampleForAviscloud.Model.Storage.Repositories.Abstract;

namespace TestExampleForAviscloud.Model.Storage.Repositories.LINQ
{
    public class LINQWorkersRepository : IWorkersRepository
    {
        private readonly StorageContext _context;

        public LINQWorkersRepository(StorageContext context)
        {
            _context = context;
        }

        public bool ContainsWorkerByNameAndEmail(string name, string email)
        {
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email))
            {
                return _context.Workers.FirstOrDefault(worker => worker.Name == name && worker.Email == email) != null;
            }

            return false;
        }

        public bool SaveWorker(Worker worker)
        {
            if(worker.Id == default)
            {
                return false;
            }
            else
            {
                var existsWorker = GetWorkerById(worker.Id);

                if (worker.Equals(existsWorker))
                {
                    if(!ContainsWorkerByNameAndEmail(worker.Name, worker.Email))
                    {
                        _context.Workers = _context.Workers.Where(w => w.Id != worker.Id).ToList();
                        _context.Workers.Add(worker);

                        return true;
                    }
                }
                else
                {
                    _context.Workers = _context.Workers.Where(w => w.Id != worker.Id).ToList();
                    _context.Workers.Add(worker);

                    return true;
                }
            }

            return false;
        }

        public Worker GetWorkerById(Guid id)
        {
            return _context.Workers.FirstOrDefault(worker => worker.Id == id);
        }

        public List<Worker> GetWorkers()
        {
            return _context.Workers;
        }
    }
}

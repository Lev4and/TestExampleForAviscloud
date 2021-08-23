using System;
using System.Collections.Generic;
using TestExampleForAviscloud.Model.Storage.Entities;

namespace TestExampleForAviscloud.Model.Storage.Repositories.Abstract
{
    public interface IWorkersRepository
    {
        bool ContainsWorkerByNameAndEmail(string name, string email);

        bool SaveWorker(Worker worker);

        Worker GetWorkerById(Guid id);

        List<Worker> GetWorkers();
    }
}

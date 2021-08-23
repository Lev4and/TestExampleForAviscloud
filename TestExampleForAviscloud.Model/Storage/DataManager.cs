using TestExampleForAviscloud.Model.Storage.Repositories.Abstract;

namespace TestExampleForAviscloud.Model.Storage
{
    public class DataManager
    {
        public IGendersRepository Genders { get; set; }

        public IWorkersRepository Workers { get; set; }

        public DataManager(IGendersRepository genders, IWorkersRepository workers)
        {
            Genders = genders;
            Workers = workers;
        }
    }
}

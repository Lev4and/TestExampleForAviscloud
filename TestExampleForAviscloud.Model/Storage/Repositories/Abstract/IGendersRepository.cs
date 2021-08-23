using System.Collections.Generic;
using TestExampleForAviscloud.Model.Storage.Entities;

namespace TestExampleForAviscloud.Model.Storage.Repositories.Abstract
{
    public interface IGendersRepository
    {
        public Dictionary<Gender, string> GetGenders();
    }
}

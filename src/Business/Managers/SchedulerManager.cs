using Business.Contracts;
using System;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class SchedulerManager : ISchedulerManager
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Start(Func<Task> taskToExecute)
        {
            throw new NotImplementedException();
        }
    }
}

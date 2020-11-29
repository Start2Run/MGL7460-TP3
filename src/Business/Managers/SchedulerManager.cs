using Business.Contracts;
using System;
using System.Reactive.Concurrency;
using System.Threading.Tasks;
using Common.Models;

namespace Business.Managers
{
    public class SchedulerManager : ISchedulerManager
    {
        private IScheduler _timerScheduler;
        private IConfigurationModel _configuration;

        public SchedulerManager(IConfigurationModel configuration, IScheduler scheduler = null)
        {
            _timerScheduler = scheduler ?? Scheduler.Default;
            _configuration = configuration;
        }

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

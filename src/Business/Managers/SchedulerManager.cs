using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Business.Contracts;
using Common.Models;

namespace Business.Managers
{
    public class SchedulerManager : ISchedulerManager
    {
        private readonly IConfigurationModel _configuration;
        private IDisposable _timer;
        private readonly IScheduler _timerScheduler;

        public SchedulerManager(IConfigurationModel configuration, IScheduler scheduler) : this(configuration)
        {
            _configuration = configuration;
            _timerScheduler = scheduler;
        }

        public SchedulerManager(IConfigurationModel configuration)
        {
            _configuration = configuration;
            _timerScheduler = Scheduler.Default;
        }

        public void Start(Func<Task> taskToExecute)
        {
            _timer = Observable
                .Timer(TimeSpan.FromSeconds(_configuration.PullIntervalInSeconds), _timerScheduler)
                .Subscribe(async x => await taskToExecute.Invoke());
        }

        public void Dispose()
        {
            if (_timerScheduler != Scheduler.Default)
            {
                return;
            }
            _timer?.Dispose();
        }
    }
}
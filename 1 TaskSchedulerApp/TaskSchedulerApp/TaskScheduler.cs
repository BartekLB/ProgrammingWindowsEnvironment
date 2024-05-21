using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TaskSchedulerApp
{
    public class TaskScheduler
    {
        private readonly List<ScheduledTask> _tasks;
        private readonly Timer _timer;

        public TaskScheduler()
        {
            _tasks = new List<ScheduledTask>();
            _timer = new Timer(CheckTasks, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));
        }

        public void AddTask(ScheduledTask task)
        {
            _tasks.Add(task);
        }

        public bool RemoveTask(string taskName)
        {
            var task = _tasks.FirstOrDefault(t => t.Name == taskName);
            if (task != null)
            {
                _tasks.Remove(task);
                return true;
            }
            return false;
        }

        public ScheduledTask GetTask(string taskName)
        {
            return _tasks.FirstOrDefault(t => t.Name == taskName);
        }

        public List<TaskInfo> GetTasks()
        {
            List<TaskInfo> taskInfos = new List<TaskInfo>();
            foreach (var task in _tasks)
            {
                taskInfos.Add(task.GetInfo());
            }
            return taskInfos;
        }

        private void CheckTasks(object state)
        {
            DateTime now = DateTime.Now;
            foreach (var task in _tasks)
            {
                if (task.ShouldRun(now))
                {
                    task.RunAsync().ConfigureAwait(false);
                }
            }
        }
    }
}
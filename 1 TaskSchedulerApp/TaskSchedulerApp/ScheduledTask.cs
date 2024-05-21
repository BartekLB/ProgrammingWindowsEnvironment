using System;
using System.Threading.Tasks;

namespace TaskSchedulerApp
{
    public class ScheduledTask
    {
        private readonly Action _taskAction;
        private readonly string _name;
        private readonly DateTime _startTime;
        private readonly int _intervalMinutes;
        private readonly int _durationMinutes;
        private readonly bool _isRecurring;

        private DateTime? _lastRun;
        private int _runCount;
        private int _successCount;
        private string _status;

        public string Name => _name;

        public ScheduledTask(string name, Action taskAction, DateTime startTime, int durationMinutes, bool isRecurring = false, int intervalMinutes = 0)
        {
            _name = name;
            _taskAction = taskAction;
            _startTime = startTime;
            _durationMinutes = durationMinutes;
            _isRecurring = isRecurring;
            _intervalMinutes = intervalMinutes;
            _status = "Zaplanowane";
        }

        public bool ShouldRun(DateTime currentTime)
        {
            if (_isRecurring)
            {
                return _lastRun == null || (currentTime - _lastRun.Value).TotalMinutes >= _intervalMinutes;
            }
            else
            {
                return _lastRun == null && currentTime >= _startTime;
            }
        }

        public async Task RunAsync()
        {
            _status = "Uruchomione";
            _lastRun = DateTime.Now;
            try
            {
                await Task.Run(async () =>
                {
                    _taskAction();
                    await Task.Delay(_durationMinutes * 60 * 1000);
                });
                _successCount++;
                LogTask("Success");
                _status = "Wykonane";
            }
            catch (Exception ex)
            {
                LogTask($"Error: {ex.Message}");
                _status = "Wykonane z błędami";
            }
            finally
            {
                _runCount++;
            }
        }

        private void LogTask(string status)
        {
            using (var log = System.IO.File.AppendText("task_log.txt"))
            {
                log.WriteLine($"{DateTime.Now}: Task '{_name}' started at {_lastRun.Value}. Status: {status}");
            }
        }

        public TaskInfo GetInfo()
        {
            return new TaskInfo
            {
                Name = _name,
                StartTime = _startTime,
                LastRunTime = _lastRun,
                Status = _status,
                IntervalMinutes = _isRecurring ? _intervalMinutes : (int?)null,
                DurationMinutes = _durationMinutes,
                RunCount = _runCount,
                SuccessCount = _successCount
            };
        }
    }
}

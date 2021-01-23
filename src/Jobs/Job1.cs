using CronJobExpress;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CronJobExpressUsing.Jobs
{
    public class Job1 : CronJobService
    {
        private readonly ILogger<Job1> _logger;

        public Job1(IScheduleConfig<Job1> config, ILogger<Job1> logger) : base(config.CronExpression, config.TimeZoneInfo)
        {
            _logger = logger;
        }


        public override Task DoJob(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} JOB-1 schedule fired.");
            //
            // job tasks here
            //
            return Task.CompletedTask;
        }
    }
}

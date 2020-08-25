using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartZLearning
{
    public class DispatchingManage
    {
        public static async Task Init()
        {
            #region<创建一个单元(时间轴/载体)>
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await factory.GetScheduler();
            await scheduler.Start();
            #endregion

            //作业
            IJobDetail jobDetail = JobBuilder.Create<SendMessageJob>()
                                           .WithIdentity("sendMessageJob","Group1")
                                           .Build();

            //时间策略
            ITrigger trigger = TriggerBuilder.Create()
                                           .WithIdentity("sendMessageJob", "Group1")
                                           .StartNow()
                                           .WithSimpleSchedule(w=>w.WithIntervalInSeconds(5).WithRepeatCount(5))
                                           .Build();

            //承载
            await scheduler.ScheduleJob(jobDetail, trigger);
        }
       
        
    }
}

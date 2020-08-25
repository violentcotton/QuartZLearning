using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartZLearning
{
    public class SendMessageJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Run(() =>
            {
                Console.WriteLine();
                Console.WriteLine("*************************");
                Console.WriteLine("现在开始上课  {0}",DateTime.UtcNow);
                Console.WriteLine("*************************");
                Console.WriteLine();
            });
        }
    }
}

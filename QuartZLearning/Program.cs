using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartZLearning
{
    class Program
    {
        static  void Main(string[] args)
        {
            try
            {
                DispatchingManage.Init().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Console.ReadLine();
        }
    }
}

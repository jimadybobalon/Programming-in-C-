using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._95
{
    class Program
    {
        static void Main()
        {
            try
            {
                ProcessOrder();
            }
            catch (MessageQueueException Ex)
            {
                throw new OrderProcessingException("Error while processing order", Ex)
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._12
{
    public static class Program
    {
        public static void Main()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[0] = 1,
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[0] = 2,
                    TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            var finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (int i in parentTask.Result)
                        Console.WriteLine(i);
                });

            finalTask.Wait();
        }
    }
}
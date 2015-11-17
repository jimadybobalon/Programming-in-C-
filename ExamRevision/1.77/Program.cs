using System.IO;

namespace _1._77
{
    class Program
    {
        public delegate TextWriter CovarianceDel();

        public StreamWriter MethodStream() { return null; }
        public StreamWriter MethodString() { return null; }

        CovarianceDel del;
        //del = MethodStream;
        //del = MethodString;

        static void Main()
        {

        }
    }
}

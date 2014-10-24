using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _1._98
{
    [Serializable]
    class OrderProcessException : Exception, ISerializable
    {
        public OrderProcessException(int orderId)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/infoaboutexception";
        }
        public OrderProcessException(int orderId, string message)
            : base(message)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/infoaboutexceptions";
        }

        public OrderProcessException(int orderId, string message, Exception innerException)
            : base(message, innerException)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/infoaboutexceptions";
        }

        protected OrderProcessException(SerializationInfo info, StreamingContext context)
        {
            OrderId = (int)info.GetValue("OrderId", typeof(int));
        }

        public int OrderId { get; set; }

        public void GetObjectData(SerializationInfo Info, StreamingContext context)
        {
            Info.AddValue("OrderId", OrderId, typeof(int));
        }

        static void Main()
        {
        }
    }
}

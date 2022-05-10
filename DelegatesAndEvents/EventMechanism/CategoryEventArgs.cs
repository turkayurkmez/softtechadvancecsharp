using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMechanism
{
    public class CategoryEventArgs : EventArgs
    {
        public Category Category { get; set; }
        public DateTime EventFiredDate { get; set; }
        public string Owner { get; set; }
    }
}

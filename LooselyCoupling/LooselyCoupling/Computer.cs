using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupling
{
    public class Computer
    {
        // Dependency: 
        //Bilgisayar ...... olmadan çalışmaz.
        //Elektrik
        //Ram
        //HD
        //OS
        //İşlemci
        //Anakart
        public IMemory Memory { get; set; }
        public IStorage Storage { get; set; }



    }

}

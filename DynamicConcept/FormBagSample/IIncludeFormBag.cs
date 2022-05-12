using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBagSample
{
    public interface IIncludeFormBag
    {
        dynamic FormBag { get; set; }
        
    }
}

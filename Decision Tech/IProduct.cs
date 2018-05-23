using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Tech
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal Cost { get; set; }
    }
}

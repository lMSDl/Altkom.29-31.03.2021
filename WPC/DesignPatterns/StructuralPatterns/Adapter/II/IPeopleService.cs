using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Adapter.II
{
    public interface IPeopleService
    {
        IEnumerable<IPerson> Get();
    }
}

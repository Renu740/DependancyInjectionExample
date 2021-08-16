using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependancyInjectionExample
{
    public interface IMyDependency
    {
        public string WriteMessage(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependancyInjectionExample
{
    public class MyDependency:IMyDependency
    {
        public string WriteMessage(string message)
        {
            return "MyDependency.WriteMessage Message:" + message;
        }
    }
}

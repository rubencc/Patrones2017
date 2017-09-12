using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

namespace Business.Implementations
{
    public class JsonExtensionStrategy : IExtensionStrategy
    {
        public string Extension => "json";
        public DocType Type => DocType.JSON;
    }
}

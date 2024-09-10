using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAssignment
{
    internal class UserInputProcessor : IDataProcessor
    {
        public string Process(string data)
        {
            return data.ToUpper();
        }
    }
}

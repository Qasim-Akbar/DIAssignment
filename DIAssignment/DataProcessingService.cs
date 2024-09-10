using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAssignment
{
    internal class DataProcessingService
    {
        private readonly IDataProcessor dataProcessor;

        public DataProcessingService(IDataProcessor dataProcessor)
        {
            this.dataProcessor = dataProcessor;
        }

        public string Run(string msg)
        {
            return dataProcessor.Process(msg);
        }
    }
}

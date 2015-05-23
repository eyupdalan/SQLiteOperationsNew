using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteOperations
{
    public class SQLiteParameter
    {
        public SQLiteParameter(string parameterName, object parameterValue)
        {
            this.ParameterName = parameterName;
            this.ParameterValue = parameterValue;
        }
        internal string ParameterName { get; set; }
        internal object ParameterValue { get; set; }
    }
}

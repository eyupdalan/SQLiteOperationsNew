using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteOperations
{
    [System.Serializable]
    public class SQLiteException : Exception
    {
        public SQLiteException() { }
        public SQLiteException(string message) : base(message) { }
        public SQLiteException(string message, Exception inner) : base(message, inner) { }
        protected SQLiteException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}

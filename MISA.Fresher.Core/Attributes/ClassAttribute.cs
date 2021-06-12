using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Fresher.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Required:Attribute
    {
        public string _msgError = string.Empty;
        public string _fieldError = string.Empty;
        public Required(string msgError, string fieldError)
        {
            _msgError = msgError;
            _fieldError = fieldError;
        }
    }
}

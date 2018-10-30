using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class TooYoung :Exception
    {
        public TooYoung()
            :base() { }
        public TooYoung(string message)
            : base(message) { }
    }
}

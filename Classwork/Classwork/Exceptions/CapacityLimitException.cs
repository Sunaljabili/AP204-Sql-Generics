using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Exceptions
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {

        }

    }
}

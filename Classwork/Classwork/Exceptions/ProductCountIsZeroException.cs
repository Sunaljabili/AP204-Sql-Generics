using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Exceptions
{
     public  class ProductCountIsZeroException:Exception
    {
        public ProductCountIsZeroException(string message):base(message)
        {

        }
    }
}

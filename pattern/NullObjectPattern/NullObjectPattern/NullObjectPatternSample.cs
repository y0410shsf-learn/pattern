using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    interface NullObjectPatternSample
    {
        void foo();
    }

    class NullObject : NullObjectPatternSample
    {
        public void foo()
        {
            throw new NotImplementedException();
        }
    }

    class RealObject : NullObjectPatternSample
    {
        public void foo()
        {
            throw new NotImplementedException();
        }
    }

}

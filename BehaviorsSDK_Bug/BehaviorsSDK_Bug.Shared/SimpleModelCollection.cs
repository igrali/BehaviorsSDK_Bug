using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviorsSDK_Bug
{
    public class SimpleModelCollection : List<SimpleModel>
    {
        public SimpleModelCollection()
        {
            this.Add(new SimpleModel());
            this.Add(new SimpleModel());
            this.Add(new SimpleModel());
            this.Add(new SimpleModel());
            this.Add(new SimpleModel());
            this.Add(new SimpleModel());
        }
    }
}

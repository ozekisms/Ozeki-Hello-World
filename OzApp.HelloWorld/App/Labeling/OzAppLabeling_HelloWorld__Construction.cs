using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozeki
{
    partial class OzAppLabeling_HelloWorld
    {
        static readonly object _sync = new object();
        static OzAppLabeling_HelloWorld _instance;

        public static OzAppLabeling_HelloWorld Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_sync)
                    {
                        if (_instance == null)
                            _instance = new OzAppLabeling_HelloWorld();
                    }
                }
                return _instance;
            }
        }

        OzAppLabeling_HelloWorld() { }
    }
}
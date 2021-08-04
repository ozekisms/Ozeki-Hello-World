using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Ozeki
{
    partial class OzAppHelloWorld
    {
        static readonly object sync = new object();

        static OzAppHelloWorld _instance;
        public static OzAppHelloWorld Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (sync)
                    {
                        if (_instance == null)
                            _instance = new OzAppHelloWorld();
                    }
                }

                return _instance;
            }
        }

        OzAppHelloWorld()
        {
        }
    }
}

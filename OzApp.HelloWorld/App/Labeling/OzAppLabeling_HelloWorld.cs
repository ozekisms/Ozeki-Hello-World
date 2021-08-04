using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozeki
{
    public partial class OzAppLabeling_HelloWorld : OzAppLabeling
    {
        public override string BrandName
        {
            get { return ""; }
        }

        public override string ProductName
        {
            get { return "HelloWorld"; }
        }

        public override Type AppType
        {
            get { return typeof(OzAppHelloWorld); }
        }

        public override string Website
        {
            get { return "www.ozeki.hu"; }
        }

        public override string Email
        {
            get { return "info@ozeki.hu"; }
        }

        public override string ProductDescription
        {
            get
            {
                return "The Hello World app is the most simple app you would create using Ozeki 10.";
            }
        }

        public override string Icon
        {
            get { return OzAppHelloWorld.Desktop_icon; }
        }

        public override string Copyright
        {
            get
            {
                return "©2021 Ozeki Informatics Ltd.";
            }
        }
    }
}
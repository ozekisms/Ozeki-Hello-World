using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Ozeki
{
    [DataContract(Name = "OzAppHelloWorld", Namespace = "Ozeki")]
    public partial class OzAppHelloWorld : OzApp
    {
        //*********************************************************
        // constants
        //*********************************************************
        public const string Desktop_icon = OzIcon.AddFriend;

        //*********************************************************
        // Name
        //*********************************************************

        public override string AppName
        {
            get { return "Hello world"; }
        }

        //*********************************************************
        // Icon
        //*********************************************************
        public override string Icon
        {
            get { return Desktop_icon; }
        }

    }
}

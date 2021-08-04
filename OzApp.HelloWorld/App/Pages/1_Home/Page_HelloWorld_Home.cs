using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozeki
{
    partial class Page_HelloWorld_Home : OzGPC_List
    {

        public Page_HelloWorld_Home()
        {
            setup();
            Add(createHelloWorldLabel());
            Add(createJamesBondLabel());
        }

        void setup()
        {
            CSS.Box.Margin = "10px";
            CSSUpdate();
        }

        OzGPC createHelloWorldLabel()
        {
            var label = new OzGPC_Label("Hello world");
            label.CSS.Text.FontSize = "20px";
            label.CSS.Color.Color = OzColor.Red;
            label.CSSUpdate();
            return label;
        }

        OzGPC createJamesBondLabel()
        {
            var label = new OzGPC_Label("My name is Bond, James Bond");
            label.CSS.Text.FontSize = "20px";
            label.CSSUpdate();
            return label;
        }

    }
}

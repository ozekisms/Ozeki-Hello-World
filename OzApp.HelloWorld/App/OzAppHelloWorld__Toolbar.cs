using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozeki
{
    partial class OzAppHelloWorld
    {
        protected override void CreateToolbarButtons()
        {
            var appPrefix = "/" + AppName;
            Toolbar.AddIcon(PageName_Home, new OzGPC_ToolbarButton(OzIcon.Home, PageName_Home), prefix: appPrefix);
            Toolbar.AddSeparator();
            Toolbar.AddIcon(PageName_About,new OzGPC_ToolbarButton(OzIcon.Info,PageName_About,"About"), false, true, prefix: appPrefix);
        }
    }
}


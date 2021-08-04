using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozeki
{
    partial class OzAppHelloWorld
    {
        protected override void CreateGuiPages()
        {
            var fileMenu = AppSitemap.AddChild("File", OzVisibility.VisibleOnCondition);
            fileMenu.AddChildType(PageName_Home, typeof(Page_HelloWorld_Home), OzVisibility.Visible, OzIcon.Home);

            var helpMenu = AppSitemap.AddChild("Help", OzVisibility.VisibleOnCondition);
            helpMenu.AddChildTypeWithInitParam(PageName_About, typeof(Page_App_About), new[] { OzAppLabeling_HelloWorld.Instance }, OzVisibility.Visible, OzIcon.Info);
        }
    }
}


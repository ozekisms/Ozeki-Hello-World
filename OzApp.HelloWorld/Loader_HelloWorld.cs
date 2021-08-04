using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ozeki;
using System.IO;

namespace Ozeki
{
    public class Loader_HelloWorld : OzLoader
    {
        public override void CreateApps(object context)
        {
            OzAppHelloWorld.Instance.CanInstallOnDesktop = true;
            OzAppHelloWorld.Instance.CanInstallInStartMenu = true;
            OzAppHelloWorld.Instance.StartmenuSubfolder = OzFeatureDesktop.ProgramGroup_Education;
            OzAppMan_Installed.Instance.InstallIfNotInstalled(OzAppHelloWorld.Instance);
        }
    }
}
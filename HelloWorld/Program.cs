using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozeki
{
    public class Program
    {
        static void Main(string[] args)
        {
            OzProgramInitializer_Windows.TakeOver();
            OzProgram.ApplicationProfile = new OzAppProfile10();
            OzEmbeddedResourceManager.CacheSpace = OzCacheSpace.Memory;
            configure();
            OzProgram.Start(args);
        }

        static void Stop()
        {
            BootLoader.Stop();
        }

        static void configure()
        {
            var config = OzConfigManager.Instance.Select<OzConf_WebServer>(OzConf_WebServer.ConfigID, out bool created);
            if (!created && config.Port != 0) return;
            config.Port = 7443;
            config.HttpPort = 7080;
            OzConfigManager.Instance.UpdateItem(config);
        }
    }
}

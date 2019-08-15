using System;
using System.Collections.Generic;
using System.Text;

namespace Vietbank.Core
{
    public class GlobalConfigurationCore
    {
        static GlobalConfigurationCore()
        {
            Modules = new List<ModuleInfo>();
        }

        public static IList<ModuleInfo> Modules { get; set; }
    }
}

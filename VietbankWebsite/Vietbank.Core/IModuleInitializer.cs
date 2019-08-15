using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vietbank.Core
{
    public interface IModuleInitializer
    {
        void Init(IServiceCollection serviceCollection);
    }
}

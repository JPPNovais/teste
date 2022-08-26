using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Amoedar.Interno.CrossCutting.Assemblies
{
    [ExcludeFromCodeCoverage]
    public class AssemblyUtil
    {
        public static IEnumerable<Assembly> GetCurrentAssemblies()
        {            
            return new Assembly[]
            {
                Assembly.Load("Amoedar.Interno.Api"),
                Assembly.Load("Amoedar.Interno.Application"),
                Assembly.Load("Amoedar.Interno.Domain"),
                Assembly.Load("Amoedar.Interno.Domain.Core"),
                Assembly.Load("Amoedar.Interno.Infrastructure"),
                Assembly.Load("Amoedar.Interno.CrossCutting")
            };
        }
    }
}

using System;
using System.Runtime.CompilerServices;

namespace Client
{
    public class Module
    {
        [ModuleInitializer]
        internal static void OnInitialized()
        {
            Console.WriteLine(nameof(OnInitialized));
        }
    }
}

// namespace System.Runtime.CompilerServices
// {
//     [AttributeUsage(AttributeTargets.Method, Inherited = false)]
//     internal sealed class ModuleInitializerAttribute : Attribute
//     {
//     }
// }
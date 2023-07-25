using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entitas.InstallerGenerator2.Editor.Models;

namespace Entitas.InstallerGenerator2.Editor.CodeGenerators
{
    public static class SystemBindGenerator
    {
        public static string GetBind(TypeElement type)
        {
            if (type.IsDebug)
            {
                return $@"{"\t\t\t"}if(isDebug)
{"\t\t\t\t"}container.BindInterfacesAndSelfTo<{type.Type.Name}>().AsSingle();{$"// {type.Order:0000} {type.Name}"}";
            }
    
            return $"\t\t\tcontainer.BindInterfacesAndSelfTo<{type.Type.Name}>().AsSingle();\t// {type.Order:0000} {type.Name}";
        }

        public static IEnumerable<string> GetBinds(IEnumerable<TypeElement> types)
        {
            types = types.OrderBy(t => t.Order).ThenBy(t=>t.Name);

            var previous = 100000;
            foreach (var t in types)
            {
                if (Math.Abs(previous - t.Order) > 10)
                    yield return $"\n			// {t.Name} {t.Order:0000}";
                yield return GetBind(t);
                previous = t.Order;
            }
        }
    }
}
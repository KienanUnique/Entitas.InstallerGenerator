using System;
using Entitas.InstallerGenerator2.Runtime.Attributes;

namespace Entitas.InstallerGenerator2.Editor.Models
{
	public class TypeElement
	{
		public readonly Type Type;
		public readonly int Order;
		public readonly string Name;
		public readonly bool IsDebug;

		public TypeElement(Type type, AInstallAttribute attribute, bool isDebug)
		{
			Type = type;
			Order = attribute.Order;
			Name = string.Join("|", attribute.Features);
			IsDebug = isDebug;
		}
	}
}
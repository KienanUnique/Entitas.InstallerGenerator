using System;
using Entitas.InstallerGenerator2.Runtime.Attributes;

namespace Entitas.InstallerGenerator2.Editor.Models
{
	public class TypeElement
	{
		public readonly Type Type;
		public readonly Enum FeatureType;
		public readonly Enum Priority;
		public readonly int Order;
		public readonly Enum[] Features;
		public readonly bool IsDebug;

		public TypeElement(Type type, AInstallAttribute attribute, bool isDebug)
		{
			Type = type;
			FeatureType = attribute.FeatureType;
			Priority = attribute.Priority;
			Order = attribute.Order;
			Features = attribute.Features;
			IsDebug = isDebug;
		}
	}
}
using System;

namespace Entitas.InstallerGenerator2.Runtime.Attributes {
	public abstract class AInstallAttribute: Attribute {
		public readonly Enum Type;
		public readonly Enum Priority;
		public readonly int Order;
		public readonly string[] Features;

		public AInstallAttribute(
			Enum type,
			Enum priority,
			int order,
			params string[] features
		) {
			Type     = type;
			Priority = priority;
			Order    = order;
			Features     = features;
		}
	}
}

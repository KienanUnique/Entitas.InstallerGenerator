using System;

namespace Entitas.InstallerGenerator2.Runtime.Attributes
{
    public abstract class AInstallAttribute : Attribute
    {
        public readonly Enum FeatureType;
        public readonly Enum Priority;
        public readonly int Order;
        public readonly Enum[] Features;

        public AInstallAttribute(
            Enum featureType,
            Enum priority,
            int order,
            params Enum[] features
        )
        {
            FeatureType = featureType;
            Priority = priority;
            Order = order;
            Features = features;
        }
    }
}
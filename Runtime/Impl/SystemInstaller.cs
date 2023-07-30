using System;
using Zenject;

namespace Entitas.InstallerGenerator2.Impl
{
    public class SystemInstaller<T> : ISystemInstaller<T>
    {
        [Inject] private T _system;

        public object System => _system;
        T ISystemInstaller<T>.System => _system;

        public Enum Type { get; }
        public Enum Priority { get; }
        public int Order { get; }
        public Enum[] Features { get; }

        public SystemInstaller(
            Enum type,
            Enum priority,
            int order,
            params Enum[] features
        )
        {
            Type = type;
            Priority = priority;
            Order = order;
            Features = features;
        }
    }
}
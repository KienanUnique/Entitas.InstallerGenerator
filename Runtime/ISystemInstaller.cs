using System;

namespace Entitas.InstallerGenerator2
{
    public interface ISystemInstaller
    {
        string Name { get; }
        
        object System { get; }
        Enum Type { get; }
        Enum Priority { get; }
        int Order { get; }
        Enum[] Features { get; }
    }
    
    public interface ISystemInstaller<out T> : ISystemInstaller
    {
        T System { get; }
    }
}
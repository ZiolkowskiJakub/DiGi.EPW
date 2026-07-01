using DiGi.Core.Interfaces;

namespace DiGi.EPW.Interfaces
{
    /// <summary>
    /// Defines a contract for objects that are both EPW-compatible and serializable.
    /// </summary>
    public interface IEPWSerializableObject : IEPWObject, ISerializableObject
    {
    }
}
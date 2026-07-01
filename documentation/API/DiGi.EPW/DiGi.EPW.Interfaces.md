#### [DiGi\.EPW](index.md 'index')

## DiGi\.EPW\.Interfaces Namespace
### Interfaces

<a name='DiGi.EPW.Interfaces.IEPWObject'></a>

## IEPWObject Interface

Defines the basic properties and behaviors for an EnergyPlus Weather \(EPW\) object\.

```csharp
public interface IEPWObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod')  
↳ [DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord')  
↳ [DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions')  
↳ [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile')  
↳ [GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature')  
↳ [Holiday](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Holiday 'DiGi\.EPW\.Classes\.Holiday')  
↳ [HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving')  
↳ [Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location')  
↳ [TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod')  
↳ [IEPWSerializableObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWSerializableObject 'DiGi\.EPW\.Interfaces\.IEPWSerializableObject')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.EPW.Interfaces.IEPWSerializableObject'></a>

## IEPWSerializableObject Interface

Defines a contract for objects that are both EPW\-compatible and serializable\.

```csharp
public interface IEPWSerializableObject : DiGi.EPW.Interfaces.IEPWObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod')  
↳ [DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord')  
↳ [DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions')  
↳ [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile')  
↳ [GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature')  
↳ [Holiday](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Holiday 'DiGi\.EPW\.Classes\.Holiday')  
↳ [HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving')  
↳ [Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location')  
↳ [TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod')

Implements [IEPWObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWObject 'DiGi\.EPW\.Interfaces\.IEPWObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
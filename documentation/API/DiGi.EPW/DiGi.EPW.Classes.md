#### [DiGi\.EPW](index.md 'index')

## DiGi\.EPW\.Classes Namespace
### Classes

<a name='DiGi.EPW.Classes.DataPeriod'></a>

## DataPeriod Class

Represents a single period entry of the DATA PERIODS header record of an EPW file\.

```csharp
public class DataPeriod : DiGi.Core.Classes.SerializableObject, DiGi.EPW.Interfaces.IEPWSerializableObject, DiGi.EPW.Interfaces.IEPWObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → DataPeriod

Implements [IEPWSerializableObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWSerializableObject 'DiGi\.EPW\.Interfaces\.IEPWSerializableObject'), [IEPWObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWObject 'DiGi\.EPW\.Interfaces\.IEPWObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.EPW.Classes.DataPeriod.DataPeriod(DiGi.EPW.Classes.DataPeriod)'></a>

## DataPeriod\(DataPeriod\) Constructor

Initializes a new instance of the [DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod') class by copying an existing instance\.

```csharp
public DataPeriod(DiGi.EPW.Classes.DataPeriod? dataPeriod);
```
#### Parameters

<a name='DiGi.EPW.Classes.DataPeriod.DataPeriod(DiGi.EPW.Classes.DataPeriod).dataPeriod'></a>

`dataPeriod` [DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod')

The source data period to copy from\.

<a name='DiGi.EPW.Classes.DataPeriod.DataPeriod(string,string,string,string)'></a>

## DataPeriod\(string, string, string, string\) Constructor

Initializes a new instance of the [DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod') class\.

```csharp
public DataPeriod(string? name, string? startDayOfWeek, string? startDate, string? endDate);
```
#### Parameters

<a name='DiGi.EPW.Classes.DataPeriod.DataPeriod(string,string,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the data period\.

<a name='DiGi.EPW.Classes.DataPeriod.DataPeriod(string,string,string,string).startDayOfWeek'></a>

`startDayOfWeek` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The day of week on which the data period starts\.

<a name='DiGi.EPW.Classes.DataPeriod.DataPeriod(string,string,string,string).startDate'></a>

`startDate` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The start date of the data period\.

<a name='DiGi.EPW.Classes.DataPeriod.DataPeriod(string,string,string,string).endDate'></a>

`endDate` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The end date of the data period\.

<a name='DiGi.EPW.Classes.DataPeriod.DataPeriod(System.Text.Json.Nodes.JsonObject)'></a>

## DataPeriod\(JsonObject\) Constructor

Initializes a new instance of the [DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod') class from a JSON object\.

```csharp
public DataPeriod(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.EPW.Classes.DataPeriod.DataPeriod(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing data period data\.
### Properties

<a name='DiGi.EPW.Classes.DataPeriod.EndDate'></a>

## DataPeriod\.EndDate Property

Gets the end date of the data period\.

```csharp
public string? EndDate { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.DataPeriod.Name'></a>

## DataPeriod\.Name Property

Gets the name of the data period\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.DataPeriod.StartDate'></a>

## DataPeriod\.StartDate Property

Gets the start date of the data period\.

```csharp
public string? StartDate { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.DataPeriod.StartDayOfWeek'></a>

## DataPeriod\.StartDayOfWeek Property

Gets the day of week on which the data period starts\.

```csharp
public string? StartDayOfWeek { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.DataRecord'></a>

## DataRecord Class

Represents a single hourly weather data record of an EPW file\.

```csharp
public class DataRecord : DiGi.Core.Classes.SerializableObject, DiGi.EPW.Interfaces.IEPWSerializableObject, DiGi.EPW.Interfaces.IEPWObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → DataRecord

Implements [IEPWSerializableObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWSerializableObject 'DiGi\.EPW\.Interfaces\.IEPWSerializableObject'), [IEPWObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWObject 'DiGi\.EPW\.Interfaces\.IEPWObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(DiGi.EPW.Classes.DataRecord)'></a>

## DataRecord\(DataRecord\) Constructor

Initializes a new instance of the [DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord') class by copying an existing instance\.

```csharp
public DataRecord(DiGi.EPW.Classes.DataRecord? dataRecord);
```
#### Parameters

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(DiGi.EPW.Classes.DataRecord).dataRecord'></a>

`dataRecord` [DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord')

The source data record to copy from\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double)'></a>

## DataRecord\(int, int, int, int, int, string, double, double, double, double, double, double, double, double, double, double, double, double, double, double, double, double, int, int, double, double, int, string, double, double, double, int, double, double, double\) Constructor

Initializes a new instance of the [DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord') class\.

```csharp
public DataRecord(int year, int month, int day, int hour, int minute, string? dataSourceAndUncertaintyFlags, double dryBulbTemperature, double dewPointTemperature, double relativeHumidity, double atmosphericStationPressure, double extraterrestrialHorizontalRadiation, double extraterrestrialDirectNormalRadiation, double horizontalInfraredRadiationIntensity, double globalHorizontalRadiation, double directNormalRadiation, double diffuseHorizontalRadiation, double globalHorizontalIlluminance, double directNormalIlluminance, double diffuseHorizontalIlluminance, double zenithLuminance, double windDirection, double windSpeed, int totalSkyCover, int opaqueSkyCover, double visibility, double ceilingHeight, int presentWeatherObservation, string? presentWeatherCodes, double precipitableWater, double aerosolOpticalDepth, double snowDepth, int daysSinceLastSnowfall, double albedo, double liquidPrecipitationDepth, double liquidPrecipitationQuantity);
```
#### Parameters

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).year'></a>

`year` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The year of the record\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).month'></a>

`month` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The month of the record\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).day'></a>

`day` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The day of the record\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).hour'></a>

`hour` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The hour of the record\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).minute'></a>

`minute` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The minute of the record\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).dataSourceAndUncertaintyFlags'></a>

`dataSourceAndUncertaintyFlags` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The data source and uncertainty flags string\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).dryBulbTemperature'></a>

`dryBulbTemperature` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The dry bulb temperature, in degrees Celsius\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).dewPointTemperature'></a>

`dewPointTemperature` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The dew point temperature, in degrees Celsius\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).relativeHumidity'></a>

`relativeHumidity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The relative humidity, in percent\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).atmosphericStationPressure'></a>

`atmosphericStationPressure` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The atmospheric station pressure, in Pascals\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).extraterrestrialHorizontalRadiation'></a>

`extraterrestrialHorizontalRadiation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The extraterrestrial horizontal radiation, in Wh/m2\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).extraterrestrialDirectNormalRadiation'></a>

`extraterrestrialDirectNormalRadiation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The extraterrestrial direct normal radiation, in Wh/m2\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).horizontalInfraredRadiationIntensity'></a>

`horizontalInfraredRadiationIntensity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The horizontal infrared radiation intensity, in Wh/m2\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).globalHorizontalRadiation'></a>

`globalHorizontalRadiation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The global horizontal radiation, in Wh/m2\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).directNormalRadiation'></a>

`directNormalRadiation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The direct normal radiation, in Wh/m2\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).diffuseHorizontalRadiation'></a>

`diffuseHorizontalRadiation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The diffuse horizontal radiation, in Wh/m2\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).globalHorizontalIlluminance'></a>

`globalHorizontalIlluminance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The global horizontal illuminance, in lux\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).directNormalIlluminance'></a>

`directNormalIlluminance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The direct normal illuminance, in lux\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).diffuseHorizontalIlluminance'></a>

`diffuseHorizontalIlluminance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The diffuse horizontal illuminance, in lux\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).zenithLuminance'></a>

`zenithLuminance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The zenith luminance, in Cd/m2\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).windDirection'></a>

`windDirection` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The wind direction, in degrees\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).windSpeed'></a>

`windSpeed` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The wind speed, in m/s\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).totalSkyCover'></a>

`totalSkyCover` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The total sky cover, in tenths\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).opaqueSkyCover'></a>

`opaqueSkyCover` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The opaque sky cover, in tenths\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).visibility'></a>

`visibility` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The visibility, in km\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).ceilingHeight'></a>

`ceilingHeight` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The ceiling height, in m\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).presentWeatherObservation'></a>

`presentWeatherObservation` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The present weather observation flag\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).presentWeatherCodes'></a>

`presentWeatherCodes` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The present weather codes\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).precipitableWater'></a>

`precipitableWater` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precipitable water, in mm\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).aerosolOpticalDepth'></a>

`aerosolOpticalDepth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The aerosol optical depth, in thousandths\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).snowDepth'></a>

`snowDepth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The snow depth, in cm\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).daysSinceLastSnowfall'></a>

`daysSinceLastSnowfall` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of days since the last snowfall\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).albedo'></a>

`albedo` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The albedo\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).liquidPrecipitationDepth'></a>

`liquidPrecipitationDepth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The liquid precipitation depth, in mm\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(int,int,int,int,int,string,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,double,int,int,double,double,int,string,double,double,double,int,double,double,double).liquidPrecipitationQuantity'></a>

`liquidPrecipitationQuantity` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The liquid precipitation quantity, in hours\.

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(System.Text.Json.Nodes.JsonObject)'></a>

## DataRecord\(JsonObject\) Constructor

Initializes a new instance of the [DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord') class from a JSON object\.

```csharp
public DataRecord(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.EPW.Classes.DataRecord.DataRecord(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing hourly weather data\.
### Properties

<a name='DiGi.EPW.Classes.DataRecord.AerosolOpticalDepth'></a>

## DataRecord\.AerosolOpticalDepth Property

Gets the aerosol optical depth, in thousandths\.

```csharp
public double AerosolOpticalDepth { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.Albedo'></a>

## DataRecord\.Albedo Property

Gets the albedo\.

```csharp
public double Albedo { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.AtmosphericStationPressure'></a>

## DataRecord\.AtmosphericStationPressure Property

Gets the atmospheric station pressure, in Pascals\.

```csharp
public double AtmosphericStationPressure { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.CeilingHeight'></a>

## DataRecord\.CeilingHeight Property

Gets the ceiling height, in m\.

```csharp
public double CeilingHeight { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.DataSourceAndUncertaintyFlags'></a>

## DataRecord\.DataSourceAndUncertaintyFlags Property

Gets the data source and uncertainty flags string\.

```csharp
public string? DataSourceAndUncertaintyFlags { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.DataRecord.Day'></a>

## DataRecord\.Day Property

Gets the day of the record\.

```csharp
public int Day { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.EPW.Classes.DataRecord.DaysSinceLastSnowfall'></a>

## DataRecord\.DaysSinceLastSnowfall Property

Gets the number of days since the last snowfall\.

```csharp
public int DaysSinceLastSnowfall { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.EPW.Classes.DataRecord.DewPointTemperature'></a>

## DataRecord\.DewPointTemperature Property

Gets the dew point temperature, in degrees Celsius\.

```csharp
public double DewPointTemperature { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.DiffuseHorizontalIlluminance'></a>

## DataRecord\.DiffuseHorizontalIlluminance Property

Gets the diffuse horizontal illuminance, in lux\.

```csharp
public double DiffuseHorizontalIlluminance { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.DiffuseHorizontalRadiation'></a>

## DataRecord\.DiffuseHorizontalRadiation Property

Gets the diffuse horizontal radiation, in Wh/m2\.

```csharp
public double DiffuseHorizontalRadiation { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.DirectNormalIlluminance'></a>

## DataRecord\.DirectNormalIlluminance Property

Gets the direct normal illuminance, in lux\.

```csharp
public double DirectNormalIlluminance { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.DirectNormalRadiation'></a>

## DataRecord\.DirectNormalRadiation Property

Gets the direct normal radiation, in Wh/m2\.

```csharp
public double DirectNormalRadiation { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.DryBulbTemperature'></a>

## DataRecord\.DryBulbTemperature Property

Gets the dry bulb temperature, in degrees Celsius\.

```csharp
public double DryBulbTemperature { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.ExtraterrestrialDirectNormalRadiation'></a>

## DataRecord\.ExtraterrestrialDirectNormalRadiation Property

Gets the extraterrestrial direct normal radiation, in Wh/m2\.

```csharp
public double ExtraterrestrialDirectNormalRadiation { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.ExtraterrestrialHorizontalRadiation'></a>

## DataRecord\.ExtraterrestrialHorizontalRadiation Property

Gets the extraterrestrial horizontal radiation, in Wh/m2\.

```csharp
public double ExtraterrestrialHorizontalRadiation { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.GlobalHorizontalIlluminance'></a>

## DataRecord\.GlobalHorizontalIlluminance Property

Gets the global horizontal illuminance, in lux\.

```csharp
public double GlobalHorizontalIlluminance { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.GlobalHorizontalRadiation'></a>

## DataRecord\.GlobalHorizontalRadiation Property

Gets the global horizontal radiation, in Wh/m2\.

```csharp
public double GlobalHorizontalRadiation { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.HorizontalInfraredRadiationIntensity'></a>

## DataRecord\.HorizontalInfraredRadiationIntensity Property

Gets the horizontal infrared radiation intensity, in Wh/m2\.

```csharp
public double HorizontalInfraredRadiationIntensity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.Hour'></a>

## DataRecord\.Hour Property

Gets the hour of the record\.

```csharp
public int Hour { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.EPW.Classes.DataRecord.LiquidPrecipitationDepth'></a>

## DataRecord\.LiquidPrecipitationDepth Property

Gets the liquid precipitation depth, in mm\.

```csharp
public double LiquidPrecipitationDepth { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.LiquidPrecipitationQuantity'></a>

## DataRecord\.LiquidPrecipitationQuantity Property

Gets the liquid precipitation quantity, in hours\.

```csharp
public double LiquidPrecipitationQuantity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.Minute'></a>

## DataRecord\.Minute Property

Gets the minute of the record\.

```csharp
public int Minute { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.EPW.Classes.DataRecord.Month'></a>

## DataRecord\.Month Property

Gets the month of the record\.

```csharp
public int Month { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.EPW.Classes.DataRecord.OpaqueSkyCover'></a>

## DataRecord\.OpaqueSkyCover Property

Gets the opaque sky cover, in tenths\.

```csharp
public int OpaqueSkyCover { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.EPW.Classes.DataRecord.PrecipitableWater'></a>

## DataRecord\.PrecipitableWater Property

Gets the precipitable water, in mm\.

```csharp
public double PrecipitableWater { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.PresentWeatherCodes'></a>

## DataRecord\.PresentWeatherCodes Property

Gets the present weather codes\.

```csharp
public string? PresentWeatherCodes { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.DataRecord.PresentWeatherObservation'></a>

## DataRecord\.PresentWeatherObservation Property

Gets the present weather observation flag\.

```csharp
public int PresentWeatherObservation { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.EPW.Classes.DataRecord.RelativeHumidity'></a>

## DataRecord\.RelativeHumidity Property

Gets the relative humidity, in percent\.

```csharp
public double RelativeHumidity { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.SnowDepth'></a>

## DataRecord\.SnowDepth Property

Gets the snow depth, in cm\.

```csharp
public double SnowDepth { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.TotalSkyCover'></a>

## DataRecord\.TotalSkyCover Property

Gets the total sky cover, in tenths\.

```csharp
public int TotalSkyCover { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.EPW.Classes.DataRecord.Visibility'></a>

## DataRecord\.Visibility Property

Gets the visibility, in km\.

```csharp
public double Visibility { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.WindDirection'></a>

## DataRecord\.WindDirection Property

Gets the wind direction, in degrees\.

```csharp
public double WindDirection { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.WindSpeed'></a>

## DataRecord\.WindSpeed Property

Gets the wind speed, in m/s\.

```csharp
public double WindSpeed { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DataRecord.Year'></a>

## DataRecord\.Year Property

Gets the year of the record\.

```csharp
public int Year { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.EPW.Classes.DataRecord.ZenithLuminance'></a>

## DataRecord\.ZenithLuminance Property

Gets the zenith luminance, in Cd/m2\.

```csharp
public double ZenithLuminance { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.DesignConditions'></a>

## DesignConditions Class

Represents the DESIGN CONDITIONS header record of an EPW file\.

```csharp
public class DesignConditions : DiGi.Core.Classes.SerializableObject, DiGi.EPW.Interfaces.IEPWSerializableObject, DiGi.EPW.Interfaces.IEPWObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → DesignConditions

Implements [IEPWSerializableObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWSerializableObject 'DiGi\.EPW\.Interfaces\.IEPWSerializableObject'), [IEPWObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWObject 'DiGi\.EPW\.Interfaces\.IEPWObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(DiGi.EPW.Classes.DesignConditions)'></a>

## DesignConditions\(DesignConditions\) Constructor

Initializes a new instance of the [DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions') class by copying an existing instance\.

```csharp
public DesignConditions(DiGi.EPW.Classes.DesignConditions? designConditions);
```
#### Parameters

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(DiGi.EPW.Classes.DesignConditions).designConditions'></a>

`designConditions` [DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions')

The source design conditions to copy from\.

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(int,string,string,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_)'></a>

## DesignConditions\(int, string, string, IList\<double\>, IList\<double\>, IList\<double\>\) Constructor

Initializes a new instance of the [DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions') class\.

```csharp
public DesignConditions(int numberOfDesignConditions, string? source, string? name, System.Collections.Generic.IList<double>? heatingValues, System.Collections.Generic.IList<double>? coolingValues, System.Collections.Generic.IList<double>? extremeValues);
```
#### Parameters

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(int,string,string,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_).numberOfDesignConditions'></a>

`numberOfDesignConditions` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of design conditions contained in the record\.

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(int,string,string,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source of the design condition data\.

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(int,string,string,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The design condition name, if specified\.

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(int,string,string,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_).heatingValues'></a>

`heatingValues` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The heating design condition values, in file order\.

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(int,string,string,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_).coolingValues'></a>

`coolingValues` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The cooling design condition values, in file order\.

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(int,string,string,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_,System.Collections.Generic.IList_double_).extremeValues'></a>

`extremeValues` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The extreme design condition values, in file order\.

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(System.Text.Json.Nodes.JsonObject)'></a>

## DesignConditions\(JsonObject\) Constructor

Initializes a new instance of the [DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions') class from a JSON object\.

```csharp
public DesignConditions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.EPW.Classes.DesignConditions.DesignConditions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing design conditions data\.
### Properties

<a name='DiGi.EPW.Classes.DesignConditions.CoolingValues'></a>

## DesignConditions\.CoolingValues Property

Gets the cooling design condition values, in file order\.

```csharp
public System.Collections.Generic.IList<double>? CoolingValues { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='DiGi.EPW.Classes.DesignConditions.ExtremeValues'></a>

## DesignConditions\.ExtremeValues Property

Gets the extreme design condition values, in file order\.

```csharp
public System.Collections.Generic.IList<double>? ExtremeValues { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='DiGi.EPW.Classes.DesignConditions.HeatingValues'></a>

## DesignConditions\.HeatingValues Property

Gets the heating design condition values, in file order\.

```csharp
public System.Collections.Generic.IList<double>? HeatingValues { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='DiGi.EPW.Classes.DesignConditions.Name'></a>

## DesignConditions\.Name Property

Gets the design condition name, if specified\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.DesignConditions.NumberOfDesignConditions'></a>

## DesignConditions\.NumberOfDesignConditions Property

Gets the number of design conditions contained in the record\.

```csharp
public int NumberOfDesignConditions { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.EPW.Classes.DesignConditions.Source'></a>

## DesignConditions\.Source Property

Gets the source of the design condition data\.

```csharp
public string? Source { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.EPWFile'></a>

## EPWFile Class

Represents an EnergyPlus Weather \(EPW\) file and its associated data\.

```csharp
public class EPWFile : DiGi.Core.Classes.SerializableObject, DiGi.EPW.Interfaces.IEPWSerializableObject, DiGi.EPW.Interfaces.IEPWObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → EPWFile

Implements [IEPWSerializableObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWSerializableObject 'DiGi\.EPW\.Interfaces\.IEPWSerializableObject'), [IEPWObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWObject 'DiGi\.EPW\.Interfaces\.IEPWObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.EPWFile)'></a>

## EPWFile\(EPWFile\) Constructor

Initializes a new instance of the [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile') class by copying an existing instance\.

```csharp
public EPWFile(DiGi.EPW.Classes.EPWFile? ePWFile);
```
#### Parameters

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.EPWFile).ePWFile'></a>

`ePWFile` [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile')

The source EPW file to copy from\.

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.Location,DiGi.EPW.Classes.DesignConditions,System.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_,DiGi.EPW.Classes.HolidaysDaylightSaving,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.DataRecord_)'></a>

## EPWFile\(Location, DesignConditions, IList\<TypicalExtremePeriod\>, IList\<GroundTemperature\>, HolidaysDaylightSaving, string, string, IList\<DataPeriod\>, IList\<DataRecord\>\) Constructor

Initializes a new instance of the [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile') class\.

```csharp
public EPWFile(DiGi.EPW.Classes.Location? location, DiGi.EPW.Classes.DesignConditions? designConditions=null, System.Collections.Generic.IList<DiGi.EPW.Classes.TypicalExtremePeriod>? typicalExtremePeriods=null, System.Collections.Generic.IList<DiGi.EPW.Classes.GroundTemperature>? groundTemperatures=null, DiGi.EPW.Classes.HolidaysDaylightSaving? holidaysDaylightSaving=null, string? comments1=null, string? comments2=null, System.Collections.Generic.IList<DiGi.EPW.Classes.DataPeriod>? dataPeriods=null, System.Collections.Generic.IList<DiGi.EPW.Classes.DataRecord>? dataRecords=null);
```
#### Parameters

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.Location,DiGi.EPW.Classes.DesignConditions,System.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_,DiGi.EPW.Classes.HolidaysDaylightSaving,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.DataRecord_).location'></a>

`location` [Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location')

The location associated with the EPW file\.

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.Location,DiGi.EPW.Classes.DesignConditions,System.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_,DiGi.EPW.Classes.HolidaysDaylightSaving,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.DataRecord_).designConditions'></a>

`designConditions` [DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions')

The design conditions header record\.

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.Location,DiGi.EPW.Classes.DesignConditions,System.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_,DiGi.EPW.Classes.HolidaysDaylightSaving,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.DataRecord_).typicalExtremePeriods'></a>

`typicalExtremePeriods` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The typical/extreme periods header record\.

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.Location,DiGi.EPW.Classes.DesignConditions,System.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_,DiGi.EPW.Classes.HolidaysDaylightSaving,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.DataRecord_).groundTemperatures'></a>

`groundTemperatures` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The ground temperatures header record\.

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.Location,DiGi.EPW.Classes.DesignConditions,System.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_,DiGi.EPW.Classes.HolidaysDaylightSaving,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.DataRecord_).holidaysDaylightSaving'></a>

`holidaysDaylightSaving` [HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving')

The holidays/daylight saving header record\.

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.Location,DiGi.EPW.Classes.DesignConditions,System.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_,DiGi.EPW.Classes.HolidaysDaylightSaving,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.DataRecord_).comments1'></a>

`comments1` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The first comments header record\.

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.Location,DiGi.EPW.Classes.DesignConditions,System.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_,DiGi.EPW.Classes.HolidaysDaylightSaving,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.DataRecord_).comments2'></a>

`comments2` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The second comments header record\.

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.Location,DiGi.EPW.Classes.DesignConditions,System.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_,DiGi.EPW.Classes.HolidaysDaylightSaving,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.DataRecord_).dataPeriods'></a>

`dataPeriods` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The data periods header record\.

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(DiGi.EPW.Classes.Location,DiGi.EPW.Classes.DesignConditions,System.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_,DiGi.EPW.Classes.HolidaysDaylightSaving,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,System.Collections.Generic.IList_DiGi.EPW.Classes.DataRecord_).dataRecords'></a>

`dataRecords` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The hourly weather data records\.

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(System.Text.Json.Nodes.JsonObject)'></a>

## EPWFile\(JsonObject\) Constructor

Initializes a new instance of the [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile') class from a JSON object\.

```csharp
public EPWFile(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.EPW.Classes.EPWFile.EPWFile(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing EPW file data\.
### Properties

<a name='DiGi.EPW.Classes.EPWFile.Comments1'></a>

## EPWFile\.Comments1 Property

Gets the first comments header record\.

```csharp
public string? Comments1 { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.EPWFile.Comments2'></a>

## EPWFile\.Comments2 Property

Gets the second comments header record\.

```csharp
public string? Comments2 { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.EPWFile.DataPeriods'></a>

## EPWFile\.DataPeriods Property

Gets the data periods header record\.

```csharp
public System.Collections.Generic.IList<DiGi.EPW.Classes.DataPeriod>? DataPeriods { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='DiGi.EPW.Classes.EPWFile.DataRecords'></a>

## EPWFile\.DataRecords Property

Gets the hourly weather data records\.

```csharp
public System.Collections.Generic.IList<DiGi.EPW.Classes.DataRecord>? DataRecords { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='DiGi.EPW.Classes.EPWFile.DesignConditions'></a>

## EPWFile\.DesignConditions Property

Gets the design conditions header record\.

```csharp
public DiGi.EPW.Classes.DesignConditions? DesignConditions { get; }
```

#### Property Value
[DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions')

<a name='DiGi.EPW.Classes.EPWFile.GroundTemperatures'></a>

## EPWFile\.GroundTemperatures Property

Gets the ground temperatures header record\.

```csharp
public System.Collections.Generic.IList<DiGi.EPW.Classes.GroundTemperature>? GroundTemperatures { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='DiGi.EPW.Classes.EPWFile.HolidaysDaylightSaving'></a>

## EPWFile\.HolidaysDaylightSaving Property

Gets the holidays/daylight saving header record\.

```csharp
public DiGi.EPW.Classes.HolidaysDaylightSaving? HolidaysDaylightSaving { get; }
```

#### Property Value
[HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving')

<a name='DiGi.EPW.Classes.EPWFile.Location'></a>

## EPWFile\.Location Property

Gets the location information associated with this EPW file\.

```csharp
public DiGi.EPW.Classes.Location? Location { get; }
```

#### Property Value
[Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location')

<a name='DiGi.EPW.Classes.EPWFile.TypicalExtremePeriods'></a>

## EPWFile\.TypicalExtremePeriods Property

Gets the typical/extreme periods header record\.

```csharp
public System.Collections.Generic.IList<DiGi.EPW.Classes.TypicalExtremePeriod>? TypicalExtremePeriods { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='DiGi.EPW.Classes.GroundTemperature'></a>

## GroundTemperature Class

Represents a single depth entry of the GROUND TEMPERATURES header record of an EPW file\.

```csharp
public class GroundTemperature : DiGi.Core.Classes.SerializableObject, DiGi.EPW.Interfaces.IEPWSerializableObject, DiGi.EPW.Interfaces.IEPWObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → GroundTemperature

Implements [IEPWSerializableObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWSerializableObject 'DiGi\.EPW\.Interfaces\.IEPWSerializableObject'), [IEPWObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWObject 'DiGi\.EPW\.Interfaces\.IEPWObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.EPW.Classes.GroundTemperature.GroundTemperature(DiGi.EPW.Classes.GroundTemperature)'></a>

## GroundTemperature\(GroundTemperature\) Constructor

Initializes a new instance of the [GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature') class by copying an existing instance\.

```csharp
public GroundTemperature(DiGi.EPW.Classes.GroundTemperature? groundTemperature);
```
#### Parameters

<a name='DiGi.EPW.Classes.GroundTemperature.GroundTemperature(DiGi.EPW.Classes.GroundTemperature).groundTemperature'></a>

`groundTemperature` [GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature')

The source ground temperature to copy from\.

<a name='DiGi.EPW.Classes.GroundTemperature.GroundTemperature(double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Collections.Generic.IList_double_)'></a>

## GroundTemperature\(double, Nullable\<double\>, Nullable\<double\>, Nullable\<double\>, IList\<double\>\) Constructor

Initializes a new instance of the [GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature') class\.

```csharp
public GroundTemperature(double depth, System.Nullable<double> conductivity, System.Nullable<double> density, System.Nullable<double> specificHeat, System.Collections.Generic.IList<double>? monthlyValues);
```
#### Parameters

<a name='DiGi.EPW.Classes.GroundTemperature.GroundTemperature(double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Collections.Generic.IList_double_).depth'></a>

`depth` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The ground depth, in meters\.

<a name='DiGi.EPW.Classes.GroundTemperature.GroundTemperature(double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Collections.Generic.IList_double_).conductivity'></a>

`conductivity` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The soil thermal conductivity, if specified\.

<a name='DiGi.EPW.Classes.GroundTemperature.GroundTemperature(double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Collections.Generic.IList_double_).density'></a>

`density` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The soil density, if specified\.

<a name='DiGi.EPW.Classes.GroundTemperature.GroundTemperature(double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Collections.Generic.IList_double_).specificHeat'></a>

`specificHeat` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The soil specific heat, if specified\.

<a name='DiGi.EPW.Classes.GroundTemperature.GroundTemperature(double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Collections.Generic.IList_double_).monthlyValues'></a>

`monthlyValues` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The twelve monthly ground temperature values\.

<a name='DiGi.EPW.Classes.GroundTemperature.GroundTemperature(System.Text.Json.Nodes.JsonObject)'></a>

## GroundTemperature\(JsonObject\) Constructor

Initializes a new instance of the [GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature') class from a JSON object\.

```csharp
public GroundTemperature(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.EPW.Classes.GroundTemperature.GroundTemperature(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing ground temperature data\.
### Properties

<a name='DiGi.EPW.Classes.GroundTemperature.Conductivity'></a>

## GroundTemperature\.Conductivity Property

Gets the soil thermal conductivity, if specified\.

```csharp
public System.Nullable<double> Conductivity { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.EPW.Classes.GroundTemperature.Density'></a>

## GroundTemperature\.Density Property

Gets the soil density, if specified\.

```csharp
public System.Nullable<double> Density { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.EPW.Classes.GroundTemperature.Depth'></a>

## GroundTemperature\.Depth Property

Gets the ground depth, in meters\.

```csharp
public double Depth { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.GroundTemperature.MonthlyValues'></a>

## GroundTemperature\.MonthlyValues Property

Gets the twelve monthly ground temperature values\.

```csharp
public System.Collections.Generic.IList<double>? MonthlyValues { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='DiGi.EPW.Classes.GroundTemperature.SpecificHeat'></a>

## GroundTemperature\.SpecificHeat Property

Gets the soil specific heat, if specified\.

```csharp
public System.Nullable<double> SpecificHeat { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.EPW.Classes.Holiday'></a>

## Holiday Class

Represents a single holiday entry of the HOLIDAYS/DAYLIGHT SAVINGS header record of an EPW file\.

```csharp
public class Holiday : DiGi.Core.Classes.SerializableObject, DiGi.EPW.Interfaces.IEPWSerializableObject, DiGi.EPW.Interfaces.IEPWObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Holiday

Implements [IEPWSerializableObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWSerializableObject 'DiGi\.EPW\.Interfaces\.IEPWSerializableObject'), [IEPWObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWObject 'DiGi\.EPW\.Interfaces\.IEPWObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.EPW.Classes.Holiday.Holiday(DiGi.EPW.Classes.Holiday)'></a>

## Holiday\(Holiday\) Constructor

Initializes a new instance of the [Holiday](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Holiday 'DiGi\.EPW\.Classes\.Holiday') class by copying an existing instance\.

```csharp
public Holiday(DiGi.EPW.Classes.Holiday? holiday);
```
#### Parameters

<a name='DiGi.EPW.Classes.Holiday.Holiday(DiGi.EPW.Classes.Holiday).holiday'></a>

`holiday` [Holiday](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Holiday 'DiGi\.EPW\.Classes\.Holiday')

The source holiday to copy from\.

<a name='DiGi.EPW.Classes.Holiday.Holiday(string,string)'></a>

## Holiday\(string, string\) Constructor

Initializes a new instance of the [Holiday](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Holiday 'DiGi\.EPW\.Classes\.Holiday') class\.

```csharp
public Holiday(string? name, string? date);
```
#### Parameters

<a name='DiGi.EPW.Classes.Holiday.Holiday(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the holiday\.

<a name='DiGi.EPW.Classes.Holiday.Holiday(string,string).date'></a>

`date` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The date of the holiday\.

<a name='DiGi.EPW.Classes.Holiday.Holiday(System.Text.Json.Nodes.JsonObject)'></a>

## Holiday\(JsonObject\) Constructor

Initializes a new instance of the [Holiday](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Holiday 'DiGi\.EPW\.Classes\.Holiday') class from a JSON object\.

```csharp
public Holiday(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.EPW.Classes.Holiday.Holiday(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing holiday data\.
### Properties

<a name='DiGi.EPW.Classes.Holiday.Date'></a>

## Holiday\.Date Property

Gets the date of the holiday\.

```csharp
public string? Date { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.Holiday.Name'></a>

## Holiday\.Name Property

Gets the name of the holiday\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving'></a>

## HolidaysDaylightSaving Class

Represents the HOLIDAYS/DAYLIGHT SAVINGS header record of an EPW file\.

```csharp
public class HolidaysDaylightSaving : DiGi.Core.Classes.SerializableObject, DiGi.EPW.Interfaces.IEPWSerializableObject, DiGi.EPW.Interfaces.IEPWObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → HolidaysDaylightSaving

Implements [IEPWSerializableObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWSerializableObject 'DiGi\.EPW\.Interfaces\.IEPWSerializableObject'), [IEPWObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWObject 'DiGi\.EPW\.Interfaces\.IEPWObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.HolidaysDaylightSaving(bool,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.Holiday_)'></a>

## HolidaysDaylightSaving\(bool, string, string, IList\<Holiday\>\) Constructor

Initializes a new instance of the [HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving') class\.

```csharp
public HolidaysDaylightSaving(bool leapYearObserved, string? daylightSavingStartDate, string? daylightSavingEndDate, System.Collections.Generic.IList<DiGi.EPW.Classes.Holiday>? holidays);
```
#### Parameters

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.HolidaysDaylightSaving(bool,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.Holiday_).leapYearObserved'></a>

`leapYearObserved` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the leap year is observed\.

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.HolidaysDaylightSaving(bool,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.Holiday_).daylightSavingStartDate'></a>

`daylightSavingStartDate` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The daylight saving start date\.

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.HolidaysDaylightSaving(bool,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.Holiday_).daylightSavingEndDate'></a>

`daylightSavingEndDate` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The daylight saving end date\.

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.HolidaysDaylightSaving(bool,string,string,System.Collections.Generic.IList_DiGi.EPW.Classes.Holiday_).holidays'></a>

`holidays` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[Holiday](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Holiday 'DiGi\.EPW\.Classes\.Holiday')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The list of holidays defined in the file\.

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.HolidaysDaylightSaving(DiGi.EPW.Classes.HolidaysDaylightSaving)'></a>

## HolidaysDaylightSaving\(HolidaysDaylightSaving\) Constructor

Initializes a new instance of the [HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving') class by copying an existing instance\.

```csharp
public HolidaysDaylightSaving(DiGi.EPW.Classes.HolidaysDaylightSaving? holidaysDaylightSaving);
```
#### Parameters

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.HolidaysDaylightSaving(DiGi.EPW.Classes.HolidaysDaylightSaving).holidaysDaylightSaving'></a>

`holidaysDaylightSaving` [HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving')

The source holidays/daylight saving record to copy from\.

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.HolidaysDaylightSaving(System.Text.Json.Nodes.JsonObject)'></a>

## HolidaysDaylightSaving\(JsonObject\) Constructor

Initializes a new instance of the [HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving') class from a JSON object\.

```csharp
public HolidaysDaylightSaving(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.HolidaysDaylightSaving(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing holidays/daylight saving data\.
### Properties

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.DaylightSavingEndDate'></a>

## HolidaysDaylightSaving\.DaylightSavingEndDate Property

Gets the daylight saving end date\.

```csharp
public string? DaylightSavingEndDate { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.DaylightSavingStartDate'></a>

## HolidaysDaylightSaving\.DaylightSavingStartDate Property

Gets the daylight saving start date\.

```csharp
public string? DaylightSavingStartDate { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.Holidays'></a>

## HolidaysDaylightSaving\.Holidays Property

Gets the list of holidays defined in the file\.

```csharp
public System.Collections.Generic.IList<DiGi.EPW.Classes.Holiday>? Holidays { get; }
```

#### Property Value
[System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[Holiday](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Holiday 'DiGi\.EPW\.Classes\.Holiday')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

<a name='DiGi.EPW.Classes.HolidaysDaylightSaving.LeapYearObserved'></a>

## HolidaysDaylightSaving\.LeapYearObserved Property

Gets a value indicating whether the leap year is observed\.

```csharp
public bool LeapYearObserved { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.EPW.Classes.Location'></a>

## Location Class

Represents a geographical location including coordinates, elevation, and administrative details\.

```csharp
public class Location : DiGi.Core.Classes.SerializableObject, DiGi.EPW.Interfaces.IEPWSerializableObject, DiGi.EPW.Interfaces.IEPWObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Location

Implements [IEPWSerializableObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWSerializableObject 'DiGi\.EPW\.Interfaces\.IEPWSerializableObject'), [IEPWObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWObject 'DiGi\.EPW\.Interfaces\.IEPWObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.EPW.Classes.Location.Location(DiGi.EPW.Classes.Location)'></a>

## Location\(Location\) Constructor

Initializes a new instance of the [Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location') class by copying an existing instance\.

```csharp
public Location(DiGi.EPW.Classes.Location? location);
```
#### Parameters

<a name='DiGi.EPW.Classes.Location.Location(DiGi.EPW.Classes.Location).location'></a>

`location` [Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location')

The source location to copy from\.

<a name='DiGi.EPW.Classes.Location.Location(string,string,string,string,string,double,double,double,double)'></a>

## Location\(string, string, string, string, string, double, double, double, double\) Constructor

Initializes a new instance of the [Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location') class\.

```csharp
public Location(string? city, string? region, string? country, string? source, string? wHO, double latitude, double longitude, double timeZone, double elevation);
```
#### Parameters

<a name='DiGi.EPW.Classes.Location.Location(string,string,string,string,string,double,double,double,double).city'></a>

`city` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the city\.

<a name='DiGi.EPW.Classes.Location.Location(string,string,string,string,string,double,double,double,double).region'></a>

`region` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The region or administrative area\.

<a name='DiGi.EPW.Classes.Location.Location(string,string,string,string,string,double,double,double,double).country'></a>

`country` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the country\.

<a name='DiGi.EPW.Classes.Location.Location(string,string,string,string,string,double,double,double,double).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The source of the location data\.

<a name='DiGi.EPW.Classes.Location.Location(string,string,string,string,string,double,double,double,double).wHO'></a>

`wHO` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The World Health Organization designation\.

<a name='DiGi.EPW.Classes.Location.Location(string,string,string,string,string,double,double,double,double).latitude'></a>

`latitude` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The latitude coordinate\.

<a name='DiGi.EPW.Classes.Location.Location(string,string,string,string,string,double,double,double,double).longitude'></a>

`longitude` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The longitude coordinate\.

<a name='DiGi.EPW.Classes.Location.Location(string,string,string,string,string,double,double,double,double).timeZone'></a>

`timeZone` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The time zone offset\.

<a name='DiGi.EPW.Classes.Location.Location(string,string,string,string,string,double,double,double,double).elevation'></a>

`elevation` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The elevation above sea level\.

<a name='DiGi.EPW.Classes.Location.Location(System.Text.Json.Nodes.JsonObject)'></a>

## Location\(JsonObject\) Constructor

Initializes a new instance of the [Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location') class from a JSON object\.

```csharp
public Location(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.EPW.Classes.Location.Location(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing location data\.
### Properties

<a name='DiGi.EPW.Classes.Location.City'></a>

## Location\.City Property

Gets the name of the city\.

```csharp
public string? City { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.Location.Country'></a>

## Location\.Country Property

Gets the name of the country\.

```csharp
public string? Country { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.Location.Elevation'></a>

## Location\.Elevation Property

Gets the elevation of the location\.

```csharp
public double Elevation { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.Location.Latitude'></a>

## Location\.Latitude Property

Gets the latitude coordinate of the location\.

```csharp
public double Latitude { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.Location.Longitude'></a>

## Location\.Longitude Property

Gets the longitude coordinate of the location\.

```csharp
public double Longitude { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.Location.Region'></a>

## Location\.Region Property

Gets the region or administrative area of the location\.

```csharp
public string? Region { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.Location.Source'></a>

## Location\.Source Property

Gets the source from which the location data was retrieved\.

```csharp
public string? Source { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.Location.TimeZone'></a>

## Location\.TimeZone Property

Gets the time zone offset for the location\.

```csharp
public double TimeZone { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.EPW.Classes.Location.WHO'></a>

## Location\.WHO Property

Gets the World Health Organization \(WHO\) designation for the location\.

```csharp
public string? WHO { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.TypicalExtremePeriod'></a>

## TypicalExtremePeriod Class

Represents a single period entry of the TYPICAL/EXTREME PERIODS header record of an EPW file\.

```csharp
public class TypicalExtremePeriod : DiGi.Core.Classes.SerializableObject, DiGi.EPW.Interfaces.IEPWSerializableObject, DiGi.EPW.Interfaces.IEPWObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → TypicalExtremePeriod

Implements [IEPWSerializableObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWSerializableObject 'DiGi\.EPW\.Interfaces\.IEPWSerializableObject'), [IEPWObject](DiGi.EPW.Interfaces.md#DiGi.EPW.Interfaces.IEPWObject 'DiGi\.EPW\.Interfaces\.IEPWObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.TypicalExtremePeriod(DiGi.EPW.Classes.TypicalExtremePeriod)'></a>

## TypicalExtremePeriod\(TypicalExtremePeriod\) Constructor

Initializes a new instance of the [TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod') class by copying an existing instance\.

```csharp
public TypicalExtremePeriod(DiGi.EPW.Classes.TypicalExtremePeriod? typicalExtremePeriod);
```
#### Parameters

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.TypicalExtremePeriod(DiGi.EPW.Classes.TypicalExtremePeriod).typicalExtremePeriod'></a>

`typicalExtremePeriod` [TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod')

The source typical/extreme period to copy from\.

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.TypicalExtremePeriod(string,string,string,string)'></a>

## TypicalExtremePeriod\(string, string, string, string\) Constructor

Initializes a new instance of the [TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod') class\.

```csharp
public TypicalExtremePeriod(string? name, string? periodType, string? startDate, string? endDate);
```
#### Parameters

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.TypicalExtremePeriod(string,string,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the typical or extreme period\.

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.TypicalExtremePeriod(string,string,string,string).periodType'></a>

`periodType` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The type of the period, e\.g\. Typical or Extreme\.

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.TypicalExtremePeriod(string,string,string,string).startDate'></a>

`startDate` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The start date of the period\.

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.TypicalExtremePeriod(string,string,string,string).endDate'></a>

`endDate` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The end date of the period\.

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.TypicalExtremePeriod(System.Text.Json.Nodes.JsonObject)'></a>

## TypicalExtremePeriod\(JsonObject\) Constructor

Initializes a new instance of the [TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod') class from a JSON object\.

```csharp
public TypicalExtremePeriod(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.TypicalExtremePeriod(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing typical/extreme period data\.
### Properties

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.EndDate'></a>

## TypicalExtremePeriod\.EndDate Property

Gets the end date of the period\.

```csharp
public string? EndDate { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.Name'></a>

## TypicalExtremePeriod\.Name Property

Gets the name of the typical or extreme period\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.PeriodType'></a>

## TypicalExtremePeriod\.PeriodType Property

Gets the type of the period, e\.g\. Typical or Extreme\.

```csharp
public string? PeriodType { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Classes.TypicalExtremePeriod.StartDate'></a>

## TypicalExtremePeriod\.StartDate Property

Gets the start date of the period\.

```csharp
public string? StartDate { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
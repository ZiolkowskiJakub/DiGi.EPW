#### [DiGi\.EPW](index.md 'index')

## DiGi\.EPW Namespace
### Classes

<a name='DiGi.EPW.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.EPW.Create.DataPeriods(string[],int,int,int)'></a>

## Create\.DataPeriods\(string\[\], int, int, int\) Method

Parses data periods data from a specific line within an array of strings to create a list of [DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.EPW.Classes.DataPeriod>? DataPeriods(string[]? lines, int index, out int recordsPerHour, out int index_Next);
```
#### Parameters

<a name='DiGi.EPW.Create.DataPeriods(string[],int,int,int).lines'></a>

`lines` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array of strings containing the raw data lines\.

<a name='DiGi.EPW.Create.DataPeriods(string[],int,int,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the line to be processed\.

<a name='DiGi.EPW.Create.DataPeriods(string[],int,int,int).recordsPerHour'></a>

`recordsPerHour` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An output parameter that returns the number of records per hour declared in the record\.

<a name='DiGi.EPW.Create.DataPeriods(string[],int,int,int).index_Next'></a>

`index_Next` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An output parameter that returns the updated index after processing\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod') instances if the input is valid; otherwise, null\.

<a name='DiGi.EPW.Create.DataRecord(string[],int,int)'></a>

## Create\.DataRecord\(string\[\], int, int\) Method

Parses an hourly weather data record from a specific line within an array of strings to create a [DataRecord\(string\[\], int, int\)](DiGi.EPW.md#DiGi.EPW.Create.DataRecord(string[],int,int) 'DiGi\.EPW\.Create\.DataRecord\(string\[\], int, int\)') object\.

```csharp
public static DiGi.EPW.Classes.DataRecord? DataRecord(string[]? lines, int index, out int index_Next);
```
#### Parameters

<a name='DiGi.EPW.Create.DataRecord(string[],int,int).lines'></a>

`lines` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array of strings containing the raw data lines\.

<a name='DiGi.EPW.Create.DataRecord(string[],int,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the line to be processed\.

<a name='DiGi.EPW.Create.DataRecord(string[],int,int).index_Next'></a>

`index_Next` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An output parameter that returns the updated index after processing\.

#### Returns
[DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord')  
A [DataRecord\(string\[\], int, int\)](DiGi.EPW.md#DiGi.EPW.Create.DataRecord(string[],int,int) 'DiGi\.EPW\.Create\.DataRecord\(string\[\], int, int\)') instance if the input is valid; otherwise, null\.

<a name='DiGi.EPW.Create.DesignConditions(string[],int,int)'></a>

## Create\.DesignConditions\(string\[\], int, int\) Method

Parses design conditions data from a specific line within an array of strings to create a [DesignConditions\(string\[\], int, int\)](DiGi.EPW.md#DiGi.EPW.Create.DesignConditions(string[],int,int) 'DiGi\.EPW\.Create\.DesignConditions\(string\[\], int, int\)') object\.

```csharp
public static DiGi.EPW.Classes.DesignConditions? DesignConditions(string[]? lines, int index, out int index_Next);
```
#### Parameters

<a name='DiGi.EPW.Create.DesignConditions(string[],int,int).lines'></a>

`lines` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array of strings containing the raw data lines\.

<a name='DiGi.EPW.Create.DesignConditions(string[],int,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the line to be processed\.

<a name='DiGi.EPW.Create.DesignConditions(string[],int,int).index_Next'></a>

`index_Next` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An output parameter that returns the updated index after processing\.

#### Returns
[DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions')  
A [DesignConditions\(string\[\], int, int\)](DiGi.EPW.md#DiGi.EPW.Create.DesignConditions(string[],int,int) 'DiGi\.EPW\.Create\.DesignConditions\(string\[\], int, int\)') instance if the input is valid; otherwise, null\.

<a name='DiGi.EPW.Create.EPWFiles(string,System.IO.SearchOption)'></a>

## Create\.EPWFiles\(string, SearchOption\) Method

Scans the specified directory for files with the EPW extension and reads them into a dictionary mapping file paths to [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile') objects\.

```csharp
public static System.Collections.Generic.Dictionary<string,DiGi.EPW.Classes.EPWFile>? EPWFiles(string? directory, System.IO.SearchOption searchOption);
```
#### Parameters

<a name='DiGi.EPW.Create.EPWFiles(string,System.IO.SearchOption).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory to search\.

<a name='DiGi.EPW.Create.EPWFiles(string,System.IO.SearchOption).searchOption'></a>

`searchOption` [System\.IO\.SearchOption](https://learn.microsoft.com/en-us/dotnet/api/system.io.searchoption 'System\.IO\.SearchOption')

Specifies whether to search only the current directory or include subdirectories\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary of file paths and their corresponding [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile') objects, or null if the directory is invalid or no files are found\.

<a name='DiGi.EPW.Create.GroundTemperatures(string[],int,int)'></a>

## Create\.GroundTemperatures\(string\[\], int, int\) Method

Parses ground temperatures data from a specific line within an array of strings to create a list of [GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.EPW.Classes.GroundTemperature>? GroundTemperatures(string[]? lines, int index, out int index_Next);
```
#### Parameters

<a name='DiGi.EPW.Create.GroundTemperatures(string[],int,int).lines'></a>

`lines` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array of strings containing the raw data lines\.

<a name='DiGi.EPW.Create.GroundTemperatures(string[],int,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the line to be processed\.

<a name='DiGi.EPW.Create.GroundTemperatures(string[],int,int).index_Next'></a>

`index_Next` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An output parameter that returns the updated index after processing\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature') instances if the input is valid; otherwise, null\.

<a name='DiGi.EPW.Create.HolidaysDaylightSaving(string[],int,int)'></a>

## Create\.HolidaysDaylightSaving\(string\[\], int, int\) Method

Parses holidays/daylight saving data from a specific line within an array of strings to create a [HolidaysDaylightSaving\(string\[\], int, int\)](DiGi.EPW.md#DiGi.EPW.Create.HolidaysDaylightSaving(string[],int,int) 'DiGi\.EPW\.Create\.HolidaysDaylightSaving\(string\[\], int, int\)') object\.

```csharp
public static DiGi.EPW.Classes.HolidaysDaylightSaving? HolidaysDaylightSaving(string[]? lines, int index, out int index_Next);
```
#### Parameters

<a name='DiGi.EPW.Create.HolidaysDaylightSaving(string[],int,int).lines'></a>

`lines` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array of strings containing the raw data lines\.

<a name='DiGi.EPW.Create.HolidaysDaylightSaving(string[],int,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the line to be processed\.

<a name='DiGi.EPW.Create.HolidaysDaylightSaving(string[],int,int).index_Next'></a>

`index_Next` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An output parameter that returns the updated index after processing\.

#### Returns
[HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving')  
A [HolidaysDaylightSaving\(string\[\], int, int\)](DiGi.EPW.md#DiGi.EPW.Create.HolidaysDaylightSaving(string[],int,int) 'DiGi\.EPW\.Create\.HolidaysDaylightSaving\(string\[\], int, int\)') instance if the input is valid; otherwise, null\.

<a name='DiGi.EPW.Create.Location(string[],int,int)'></a>

## Create\.Location\(string\[\], int, int\) Method

Parses location data from a specific line within an array of strings to create a [Location\(string\[\], int, int\)](DiGi.EPW.md#DiGi.EPW.Create.Location(string[],int,int) 'DiGi\.EPW\.Create\.Location\(string\[\], int, int\)') object\.

```csharp
public static DiGi.EPW.Classes.Location? Location(string[]? lines, int index, out int index_Next);
```
#### Parameters

<a name='DiGi.EPW.Create.Location(string[],int,int).lines'></a>

`lines` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array of strings containing the raw data lines\.

<a name='DiGi.EPW.Create.Location(string[],int,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the line to be processed\.

<a name='DiGi.EPW.Create.Location(string[],int,int).index_Next'></a>

`index_Next` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An output parameter that returns the updated index after processing\.

#### Returns
[Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location')  
A [Location\(string\[\], int, int\)](DiGi.EPW.md#DiGi.EPW.Create.Location(string[],int,int) 'DiGi\.EPW\.Create\.Location\(string\[\], int, int\)') instance if the input is valid; otherwise, null\.

<a name='DiGi.EPW.Create.TypicalExtremePeriods(string[],int,int)'></a>

## Create\.TypicalExtremePeriods\(string\[\], int, int\) Method

Parses typical/extreme periods data from a specific line within an array of strings to create a list of [TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod') objects\.

```csharp
public static System.Collections.Generic.List<DiGi.EPW.Classes.TypicalExtremePeriod>? TypicalExtremePeriods(string[]? lines, int index, out int index_Next);
```
#### Parameters

<a name='DiGi.EPW.Create.TypicalExtremePeriods(string[],int,int).lines'></a>

`lines` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array of strings containing the raw data lines\.

<a name='DiGi.EPW.Create.TypicalExtremePeriods(string[],int,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the line to be processed\.

<a name='DiGi.EPW.Create.TypicalExtremePeriods(string[],int,int).index_Next'></a>

`index_Next` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An output parameter that returns the updated index after processing\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod') instances if the input is valid; otherwise, null\.

<a name='DiGi.EPW.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.EPW.Modify.Read(string)'></a>

## Modify\.Read\(string\) Method

Reads an EPW file from the specified path and parses it into an [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile') object\.

```csharp
public static DiGi.EPW.Classes.EPWFile? Read(string? path);
```
#### Parameters

<a name='DiGi.EPW.Modify.Read(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the EPW file\.

#### Returns
[EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile')  
An [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile') instance if the file is successfully read; otherwise, `null`\.

<a name='DiGi.EPW.Modify.Write(thisDiGi.EPW.Classes.EPWFile,string)'></a>

## Modify\.Write\(this EPWFile, string\) Method

Writes an [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile') instance to the specified path as an EPW file\.

```csharp
public static bool Write(this DiGi.EPW.Classes.EPWFile? epwFile, string? path);
```
#### Parameters

<a name='DiGi.EPW.Modify.Write(thisDiGi.EPW.Classes.EPWFile,string).epwFile'></a>

`epwFile` [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile')

The EPW file data to be written\.

<a name='DiGi.EPW.Modify.Write(thisDiGi.EPW.Classes.EPWFile,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path the EPW file is written to\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the EPW file is successfully written; otherwise, `false`\.

<a name='DiGi.EPW.Query'></a>

## Query Class

Provides extension methods for querying EPW\-related objects\.

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.EPW.Query.Name(thisDiGi.EPW.Classes.EPWFile)'></a>

## Query\.Name\(this EPWFile\) Method

Generates the name of the EPW file based on its location properties, omitting the file extension\.

```csharp
public static string Name(this DiGi.EPW.Classes.EPWFile ePWFile);
```
#### Parameters

<a name='DiGi.EPW.Query.Name(thisDiGi.EPW.Classes.EPWFile).ePWFile'></a>

`ePWFile` [EPWFile](DiGi.EPW.Classes.md#DiGi.EPW.Classes.EPWFile 'DiGi\.EPW\.Classes\.EPWFile')

The EPW file to generate the name for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The generated name without the file extension\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
Thrown when the provided EPW file is null\.

[System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException')  
Thrown when the EPW file does not have a valid location\.

<a name='DiGi.EPW.Query.ToString(thisDiGi.EPW.Classes.DataRecord)'></a>

## Query\.ToString\(this DataRecord\) Method

Converts a [DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord') instance into its EPW hourly weather data line representation\.

```csharp
public static string ToString(this DiGi.EPW.Classes.DataRecord dataRecord);
```
#### Parameters

<a name='DiGi.EPW.Query.ToString(thisDiGi.EPW.Classes.DataRecord).dataRecord'></a>

`dataRecord` [DataRecord](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataRecord 'DiGi\.EPW\.Classes\.DataRecord')

The data record to be converted\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The EPW hourly weather data line\.

<a name='DiGi.EPW.Query.ToString(thisDiGi.EPW.Classes.DesignConditions)'></a>

## Query\.ToString\(this DesignConditions\) Method

Converts a [DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions') instance into its EPW DESIGN CONDITIONS header record line representation\.

```csharp
public static string ToString(this DiGi.EPW.Classes.DesignConditions designConditions);
```
#### Parameters

<a name='DiGi.EPW.Query.ToString(thisDiGi.EPW.Classes.DesignConditions).designConditions'></a>

`designConditions` [DesignConditions](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DesignConditions 'DiGi\.EPW\.Classes\.DesignConditions')

The design conditions to be converted\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The EPW DESIGN CONDITIONS header record line\.

<a name='DiGi.EPW.Query.ToString(thisDiGi.EPW.Classes.HolidaysDaylightSaving)'></a>

## Query\.ToString\(this HolidaysDaylightSaving\) Method

Converts a [HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving') instance into its EPW HOLIDAYS/DAYLIGHT SAVINGS header record line representation\.

```csharp
public static string ToString(this DiGi.EPW.Classes.HolidaysDaylightSaving holidaysDaylightSaving);
```
#### Parameters

<a name='DiGi.EPW.Query.ToString(thisDiGi.EPW.Classes.HolidaysDaylightSaving).holidaysDaylightSaving'></a>

`holidaysDaylightSaving` [HolidaysDaylightSaving](DiGi.EPW.Classes.md#DiGi.EPW.Classes.HolidaysDaylightSaving 'DiGi\.EPW\.Classes\.HolidaysDaylightSaving')

The holidays/daylight saving record to be converted\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The EPW HOLIDAYS/DAYLIGHT SAVINGS header record line\.

<a name='DiGi.EPW.Query.ToString(thisDiGi.EPW.Classes.Location)'></a>

## Query\.ToString\(this Location\) Method

Converts a [Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location') instance into its EPW LOCATION header record line representation\.

```csharp
public static string ToString(this DiGi.EPW.Classes.Location location);
```
#### Parameters

<a name='DiGi.EPW.Query.ToString(thisDiGi.EPW.Classes.Location).location'></a>

`location` [Location](DiGi.EPW.Classes.md#DiGi.EPW.Classes.Location 'DiGi\.EPW\.Classes\.Location')

The location to be converted\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The EPW LOCATION header record line\.

<a name='DiGi.EPW.Query.ToString(thisSystem.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,int)'></a>

## Query\.ToString\(this IList\<DataPeriod\>, int\) Method

Converts a list of [DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod') instances into their EPW DATA PERIODS header record line representation\.

```csharp
public static string ToString(this System.Collections.Generic.IList<DiGi.EPW.Classes.DataPeriod> dataPeriods, int recordsPerHour);
```
#### Parameters

<a name='DiGi.EPW.Query.ToString(thisSystem.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,int).dataPeriods'></a>

`dataPeriods` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[DataPeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.DataPeriod 'DiGi\.EPW\.Classes\.DataPeriod')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The data periods to be converted\.

<a name='DiGi.EPW.Query.ToString(thisSystem.Collections.Generic.IList_DiGi.EPW.Classes.DataPeriod_,int).recordsPerHour'></a>

`recordsPerHour` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of records per hour to be written into the record\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The EPW DATA PERIODS header record line\.

<a name='DiGi.EPW.Query.ToString(thisSystem.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_)'></a>

## Query\.ToString\(this IList\<GroundTemperature\>\) Method

Converts a list of [GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature') instances into their EPW GROUND TEMPERATURES header record line representation\.

```csharp
public static string ToString(this System.Collections.Generic.IList<DiGi.EPW.Classes.GroundTemperature> groundTemperatures);
```
#### Parameters

<a name='DiGi.EPW.Query.ToString(thisSystem.Collections.Generic.IList_DiGi.EPW.Classes.GroundTemperature_).groundTemperatures'></a>

`groundTemperatures` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[GroundTemperature](DiGi.EPW.Classes.md#DiGi.EPW.Classes.GroundTemperature 'DiGi\.EPW\.Classes\.GroundTemperature')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The ground temperatures to be converted\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The EPW GROUND TEMPERATURES header record line\.

<a name='DiGi.EPW.Query.ToString(thisSystem.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_)'></a>

## Query\.ToString\(this IList\<TypicalExtremePeriod\>\) Method

Converts a list of [TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod') instances into their EPW TYPICAL/EXTREME PERIODS header record line representation\.

```csharp
public static string ToString(this System.Collections.Generic.IList<DiGi.EPW.Classes.TypicalExtremePeriod> typicalExtremePeriods);
```
#### Parameters

<a name='DiGi.EPW.Query.ToString(thisSystem.Collections.Generic.IList_DiGi.EPW.Classes.TypicalExtremePeriod_).typicalExtremePeriods'></a>

`typicalExtremePeriods` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[TypicalExtremePeriod](DiGi.EPW.Classes.md#DiGi.EPW.Classes.TypicalExtremePeriod 'DiGi\.EPW\.Classes\.TypicalExtremePeriod')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The typical/extreme periods to be converted\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The EPW TYPICAL/EXTREME PERIODS header record line\.
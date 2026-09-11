#### [DiGi\.EPW](DiGi.EPW.Overview.md 'DiGi\.EPW\.Overview')

## DiGi\.EPW\.Constants Namespace
### Classes

<a name='DiGi.EPW.Constants.FileExtension'></a>

## FileExtension Class

Provides constant values for supported file extensions\.

```csharp
public static class FileExtension
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → FileExtension
### Fields

<a name='DiGi.EPW.Constants.FileExtension.EPWFile'></a>

## FileExtension\.EPWFile Field

The file extension for EPW files\.

```csharp
public const string EPWFile = "epw";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Constants.HeaderName'></a>

## HeaderName Class

Provides constant definitions for header names used across the application\.

```csharp
public static class HeaderName
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → HeaderName
### Fields

<a name='DiGi.EPW.Constants.HeaderName.Comments1'></a>

## HeaderName\.Comments1 Field

The header name representing the first comments record\.

```csharp
public const string Comments1 = "COMMENTS 1";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Constants.HeaderName.Comments2'></a>

## HeaderName\.Comments2 Field

The header name representing the second comments record\.

```csharp
public const string Comments2 = "COMMENTS 2";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Constants.HeaderName.DataPeriods'></a>

## HeaderName\.DataPeriods Field

The header name representing the data periods information\.

```csharp
public const string DataPeriods = "DATA PERIODS";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Constants.HeaderName.DesignConditions'></a>

## HeaderName\.DesignConditions Field

The header name representing the design conditions information\.

```csharp
public const string DesignConditions = "DESIGN CONDITIONS";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Constants.HeaderName.GroundTemperatures'></a>

## HeaderName\.GroundTemperatures Field

The header name representing the ground temperatures information\.

```csharp
public const string GroundTemperatures = "GROUND TEMPERATURES";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Constants.HeaderName.HolidaysDaylightSavings'></a>

## HeaderName\.HolidaysDaylightSavings Field

The header name representing the holidays/daylight savings information\.

```csharp
public const string HolidaysDaylightSavings = "HOLIDAYS/DAYLIGHT SAVINGS";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Constants.HeaderName.Location'></a>

## HeaderName\.Location Field

The header name representing the location information\.

```csharp
public const string Location = "LOCATION";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Constants.HeaderName.TypicalExtremePeriods'></a>

## HeaderName\.TypicalExtremePeriods Field

The header name representing the typical/extreme periods information\.

```csharp
public const string TypicalExtremePeriods = "TYPICAL/EXTREME PERIODS";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.EPW.Constants.MissingValue'></a>

## MissingValue Class

Provides constant definitions for the missing\-value markers that EPW numeric fields carry instead of a measurement\.

```csharp
public static class MissingValue
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → MissingValue
### Fields

<a name='DiGi.EPW.Constants.MissingValue.Albedo'></a>

## MissingValue\.Albedo Field

The value 999 that marks a missing albedo reading in an EPW file\.

```csharp
public const float Albedo = 999;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.EPW.Constants.MissingValue.DiffuseHorizontalRadiation'></a>

## MissingValue\.DiffuseHorizontalRadiation Field

The value 9999 that marks a missing diffuse horizontal radiation reading in an EPW file\.

```csharp
public const float DiffuseHorizontalRadiation = 9999;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.EPW.Constants.MissingValue.DirectNormalRadiation'></a>

## MissingValue\.DirectNormalRadiation Field

The value 9999 that marks a missing direct normal radiation reading in an EPW file\.

```csharp
public const float DirectNormalRadiation = 9999;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.EPW.Constants.MissingValue.GlobalHorizontalRadiation'></a>

## MissingValue\.GlobalHorizontalRadiation Field

The value 9999 that marks a missing global horizontal radiation reading in an EPW file\.

```csharp
public const float GlobalHorizontalRadiation = 9999;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.EPW.Constants.MissingValue.SnowDepth'></a>

## MissingValue\.SnowDepth Field

The value 999 that marks a missing snow depth reading in an EPW file\.

```csharp
public const float SnowDepth = 999;
```

#### Field Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')
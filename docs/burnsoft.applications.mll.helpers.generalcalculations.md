[`< Back`](./)

---

# GeneralCalculations

Namespace: BurnSoft.Applications.MLL.Helpers

Class GeneralCalculations handles some math and 
 logic calculations used in the application

```csharp
public class GeneralCalculations
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [GeneralCalculations](./burnsoft.applications.mll.helpers.generalcalculations)

## Constructors

### **GeneralCalculations()**

```csharp
public GeneralCalculations()
```

## Methods

### **CalculateMetallicRoundsToMake(Int64, Int64, Int64, Double, Double, String&)**

Calculates the metallic rounds to make.

```csharp
public static long CalculateMetallicRoundsToMake(long bulletQty, long caseQty, long primerQty, double powderQty, double powderMidRangeLoad, String& errOut)
```

#### Parameters

`bulletQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The bullet qty.

`caseQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The case qty.

`primerQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The primer qty.

`powderQty` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The powder qty.

`powderMidRangeLoad` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The powder mid range load.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

### **CalculateShotgunRoundsToMake(Double, Double, Int64, Int64, Double, Double, Int64, String&)**

Calculates the shotgun rounds to make.

```csharp
public static long CalculateShotgunRoundsToMake(double shotOzQty, double shotPrefferedLoad, long caseQty, long wadQty, double powderQty, double powderMidRangeLoad, long primerQty, String& errOut)
```

#### Parameters

`shotOzQty` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The shot oz qty.

`shotPrefferedLoad` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The shot preffered load.

`caseQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The case qty.

`wadQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The wad qty.

`powderQty` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The powder qty.

`powderMidRangeLoad` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The powder mid range load.

`primerQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The primer qty.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

### **CalculateShotgunSlugRoundsToMake(Int64, Int64, Int64, Double, Double, Int64, String&)**

Calculates the shotgun slug rounds to make.

```csharp
public static long CalculateShotgunSlugRoundsToMake(long slugQty, long caseQty, long wadQty, double powderQty, double powderMidRangeLoad, long primerQty, String& errOut)
```

#### Parameters

`slugQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The slug qty.

`caseQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The case qty.

`wadQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The wad qty.

`powderQty` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The powder qty.

`powderMidRangeLoad` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The powder mid range load.

`primerQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The primer qty.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

---

[`< Back`](./)

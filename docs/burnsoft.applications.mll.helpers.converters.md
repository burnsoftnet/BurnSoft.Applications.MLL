[`< Back`](./)

---

# Converters

Namespace: BurnSoft.Applications.MLL.Helpers

Class Converters contains functions that can be used to convert values for the application

```csharp
public class Converters
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Converters](./burnsoft.applications.mll.helpers.converters)

## Constructors

### **Converters()**

```csharp
public Converters()
```

## Methods

### **ConvertToNumber(String, String&)**

Converts string to Double and removes any non characters

```csharp
public static double ConvertToNumber(string strValue, String& errOut)
```

#### Parameters

`strValue` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string value.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
System.Double.

### **ConvertOuncesToDouble(String, String&)**

Converts the ounces to double.

```csharp
public static double ConvertOuncesToDouble(string sValue, String& errOut)
```

#### Parameters

`sValue` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The s value.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
System.Double.

### **ConvertWeight(Double, WeightType, WeightType, String&)**

Converts the value to a specifict weight type, so if you had 2 lbs of powder you can convert it to grains etc.

```csharp
public static double ConvertWeight(double value, WeightType convertTo, WeightType convertFrom, String& errOut)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The value.

`convertTo` [WeightType](./burnsoft.applications.mll.global.weightvalues.weighttype)<br>
The convert to.

`convertFrom` [WeightType](./burnsoft.applications.mll.global.weightvalues.weighttype)<br>
The convert from.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
System.Double.

### **ConvertToDollars(Double)**

Converts long double to dollars format, at least with 3 decimal places on thr right.

```csharp
public static double ConvertToDollars(double dValue)
```

#### Parameters

`dValue` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The d value.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
System.Double.

---

[`< Back`](./)

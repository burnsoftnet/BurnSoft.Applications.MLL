[`< Back`](./)

---

# GeneralHelpers

Namespace: BurnSoft.Applications.MLL.Helpers

Class General functions that are used through out the program that have no general category

```csharp
public class GeneralHelpers
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [GeneralHelpers](./burnsoft.applications.mll.helpers.generalhelpers)

## Constructors

### **GeneralHelpers()**

```csharp
public GeneralHelpers()
```

## Methods

### **FluffContent(String, String)**

Fluffs the content for database

```csharp
public static string FluffContent(string value, string defaultValue)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

`defaultValue` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The default value.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
System.String.

### **FluffContent(String, Double)**

Fluffs the content to double

```csharp
public static double FluffContent(string value, double defaultValue)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

`defaultValue` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The default value.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
System.Double.

### **UnFluffContent(String)**

Uns the content of the fluff.

```csharp
public static string UnFluffContent(string value)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
System.String.

### **IsRequired(String, String, String)**

Determines whether the specified string value is required.

```csharp
public static bool IsRequired(string strValue, string strField, string strTitle)
```

#### Parameters

`strValue` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string value.

`strField` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string field.

`strTitle` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string title.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if the specified string value is required; otherwise, `false`.

### **IsRequired(Int64, Int64, String, String)**

Determines whether the specified l value is required.

```csharp
public static bool IsRequired(long lValue, long lDefault, string strField, string strTitle)
```

#### Parameters

`lValue` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The l value.

`lDefault` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The l default.

`strField` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string field.

`strTitle` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string title.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if the specified l value is required; otherwise, `false`.

### **IsRequired(Double, Double, String, String)**

Determines whether the specified l value is required.

```csharp
public static bool IsRequired(double lValue, double lDefault, string strField, string strTitle)
```

#### Parameters

`lValue` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The l value.

`lDefault` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The l default.

`strField` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string field.

`strTitle` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string title.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if the specified l value is required; otherwise, `false`.

---

[`< Back`](./)

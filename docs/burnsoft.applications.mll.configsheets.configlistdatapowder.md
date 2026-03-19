[`< Back`](./)

---

# ConfigListDataPowder

Namespace: BurnSoft.Applications.MLL.ConfigSheets

Class ConfigListDataPowder to work with the Config_List_Powder_Data_NSG ( Metalic ) 
 table for shotgun see ConfigListDataPowderShotGun

```csharp
public class ConfigListDataPowder
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ConfigListDataPowder](./burnsoft.applications.mll.configsheets.configlistdatapowder)

## Constructors

### **ConfigListDataPowder()**

```csharp
public ConfigListDataPowder()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<ConfigListPowderData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListPowderData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListPowderData&gt;.

### **GetId(String, Int32, String&)**

Gets the identifier.

```csharp
public static long GetId(string databasePath, int ConfigNameId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`ConfigNameId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The configuration name identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetDetails(String, Int32, String&)**

Gets the details.

```csharp
public static List<ConfigListPowderData> GetDetails(string databasePath, int id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListPowderData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListPowderData&gt;.

### **GetDefaultPowderId(String, Int32, Double&, Nullable`1&, String&)**

Gets the default powder.

```csharp
public static long GetDefaultPowderId(string databasePath, int configId, Double& powderLoad, Nullable`1& fps, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The configuration identifier.

`powderLoad` [Double&](https://docs.microsoft.com/en-us/dotnet/api/system.double&)<br>
The powder load.

`fps` [Nullable`1&](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1&)<br>
The FPS.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetDefaultPowderId(String, Int32, Double&, String&)**

Gets the default powder identifier.

```csharp
public static long GetDefaultPowderId(string databasePath, int configId, Double& powderLoad, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The configuration identifier.

`powderLoad` [Double&](https://docs.microsoft.com/en-us/dotnet/api/system.double&)<br>
The powder load.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetDetails(String, Int64, String&)**

Gets the details.

```csharp
public static List<ConfigListPowderData> GetDetails(string databasePath, long Configid, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`Configid` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configid.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListPowderData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListPowderData&gt;.

### **DataExists(String, String&)**

Datas the exists.

```csharp
public static bool DataExists(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **DataExists(String, Int64, String&)**

Datas the exists.

```csharp
public static bool DataExists(string databasePath, long Configid, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`Configid` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configid.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, Int64, Int64, Double, Double, Double, Double, Double, Double, Double, Double, Double, Boolean, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, long ConfgNameId, long PowderId, double LoadMin, double LoadMid, double LoadMax, double FpsMin, double FpsMid, double FpsMax, double CupsMin, double CupsMid, double CupsMax, bool isDefault, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`ConfgNameId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The confg name identifier.

`PowderId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The powder identifier.

`LoadMin` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The load minimum.

`LoadMid` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The load mid.

`LoadMax` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The load maximum.

`FpsMin` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The FPS minimum.

`FpsMid` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The FPS mid.

`FpsMax` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The FPS maximum.

`CupsMin` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The cups minimum.

`CupsMid` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The cups mid.

`CupsMax` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The cups maximum.

`isDefault` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is default].

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Update(String, Int64, Int64, Int64, Double, Double, Double, Double, Double, Double, Double, Double, Double, Boolean, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, long ConfgNameId, long PowderId, double LoadMin, double LoadMid, double LoadMax, double FpsMin, double FpsMid, double FpsMax, double CupsMin, double CupsMid, double CupsMax, bool isDefault, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`ConfgNameId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The confg name identifier.

`PowderId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The powder identifier.

`LoadMin` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The load minimum.

`LoadMid` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The load mid.

`LoadMax` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The load maximum.

`FpsMin` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The FPS minimum.

`FpsMid` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The FPS mid.

`FpsMax` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The FPS maximum.

`CupsMin` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The cups minimum.

`CupsMid` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The cups mid.

`CupsMax` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The cups maximum.

`isDefault` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is default].

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Delete(String, Int64, String&)**

Deletes the specified database path.

```csharp
public static bool Delete(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

---

[`< Back`](./)

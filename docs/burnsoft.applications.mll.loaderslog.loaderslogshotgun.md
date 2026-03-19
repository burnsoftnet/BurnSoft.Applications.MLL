[`< Back`](./)

---

# LoadersLogShotgun

Namespace: BurnSoft.Applications.MLL.LoadersLog

Class LoadersLogShotgun handles the data in the Loaders_Log_SG table..

```csharp
public class LoadersLogShotgun
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [LoadersLogShotgun](./burnsoft.applications.mll.loaderslog.loaderslogshotgun)

## Constructors

### **LoadersLogShotgun()**

```csharp
public LoadersLogShotgun()
```

## Methods

### **GetDetails(String, Int32, String&)**

Gets the details.

```csharp
public static List<LoadersLogShotgunData> GetDetails(string databasePath, int id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogShotgunData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogShotgunData&gt;.

### **GetDetails(String, String, String, String&)**

Gets the details.

```csharp
public static List<LoadersLogShotgunData> GetDetails(string databasePath, string configName, string dateCreated, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the configuration.

`dateCreated` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The date created.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogShotgunData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogShotgunData&gt;.

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<LoadersLogShotgunData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogShotgunData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogShotgunData&gt;.

### **GetId(String, String, String, String&)**

Gets the identifier.

```csharp
public static long GetId(string databasePath, string configName, string dateCreated, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the configuration.

`dateCreated` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The date created.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

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

### **DataExists(String, String, String, String&)**

Datas the exists.

```csharp
public static bool DataExists(string databasePath, string configName, string dateCreated, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the configuration.

`dateCreated` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The date created.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, Int64, String, String, String, String, String, String, String, String, String, String, String, String, Int32, String, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, long firearmId, string fireArmName, string caliber, string BarrelLenght, string ConfigName, string dateCreated, string shotWeight, string shotSize, string caseDetails, string powderDetails, string wadDetails, string primerDetails, string patterDensity, int yards, string notes, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`firearmId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The firearm identifier.

`fireArmName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the fire arm.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

`BarrelLenght` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The barrel lenght.

`ConfigName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the configuration.

`dateCreated` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The date created.

`shotWeight` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The shot weight.

`shotSize` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Size of the shot.

`caseDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The case details.

`powderDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The powder details.

`wadDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The wad details.

`primerDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The primer details.

`patterDensity` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The patter density.

`yards` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The yards.

`notes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The notes.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Update(String, Int64, Int64, String, String, String, String, String, String, String, String, String, String, String, String, Int32, String, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, long firearmId, string fireArmName, string caliber, string BarrelLenght, string ConfigName, string dateCreated, string shotWeight, string shotSize, string caseDetails, string powderDetails, string wadDetails, string primerDetails, string patterDensity, int yards, string notes, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`firearmId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The firearm identifier.

`fireArmName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the fire arm.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

`BarrelLenght` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The barrel lenght.

`ConfigName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the configuration.

`dateCreated` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The date created.

`shotWeight` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The shot weight.

`shotSize` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Size of the shot.

`caseDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The case details.

`powderDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The powder details.

`wadDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The wad details.

`primerDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The primer details.

`patterDensity` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The patter density.

`yards` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The yards.

`notes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The notes.

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

### **Delete(String, String, String, String&)**

Deletes the specified database path.

```csharp
public static bool Delete(string databasePath, string configName, string dateCreated, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the configuration.

`dateCreated` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The date created.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

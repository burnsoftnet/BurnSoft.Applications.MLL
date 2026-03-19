[`< Back`](./)

---

# LoadersLogMetallic

Namespace: BurnSoft.Applications.MLL.LoadersLog

Class LoadersLogMetallic handles the data in the Loaders_Log_NSG table.

```csharp
public class LoadersLogMetallic
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [LoadersLogMetallic](./burnsoft.applications.mll.loaderslog.loaderslogmetallic)

## Constructors

### **LoadersLogMetallic()**

```csharp
public LoadersLogMetallic()
```

## Methods

### **GetDetails(String, Int32, String&)**

Gets the details.

```csharp
public static List<LoadersLogMetallicData> GetDetails(string databasePath, int id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogMetallicData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogMetallicData&gt;.

### **GetDetails(String, String, String, String&)**

Gets the details.

```csharp
public static List<LoadersLogMetallicData> GetDetails(string databasePath, string configName, string dateCreated, String& errOut)
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

[List&lt;LoadersLogMetallicData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogMetallicData&gt;.

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<LoadersLogMetallicData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogMetallicData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogMetallicData&gt;.

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

### **Add(String, Int64, String, Int32, String, Int32, String, String, String, String, String, String, String, String, String, String, String, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, long firearmId, string dateCreated, int yards, string groupSize, int numberOfShots, string powderDetails, string bulletDetails, string primerDetails, string caseDetails, string condition, string oal, string notes, string configName, string FirearmName, string caliber, string BarrelLenght, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`firearmId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The firearm identifier.

`dateCreated` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The date created.

`yards` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The yards.

`groupSize` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Size of the group.

`numberOfShots` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of shots.

`powderDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The powder details.

`bulletDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The bullet details.

`primerDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The primer details.

`caseDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The case details.

`condition` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The condition.

`oal` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The oal.

`notes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The notes.

`configName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the configuration.

`FirearmName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the firearm.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

`BarrelLenght` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The barrel lenght.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Update(String, Int64, Int64, String, Int32, String, Int32, String, String, String, String, String, String, String, String, String, String, String, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, long firearmId, string dateCreated, int yards, string groupSize, int numberOfShots, string powderDetails, string bulletDetails, string primerDetails, string caseDetails, string condition, string oal, string notes, string configName, string FirearmName, string caliber, string BarrelLenght, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`firearmId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The firearm identifier.

`dateCreated` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The date created.

`yards` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The yards.

`groupSize` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Size of the group.

`numberOfShots` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of shots.

`powderDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The powder details.

`bulletDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The bullet details.

`primerDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The primer details.

`caseDetails` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The case details.

`condition` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The condition.

`oal` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The oal.

`notes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The notes.

`configName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the configuration.

`FirearmName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the firearm.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

`BarrelLenght` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The barrel lenght.

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

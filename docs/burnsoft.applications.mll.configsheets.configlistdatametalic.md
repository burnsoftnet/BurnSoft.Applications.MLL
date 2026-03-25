[`< Back`](./)

---

# ConfigListDataMetalic

Namespace: BurnSoft.Applications.MLL.ConfigSheets

Class ConfigListDataMetalic helps manahe the data on 
 the Config_List_Data_NSG table

```csharp
public class ConfigListDataMetalic
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ConfigListDataMetalic](./burnsoft.applications.mll.configsheets.configlistdatametalic)

## Constructors

### **ConfigListDataMetalic()**

```csharp
public ConfigListDataMetalic()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<ConfigListDataMetalicData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListDataMetalicData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListDataMetalicData&gt;.

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
public static List<ConfigListDataMetalicData> GetDetails(string databasePath, int id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListDataMetalicData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListDataMetalicData&gt;.

### **GetDetails(String, Int64, String&)**

Gets the details.

```csharp
public static List<ConfigListDataMetalicData> GetDetails(string databasePath, long Configid, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`Configid` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configid.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListDataMetalicData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListDataMetalicData&gt;.

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

### **Add(String, Int32, Int32, Int32, Int32, Int32, Int32, String, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, int ConfgNameId, int AmmoTypeId, int CaliberId, int BulletId, int PrimerId, int CaseId, string source, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`ConfgNameId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The confg name identifier.

`AmmoTypeId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The ammo type identifier.

`CaliberId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The caliber identifier.

`BulletId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The bullet identifier.

`PrimerId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The primer identifier.

`CaseId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The case identifier.

`source` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The source.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **CopyConfig(String, Int32, Int64, String&)**

Copies the configuration of the given config id and copies all the data from the old.

```csharp
public static bool CopyConfig(string databasePath, int newConfigId, long oldConfigId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`newConfigId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The new configuration identifier.

`oldConfigId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The old configuration identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Update(String, Int64, Int32, Int32, Int32, Int32, Int32, Int32, String, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, int ConfgNameId, int AmmoTypeId, int CaliberId, int BulletId, int PrimerId, int CaseId, string source, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`ConfgNameId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The confg name identifier.

`AmmoTypeId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The ammo type identifier.

`CaliberId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The caliber identifier.

`BulletId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The bullet identifier.

`PrimerId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The primer identifier.

`CaseId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The case identifier.

`source` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The source.

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

### **DeleteByConfigId(String, Int64, String&)**

Deletes the by configuration identifier which will delete all the powder using the config id.

```csharp
public static bool DeleteByConfigId(string databasePath, long id, String& errOut)
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

[`< Back`](./)

---

# ConfigListDataShotgun

Namespace: BurnSoft.Applications.MLL.ConfigSheets

Class ConfigListDataShotgun to handle the data 
 in the Config_List_Data_SG table

```csharp
public class ConfigListDataShotgun
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ConfigListDataShotgun](./burnsoft.applications.mll.configsheets.configlistdatashotgun)

## Constructors

### **ConfigListDataShotgun()**

```csharp
public ConfigListDataShotgun()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<ConfigListDataShotgunData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListDataShotgunData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListDataShotgunData&gt;.

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
public static List<ConfigListDataShotgunData> GetDetails(string databasePath, int id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListDataShotgunData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListDataShotgunData&gt;.

### **GetDetails(String, Int64, String&)**

Gets the details.

```csharp
public static List<ConfigListDataShotgunData> GetDetails(string databasePath, long Configid, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`Configid` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configid.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListDataShotgunData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListDataShotgunData&gt;.

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

### **Add(String, Int32, Int32, Int32, Int32, Int32, Double, String, Int64, Int64, Int64, Int64, String, Int64, Boolean, Int64, Int64, Int64, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, int ConfgNameId, int AmmoTypeId, int CaliberId, int PrimerId, int CaseId, double shotWeight, string shotWeightText, long shotSize, long bushing, long wad, long shotChargeLoad, string source, long gunId, bool isPersonal, long listTypeId, long bushingId, long chargeBarId, String& errOut)
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

`PrimerId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The primer identifier.

`CaseId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The case identifier.

`shotWeight` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The shot weight.

`shotWeightText` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The shot weight text.

`shotSize` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
Size of the shot.

`bushing` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The bushing.

`wad` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The wad.

`shotChargeLoad` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The shot charge load.

`source` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The source.

`gunId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The gun identifier.

`isPersonal` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is personal].

`listTypeId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The list type identifier.

`bushingId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The bushing identifier.

`chargeBarId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The charge bar identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Update(String, Int64, Int32, Int32, Int32, Int32, Int32, Double, String, Int64, Int64, Int64, Int64, String, Int64, Boolean, Int64, Int64, Int64, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, int ConfgNameId, int AmmoTypeId, int CaliberId, int PrimerId, int CaseId, double shotWeight, string shotWeightText, long shotSize, long bushing, long wad, long shotChargeLoad, string source, long gunId, bool isPersonal, long listTypeId, long bushingId, long chargeBarId, String& errOut)
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

`PrimerId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The primer identifier.

`CaseId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The case identifier.

`shotWeight` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The shot weight.

`shotWeightText` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The shot weight text.

`shotSize` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
Size of the shot.

`bushing` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The bushing.

`wad` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The wad.

`shotChargeLoad` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The shot charge load.

`source` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The source.

`gunId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The gun identifier.

`isPersonal` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is personal].

`listTypeId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The list type identifier.

`bushingId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The bushing identifier.

`chargeBarId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The charge bar identifier.

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

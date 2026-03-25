[`< Back`](./)

---

# LoadersLogAmmunitionAudit

Namespace: BurnSoft.Applications.MLL.LoadersLog

Class LoadersLogAmmunition handles the data in the 
 Loaders_Log_Ammunition_Audit_Audit

```csharp
public class LoadersLogAmmunitionAudit
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [LoadersLogAmmunitionAudit](./burnsoft.applications.mll.loaderslog.loaderslogammunitionaudit)

## Constructors

### **LoadersLogAmmunitionAudit()**

```csharp
public LoadersLogAmmunitionAudit()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<LoadersLogAmmunitionAuditData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogAmmunitionAuditData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogAmmunitionAuditData&gt;.

### **GetId(String, Int64, String&)**

Gets the identifier.

```csharp
public static long GetId(string databasePath, long configId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configuration identifier.

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
public static List<LoadersLogAmmunitionAuditData> GetDetails(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogAmmunitionAuditData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogAmmunitionAuditData&gt;.

### **GetDetails(String, Int32, String&)**

Gets the details.

```csharp
public static List<LoadersLogAmmunitionAuditData> GetDetails(string databasePath, int configId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The configuration identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogAmmunitionAuditData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogAmmunitionAuditData&gt;.

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
public static bool DataExists(string databasePath, long id, String& errOut)
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

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **DataExists(String, Int32, String&)**

Datas the exists.

```csharp
public static bool DataExists(string databasePath, int configId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The configuration identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, Int64, String, Int64, Double, Double, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, long configId, string dateCreated, long qty, double estimatedTotalCost, double estimatedCostPerRound, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configuration identifier.

`dateCreated` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The date created.

`qty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The qty.

`estimatedTotalCost` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The estimated total cost.

`estimatedCostPerRound` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The estimated cost per round.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Update(String, Int64, Int64, String, Int64, Double, Double, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, long configId, string dateCreated, long qty, double estimatedTotalCost, double estimatedCostPerRound, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`configId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configuration identifier.

`dateCreated` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The date created.

`qty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The qty.

`estimatedTotalCost` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The estimated total cost.

`estimatedCostPerRound` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The estimated cost per round.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

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

### **Delete(String, Int32, String&)**

Deletes the specified database path.

```csharp
public static bool Delete(string databasePath, int configId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The configuration identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **DeleteByConfigId(String, Int64, String&)**

Deletes the by configuration identifier.

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

[`< Back`](./)

---

# ShotgunData

Namespace: BurnSoft.Applications.MLL.Search

Class ShotgunData to handle the data in the Search_Fields_SG_SG table

```csharp
public class ShotgunData
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ShotgunData](./burnsoft.applications.mll.search.shotgundata)

## Constructors

### **ShotgunData()**

```csharp
public ShotgunData()
```

## Methods

### **GetDetails(String, Int32, String&)**

Gets the details.

```csharp
public static List<SearchFieldsData> GetDetails(string databasePath, int id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;SearchFieldsData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;SearchFieldsData&gt;.

### **GetDetails(String, String, String&)**

Gets the details.

```csharp
public static List<SearchFieldsData> GetDetails(string databasePath, string description, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The description.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;SearchFieldsData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;SearchFieldsData&gt;.

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<SearchFieldsData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;SearchFieldsData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;SearchFieldsData&gt;.

### **GetId(String, String, String&)**

Gets the identifier.

```csharp
public static long GetId(string databasePath, string description, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The description.

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

### **DataExists(String, String, String&)**

Datas the exists.

```csharp
public static bool DataExists(string databasePath, string description, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The description.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, String, String, String, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, string description, string columnName, string columnType, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The description.

`columnName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the column.

`columnType` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Type of the column.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Update(String, Int64, String, String, String, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, string description, string columnName, string columnType, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The description.

`columnName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the column.

`columnType` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Type of the column.

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

### **Delete(String, String, String&)**

Deletes the specified database path.

```csharp
public static bool Delete(string databasePath, string description, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`description` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The description.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

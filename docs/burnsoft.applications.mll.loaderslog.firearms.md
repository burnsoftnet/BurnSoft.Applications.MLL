[`< Back`](./)

---

# Firearms

Namespace: BurnSoft.Applications.MLL.LoadersLog

Class Firearms which handles the local collection for 
 the loaders log firearms that is used

```csharp
public class Firearms
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Firearms](./burnsoft.applications.mll.loaderslog.firearms)

## Constructors

### **Firearms()**

```csharp
public Firearms()
```

## Methods

### **GetDetails(String, Int32, String&)**

Gets the details of the selected firearm

```csharp
public static List<FirearmCollection> GetDetails(string databasePath, int id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;FirearmCollection&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;FirearmCollection&gt;.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetDetails(String, String, String&)**

Gets the details.

```csharp
public static List<FirearmCollection> GetDetails(string databasePath, string fullName, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`fullName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;FirearmCollection&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;FirearmCollection&gt;.

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<FirearmCollection> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;FirearmCollection&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;FirearmCollection&gt;.

### **GetId(String, String, String&)**

Gets the firearm identifier.

```csharp
public static long GetId(string databasePath, string fullName, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`fullName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full name.

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
public static bool DataExists(string databasePath, string fullName, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`fullName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, String, String, String, String, String, String, String&, Int32, Boolean, String)**

Adds the firearm to the loaders log table to use for sample logging testing.

```csharp
public static bool Add(string databasePath, string manufacturer, string model, string serial, string caliber, string type, string barrel, String& errOut, int mgcId, bool exclude, string fullName)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`model` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The model.

`serial` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The serial.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

`type` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The type.

`barrel` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The barrel.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

`mgcId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The MGC identifier.

`exclude` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [exclude].

`fullName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full name.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Update(String, Int64, String, String, String, String, String, String, String&, Int32, Boolean, String)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, string manufacturer, string model, string serial, string caliber, string type, string barrel, String& errOut, int mgcId, bool exclude, string fullName)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`model` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The model.

`serial` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The serial.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

`type` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The type.

`barrel` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The barrel.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

`mgcId` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The MGC identifier.

`exclude` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [exclude].

`fullName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full name.

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
public static bool Delete(string databasePath, string fullName, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`fullName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

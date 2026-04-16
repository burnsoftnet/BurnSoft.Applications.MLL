[`< Back`](./)

---

# LoadersLogAmmunition

Namespace: BurnSoft.Applications.MLL.LoadersLog

Class LoadersLogAmmunition handles the data in the 
 Loaders_Log_Ammunition Table which is where the 
 Make Ammunition function stores the ammo to ether 
 track on your own or export to the My Gun 
 Collection application

```csharp
public class LoadersLogAmmunition
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [LoadersLogAmmunition](./burnsoft.applications.mll.loaderslog.loaderslogammunition)

## Constructors

### **LoadersLogAmmunition()**

```csharp
public LoadersLogAmmunition()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<LoadersLogAmmunitionData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogAmmunitionData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogAmmunitionData&gt;.

### **GetId(String, String, String, String&)**

Gets the identifier.

```csharp
public static long GetId(string databasePath, string manufacturer, string name, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetName(String, Int64, String&)**

Gets the name.

```csharp
public static string GetName(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
System.String.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetDetails(String, String, String, String&)**

Gets the details.

```csharp
public static List<LoadersLogAmmunitionData> GetDetails(string databasePath, string manufacturer, string name, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogAmmunitionData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogAmmunitionData&gt;.

### **GetDetails(String, Int64, String&)**

Gets the details.

```csharp
public static List<LoadersLogAmmunitionData> GetDetails(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoadersLogAmmunitionData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoadersLogAmmunitionData&gt;.

### **IsAlreadyListed(String, String, String, String, String, String, String&, Int64&, Int64&)**

Determines whether the ammo is already listed in the ammo log from the make ready functions 
 based on all the fields that is passed. If it is then it will also return the qty and 
 ammo ID so you can updated the table accordingly.

```csharp
public static bool IsAlreadyListed(string databasePath, string manufacturer, string name, string caliber, string grain, string jacket, String& errOut, Int64& qty, Int64& ammoId)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

`grain` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The grain.

`jacket` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The jacket.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

`qty` [Int64&](https://docs.microsoft.com/en-us/dotnet/api/system.int64&)<br>
The qty.

`ammoId` [Int64&](https://docs.microsoft.com/en-us/dotnet/api/system.int64&)<br>
The ammo identifier.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if [is already listed] [the specified database path]; otherwise, `false`.

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
public static bool DataExists(string databasePath, string manufacturer, string name, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, String, String, String, String, String, Int64, Int32, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, string manufacturer, string name, string caliber, string grain, string jacket, long qty, int velocity, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

`grain` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The grain.

`jacket` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The jacket.

`qty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The qty.

`velocity` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The velocity.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Update(String, Int64, String, String, String, String, String, Int64, Int32, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, string manufacturer, string name, string caliber, string grain, string jacket, long qty, int velocity, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

`grain` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The grain.

`jacket` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The jacket.

`qty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The qty.

`velocity` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The velocity.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **UpdateQty(String, Int64, Int64, String&)**

Updates the qty.

```csharp
public static bool UpdateQty(string databasePath, long id, long newQty, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`newQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The new qty.

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
public static bool Delete(string databasePath, string manufacturer, string name, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

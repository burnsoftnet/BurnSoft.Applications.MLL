[`< Back`](./)

---

# ConfigListDataName

Namespace: BurnSoft.Applications.MLL.ConfigSheets

Class ConfigListDataName contains the functions to use to 
 interact with the data in the Config_List_Name table

```csharp
public class ConfigListDataName
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ConfigListDataName](./burnsoft.applications.mll.configsheets.configlistdataname)

## Constructors

### **ConfigListDataName()**

```csharp
public ConfigListDataName()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<ConfigNameList> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigNameList&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigNameList&gt;.

### **GetId(String, String, String&)**

Gets the identifier.

```csharp
public static long GetId(string databasePath, string name, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetDetails(String, String, String&)**

Gets the details.

```csharp
public static List<ConfigNameList> GetDetails(string databasePath, string name, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigNameList&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigNameList&gt;.

### **GetDetails(String, Int64, String&)**

Gets the details.

```csharp
public static List<ConfigNameList> GetDetails(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigNameList&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigNameList&gt;.

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
public static bool DataExists(string databasePath, string name, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, String, Boolean, Boolean, String, Boolean, Boolean, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, string name, bool isPersonal, bool isShotgun, string notes, bool isActive, bool isFavorite, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`isPersonal` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is personal].

`isShotgun` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is shotgun].

`notes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The notes.

`isActive` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is active].

`isFavorite` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is favorite].

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **CopyConfig(String, String, Int64, String&)**

Copies the configuration based on the old Configuration ID. This will created the new 
 name with the settings of the old and copy the General Details and Powder Details from that
 config id. And Based on the Setting of the Config that is being Copied, it will determine
 if it goes in the Metalic or shotgun config data tables.

```csharp
public static bool CopyConfig(string databasePath, string newConfigName, long oldConfigId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`newConfigName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
New name of the configuration.

`oldConfigId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The old configuration identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Update(String, Int64, String, Boolean, Boolean, String, Boolean, Boolean, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, string name, bool isPersonal, bool isShotgun, string notes, bool isActive, bool isFavorite, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`isPersonal` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is personal].

`isShotgun` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is shotgun].

`notes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The notes.

`isActive` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is active].

`isFavorite` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is favorite].

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Rename(String, Int64, String, String&)**

Renames the specified configuration based on the id

```csharp
public static bool Rename(string databasePath, long id, string name, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **SetActivity(String, Int64, Boolean, String&)**

Sets the activity of the config, when set to try it will show in the active section, when false it is archived.

```csharp
public static bool SetActivity(string databasePath, long id, bool isActive, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`isActive` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is active].

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **SetFavorite(String, Int64, Boolean, String&)**

Sets the favorite marker

```csharp
public static bool SetFavorite(string databasePath, long id, bool isFavorite, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`isFavorite` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is favorite].

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **SetPersonal(String, Int64, Boolean, String&)**

Sets the personal.

```csharp
public static bool SetPersonal(string databasePath, long id, bool isPersonal, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`isPersonal` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is personal].

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **UpdateNotes(String, Int64, String, String&)**

Updates the notes.

```csharp
public static bool UpdateNotes(string databasePath, long id, string value, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Delete(String, Int64, String&)**

Deletes The Configuration and all the data relating to it.

```csharp
public static bool Delete(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configuration identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Delete(String, String, String&)**

Deletes the specified database path.

```csharp
public static bool Delete(string databasePath, string name, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

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

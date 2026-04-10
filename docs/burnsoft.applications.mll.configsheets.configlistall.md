[`< Back`](./)

---

# ConfigListAll

Namespace: BurnSoft.Applications.MLL.ConfigSheets

Class ConfigListAll will get all the data related to the config 
 sheets and put them in a single list container

```csharp
public class ConfigListAll
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ConfigListAll](./burnsoft.applications.mll.configsheets.configlistall)

## Constructors

### **ConfigListAll()**

```csharp
public ConfigListAll()
```

## Methods

### **Metallic(String, Int64, String&)**

Metallics the specified database path.

```csharp
public static List<ConfigListAllMetallicData> Metallic(string databasePath, long configId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configuration identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListAllMetallicData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListAllMetallicData&gt;.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Shotgun(String, Int64, String&)**

Shotguns the specified database path.

```csharp
public static List<ConfigListAllShotgunData> Shotgun(string databasePath, long configId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configuration identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ConfigListAllShotgunData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ConfigListAllShotgunData&gt;.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

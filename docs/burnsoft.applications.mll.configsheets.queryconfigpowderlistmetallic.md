[`< Back`](./)

---

# QueryConfigPowderListMetallic

Namespace: BurnSoft.Applications.MLL.ConfigSheets

Class QueryConfigPowderListMetallic data handler for the qry_CFG_SR_PowderList query

```csharp
public class QueryConfigPowderListMetallic
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [QueryConfigPowderListMetallic](./burnsoft.applications.mll.configsheets.queryconfigpowderlistmetallic)

## Constructors

### **QueryConfigPowderListMetallic()**

```csharp
public QueryConfigPowderListMetallic()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<QueryConfigPowderListData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;QueryConfigPowderListData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;QueryConfigPowderListData&gt;.

### **GetDetails(String, String, String&)**

Gets the details.

```csharp
public static List<QueryConfigPowderListData> GetDetails(string databasePath, string name, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;QueryConfigPowderListData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;QueryConfigPowderListData&gt;.

### **GetDetails(String, Int64, String&)**

Gets the details.

```csharp
public static List<QueryConfigPowderListData> GetDetails(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;QueryConfigPowderListData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;QueryConfigPowderListData&gt;.

---

[`< Back`](./)

[`< Back`](./)

---

# WadInventory

Namespace: BurnSoft.Applications.MLL.Inventory

Class WadInventory handles the data in the List_SG_WAD table

```csharp
public class WadInventory
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [WadInventory](./burnsoft.applications.mll.inventory.wadinventory)

## Constructors

### **WadInventory()**

```csharp
public WadInventory()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<WadData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;WadData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;WadData&gt;.

### **GetId(String, String, String, String, String&)**

Gets the identifier.

```csharp
public static long GetId(string databasePath, string manufacturer, string name, string gauge, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`gauge` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The gauge.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetDetails(String, String, String, String, String&)**

Gets the details.

```csharp
public static List<WadData> GetDetails(string databasePath, string manufacturer, string name, string gauge, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`gauge` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The gauge.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;WadData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;WadData&gt;.

### **GetDetails(String, Int64, String&)**

Gets the details.

```csharp
public static List<WadData> GetDetails(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;WadData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;WadData&gt;.

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

### **DataExists(String, String, String, String, String&)**

Datas the exists.

```csharp
public static bool DataExists(string databasePath, string manufacturer, string name, string gauge, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`gauge` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The gauge.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, String, String, String, Int64, String, Int32, Double, String&, Boolean)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, string manufacturer, string name, string gauge, long gaugeId, string load, int qty, double price, String& errOut, bool preFluffEn)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`gauge` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The gauge.

`gaugeId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The gun identifier.

`load` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The load.

`qty` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The qty.

`price` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

`preFluffEn` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [pre fluff en].

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Update(String, Int64, String, String, String, Int64, String, Int32, Double, String&, Boolean)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, string manufacturer, string name, string gauge, long guageId, string load, int qty, double price, String& errOut, bool preFluffEn)
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

`gauge` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The gauge.

`guageId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The guage identifier.

`load` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The load.

`qty` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The qty.

`price` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

`preFluffEn` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [pre fluff en].

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Update(String, Int64, Int32, Double, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, int qty, double price, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`qty` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The qty.

`price` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **UpdateQty(String, Int64, Int32, Double, Double, Int32, Double, String&)**

Updates the qty.

```csharp
public static bool UpdateQty(string databasePath, long id, int currentQty, double currentPrice, double currentPricePerItem, int newQty, double NewPrice, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`currentQty` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The current qty.

`currentPrice` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The current price.

`currentPricePerItem` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The current price per item.

`newQty` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The new qty.

`NewPrice` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
Creates new price.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **UpdateQty(String, Int64, Int32, String&)**

Updates the qty.

```csharp
public static bool UpdateQty(string databasePath, long id, int newQty, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`newQty` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
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

### **Delete(String, String, String, String, String&)**

Deletes the specified database path.

```csharp
public static bool Delete(string databasePath, string manufacturer, string name, string gauge, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`gauge` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The gauge.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

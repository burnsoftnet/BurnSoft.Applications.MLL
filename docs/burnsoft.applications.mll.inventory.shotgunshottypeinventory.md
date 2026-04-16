[`< Back`](./)

---

# ShotgunShotTypeInventory

Namespace: BurnSoft.Applications.MLL.Inventory

Class ShotgunShotTypeInventory handles the data in 
 the List_SG_ShotType_Details table

```csharp
public class ShotgunShotTypeInventory
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ShotgunShotTypeInventory](./burnsoft.applications.mll.inventory.shotgunshottypeinventory)

## Constructors

### **ShotgunShotTypeInventory()**

```csharp
public ShotgunShotTypeInventory()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<ShotgunShotTypeData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ShotgunShotTypeData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ShotgunShotTypeData&gt;.

### **GetId(String, String, String, String, String&)**

Gets the identifier.

```csharp
public static long GetId(string databasePath, string manufacturer, string name, string materialUsed, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`materialUsed` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The material used.

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

### **GetDetails(String, String, String, String, String&)**

Gets the details.

```csharp
public static List<ShotgunShotTypeData> GetDetails(string databasePath, string manufacturer, string name, string materialUsed, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`materialUsed` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The material used.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ShotgunShotTypeData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ShotgunShotTypeData&gt;.

### **GetDetails(String, Int64, String&)**

Gets the details.

```csharp
public static List<ShotgunShotTypeData> GetDetails(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;ShotgunShotTypeData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;ShotgunShotTypeData&gt;.

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
public static bool DataExists(string databasePath, string manufacturer, string name, string materialUsed, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`materialUsed` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The material used.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, String, String, String, String, Boolean, String, String, Int32, Double, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, string manufacturer, string name, string materialUsed, string weight, bool isSlug, string shotNumber, string caliber, int qty, double price, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`materialUsed` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The material used.

`weight` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The weight.

`isSlug` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is slug].

`shotNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The shot number.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

`qty` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The qty.

`price` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **ConvertValueTo(String, WeightTypes)**

Converts the value to for the weight types, but this might already exist. just need to 
 look around in the code.

```csharp
public static double ConvertValueTo(string value, WeightTypes type)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

`type` [WeightTypes](./burnsoft.applications.mll.enums.weighttypes)<br>
The type.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
System.Double.

### **GetWeightType(String)**

Gets the type of the weight base on the weight string passed where first 
 part is numeric and the second part is the weight type.

```csharp
public static WeightTypes GetWeightType(string value)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

#### Returns

[WeightTypes](./burnsoft.applications.mll.enums.weighttypes)<br>
WeightTypes.

### **Update(String, Int64, String, String, String, String, Boolean, String, String, Int32, Double, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, string manufacturer, string name, string materialUsed, string weight, bool isSlug, string shotNumber, string caliber, int qty, double price, String& errOut)
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

`materialUsed` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The material used.

`weight` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The weight.

`isSlug` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is slug].

`shotNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The shot number.

`caliber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber details.

`qty` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The qty.

`price` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **UpdateSlugQty(String, Int64, Int64, String&)**

Updates the qty for a slug

```csharp
public static bool UpdateSlugQty(string databasePath, long id, long newQty, String& errOut)
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

### **UpdateQty(String, Int64, Double, Double, Double, String&)**

Updates the qty.

```csharp
public static bool UpdateQty(string databasePath, long id, double newShotOz, double newShotGrains, double newShotPounds, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`newShotOz` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The new shot oz.

`newShotGrains` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The new shot grains.

`newShotPounds` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The new shot pounds.

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

### **UpdateQtySlug(String, Int64, Int32, Double, Double, Int32, Double, String&)**

Updates the qty slug.

```csharp
public static bool UpdateQtySlug(string databasePath, long id, int currentQty, double currentPrice, double currentPricePerItem, int newQty, double NewPrice, String& errOut)
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
public static bool Delete(string databasePath, string manufacturer, string name, string materialUsed, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`materialUsed` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The material used.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

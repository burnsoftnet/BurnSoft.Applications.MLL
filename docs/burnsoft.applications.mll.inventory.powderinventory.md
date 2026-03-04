[`< Back`](./)

---

# PowderInventory

Namespace: BurnSoft.Applications.MLL.Inventory

Class PowderInventory to work with the data in the General_Powder Table.

```csharp
public class PowderInventory
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PowderInventory](./burnsoft.applications.mll.inventory.powderinventory)

## Constructors

### **PowderInventory()**

```csharp
public PowderInventory()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<PowderListing> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;PowderListing&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;PowderListing&gt;.

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

### **GetDetails(String, String, String, String&)**

Gets the details.

```csharp
public static List<PowderListing> GetDetails(string databasePath, string manufacturer, string name, String& errOut)
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

[List&lt;PowderListing&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;PowderListing&gt;.

### **GetDetails(String, Int64, String&)**

Gets the details.

```csharp
public static List<PowderListing> GetDetails(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;PowderListing&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;PowderListing&gt;.

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

### **Add(String, String, String, Double, Double, String, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, string manufacturer, string name, double weightInPounds, double price, string notes, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`weightInPounds` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The weight in pounds.

`price` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

`notes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The notes.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Update(String, Int64, String, String, Double, Double, String, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, string manufacturer, string name, double weightInPounds, double price, string notes, String& errOut)
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

`weightInPounds` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The weight in pounds.

`price` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

`notes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The notes.

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

### **CalculatePricePerItem(Double, Double, PowderWeightType, Boolean)**

Calculates the price per item.

```csharp
public static double CalculatePricePerItem(double weightValue, double price, PowderWeightType VolumeType, bool useDollar)
```

#### Parameters

`weightValue` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The weight value.

`price` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

`VolumeType` [PowderWeightType](./burnsoft.applications.mll.enums.powderweighttype)<br>
Type of the of weight: Grains (grs) , Pounds (lbs).

`useDollar` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Use the Dollar amount to get the doube with 2 decimal places, 
 when set to false it will give you the full double.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
System.Double.

### **UpdateQty(String, Int64, Double, Double, Double, Double, Double, Double, PowderWeightType, String&)**

Updates the qty and price per item using the current qty in inventory and adding the new item details in stock

```csharp
public static bool UpdateQty(string databasePath, long id, double currentQty, double currentGrains, double currentPrice, double currentPricePerItem, double newQty, double newPrice, PowderWeightType VolumeType, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`currentQty` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The current qy.

`currentGrains` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The current grains.

`currentPrice` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The current price.

`currentPricePerItem` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The current price per item.

`newQty` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The new qty.

`newPrice` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The new price.

`VolumeType` [PowderWeightType](./burnsoft.applications.mll.enums.powderweighttype)<br>
Type of the volume.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

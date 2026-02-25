[`< Back`](./)

---

# BulletsInventory

Namespace: BurnSoft.Applications.MLL.Inventory

Class Bullets handles the ability to interact with the List_Bullets Table

```csharp
public class BulletsInventory
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BulletsInventory](./burnsoft.applications.mll.inventory.bulletsinventory)

## Constructors

### **BulletsInventory()**

```csharp
public BulletsInventory()
```

## Methods

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<BulletListings> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;BulletListings&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;BulletListings&gt;.

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
public static List<BulletListings> GetDetails(string databasePath, string manufacturer, string name, String& errOut)
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

[List&lt;BulletListings&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;BulletListings&gt;.

### **GetDetails(String, Int64, String&)**

Gets the details.

```csharp
public static List<BulletListings> GetDetails(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;BulletListings&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;BulletListings&gt;.

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

### **Add(String, String, String, String, String, String, String, String, Int32, Int32, Double, Int64, String&)**

Adds The new bullet information to the database

```csharp
public static bool Add(string databasePath, string manufacturer, string name, string diameter, string weight, string sectionalDensity, string partNumber, string bc, int bulletType, int qty, double price, long caliberId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`diameter` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The diameter.

`weight` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The weight.

`sectionalDensity` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The sectional density.

`partNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The part number.

`bc` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The bc.

`bulletType` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
Type of the bullet.

`qty` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The qty.

`price` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

`caliberId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The caliber identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Update(String, Int64, String, String, String, String, String, String, String, Int32, Int32, Double, Int64, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, string manufacturer, string name, string diameter, string weight, string sectionalDensity, string partNumber, string bc, int bulletType, int qty, double price, long caliberId, String& errOut)
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

`diameter` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The diameter.

`weight` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The weight.

`sectionalDensity` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The sectional density.

`partNumber` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The part number.

`bc` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The bc.

`bulletType` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
Type of the bullet.

`qty` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The qty.

`price` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

`caliberId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The caliber identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Update(String, Int64, Int32, Double, String&)**

Updates the BUllet information when you just jabe to update the price and qty which 
 will adjust the estimated price per bullet.

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

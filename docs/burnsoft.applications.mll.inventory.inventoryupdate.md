[`< Back`](./)

---

# InventoryUpdate

Namespace: BurnSoft.Applications.MLL.Inventory

Class InventoryUpdate does just that functions ot update the 
 inventory when you make some ammo

```csharp
public class InventoryUpdate
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [InventoryUpdate](./burnsoft.applications.mll.inventory.inventoryupdate)

## Constructors

### **InventoryUpdate()**

```csharp
public InventoryUpdate()
```

## Methods

### **MetallicUpdate(String, Int64, Int64, Int64, Int64, Int64, Int64, Int64, Double, Int64, Double, String&)**

Metallics the update qty for items used in make laoded ammunition process

```csharp
public static bool MetallicUpdate(string databasePath, long qtyMade, long bulletsInStockQty, long bulletId, long primersInStockQty, long primerId, long caseInStockQty, long caseId, double powderInStockGrains, long perfferedPowderId, double midRangePowderUsed, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`qtyMade` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The qty made.

`bulletsInStockQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The bullets in stock qty.

`bulletId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The bullet identifier.

`primersInStockQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The primers in stock qty.

`primerId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The primer identifier.

`caseInStockQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The case in stock qty.

`caseId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The case identifier.

`powderInStockGrains` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The powder in stock grains.

`perfferedPowderId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The perffered powder identifier.

`midRangePowderUsed` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The mid range powder used.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **ShotgunUpdate(String, Int64, Int64, Int64, Boolean, Double, Double, Double, Int64, Int64, Int64, Int64, Int64, Int64, Double, Int64, Double, String&)**

Shotguns the update qty for items used in make laoded ammunition process

```csharp
public static bool ShotgunUpdate(string databasePath, long qtyMade, long shotDetailsId, long shotDetailsQty, bool isSlug, double shotDetailsShotOz, double shotDetailsShotGrains, double shotDetailsMidRangeLoad, long wadsInStock, long wadsId, long primersInStockQty, long primerId, long caseInStockQty, long caseId, double powderInStockGrains, long perfferedPowderId, double midRangePowderUsed, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`qtyMade` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The qty made.

`shotDetailsId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The shot details identifier.

`shotDetailsQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The shot details qty.

`isSlug` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [is slug].

`shotDetailsShotOz` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The shot details shot oz.

`shotDetailsShotGrains` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The shot details shot grains.

`shotDetailsMidRangeLoad` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The shot details mid range load.

`wadsInStock` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The wads in stock.

`wadsId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The wads identifier.

`primersInStockQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The primers in stock qty.

`primerId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The primer identifier.

`caseInStockQty` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The case in stock qty.

`caseId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The case identifier.

`powderInStockGrains` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The powder in stock grains.

`perfferedPowderId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The perffered powder identifier.

`midRangePowderUsed` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The mid range powder used.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

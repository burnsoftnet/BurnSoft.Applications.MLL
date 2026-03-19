[`< Back`](./)

---

# GunCollectionAmmoData

Namespace: BurnSoft.Applications.MLL.Types

Class GunCollectionAmmo list container for the Gun_Collection_Ammo Table.
 This table is where the generated "Make Ammo" window stores all the loads 
 that was created and store that qty in this table. Then you have the 
 option to move it to the Gun Collection Application Ammo Inventory Table.

```csharp
public class GunCollectionAmmoData
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [GunCollectionAmmoData](./burnsoft.applications.mll.types.guncollectionammodata)

## Properties

### **Id**

Gets or sets the identifier.

```csharp
public int Id { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

### **Manufacturer**

Gets or sets the manufacturer.

```csharp
public string Manufacturer { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

### **Name**

Gets or sets the name.

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

### **Caliber**

Gets or sets the caliber.

```csharp
public string Caliber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The caliber.

### **Weight**

Gets or sets the weight.

```csharp
public string Weight { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The weight.

### **Jacket**

Gets or sets the jacket.

```csharp
public string Jacket { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The jacket.

### **Qty**

Gets or sets the qty.

```csharp
public long Qty { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The qty.

### **Price**

Gets or sets the price.

```csharp
public double Price { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

### **WeightDouble**

Gets or sets the weight double.

```csharp
public double WeightDouble { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The weight double.

### **LastSync**

```csharp
public string LastSync { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **GunCollectionAmmoData()**

```csharp
public GunCollectionAmmoData()
```

---

[`< Back`](./)

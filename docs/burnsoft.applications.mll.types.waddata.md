[`< Back`](./)

---

# WadData

Namespace: BurnSoft.Applications.MLL.Types

Class WadData is the list container for the List_SG_WAD table

```csharp
public class WadData
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [WadData](./burnsoft.applications.mll.types.waddata)

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

Gets or sets the name for the WAD Column

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

### **Gauge**

Gets or sets the gauge.

```csharp
public string Gauge { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The gauge.

### **GaugeId**

Gets or sets the gauge identifier for the GID Column

```csharp
public long GaugeId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The gauge identifier.

### **LoadInOzText**

Gets or sets Load in oz. text fort he load_t column

```csharp
public string LoadInOzText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The length.

### **LoadInOz**

Gets or sets Load in oz. in numeric form, background 
 calculation for the load_d column

```csharp
public double LoadInOz { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The load in oz.

### **Qty**

Gets or sets the qty.

```csharp
public int Qty { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The qty.

### **Price**

Gets or sets the price.

```csharp
public double Price { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The price.

### **EstimatedPricePerItem**

Gets or sets the Esitmated Price Per Shell. for the epps column

```csharp
public double EstimatedPricePerItem { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The estimated price per item.

### **LastSync**

Gets or sets the last synchronize for the sync_lastupdate column

```csharp
public string LastSync { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The last synchronize.

## Constructors

### **WadData()**

```csharp
public WadData()
```

---

[`< Back`](./)

[`< Back`](./)

---

# CaseListings

Namespace: BurnSoft.Applications.MLL.Types

Class CaseListings list container for the List_Case table

```csharp
public class CaseListings
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CaseListings](./burnsoft.applications.mll.types.caselistings)

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

### **TrimToLength**

Gets or sets the length of the trim to. Using the TTL column

```csharp
public string TrimToLength { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The length of the trim to.

### **IsNew**

Gets or sets a value indicating whether this instance is new.

```csharp
public bool IsNew { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if this instance is new; otherwise, `false`.

### **TimesUsed**

Gets or sets the times used.

```csharp
public int TimesUsed { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The times used.

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

### **CaliberId**

Gets or sets the caliber identifier. Using the CID column

```csharp
public long CaliberId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The caliber identifier.

### **EstimatedPricePerCase**

Gets or sets the estimated price per case. Using the ePPC column

```csharp
public double EstimatedPricePerCase { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The estimated price per case.

### **LastSync**

Gets or sets the last synchronize for the sync_lastupdate column

```csharp
public string LastSync { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The last synchronize.

## Constructors

### **CaseListings()**

```csharp
public CaseListings()
```

---

[`< Back`](./)

[`< Back`](./)

---

# BulletSupportingCaliber

Namespace: BurnSoft.Applications.MLL.Types

Class BulletSupportingCaliber list container for the List_Bullers_SupprtingCaliber 
 Table. This related to the Bullet SIngle Use.
 This table was created to help with bullets that applied to more than one
 caliber. Something like .355 9mm 115 can apply to .380. Some other diameter 
 bullets can apply to other calibers

```csharp
public class BulletSupportingCaliber
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BulletSupportingCaliber](./burnsoft.applications.mll.types.bulletsupportingcaliber)

## Properties

### **Id**

Gets or sets the identifier.

```csharp
public int Id { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

### **BulletId**

Gets or sets the bullet identifier. for Column BID

```csharp
public int BulletId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The bullet identifier.

### **CaliberId**

Gets or sets the caliber identifier. For Column CID

```csharp
public int CaliberId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The caliber identifier.

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

### **LastSync**

Gets or sets the last synchronize for the sync_lastupdate column

```csharp
public string LastSync { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The last synchronize.

## Constructors

### **BulletSupportingCaliber()**

```csharp
public BulletSupportingCaliber()
```

---

[`< Back`](./)

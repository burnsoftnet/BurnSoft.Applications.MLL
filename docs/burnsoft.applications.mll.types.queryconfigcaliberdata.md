[`< Back`](./)

---

# QueryConfigCaliberData

Namespace: BurnSoft.Applications.MLL.Types

Class QueryConfigCaliberData list container to work with the qry_ConfigCal_NSG or qry_ConfigCal_SG Query.

```csharp
public class QueryConfigCaliberData
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [QueryConfigCaliberData](./burnsoft.applications.mll.types.queryconfigcaliberdata)

## Properties

### **Id**

Gets or sets the identifier.

```csharp
public int Id { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

### **Name**

Gets or sets the name for the ConfigName column

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

### **IsPersonal**

Gets or sets a value indicating whether this instance is personal.

```csharp
public bool IsPersonal { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if this instance is personal; otherwise, `false`.

### **IsShotGun**

Gets or sets a value indicating whether this instance is shot gun.

```csharp
public bool IsShotGun { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if this instance is shot gun; otherwise, `false`.

### **CaliberId**

Gets or sets the caliber identifier.

```csharp
public long CaliberId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The caliber identifier.

### **IsActive**

Gets or sets a value indicating whether this instance is active.

```csharp
public bool IsActive { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if this instance is active; otherwise, `false`.

### **IsFavorite**

Gets or sets a value indicating whether this instance is favorite for the IsFav column

```csharp
public bool IsFavorite { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if this instance is favoriate; otherwise, `false`.

## Constructors

### **QueryConfigCaliberData()**

```csharp
public QueryConfigCaliberData()
```

---

[`< Back`](./)

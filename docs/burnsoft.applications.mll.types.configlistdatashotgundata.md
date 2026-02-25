[`< Back`](./)

---

# ConfigListDataShotgunData

Namespace: BurnSoft.Applications.MLL.Types

Class ConfigListDataShotgunData is the list container 
 for the Config_List_Data_SG table

```csharp
public class ConfigListDataShotgunData
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ConfigListDataShotgunData](./burnsoft.applications.mll.types.configlistdatashotgundata)

## Properties

### **Id**

Gets or sets the identifier.

```csharp
public int Id { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

### **ConfgNameId**

Gets or sets the clnid. Config List Name ID

```csharp
public int ConfgNameId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The clnid.

### **AmmoTypeId**

Gets or sets the atid. Ammunition Type ID

```csharp
public int AmmoTypeId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The atid.

### **CaliberId**

Gets or sets the calid. Caliber ID

```csharp
public int CaliberId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The calid.

### **PrimerId**

Gets or sets the prid. Primer ID
 Primer ID from General_Primer

```csharp
public int PrimerId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The prid.

### **CaseId**

Gets or sets the caid. Case ID
 Case ID from List_SG_Case

```csharp
public int CaseId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The caid.

### **ShotWeight**

Gets or sets the shot weight. for the SW column
 Shot Weight from List_SG_ShotWeight

```csharp
public double ShotWeight { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The shot weight.

### **ShotWeightText**

Gets or sets the shot weight text. for the SW_t column
 Shot Weight in Text

```csharp
public string ShotWeightText { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The shot weight text.

### **ShotSize**

Gets or sets the size of the shot. for the SS column
 Shot Size from List_SG_ShotSize

```csharp
public long ShotSize { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The size of the shot.

### **Bushing**

Gets or sets the bushing.
 Bushing from List_SG_Bushing

```csharp
public long Bushing { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The bushing.

### **Wad**

Gets or sets the wad.
 WAD from List_SG_WAD

```csharp
public long Wad { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The wad.

### **ShotChargeLoad**

Gets or sets the shot charge load. for the SCL Column,
 ShotCharge Loads from List_SG_ShotCharge_Loads

```csharp
public long ShotChargeLoad { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The shot charge load.

### **Source**

Gets or sets the source. If not Personal Referance a souce (optional)

```csharp
public string Source { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The source.

### **GunId**

Gets or sets the gun identifier. for the GID column

```csharp
public long GunId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The gun identifier.

### **IsPersonal**

Gets or sets a value indicating whether this instance is personal.

```csharp
public bool IsPersonal { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if this instance is personal; otherwise, `false`.

### **ListTypeId**

Gets or sets the list type identifier. for the LTID column
 List Type ID

```csharp
public long ListTypeId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The list type identifier.

### **BushingId**

Gets or sets the bushing identifier.

```csharp
public long BushingId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The bushing identifier.

### **ChargeBarId**

Gets or sets the charge bar identifier.

```csharp
public long ChargeBarId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The charge bar identifier.

### **LastSync**

Gets or sets the last synchronize for the sync_lastupdate column

```csharp
public string LastSync { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The last synchronize.

## Constructors

### **ConfigListDataShotgunData()**

```csharp
public ConfigListDataShotgunData()
```

---

[`< Back`](./)

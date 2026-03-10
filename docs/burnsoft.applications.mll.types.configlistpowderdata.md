[`< Back`](./)

---

# ConfigListPowderData

Namespace: BurnSoft.Applications.MLL.Types

Class ConfigListPowderData is the list container for the 
 Config_List_Powder_Data_NSG ( Metalic ) and 
 Config_Lst_Powder_Data_SG ( Shotgun )

```csharp
public class ConfigListPowderData
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ConfigListPowderData](./burnsoft.applications.mll.types.configlistpowderdata)

## Properties

### **Id**

Gets or sets the identifier.

```csharp
public long Id { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

### **ConfigId**

Gets or sets the configuration identifier. for the CLNID column

```csharp
public long ConfigId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configuration identifier.

### **PowderId**

Gets or sets the powder identifier. for the PID column

```csharp
public long PowderId { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The powder identifier.

### **LoadMin**

Gets or sets the load minimum. For the Load_Min Column
 Charge Weight in Grains

```csharp
public double LoadMin { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The load minimum.

### **LoadMid**

Gets or sets the load mid. For the Load_Mid column
 Charge Weight in Grains

```csharp
public double LoadMid { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The load mid.

### **LoadMax**

Gets or sets the load maximum. For the Load_Max column
 Charge Weight in Grains

```csharp
public double LoadMax { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The load maximum.

### **FpsMin**

Gets or sets the FPS minimum. for the FPS_Min Column
 Muzzle Velocity

```csharp
public Nullable<double> FpsMin { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The FPS minimum.

### **FpsMid**

Gets or sets the FPS mid. for the FPS_Mid column
 Muzzle Velocity

```csharp
public Nullable<double> FpsMid { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The FPS mid.

### **FpsMax**

Gets or sets the FPS maximum. for the FPS_Max column
 Muzzle Velocity

```csharp
public Nullable<double> FpsMax { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The FPS maximum.

### **CupsMin**

Gets or sets the cups minimum. for the CUPS_Min column ( METALIC ONLY RELATED )
 Pressure C.U.P.S

```csharp
public Nullable<double> CupsMin { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The cups minimum.

### **CupsMid**

Gets or sets the cups mid. for the CUPS_Mid column ( METALIC ONLY RELATED )
 Pressure C.U.P.S

```csharp
public Nullable<double> CupsMid { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The cups mid.

### **CupsMax**

Gets or sets the cups maximum. For the CUPS_Max column ( METALIC ONLY RELATED )
 Pressure C.U.P.S

```csharp
public Nullable<double> CupsMax { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The cups maximum.

### **PsiMin**

Gets or sets the psi minimum. for the PSI_Min column ( SHOTGUN RELATED )

```csharp
public Nullable<double> PsiMin { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The psi minimum.

### **PsiMid**

Gets or sets the psi mid. for the PSI_Mid column ( SHOTGUN RELATED )

```csharp
public Nullable<double> PsiMid { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The psi mid.

### **PsiMax**

Gets or sets the psi maximum. for the PSI_Max column ( SHOTGUN RELATED )

```csharp
public Nullable<double> PsiMax { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The psi maximum.

### **LupMin**

Gets or sets the lup minimum. for the LUP_Min column ( SHOTGUN RELATED )

```csharp
public Nullable<double> LupMin { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The lup minimum.

### **LupMid**

Gets or sets the lup mid. for the LUP_Mid column ( SHOTGUN RELATED )

```csharp
public Nullable<double> LupMid { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The lup mid.

### **LupMax**

Gets or sets the lup maximum. for the LUP_Max column ( SHOTGUN RELATED )

```csharp
public Nullable<double> LupMax { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The lup maximum.

### **IsDefault**

Gets or sets a value indicating whether this instance is default. for the IsPref column

```csharp
public bool IsDefault { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if this instance is default; otherwise, `false`.

### **LastSync**

Gets or sets the last synchronize for the sync_lastupdate column

```csharp
public string LastSync { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The last synchronize.

## Constructors

### **ConfigListPowderData()**

```csharp
public ConfigListPowderData()
```

---

[`< Back`](./)

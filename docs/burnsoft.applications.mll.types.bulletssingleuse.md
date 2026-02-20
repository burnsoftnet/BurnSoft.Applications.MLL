[`< Back`](./)

---

# BulletsSingleUse

Namespace: BurnSoft.Applications.MLL.Types

Class BulletsSingleUse list container for the List_Bullets_SU table.
 This table was created to help with bullets that applied to more than one
 caliber. Something like .355 9mm 115 can apply to .380. Some other diameter 
 bullets can apply to other calibers

```csharp
public class BulletsSingleUse
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BulletsSingleUse](./burnsoft.applications.mll.types.bulletssingleuse)

## Properties

### **Id**

Gets or sets the identifier.

```csharp
public int Id { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

### **SuggestedUsedId**

Gets or sets the suggested used identifier. Column Name is SUID

```csharp
public int SuggestedUsedId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The suggested used identifier.

### **BulletId**

Gets or sets the bullet identifier. Column Name is BulletID

```csharp
public int BulletId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The bullet identifier.

### **LastSync**

Gets or sets the last synchronize for the sync_lastupdate column

```csharp
public string LastSync { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The last synchronize.

## Constructors

### **BulletsSingleUse()**

```csharp
public BulletsSingleUse()
```

---

[`< Back`](./)

[`< Back`](./)

---

# BulletPictures

Namespace: BurnSoft.Applications.MLL.Types

Class BulletPictures list container for the List_Bullets_Picture Table.
 This was put in some time ago but never used in the application. Might
 Come back to this and add it, still Need to Create the functions to 
 interact with the table and data.

```csharp
public class BulletPictures
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BulletPictures](./burnsoft.applications.mll.types.bulletpictures)

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

Gets or sets the bullet identifier. Column name is BID

```csharp
public int BulletId { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The bullet identifier.

### **PicuteBlob**

Gets or sets the picute BLOB. Column Name is Pic_Blob

```csharp
public object PicuteBlob { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The picute BLOB.

### **IsDefault**

Gets or sets a value indicating whether this instance is default.

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

### **BulletPictures()**

```csharp
public BulletPictures()
```

---

[`< Back`](./)

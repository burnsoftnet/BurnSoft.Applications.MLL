[`< Back`](./)

---

# Wishlists

Namespace: BurnSoft.Applications.MLL.Global

Class Wishlists handles the data in the wishlist table

```csharp
public class Wishlists
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Wishlists](./burnsoft.applications.mll.global.wishlists)

## Constructors

### **Wishlists()**

```csharp
public Wishlists()
```

## Methods

### **GetDetails(String, Int32, String&)**

Gets the details.

```csharp
public static List<WishlistData> GetDetails(string databasePath, int id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;WishlistData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;WishlistData&gt;.

### **GetDetails(String, String, String, String&)**

Gets the details.

```csharp
public static List<WishlistData> GetDetails(string databasePath, string manufacturer, string model, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`model` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The model.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;WishlistData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;WishlistData&gt;.

### **GetAll(String, String&)**

Gets all.

```csharp
public static List<WishlistData> GetAll(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;WishlistData&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;WishlistData&gt;.

### **GetId(String, String, String, String&)**

Gets the identifier.

```csharp
public static long GetId(string databasePath, string manufacturer, string model, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`model` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The model.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
System.Int64.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **DataExists(String, String&)**

Datas the exists.

```csharp
public static bool DataExists(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **DataExists(String, String, String, String&)**

Datas the exists.

```csharp
public static bool DataExists(string databasePath, string manufacturer, string model, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`model` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The model.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, String, String, String, String, String, String, String&)**

Adds the specified database path.

```csharp
public static bool Add(string databasePath, string manufacturer, string model, string placeToBuy, string qty, string value, string notes, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`model` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The model.

`placeToBuy` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The place to buy.

`qty` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The qty.

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

`notes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The notes.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Update(String, Int64, String, String, String, String, String, String, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, long id, string manufacturer, string model, string placeToBuy, string qty, string value, string notes, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`model` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The model.

`placeToBuy` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The place to buy.

`qty` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The qty.

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

`notes` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The notes.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Delete(String, Int64, String&)**

Deletes the specified database path.

```csharp
public static bool Delete(string databasePath, long id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Delete(String, String, String, String&)**

Deletes the specified database path.

```csharp
public static bool Delete(string databasePath, string manufacturer, string model, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`manufacturer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The manufacturer.

`model` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The model.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

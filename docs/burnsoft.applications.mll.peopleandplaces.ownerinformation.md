[`< Back`](./)

---

# OwnerInformation

Namespace: BurnSoft.Applications.MLL.PeopleAndPlaces

Class OwnerInformation.

```csharp
public class OwnerInformation
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OwnerInformation](./burnsoft.applications.mll.peopleandplaces.ownerinformation)

## Constructors

### **OwnerInformation()**

```csharp
public OwnerInformation()
```

## Methods

### **GetAllData(String, String&)**

Gets all data from the Personal Information Table

```csharp
public static List<PersonalInformation> GetAllData(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;PersonalInformation&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;PersonalInformation&gt;.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetData(String, String&)**

Gets the data from yhr Personal Information Table for the Top User listed

```csharp
public static List<PersonalInformation> GetData(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;PersonalInformation&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;PersonalInformation&gt;.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetLoadName(String, String&)**

Gets the name of the load.

```csharp
public static string GetLoadName(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
System.String.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **LoginEnabled(String, String&)**

Get the information related only to the login information, There is default information listed
 just in case someone click on the lock option but doesn't set the other information and close the application
 if this happens then they will not be able to log in. The default will help save them in this
 where it will give a backup default if that information is not set.

```csharp
public static List<LoginInformationOnly> LoginEnabled(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;LoginInformationOnly&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;LoginInformationOnly&gt;.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetOwnerID(String, String&)**

Gets the maximum identifier for the owner.

```csharp
public static int GetOwnerID(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
System.Int32.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **Add(String, String, String, String, String, String, String, String, String, Boolean, String, String, String, String, String&)**

Adds The owner Information to the database

```csharp
public static bool Add(string databasePath, string name, string loadName, string address, string city, string state, string zipCode, string phone, string license, bool usePassword, string username, string password, string forgotPhrase, string forgotAnswer, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`loadName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the load.

`address` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The address.

`city` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The city.

`state` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The state.

`zipCode` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The zip code.

`phone` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The phone.

`license` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The license.

`usePassword` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [use password].

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username.

`password` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The password.

`forgotPhrase` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The forgot phrase.

`forgotAnswer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The forgot answer.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Update(String, Int32, String, String, String, String, String, String, String, String, Boolean, String, String, String, String, String&)**

Updates the specified database path.

```csharp
public static bool Update(string databasePath, int id, string name, string loadName, string address, string city, string state, string zipCode, string phone, string license, bool usePassword, string username, string password, string forgotPhrase, string forgotAnswer, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

`loadName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the load.

`address` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The address.

`city` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The city.

`state` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The state.

`zipCode` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The zip code.

`phone` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The phone.

`license` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The license.

`usePassword` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [use password].

`username` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The username.

`password` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The password.

`forgotPhrase` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The forgot phrase.

`forgotAnswer` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The forgot answer.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Delete(String, String&)**

Deletes everything from the Personal_Information table.

```csharp
public static bool Delete(string databasePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **Delete(String, Int32, String&)**

Deletes the row based on the id from the Personal_Information table.

```csharp
public static bool Delete(string databasePath, int id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`id` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

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

---

[`< Back`](./)

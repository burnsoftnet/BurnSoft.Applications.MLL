[`< Back`](./)

---

# ConfigListGeneral

Namespace: BurnSoft.Applications.MLL.ConfigSheets

Class ConfigListGeneral contains general functions relating to different 
 sections of the confg sheets section

```csharp
public class ConfigListGeneral
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ConfigListGeneral](./burnsoft.applications.mll.configsheets.configlistgeneral)

## Constructors

### **ConfigListGeneral()**

```csharp
public ConfigListGeneral()
```

## Methods

### **IsShotgunConfig(String, Int64, String&)**

Determines whether [is shotgun configuration] [the specified database path].

```csharp
public static bool IsShotgunConfig(string databasePath, long caliberId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`caliberId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The caliber identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if [is shotgun configuration] [the specified database path]; otherwise, `false`.

### **IsSlugConfig(String, Int64, String&)**

Determines whether [is slug configuration] [the specified database path].

```csharp
public static bool IsSlugConfig(string databasePath, long Id, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`Id` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if [is slug configuration] [the specified database path]; otherwise, `false`.

### **InShotgun(String, Int64, String&)**

Ins the shotgun configs

```csharp
public static bool InShotgun(string databasePath, long caliberId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`caliberId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The caliber identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **InMetallic(String, Int64, String&)**

In the metallic config.

```csharp
public static bool InMetallic(string databasePath, long caliberId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`caliberId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The caliber identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **IsNotInShotgunConfigByCaliber(String, Int64, String&)**

Determines whether [is not in shotgun configuration by caliber] [the specified database path].

```csharp
public static bool IsNotInShotgunConfigByCaliber(string databasePath, long caliberId, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`caliberId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The caliber identifier.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if [is not in shotgun configuration by caliber] [the specified database path]; otherwise, `false`.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

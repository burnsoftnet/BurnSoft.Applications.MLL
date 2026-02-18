[`< Back`](./)

---

# MyRegistry

Namespace: BurnSoft.Applications.MLL.Global

Class MyRegistry. General Registry class for the My Loaders Log Application to read, setups, and write

```csharp
public class MyRegistry
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MyRegistry](./burnsoft.applications.mll.global.myregistry)

## Properties

### **DefaultRegPath**

Gets or sets the default reg path.

```csharp
public static string DefaultRegPath { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The default reg path.

## Constructors

### **MyRegistry()**

```csharp
public MyRegistry()
```

## Methods

### **CreateSubKey(String, String&)**

Creates the sub key.

```csharp
public static void CreateSubKey(string strValue, String& errOut)
```

#### Parameters

`strValue` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string value.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

### **UpdateAppDetails(String, String, String, String, String, String, String, String&)**

Ups the date application details.

```csharp
public static bool UpdateAppDetails(string productVersion, string productName, string executablePath, string appPath, string logFile, string databasePath, string appDataPath, String& errOut)
```

#### Parameters

`productVersion` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The product version.

`productName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the product.

`executablePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The executable path.

`appPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The application path.

`logFile` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The log file.

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`appDataPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The application data path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **RegSubKeyExists(String, String&)**

Regs the sub key exists.

```csharp
public static bool RegSubKeyExists(string strValue, String& errOut)
```

#### Parameters

`strValue` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string value.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **GetRegSubKeyValue(String, String, String, String&)**

Gets the reg sub key value.

```csharp
public static string GetRegSubKeyValue(string strKey, string strValue, string strDefault, String& errOut)
```

#### Parameters

`strKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string key.

`strValue` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string value.

`strDefault` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string default.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
System.String.

### **SetSettingDetails(String&)**

Sets the setting details.

```csharp
public static bool SetSettingDetails(String& errOut)
```

#### Parameters

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **SettingsExists(String&)**

Settingses the exists.

```csharp
public static bool SettingsExists(String& errOut)
```

#### Parameters

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **GetSettings(String&)**

Gets the settings.

```csharp
public static List<RegistrySettings> GetSettings(String& errOut)
```

#### Parameters

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[List&lt;RegistrySettings&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;RegistrySettings&gt;.

### **BuildRegistry(Boolean, Boolean, String, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, String, String, Int32, Boolean)**

Builds the registry list string to use for saving

```csharp
public static List<RegistrySettings> BuildRegistry(bool AutoUpdate, bool UseProxy, string Successful, bool AlertOnBackUp, bool BackupOnExit, bool UseOrgImage, bool LOADERTYPE_SHOTGUN, bool LOADERTYPE_NONSHOTGUN, bool VIEW_FPS, bool IndvReports, bool VIEW_CUPS, string DefaultList, string ConfigSort, int TrackHistoryDays, bool TrackHistory)
```

#### Parameters

`AutoUpdate` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [automatic update].

`UseProxy` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [use proxy].

`Successful` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The successful.

`AlertOnBackUp` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [alert on back up].

`BackupOnExit` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [backup on exit].

`UseOrgImage` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [use org image].

`LOADERTYPE_SHOTGUN` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [loadertype shotgun].

`LOADERTYPE_NONSHOTGUN` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [loadertype nonshotgun].

`VIEW_FPS` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [view FPS].

`IndvReports` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [indv reports].

`VIEW_CUPS` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [view cups].

`DefaultList` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The default list.

`ConfigSort` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The configuration sort.

`TrackHistoryDays` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The track history days.

`TrackHistory` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if set to `true` [track history].

#### Returns

[List&lt;RegistrySettings&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List&lt;RegistrySettings&gt;.

### **SaveSettings(List&lt;RegistrySettings&gt;, String&)**

Saves the settings.

```csharp
public static bool SaveSettings(List<RegistrySettings> settings, String& errOut)
```

#### Parameters

`settings` [List&lt;RegistrySettings&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
The settings.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **SaveLastWorkingDir(String, String&)**

Saves the last working dir.

```csharp
public static bool SaveLastWorkingDir(string strPath, String& errOut)
```

#### Parameters

`strPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **SetHotFix(Int32, String&, String)**

Sets the hot fix.

```csharp
public static bool SetHotFix(int hotfixNumber, String& errOut, string installNotice)
```

#### Parameters

`hotfixNumber` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The hotfix number.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

`installNotice` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The Date and Time it was installed, OnInstall will skip the 
 reinstall since that is by current version.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **SetValue(String, String, String, String&)**

Sets the setting value.

```csharp
public static bool SetValue(string subKey, string name, string value, String& errOut)
```

#### Parameters

`subKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the sub key with the default to the Main Application Path, 
 if left blank it will insert in root

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
name to store the value in the key

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **SaveViewSettings(String, String, String&)**

Saves the view settings.

```csharp
public static bool SaveViewSettings(string key, string value, String& errOut)
```

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key.

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **SaveConfigSort(String, String&)**

Saves the configuration sort.

```csharp
public static bool SaveConfigSort(string value, String& errOut)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **SetLastUpdate(Int32, String&)**

Sets the last update.

```csharp
public static bool SetLastUpdate(int hotfixNumber, String& errOut)
```

#### Parameters

`hotfixNumber` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The hotfix number.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

### **GetLastWorkingDir(String&)**

Gets the last working dir.

```csharp
public static string GetLastWorkingDir(String& errOut)
```

#### Parameters

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
System.String.

### **GetViewSettings(String, String&, String)**

Gets the view settings.

```csharp
public static string GetViewSettings(string sKey, String& errOut, string sDefault)
```

#### Parameters

`sKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The s key.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

`sDefault` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The s default.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
System.String.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetDatabaseLocation(String&, String)**

Gets the database location.

```csharp
public static string GetDatabaseLocation(String& errOut, string sDefault)
```

#### Parameters

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

`sDefault` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The s default.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
System.String.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **GetExePath(String&, String)**

Gets the executable path.

```csharp
public static string GetExePath(String& errOut, string sDefault)
```

#### Parameters

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

`sDefault` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The s default.

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
System.String.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **MyGunCollectionIsInstalled(String&)**

Checks to see if the gun collection is installed.

```csharp
public static bool MyGunCollectionIsInstalled(String& errOut)
```

#### Parameters

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

#### Exceptions

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

---

[`< Back`](./)

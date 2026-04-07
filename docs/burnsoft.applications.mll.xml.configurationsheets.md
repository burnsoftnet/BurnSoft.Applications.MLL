[`< Back`](./)

---

# ConfigurationSheets

Namespace: BurnSoft.Applications.MLL.Xml

Class ConfigurationSheets XML Export and save to file for Metallic Configs.

```csharp
public class ConfigurationSheets
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ConfigurationSheets](./burnsoft.applications.mll.xml.configurationsheets)

## Constructors

### **ConfigurationSheets()**

```csharp
public ConfigurationSheets()
```

## Methods

### **Generate(String, Int64, String, String&)**

Generates The XML File report for the selected configuration id that you pass and
 saves it to the selected file.

```csharp
public static bool Generate(string databasePath, long configId, string filePath, String& errOut)
```

#### Parameters

`databasePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The database path.

`configId` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>
The configuration identifier.

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The file path.

`errOut` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>
The error out.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
`true` if XXXX, `false` otherwise.

---

[`< Back`](./)

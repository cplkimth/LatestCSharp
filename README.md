# Overview
Some codes to use latest C# language features on .Net Framework 4.8

# Features
## Record type
```c#
public record Person(string FirstName, string LastName)
{
    public string[] PhoneNumbers { get; init; }
}
```

## Index and Range
```c#
Range range = 1 .. ^1;
Console.WriteLine("abc"[range]);
```

# LangVersion
Don't forget to using latest version of C# by modifying .csproj file.
```xml
<LangVersion>latest</LangVersion>
```

# Package
You can find this package from nuget by keyword "latestcsharp"

![image](https://user-images.githubusercontent.com/22572720/166096134-dcef7862-8118-4e27-92f0-42f0055b3cad.png)


# Thanks to ...
All of codes are from developers from Stack Overflow. I just packed codes for my convenience.

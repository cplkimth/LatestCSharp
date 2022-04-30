# Overview
Some codes to use latest C# language features on .Net Framework 4.8

# Record type
```
public record Person(string FirstName, string LastName)
{
    public string[] PhoneNumbers { get; init; }
}
```

# Index and Range
```
Range range = 1 .. ^1;
Console.WriteLine("abc"[range]);
```


# Thanks to ...
All of codes are from developers from Stack Overflow. I just packed codes for my convenience.

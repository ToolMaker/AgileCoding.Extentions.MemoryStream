AgileCoding.Extensions.MemoryStream
===================================

Overview
--------

AgileCoding.Extensions.MemoryStream is a .NET library that provides several useful extension methods related to MemoryStream. This package simplifies certain tasks related to stream conversion and manipulation.

Installation
------------

This library is distributed via NuGet. To install it, use the NuGet package manager console:

bashCopy code

`Install-Package AgileCoding.Extensions.MemoryStream -Version 2.0.5`

Features
--------

This library introduces the following extension methods:

1.  GetStreamForString: Returns a MemoryStream for the provided string data.

Usage
-----

Here's an example of how to use these features in your code:

```csharp
using AgileCoding.Extentions.Streams;
using System.IO;

// Get a MemoryStream for a specific string
MemoryStream memoryStream = new MemoryStream();
string data = "Hello World!";
memoryStream = memoryStream.GetStreamForString(data);
```

Documentation
-------------

For more detailed information about the usage of this library, please refer to the [official documentation](https://github.com/ToolMaker/AgileCoding.Extentions.MemoryStream/wiki).

License
-------

This project is licensed under the terms of the MIT license. For more information, see the [LICENSE](https://github.com/ToolMaker/AgileCoding.Extentions.MemoryStream/blob/main/LICENSE) file.

Contributing
------------

Contributions are welcome! Please see our [contributing guidelines](https://github.com/ToolMaker/AgileCoding.Extentions.MemoryStream/blob/main/CONTRIBUTING.md) for more details.
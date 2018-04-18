# ofxparser.netCore
OfxParser is a .NET library for working with Open Financial Exchange (OFX) data - both OFXv1 (SGML) and OFXv2 (pure XML) - which is the standard format for downloading financial information from banks and stockbrokers.
Project original: https://github.com/leonardomelosantos/ofxparser.net

## Dependencies
.NET Standard 2.0+

You can check supported frameworks here:

https://docs.microsoft.com/pt-br/dotnet/standard/net-standard

## Instalation
This package is available through Nuget Packages: https://www.nuget.org/packages/OFXParserCore

**Nuget**
```
Install-Package OFXParserCore
```

**.NET CLI**
```
dotnet add package OFXParserCore
```

# How to Use
```
Extract extrat = OFXParser.Parser.GenerateExtract(ofx);

if (extrat != null)
{
	foreach (var tran in extrat.Transactions)
	{

	}
}
```

# Horoscope NuGet
A .NET library for zodiac signs. Get details on each zodiac sign, pass a date and know which zodiac sign it falls in or get a list of all zodiac signs. Now includes Chinese zodiac signs and elements! 
    
[![NuGet](https://img.shields.io/nuget/v/horoscope.svg?colorB=green&label=NuGet&logo=nuget&style=flat)](https://www.nuget.org/packages/Horoscope/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/horoscope.svg?colorB=%23004880&label=NuGet%20Downloads&logo=nuget&style=flat)](https://www.nuget.org/packages/Horoscope/)
[![Azure DevOps builds](https://img.shields.io/azure-devops/build/clydedsouza-nuget/90af4830-1be2-4677-981d-15d0b01937e4/1?logo=Azure%20DevOps)](https://dev.azure.com/clydedsouza-nuget/Horoscope%20NuGet/_build) 
[![Azure DevOps tests](https://img.shields.io/azure-devops/tests/clydedsouza-nuget/Horoscope%2520NuGet/1?logo=Azure%20DevOps)](https://dev.azure.com/clydedsouza-nuget/Horoscope%20NuGet/_build)     

## How to use
#### Installation 
Library can either be directly downloaded from [Nuget.org](https://www.nuget.org/packages/Horoscope/), OR installed via the [NuGet Package Manager UI](https://docs.microsoft.com/en-us/nuget/tools/package-manager-ui#finding-and-installing-a-package) or via the [Package Manager Console](https://docs.microsoft.com/en-us/nuget/tools/package-manager-console) if you're using Visual Studio.

Command to install Horoscope NuGet via the Package Manager Console UI in Visual Studio shown below.
```PowerShell
PM> Install-Package Horoscope 
```
  
#### Usage
Include the namespace in your program.
```C#
using Horoscope;
```

Then go ahead and consume it.
```C#
var zodiacSign = Zodiac.GetZodiacSignForDate(new DateTime(1950, 2, 12));
```

Another simpler option if all you need is the zodiac sign for a single date is:
```C#
var givenDateTime = new DateTime(1995, 8, 26);
var zodiacSign = givenDateTime.GetZodiacSign();
```

#### More examples
[Horoscope.Zodiac](https://github.com/ClydeDz/horoscope-nuget/blob/master/Src/Horoscope.TestConsole/ZodiacExamples.cs)   
[Horoscope.ChineseZodiac](https://github.com/ClydeDz/horoscope-nuget/blob/master/Src/Horoscope.TestConsole/ChineseZodiacExamples.cs)
   

## Release notes
Find release notes [here](https://github.com/ClydeDz/horoscope-nuget/releases).

## Credits
(c) 2018 [Clyde D'Souza](https://clydedsouza.net)   
Icon credits: [Firkin](https://openclipart.org/detail/297192/bold-zodiac-symbols-colour)

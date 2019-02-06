# Horoscope NuGet
A .NET library for zodiac signs. Get details on each zodiac sign, pass a date and know which zodiac sign it falls in or get a list of all zodiac signs. Now includes Chinese zodiac signs and elements! 
    
[![NuGet](https://img.shields.io/nuget/v/horoscope.svg?colorB=green&label=NuGet&logo=nuget&style=flat)](https://www.nuget.org/packages/Horoscope/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/horoscope.svg?colorB=%23004880&label=NuGet%20Downloads&logo=nuget&style=flat)](https://www.nuget.org/packages/Horoscope/)
[![Build status](https://dev.azure.com/horoscope-nuget/Horoscope%20NuGet/_apis/build/status/Master%20branch%20build)](https://dev.azure.com/horoscope-nuget/Horoscope%20NuGet/_build/latest?definitionId=1)
[![Test status](https://img.shields.io/azure-devops/tests/horoscope-nuget/Horoscope%20NuGet/1/master.svg?label=Tests&logo=Azure%20DevOps&style=flat)](https://dev.azure.com/horoscope-nuget/Horoscope%20NuGet/_build/latest?definitionId=1)

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

#### More examples
[Horoscope.Zodiac](https://github.com/ClydeDz/horoscope-nuget/blob/master/Src/Horoscope.TestConsole/ZodiacExamples.cs)   
[Horoscope.ChineseZodiac](https://github.com/ClydeDz/horoscope-nuget/blob/master/Src/Horoscope.TestConsole/ChineseZodiacExamples.cs)
   

## Release notes
Find release notes [here](https://github.com/ClydeDz/horoscope-nuget/wiki#release-notes).

## Credits
(c) 2018 [Clyde D'Souza](https://clydedsouza.net)   
Icon credits: [Firkin](https://openclipart.org/detail/297192/bold-zodiac-symbols-colour)

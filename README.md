# Horoscope NuGet
A .NET library for zodiac signs. Get details on each zodiac sign, pass a date and know which zodiac sign it falls in or get a list of all zodiac signs. Now includes Chinese zodiac signs and elements! 
    
[![NuGet](https://img.shields.io/nuget/v/Horoscope.svg)](https://www.nuget.org/packages/Horoscope/)

     
## How to use
#### Installation 
Library can be installed with [Nuget](https://www.nuget.org/packages/Horoscope/).
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

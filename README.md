# Horoscope NuGet
A .NET library for Zodiac signs. Get details on each Zodiac sign, pass a date and know which Zodiac sign it falls in or get a list of all Zodiac signs. Currently in beta.

[![NuGet](https://img.shields.io/nuget/v/Horoscope.svg)](https://www.nuget.org/packages/Horoscope/)

     
## Usage
Install using package manager.
```
Install-Package Horoscope -Version 0.0.2
```

Include the namespace in your program.
```
using Horoscope;
```

Then go ahead and consume it.
```
var zodiacSign = Zodiac.GetZodiacSignForDate(new DateTime(1950, 2, 12));
```
    


## Credits
(c) 2018 [Clyde D'Souza](https://clydedsouza.net)   
Icon credits: [Firkin](https://openclipart.org/detail/297192/bold-zodiac-symbols-colour)

# BlazorVintageKit

A vintage inspired seventeen segment display and configuration scoller for Blazor. Supports serverside or wasm interaction.

<a href="https://blazorvintagekit-gjefahhff5dng7dg.uksouth-01.azurewebsites.net/">Demo site here</a> (azure free tier, might be slow or stopped if quota is exceeded).

<details>
  <summary>Click for seventeen segment animated screenshot</summary>
  <p> <img src="media/BVKSS.gif" alt="Seventeen Segment Scroller animation" /> </p>
</details>
<details>
  <summary>Click for LED stack animated screenshot</summary>
  <p> <img src="media/BVKLS.gif" alt="LED Stack animation" /> </p>
</details>

## Table of Contents

1. [Installation](#installation)
2. [Usage](#usage)
3. [Contributing](#contributing)
4. [License](#license)
5. [Contact](#contact)

## Installation

<code>dotnet add package BlazorVintageKit</code>

After installation include css from the package:
<code> &lt;link rel="stylesheet" href="_content/BlazorVintageKit/BlazorVintageKit.css" /> </code>

## Usage
[See the examples in this repo.](https://github.com/BrettLaw/BlazorVintageKit/tree/dev/src/Examples/Examples.Client/Pages)

This package provides:

* A seventeen segment display:<br>
	<img src="media/SeventeenSegment.png" alt="Seventeen Segment Display" /><br>
	<code><BlazorVintageKit.Components.SeventeenSegmentDisplay Character="@CurrentCharacter" /></code>
* A scroller composed of seventeed segment displays:
	<img src="media/Scroller.png" alt="Seventeen Segment Scroller" /><br>
	<code><BlazorVintageKit.Components.RetroScrollingDisplay DisplayText="Text to scroll." /></code><br>
	customisable like this:<br>
	<code><BlazorVintageKit.Components.RetroScrollingDisplay DisplayText="@DisplayText" ScrollDelayMS=@ScrollDelay CharacterCount=@CharacterCount LoopPadding="@LoopPadding" FixHeightPX="@FixHeightPX" /></code>
* An LED stack:<br>
	<img src="media/LEDStack.png" alt="LED Stack" /><br>
	<code><BlazorVintageKit.Components.LEDStack BarValue=@barValue BarCount=11 LowLimit=4 MedLimit=7 /></code>
## Contributing
?

## License
MIT - see license.txt


# BlazorVintageKit

A vintage inspired seventeen segment display and configuration scoller for Blazor. Supports serverside or wasm interaction.

<a href="https://blazorvintagekit-gjefahhff5dng7dg.uksouth-01.azurewebsites.net/">Demo site here</a> (azure free tier, might be slow or stopped if quota is exceeded).

<details>
  <summary>Click for animated screenshot</summary>
  <p> <img src="media/BVKSS.gif" alt="Screenshot" /> </p>
</details>


## Table of Contents

1. [Installation](#installation)
2. [Usage](#usage)
3. [Contributing](#contributing)
4. [License](#license)
5. [Contact](#contact)

## Installation

<code>dotnet add package BlazorVintageKit --version 1.0.1</code>

## Usage

**See the examples in this repo.**

A single segment display can be used like this:
<code><BlazorVintageKit.Components.SeventeenSegmentDisplay Character="@CurrentCharacter" />
</code>

The scroller can be used like this:
<code><BlazorVintageKit.Components.RetroScrollingDisplay DisplayText="No customisation - default." />
</code>

or customised like this:
<code>
<BlazorVintageKit.Components.RetroScrollingDisplay DisplayText="@DisplayText" ScrollDelayMS=@ScrollDelay CharacterCount=@CharacterCount LoopPadding="@LoopPadding" FixHeightPX="@FixHeightPX" />
</code>

## Contributing
?

## License
MIT - see license.txt


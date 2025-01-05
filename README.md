# BlazorVintageKit

A vintage inspired seventeen segment display and configuration scoller for Blazor. Supports serverside or wasm interaction.

<details>
  <summary>Click for animated screenshot</summary>
  <p> <img src="media/GVKSS.gif" alt="Screenshot" /> </p>
</details>


## Table of Contents

1. [Installation](#installation)
2. [Usage](#usage)
3. [Contributing](#contributing)
4. [License](#license)
5. [Contact](#contact)

## Installation

Nuget package named BlazorVintageKit

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


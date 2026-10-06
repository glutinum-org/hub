namespace rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

module Chalk =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        /// <summary>
        /// Return a new Chalk instance.
        /// </summary>
        [<Import("Chalk", "chalk")>]
        static member inline Chalk: Exports.Chalk__.Type = nativeOnly
        [<Import("supportsColor", "chalk")>]
        static member inline supportsColor: Chalk.ColorInfo = nativeOnly
        [<Import("chalkStderr", "chalk")>]
        static member inline chalkStderr: ChalkInstance = nativeOnly
        [<Import("supportsColorStderr", "chalk")>]
        static member inline supportsColorStderr: obj = nativeOnly
        [<Import("modifiers", "chalk")>]
        [<Obsolete("Use `modifierNames` instead.\n\nBasic modifier names.")>]
        static member inline modifiers: ReadonlyArray<Chalk.ModifierName> = nativeOnly
        [<Import("foregroundColors", "chalk")>]
        [<Obsolete("Use `foregroundColorNames` instead.\n\nBasic foreground color names.")>]
        static member inline foregroundColors: ReadonlyArray<Chalk.ForegroundColorName> = nativeOnly
        [<Import("backgroundColors", "chalk")>]
        [<Obsolete("Use `backgroundColorNames` instead.\n\nBasic background color names.")>]
        static member inline backgroundColors: ReadonlyArray<Chalk.BackgroundColorName> = nativeOnly
        [<Import("colors", "chalk")>]
        [<Obsolete("Use `colorNames` instead.\n\nBasic color names. The combination of foreground and background color names.")>]
        static member inline colors: ReadonlyArray<Chalk.ColorName> = nativeOnly
        [<ImportDefault("chalk")>]
        static member inline chalk: Chalk.ChalkInstance = nativeOnly
        /// <summary>
        /// Basic modifier names.
        /// </summary>
        [<Import("modifierNames", "chalk")>]
        static member inline modifierNames: ReadonlyArray<Chalk.ModifierName> = nativeOnly
        /// <summary>
        /// Basic foreground color names.
        /// </summary>
        [<Import("foregroundColorNames", "chalk")>]
        static member inline foregroundColorNames: ReadonlyArray<Chalk.ForegroundColorName> = nativeOnly
        /// <summary>
        /// Basic background color names.
        /// </summary>
        [<Import("backgroundColorNames", "chalk")>]
        static member inline backgroundColorNames: ReadonlyArray<Chalk.BackgroundColorName> = nativeOnly
        /// <summary>
        /// Basic underline color names.
        /// </summary>
        [<Import("underlineColorNames", "chalk")>]
        static member inline underlineColorNames: ReadonlyArray<Chalk.UnderlineColorName> = nativeOnly
        /// <summary>
        /// Basic color names. The combination of foreground and background color names.
        /// </summary>
        [<Import("colorNames", "chalk")>]
        static member inline colorNames: ReadonlyArray<Chalk.ColorName> = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type Options =
        /// <summary>
        /// Specify the color support for Chalk.
        ///
        /// By default, color support is automatically detected based on the environment.
        ///
        /// Levels:
        /// - <c>0</c> - All colors disabled.
        /// - <c>1</c> - Basic 16 colors support.
        /// - <c>2</c> - ANSI 256 colors support.
        /// - <c>3</c> - Truecolor 16 million colors support.
        ///
        /// Omit this option, or pass <c>undefined</c>, to have the level detected instead.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// If the value is neither <c>undefined</c> nor an integer from 0 to 3.
        /// </remarks>
        abstract member level: Chalk.ColorSupportLevel option with get
        [<ParamObject; Emit("$0")>]
        static member Create (?level: Chalk.ColorSupportLevel) : Options = nativeOnly

    [<AllowNullLiteral>]
    [<Interface>]
    type ChalkInstance =
        [<Emit("$0($1...)")>]
        abstract member Invoke: [<ParamArray>] text: obj [] -> string
        /// <summary>
        /// The color support for Chalk.
        ///
        /// By default, color support is automatically detected based on the environment.
        ///
        /// Levels:
        /// - <c>0</c> - All colors disabled.
        /// - <c>1</c> - Basic 16 colors support.
        /// - <c>2</c> - ANSI 256 colors support.
        /// - <c>3</c> - Truecolor 16 million colors support.
        /// </summary>
        /// <remarks>
        /// Throws:
        /// -------
        ///
        /// If the assigned value is not an integer from 0 to 3.
        /// </remarks>
        abstract member level: Chalk.ColorSupportLevel with get, set
        /// <summary>
        /// Use RGB values to set text color.
        /// </summary>
        /// <example>
        /// <code>
        /// import chalk from 'chalk';
        ///
        /// chalk.rgb(222, 173, 237);
        /// </code>
        /// </example>
        abstract member rgb: ChalkInstance.rgb with get, set
        /// <summary>
        /// Use HEX value to set text color.
        /// </summary>
        /// <example>
        /// <code>
        /// import chalk from 'chalk';
        ///
        /// chalk.hex('#DEADED');
        /// </code>
        /// </example>
        /// <param name="color">
        /// Hexadecimal value representing the desired color.
        /// </param>
        abstract member hex: (string -> ChalkInstance) with get, set
        /// <summary>
        /// Use an [8-bit unsigned number](https://en.wikipedia.org/wiki/ANSI_escape_code#8-bit) to set text color.
        ///
        /// The value is downsampled to the 16-color palette on terminals that only support basic colors (level 1), so <c>chalk.ansi256(196)</c> becomes 91 (ANSI escape for bright red).
        /// </summary>
        /// <example>
        /// <code>
        /// import chalk from 'chalk';
        ///
        /// chalk.ansi256(201);
        /// </code>
        /// </example>
        abstract member ansi256: (float -> ChalkInstance) with get, set
        /// <summary>
        /// Use RGB values to set background color.
        /// </summary>
        /// <example>
        /// <code>
        /// import chalk from 'chalk';
        ///
        /// chalk.bgRgb(222, 173, 237);
        /// </code>
        /// </example>
        abstract member bgRgb: ChalkInstance.bgRgb with get, set
        /// <summary>
        /// Use HEX value to set background color.
        /// </summary>
        /// <example>
        /// <code>
        /// import chalk from 'chalk';
        ///
        /// chalk.bgHex('#DEADED');
        /// </code>
        /// </example>
        /// <param name="color">
        /// Hexadecimal value representing the desired color.
        /// </param>
        abstract member bgHex: (string -> ChalkInstance) with get, set
        /// <summary>
        /// Use an [8-bit unsigned number](https://en.wikipedia.org/wiki/ANSI_escape_code#8-bit) to set background color.
        ///
        /// The value is downsampled to the 16-color palette on terminals that only support basic colors (level 1), so <c>chalk.bgAnsi256(196)</c> becomes 101 (ANSI escape for bright red background).
        /// </summary>
        /// <example>
        /// <code>
        /// import chalk from 'chalk';
        ///
        /// chalk.bgAnsi256(201);
        /// </code>
        /// </example>
        abstract member bgAnsi256: (float -> ChalkInstance) with get, set
        /// <summary>
        /// Use RGB values to set underline color.
        ///
        /// The underline color is only visible when an underline style is also applied.
        /// </summary>
        /// <example>
        /// <code>
        /// import chalk from 'chalk';
        ///
        /// chalk.underlineRgb(222, 173, 237).underlineCurly('Hello, world!');
        /// </code>
        /// </example>
        abstract member underlineRgb: ChalkInstance.underlineRgb with get, set
        /// <summary>
        /// Use HEX value to set underline color.
        ///
        /// The underline color is only visible when an underline style is also applied.
        /// </summary>
        /// <example>
        /// <code>
        /// import chalk from 'chalk';
        ///
        /// chalk.underlineHex('#DEADED').underlineCurly('Hello, world!');
        /// </code>
        /// </example>
        /// <param name="color">
        /// Hexadecimal value representing the desired color.
        /// </param>
        abstract member underlineHex: (string -> ChalkInstance) with get, set
        /// <summary>
        /// Use an [8-bit unsigned number](https://en.wikipedia.org/wiki/ANSI_escape_code#8-bit) to set underline color.
        ///
        /// The underline color is only visible when an underline style is also applied.
        ///
        /// The value is downsampled to the first 16 palette entries on terminals that only support basic colors (level 1), so <c>chalk.underlineAnsi256(196)</c> becomes 9 (the palette index for bright red).
        /// </summary>
        /// <example>
        /// <code>
        /// import chalk from 'chalk';
        ///
        /// chalk.underlineAnsi256(201).underlineCurly('Hello, world!');
        /// </code>
        /// </example>
        abstract member underlineAnsi256: (float -> ChalkInstance) with get, set
        /// <summary>
        /// Modifier: Reset the current style.
        /// </summary>
        abstract member reset: ChalkInstance with get
        /// <summary>
        /// Modifier: Make the text bold.
        /// </summary>
        abstract member bold: ChalkInstance with get
        /// <summary>
        /// Modifier: Make the text have lower opacity.
        /// </summary>
        abstract member dim: ChalkInstance with get
        /// <summary>
        /// Modifier: Make the text italic. *(Not widely supported)*
        /// </summary>
        abstract member italic: ChalkInstance with get
        /// <summary>
        /// Modifier: Put a horizontal line below the text. *(Not widely supported)*
        /// </summary>
        abstract member underline: ChalkInstance with get
        /// <summary>
        /// Modifier: Put a double horizontal line below the text. *(Not widely supported)*
        /// </summary>
        abstract member underlineDouble: ChalkInstance with get
        /// <summary>
        /// Modifier: Put a curly horizontal line below the text. *(Not widely supported)*
        /// </summary>
        abstract member underlineCurly: ChalkInstance with get
        /// <summary>
        /// Modifier: Put a dotted horizontal line below the text. *(Not widely supported)*
        /// </summary>
        abstract member underlineDotted: ChalkInstance with get
        /// <summary>
        /// Modifier: Put a dashed horizontal line below the text. *(Not widely supported)*
        /// </summary>
        abstract member underlineDashed: ChalkInstance with get
        /// <summary>
        /// Modifier: Put a horizontal line above the text. *(Not widely supported)*
        /// </summary>
        abstract member overline: ChalkInstance with get
        /// <summary>
        /// Modifier: Invert background and foreground colors.
        /// </summary>
        abstract member inverse: ChalkInstance with get
        /// <summary>
        /// Modifier: Print the text but make it invisible.
        /// </summary>
        abstract member hidden: ChalkInstance with get
        /// <summary>
        /// Modifier: Puts a horizontal line through the center of the text. *(Not widely supported)*
        /// </summary>
        abstract member strikethrough: ChalkInstance with get
        /// <summary>
        /// Modifier: Print the text only when Chalk has a color level above zero.
        ///
        /// Can be useful for things that are purely cosmetic.
        /// </summary>
        abstract member visible: ChalkInstance with get
        abstract member black: ChalkInstance with get
        abstract member red: ChalkInstance with get
        abstract member green: ChalkInstance with get
        abstract member yellow: ChalkInstance with get
        abstract member blue: ChalkInstance with get
        abstract member magenta: ChalkInstance with get
        abstract member cyan: ChalkInstance with get
        abstract member white: ChalkInstance with get
        /// <summary>
        /// Alias for <c>blackBright</c>.
        /// </summary>
        abstract member gray: ChalkInstance with get
        /// <summary>
        /// Alias for <c>blackBright</c>.
        /// </summary>
        abstract member grey: ChalkInstance with get
        abstract member blackBright: ChalkInstance with get
        abstract member redBright: ChalkInstance with get
        abstract member greenBright: ChalkInstance with get
        abstract member yellowBright: ChalkInstance with get
        abstract member blueBright: ChalkInstance with get
        abstract member magentaBright: ChalkInstance with get
        abstract member cyanBright: ChalkInstance with get
        abstract member whiteBright: ChalkInstance with get
        abstract member bgBlack: ChalkInstance with get
        abstract member bgRed: ChalkInstance with get
        abstract member bgGreen: ChalkInstance with get
        abstract member bgYellow: ChalkInstance with get
        abstract member bgBlue: ChalkInstance with get
        abstract member bgMagenta: ChalkInstance with get
        abstract member bgCyan: ChalkInstance with get
        abstract member bgWhite: ChalkInstance with get
        /// <summary>
        /// Alias for <c>bgBlackBright</c>.
        /// </summary>
        abstract member bgGray: ChalkInstance with get
        /// <summary>
        /// Alias for <c>bgBlackBright</c>.
        /// </summary>
        abstract member bgGrey: ChalkInstance with get
        abstract member bgBlackBright: ChalkInstance with get
        abstract member bgRedBright: ChalkInstance with get
        abstract member bgGreenBright: ChalkInstance with get
        abstract member bgYellowBright: ChalkInstance with get
        abstract member bgBlueBright: ChalkInstance with get
        abstract member bgMagentaBright: ChalkInstance with get
        abstract member bgCyanBright: ChalkInstance with get
        abstract member bgWhiteBright: ChalkInstance with get
        abstract member underlineBlack: ChalkInstance with get
        abstract member underlineRed: ChalkInstance with get
        abstract member underlineGreen: ChalkInstance with get
        abstract member underlineYellow: ChalkInstance with get
        abstract member underlineBlue: ChalkInstance with get
        abstract member underlineMagenta: ChalkInstance with get
        abstract member underlineCyan: ChalkInstance with get
        abstract member underlineWhite: ChalkInstance with get
        /// <summary>
        /// Alias for <c>underlineBlackBright</c>.
        /// </summary>
        abstract member underlineGray: ChalkInstance with get
        /// <summary>
        /// Alias for <c>underlineBlackBright</c>.
        /// </summary>
        abstract member underlineGrey: ChalkInstance with get
        abstract member underlineBlackBright: ChalkInstance with get
        abstract member underlineRedBright: ChalkInstance with get
        abstract member underlineGreenBright: ChalkInstance with get
        abstract member underlineYellowBright: ChalkInstance with get
        abstract member underlineBlueBright: ChalkInstance with get
        abstract member underlineMagentaBright: ChalkInstance with get
        abstract member underlineCyanBright: ChalkInstance with get
        abstract member underlineWhiteBright: ChalkInstance with get

    [<Obsolete("Use `ModifierName` instead.\n\nBasic modifier names.")>]
    type Modifiers =
        Chalk.ModifierName

    [<Obsolete("Use `ForegroundColorName` instead.\n\nBasic foreground color names.\n\n[More colors here.](https://github.com/chalk/chalk/blob/main/readme.md#256-and-truecolor-color-support)")>]
    type ForegroundColor =
        Chalk.ForegroundColorName

    [<Obsolete("Use `BackgroundColorName` instead.\n\nBasic background color names.\n\n[More colors here.](https://github.com/chalk/chalk/blob/main/readme.md#256-and-truecolor-color-support)")>]
    type BackgroundColor =
        Chalk.BackgroundColorName

    [<Obsolete("Use `ColorName` instead.\n\nBasic color names. The combination of foreground and background color names.\n\n[More colors here.](https://github.com/chalk/chalk/blob/main/readme.md#256-and-truecolor-color-support)")>]
    type Color =
        Chalk.ColorName

    [<AllowNullLiteral>]
    [<Interface>]
    type CSPair =
        /// <summary>
        /// The ANSI terminal control sequence for starting this style.
        /// </summary>
        abstract member ``open``: string with get
        /// <summary>
        /// The ANSI terminal control sequence for ending this style.
        /// </summary>
        abstract member close: string with get

    [<AllowNullLiteral>]
    [<Interface>]
    type ColorBase =
        /// <summary>
        /// The ANSI terminal control sequence for ending this color.
        /// </summary>
        abstract member close: string with get
        abstract member ansi: code: float -> string
        abstract member ansi256: code: float -> string
        abstract member ansi16m: red: float * green: float * blue: float -> string

    [<AllowNullLiteral>]
    [<Interface>]
    type Modifier =
        /// <summary>
        /// Resets the current color chain.
        /// </summary>
        abstract member reset: Chalk.CSPair with get
        /// <summary>
        /// Make text bold.
        /// </summary>
        abstract member bold: Chalk.CSPair with get
        /// <summary>
        /// Emitting only a small amount of light.
        /// </summary>
        abstract member dim: Chalk.CSPair with get
        /// <summary>
        /// Make text italic. (Not widely supported)
        /// </summary>
        abstract member italic: Chalk.CSPair with get
        /// <summary>
        /// Put a horizontal line below the text. (Not widely supported)
        /// </summary>
        abstract member underline: Chalk.CSPair with get
        /// <summary>
        /// Put a double horizontal line below the text. (Not widely supported)
        /// </summary>
        abstract member underlineDouble: Chalk.CSPair with get
        /// <summary>
        /// Put a curly horizontal line below the text. (Not widely supported)
        /// </summary>
        abstract member underlineCurly: Chalk.CSPair with get
        /// <summary>
        /// Put a dotted horizontal line below the text. (Not widely supported)
        /// </summary>
        abstract member underlineDotted: Chalk.CSPair with get
        /// <summary>
        /// Put a dashed horizontal line below the text. (Not widely supported)
        /// </summary>
        abstract member underlineDashed: Chalk.CSPair with get
        /// <summary>
        /// Put a horizontal line above the text.
        ///
        /// Supported on VTE-based terminals, the GNOME terminal, mintty, and Git Bash.
        /// </summary>
        abstract member overline: Chalk.CSPair with get
        /// <summary>
        /// Inverse background and foreground colors.
        /// </summary>
        abstract member inverse: Chalk.CSPair with get
        /// <summary>
        /// Prints the text, but makes it invisible.
        /// </summary>
        abstract member hidden: Chalk.CSPair with get
        /// <summary>
        /// Puts a horizontal line through the center of the text. (Not widely supported)
        /// </summary>
        abstract member strikethrough: Chalk.CSPair with get

    [<AllowNullLiteral>]
    [<Interface>]
    type UnderlineColor =
        abstract member underlineBlack: Chalk.CSPair with get
        abstract member underlineRed: Chalk.CSPair with get
        abstract member underlineGreen: Chalk.CSPair with get
        abstract member underlineYellow: Chalk.CSPair with get
        abstract member underlineBlue: Chalk.CSPair with get
        abstract member underlineCyan: Chalk.CSPair with get
        abstract member underlineMagenta: Chalk.CSPair with get
        abstract member underlineWhite: Chalk.CSPair with get
        /// <summary>
        /// Alias for <c>underlineBlackBright</c>.
        /// </summary>
        abstract member underlineGray: Chalk.CSPair with get
        /// <summary>
        /// Alias for <c>underlineBlackBright</c>.
        /// </summary>
        abstract member underlineGrey: Chalk.CSPair with get
        abstract member underlineBlackBright: Chalk.CSPair with get
        abstract member underlineRedBright: Chalk.CSPair with get
        abstract member underlineGreenBright: Chalk.CSPair with get
        abstract member underlineYellowBright: Chalk.CSPair with get
        abstract member underlineBlueBright: Chalk.CSPair with get
        abstract member underlineCyanBright: Chalk.CSPair with get
        abstract member underlineMagentaBright: Chalk.CSPair with get
        abstract member underlineWhiteBright: Chalk.CSPair with get

    [<AllowNullLiteral>]
    [<Interface>]
    type ConvertColor =
        /// <summary>
        /// Convert from the RGB color space to the ANSI 256 color space.
        /// </summary>
        /// <param name="red">
        /// (<c>0...255</c>)
        /// </param>
        /// <param name="green">
        /// (<c>0...255</c>)
        /// </param>
        /// <param name="blue">
        /// (<c>0...255</c>)
        /// </param>
        abstract member rgbToAnsi256: red: float * green: float * blue: float -> float
        /// <summary>
        /// Convert from the RGB HEX color space to the RGB color space.
        /// </summary>
        /// <param name="hex">
        /// A hexadecimal string containing RGB data.
        /// </param>
        abstract member hexToRgb: hex: string -> float * float * float
        /// <summary>
        /// Convert from the RGB HEX color space to the ANSI 256 color space.
        /// </summary>
        /// <param name="hex">
        /// A hexadecimal string containing RGB data.
        /// </param>
        abstract member hexToAnsi256: hex: string -> float
        /// <summary>
        /// Convert from the ANSI 256 color space to the ANSI 16 color space.
        /// </summary>
        /// <param name="code">
        /// A number representing the ANSI 256 color.
        /// </param>
        abstract member ansi256ToAnsi: code: float -> float
        /// <summary>
        /// Convert from the RGB color space to the ANSI 16 color space.
        /// </summary>
        /// <param name="red">
        /// (<c>0...255</c>)
        /// </param>
        /// <param name="green">
        /// (<c>0...255</c>)
        /// </param>
        /// <param name="blue">
        /// (<c>0...255</c>)
        /// </param>
        abstract member rgbToAnsi: red: float * green: float * blue: float -> float
        /// <summary>
        /// Convert from the RGB HEX color space to the ANSI 16 color space.
        /// </summary>
        /// <param name="hex">
        /// A hexadecimal string containing RGB data.
        /// </param>
        abstract member hexToAnsi: hex: string -> float

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ModifierName =
        | reset
        | bold
        | dim
        | italic
        | underline
        | underlineDouble
        | underlineCurly
        | underlineDotted
        | underlineDashed
        | overline
        | inverse
        | hidden
        | strikethrough

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ForegroundColorName =
        | black
        | red
        | green
        | yellow
        | blue
        | cyan
        | magenta
        | white
        | gray
        | grey
        | blackBright
        | redBright
        | greenBright
        | yellowBright
        | blueBright
        | cyanBright
        | magentaBright
        | whiteBright

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type BackgroundColorName =
        | bgBlack
        | bgRed
        | bgGreen
        | bgYellow
        | bgBlue
        | bgCyan
        | bgMagenta
        | bgWhite
        | bgGray
        | bgGrey
        | bgBlackBright
        | bgRedBright
        | bgGreenBright
        | bgYellowBright
        | bgBlueBright
        | bgCyanBright
        | bgMagentaBright
        | bgWhiteBright

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type UnderlineColorName =
        | underlineBlack
        | underlineRed
        | underlineGreen
        | underlineYellow
        | underlineBlue
        | underlineCyan
        | underlineMagenta
        | underlineWhite
        | underlineGray
        | underlineGrey
        | underlineBlackBright
        | underlineRedBright
        | underlineGreenBright
        | underlineYellowBright
        | underlineBlueBright
        | underlineCyanBright
        | underlineMagentaBright
        | underlineWhiteBright

    /// <summary>
    /// Basic color names. The combination of foreground and background color names.
    ///
    /// [More colors here.](https://github.com/chalk/chalk/blob/main/readme.md#256-and-truecolor-color-support)
    /// </summary>
    type ColorName =
        U2<Chalk.ForegroundColorName, Chalk.BackgroundColorName>

    [<RequireQualifiedAccess>]
    type ColorSupportLevel =
        | ``0`` = 0
        | ``1`` = 1
        | ``2`` = 2
        | ``3`` = 3

    [<AllowNullLiteral>]
    [<Interface>]
    type ColorSupport =
        /// <summary>
        /// The color level.
        /// </summary>
        abstract member level: Chalk.ColorSupportLevel with get, set
        /// <summary>
        /// Whether basic 16 colors are supported.
        /// </summary>
        abstract member hasBasic: bool with get, set
        /// <summary>
        /// Whether ANSI 256 colors are supported.
        /// </summary>
        abstract member has256: bool with get, set
        /// <summary>
        /// Whether Truecolor 16 million colors are supported.
        /// </summary>
        abstract member has16m: bool with get, set

    type ColorInfo =
        U2<Chalk.ColorSupport, bool>

    module source =

        module vendor =

            module ansi_styles =

                [<AllowNullLiteral>]
                [<Interface>]
                type ForegroundColor =
                    abstract member black: Chalk.CSPair with get
                    abstract member red: Chalk.CSPair with get
                    abstract member green: Chalk.CSPair with get
                    abstract member yellow: Chalk.CSPair with get
                    abstract member blue: Chalk.CSPair with get
                    abstract member cyan: Chalk.CSPair with get
                    abstract member magenta: Chalk.CSPair with get
                    abstract member white: Chalk.CSPair with get
                    /// <summary>
                    /// Alias for <c>blackBright</c>.
                    /// </summary>
                    abstract member gray: Chalk.CSPair with get
                    /// <summary>
                    /// Alias for <c>blackBright</c>.
                    /// </summary>
                    abstract member grey: Chalk.CSPair with get
                    abstract member blackBright: Chalk.CSPair with get
                    abstract member redBright: Chalk.CSPair with get
                    abstract member greenBright: Chalk.CSPair with get
                    abstract member yellowBright: Chalk.CSPair with get
                    abstract member blueBright: Chalk.CSPair with get
                    abstract member cyanBright: Chalk.CSPair with get
                    abstract member magentaBright: Chalk.CSPair with get
                    abstract member whiteBright: Chalk.CSPair with get

                [<AllowNullLiteral>]
                [<Interface>]
                type BackgroundColor =
                    abstract member bgBlack: Chalk.CSPair with get
                    abstract member bgRed: Chalk.CSPair with get
                    abstract member bgGreen: Chalk.CSPair with get
                    abstract member bgYellow: Chalk.CSPair with get
                    abstract member bgBlue: Chalk.CSPair with get
                    abstract member bgCyan: Chalk.CSPair with get
                    abstract member bgMagenta: Chalk.CSPair with get
                    abstract member bgWhite: Chalk.CSPair with get
                    /// <summary>
                    /// Alias for <c>bgBlackBright</c>.
                    /// </summary>
                    abstract member bgGray: Chalk.CSPair with get
                    /// <summary>
                    /// Alias for <c>bgBlackBright</c>.
                    /// </summary>
                    abstract member bgGrey: Chalk.CSPair with get
                    abstract member bgBlackBright: Chalk.CSPair with get
                    abstract member bgRedBright: Chalk.CSPair with get
                    abstract member bgGreenBright: Chalk.CSPair with get
                    abstract member bgYellowBright: Chalk.CSPair with get
                    abstract member bgBlueBright: Chalk.CSPair with get
                    abstract member bgCyanBright: Chalk.CSPair with get
                    abstract member bgMagentaBright: Chalk.CSPair with get
                    abstract member bgWhiteBright: Chalk.CSPair with get

            module supports_color =

                [<AllowNullLiteral>]
                [<Interface>]
                type Options =
                    /// <summary>
                    /// Whether <c>process.argv</c> should be sniffed for <c>--color</c> and <c>--no-color</c> flags.
                    /// </summary>
                    abstract member sniffFlags: bool option with get
                    [<ParamObject; Emit("$0")>]
                    static member Create (?sniffFlags: bool) : Options = nativeOnly

    module ChalkInstance =

        type rgb =
            delegate of red: float * green: float * blue: float -> ChalkInstance

        type bgRgb =
            delegate of red: float * green: float * blue: float -> ChalkInstance

        type underlineRgb =
            delegate of red: float * green: float * blue: float -> ChalkInstance

    module Exports =

        module Chalk__ =

            [<AllowNullLiteral>]
            [<Interface>]
            type Type =
                [<EmitConstructor>]
                abstract member Create: ?options: Chalk.Options -> Chalk.ChalkInstance

        module chalkStderr__ =

            module Type =

                module ChalkInstance =

                    type rgb =
                        delegate of red: float * green: float * blue: float -> ChalkInstance

                    type bgRgb =
                        delegate of red: float * green: float * blue: float -> ChalkInstance

                    type underlineRgb =
                        delegate of red: float * green: float * blue: float -> ChalkInstance

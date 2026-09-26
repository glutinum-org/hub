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
        static member inline supportsColor: Chalk.source_vendor_supports_color.ColorInfo = nativeOnly
        [<Import("chalkStderr", "chalk")>]
        static member inline chalkStderr: ChalkInstance = nativeOnly
        [<Import("supportsColorStderr", "chalk")>]
        static member inline supportsColorStderr: obj = nativeOnly
        /// <summary>
        /// Basic modifier names.
        /// </summary>
        [<Import("modifierNames", "chalk")>]
        static member inline modifierNames: ReadonlyArray<Chalk.source_vendor_ansi_styles.ModifierName> = nativeOnly
        /// <summary>
        /// Basic foreground color names.
        /// </summary>
        [<Import("foregroundColorNames", "chalk")>]
        static member inline foregroundColorNames: ReadonlyArray<Chalk.source_vendor_ansi_styles.ForegroundColorName> = nativeOnly
        /// <summary>
        /// Basic background color names.
        /// </summary>
        [<Import("backgroundColorNames", "chalk")>]
        static member inline backgroundColorNames: ReadonlyArray<Chalk.source_vendor_ansi_styles.BackgroundColorName> = nativeOnly
        /// <summary>
        /// Basic underline color names.
        /// </summary>
        [<Import("underlineColorNames", "chalk")>]
        static member inline underlineColorNames: ReadonlyArray<Chalk.source_vendor_ansi_styles.UnderlineColorName> = nativeOnly
        /// <summary>
        /// Basic color names. The combination of foreground and background color names.
        /// </summary>
        [<Import("colorNames", "chalk")>]
        static member inline colorNames: ReadonlyArray<Chalk.source_vendor_ansi_styles.ColorName> = nativeOnly
        [<Import("modifiers", "chalk")>]
        [<Obsolete("""Use `modifierNames` instead.

Basic modifier names.""")>]
        static member inline modifiers: ReadonlyArray<Chalk.source_vendor_ansi_styles.ModifierName> = nativeOnly
        [<Import("foregroundColors", "chalk")>]
        [<Obsolete("""Use `foregroundColorNames` instead.

Basic foreground color names.""")>]
        static member inline foregroundColors: ReadonlyArray<Chalk.source_vendor_ansi_styles.ForegroundColorName> = nativeOnly
        [<Import("backgroundColors", "chalk")>]
        [<Obsolete("""Use `backgroundColorNames` instead.

Basic background color names.""")>]
        static member inline backgroundColors: ReadonlyArray<Chalk.source_vendor_ansi_styles.BackgroundColorName> = nativeOnly
        [<Import("colors", "chalk")>]
        [<Obsolete("""Use `colorNames` instead.

Basic color names. The combination of foreground and background color names.""")>]
        static member inline colors: ReadonlyArray<Chalk.source_vendor_ansi_styles.ColorName> = nativeOnly
        [<ImportDefault("chalk")>]
        static member inline chalk: ChalkInstance = nativeOnly

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
        abstract member level: Chalk.source_vendor_supports_color.ColorSupportLevel option with get
        [<ParamObject; Emit("$0")>]
        static member Create (?level: Chalk.source_vendor_supports_color.ColorSupportLevel) : Options = nativeOnly

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
        abstract member level: Chalk.source_vendor_supports_color.ColorSupportLevel with get, set
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

    type ModifierName =
        Chalk.source_vendor_ansi_styles.ModifierName

    type ForegroundColorName =
        Chalk.source_vendor_ansi_styles.ForegroundColorName

    type BackgroundColorName =
        Chalk.source_vendor_ansi_styles.BackgroundColorName

    type UnderlineColorName =
        Chalk.source_vendor_ansi_styles.UnderlineColorName

    type ColorName =
        Chalk.source_vendor_ansi_styles.ColorName

    type ColorInfo =
        Chalk.source_vendor_supports_color.ColorInfo

    type ColorSupport =
        Chalk.source_vendor_supports_color.ColorSupport

    type ColorSupportLevel =
        Chalk.source_vendor_supports_color.ColorSupportLevel

    [<Obsolete("""Use `ModifierName` instead.

Basic modifier names.""")>]
    type Modifiers =
        Chalk.source_vendor_ansi_styles.ModifierName

    [<Obsolete("""Use `ForegroundColorName` instead.

Basic foreground color names.

[More colors here.](https://github.com/chalk/chalk/blob/main/readme.md#256-and-truecolor-color-support)""")>]
    type ForegroundColor =
        Chalk.source_vendor_ansi_styles.ForegroundColorName

    [<Obsolete("""Use `BackgroundColorName` instead.

Basic background color names.

[More colors here.](https://github.com/chalk/chalk/blob/main/readme.md#256-and-truecolor-color-support)""")>]
    type BackgroundColor =
        Chalk.source_vendor_ansi_styles.BackgroundColorName

    [<Obsolete("""Use `ColorName` instead.

Basic color names. The combination of foreground and background color names.

[More colors here.](https://github.com/chalk/chalk/blob/main/readme.md#256-and-truecolor-color-support)""")>]
    type Color =
        Chalk.source_vendor_ansi_styles.ColorName

    module source_vendor_ansi_styles =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            /// <summary>
            /// Basic modifier names.
            /// </summary>
            [<Import("modifierNames", "chalk/source/vendor/ansi-styles/index.js")>]
            static member inline modifierNames: ReadonlyArray<Chalk.source_vendor_ansi_styles.ModifierName> = nativeOnly
            /// <summary>
            /// Basic foreground color names.
            /// </summary>
            [<Import("foregroundColorNames", "chalk/source/vendor/ansi-styles/index.js")>]
            static member inline foregroundColorNames: ReadonlyArray<Chalk.source_vendor_ansi_styles.ForegroundColorName> = nativeOnly
            /// <summary>
            /// Basic background color names.
            /// </summary>
            [<Import("backgroundColorNames", "chalk/source/vendor/ansi-styles/index.js")>]
            static member inline backgroundColorNames: ReadonlyArray<Chalk.source_vendor_ansi_styles.BackgroundColorName> = nativeOnly
            /// <summary>
            /// Basic underline color names.
            /// </summary>
            [<Import("underlineColorNames", "chalk/source/vendor/ansi-styles/index.js")>]
            static member inline underlineColorNames: ReadonlyArray<Chalk.source_vendor_ansi_styles.UnderlineColorName> = nativeOnly
            /// <summary>
            /// Basic color names. The combination of foreground and background color names.
            /// </summary>
            [<Import("colorNames", "chalk/source/vendor/ansi-styles/index.js")>]
            static member inline colorNames: ReadonlyArray<Chalk.source_vendor_ansi_styles.ColorName> = nativeOnly
            [<ImportDefault("chalk/source/vendor/ansi-styles/index.js")>]
            static member inline ansiStyles: obj = nativeOnly

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
            abstract member reset: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Make text bold.
            /// </summary>
            abstract member bold: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Emitting only a small amount of light.
            /// </summary>
            abstract member dim: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Make text italic. (Not widely supported)
            /// </summary>
            abstract member italic: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Put a horizontal line below the text. (Not widely supported)
            /// </summary>
            abstract member underline: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Put a double horizontal line below the text. (Not widely supported)
            /// </summary>
            abstract member underlineDouble: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Put a curly horizontal line below the text. (Not widely supported)
            /// </summary>
            abstract member underlineCurly: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Put a dotted horizontal line below the text. (Not widely supported)
            /// </summary>
            abstract member underlineDotted: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Put a dashed horizontal line below the text. (Not widely supported)
            /// </summary>
            abstract member underlineDashed: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Put a horizontal line above the text.
            ///
            /// Supported on VTE-based terminals, the GNOME terminal, mintty, and Git Bash.
            /// </summary>
            abstract member overline: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Inverse background and foreground colors.
            /// </summary>
            abstract member inverse: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Prints the text, but makes it invisible.
            /// </summary>
            abstract member hidden: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Puts a horizontal line through the center of the text. (Not widely supported)
            /// </summary>
            abstract member strikethrough: Chalk.source_vendor_ansi_styles.CSPair with get

        [<AllowNullLiteral>]
        [<Interface>]
        type ForegroundColor =
            abstract member black: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member red: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member green: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member yellow: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member blue: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member cyan: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member magenta: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member white: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Alias for <c>blackBright</c>.
            /// </summary>
            abstract member gray: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Alias for <c>blackBright</c>.
            /// </summary>
            abstract member grey: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member blackBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member redBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member greenBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member yellowBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member blueBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member cyanBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member magentaBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member whiteBright: Chalk.source_vendor_ansi_styles.CSPair with get

        [<AllowNullLiteral>]
        [<Interface>]
        type BackgroundColor =
            abstract member bgBlack: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgRed: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgGreen: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgYellow: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgBlue: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgCyan: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgMagenta: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgWhite: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Alias for <c>bgBlackBright</c>.
            /// </summary>
            abstract member bgGray: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Alias for <c>bgBlackBright</c>.
            /// </summary>
            abstract member bgGrey: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgBlackBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgRedBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgGreenBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgYellowBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgBlueBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgCyanBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgMagentaBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member bgWhiteBright: Chalk.source_vendor_ansi_styles.CSPair with get

        [<AllowNullLiteral>]
        [<Interface>]
        type UnderlineColor =
            abstract member underlineBlack: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineRed: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineGreen: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineYellow: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineBlue: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineCyan: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineMagenta: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineWhite: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Alias for <c>underlineBlackBright</c>.
            /// </summary>
            abstract member underlineGray: Chalk.source_vendor_ansi_styles.CSPair with get
            /// <summary>
            /// Alias for <c>underlineBlackBright</c>.
            /// </summary>
            abstract member underlineGrey: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineBlackBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineRedBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineGreenBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineYellowBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineBlueBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineCyanBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineMagentaBright: Chalk.source_vendor_ansi_styles.CSPair with get
            abstract member underlineWhiteBright: Chalk.source_vendor_ansi_styles.CSPair with get

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
            U2<Chalk.source_vendor_ansi_styles.ForegroundColorName, Chalk.source_vendor_ansi_styles.BackgroundColorName>

    module source_vendor_supports_color =

        [<AbstractClass>]
        [<Erase>]
        type Exports =
            [<Import("createSupportsColor", "chalk/source/vendor/supports-color/index.js")>]
            static member createSupportsColor (?stream: obj, ?options: Chalk.source_vendor_supports_color.Options) : Chalk.source_vendor_supports_color.ColorInfo = nativeOnly
            [<ImportDefault("chalk/source/vendor/supports-color/index.js")>]
            static member inline supportsColor: Exports.supportsColor__.Type = nativeOnly

        [<AllowNullLiteral>]
        [<Interface>]
        type Options =
            /// <summary>
            /// Whether <c>process.argv</c> should be sniffed for <c>--color</c> and <c>--no-color</c> flags.
            /// </summary>
            abstract member sniffFlags: bool option with get

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
            abstract member level: Chalk.source_vendor_supports_color.ColorSupportLevel with get, set
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
            U2<Chalk.source_vendor_supports_color.ColorSupport, bool>

        module Exports =

            module supportsColor__ =

                [<AllowNullLiteral>]
                [<Interface>]
                type Type =
                    abstract member stdout: Chalk.source_vendor_supports_color.ColorInfo with get, set
                    abstract member stderr: Chalk.source_vendor_supports_color.ColorInfo with get, set
                    [<ParamObject; Emit("$0")>]
                    static member Create (stdout: Chalk.source_vendor_supports_color.ColorInfo, stderr: Chalk.source_vendor_supports_color.ColorInfo) : Type = nativeOnly

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

        module chalk__ =

            module Type =

                module ChalkInstance =

                    type rgb =
                        delegate of red: float * green: float * blue: float -> ChalkInstance

                    type bgRgb =
                        delegate of red: float * green: float * blue: float -> ChalkInstance

                    type underlineRgb =
                        delegate of red: float * green: float * blue: float -> ChalkInstance

# UnicodeNormalization
This project aims to create a substitute for String.Normalize() from .NET, which unfortunately isn't supported in Portable Class Libraries (which includes Windows Phone projects).

The algorithm used comes directly from [unorm](https://github.com/walling/unorm), a JavaScript implementation, which is released under MIT/GPL licenses. This project itself is released under the MIT license.

## Usage
Usage of this library is the same as the native Normalize method.

    using UnicodeNormalization;
    //...
    string text = "cafe\u0301";
    string normalized = text.Normalize(NormalizationForm.FormC); //café

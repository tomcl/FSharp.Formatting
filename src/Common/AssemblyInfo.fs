﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.Formatting")>]
[<assembly: AssemblyProductAttribute("FSharp.Formatting")>]
[<assembly: AssemblyDescriptionAttribute("A package for building great F# documentation, samples and blogs")>]
[<assembly: AssemblyVersionAttribute("2.3.1")>]
[<assembly: AssemblyFileVersionAttribute("2.3.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.3.1"
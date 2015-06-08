namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharpDomain")>]
[<assembly: AssemblyProductAttribute("FSharpDomain")>]
[<assembly: AssemblyDescriptionAttribute("Demonstration of F# being used in a C# project")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"

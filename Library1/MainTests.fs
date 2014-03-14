module MainTests

open NUnit.Framework
open FsUnit

[<Test>]
let ``addition`` () =
    Main.foo 1 |> should equal 2
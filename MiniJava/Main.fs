module Main

let foo x = x + 1

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

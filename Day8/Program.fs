﻿// Learn more about F# at http://fsharp.org

open System
open Day8

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let result = getSumOfMetadataFromFileName "input.txt"
    printfn "%A" (result)
    let result = getRootNodeValueFromFileName "input.txt"
    printfn "%A" (result)
    let text = Console.ReadLine()
    0 // return an integer exit code

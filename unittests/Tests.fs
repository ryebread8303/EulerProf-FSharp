module Tests

open System
open Xunit
open libs

[<Fact>]
let ``Project 1 - Multiples of 3 or 5`` () =
    let MultiplesOf3 = libs.Multiples.Of 3 10
    //let MultiplesOf5 = libs.Say.hello
    Assert.Equal<int>(seq {3 .. 3 .. 9}, MultiplesOf3)
    Assert.NotEqual<int> (libs.Multiples.Of 5 10, [3; 6; 9])

namespace libs

module Multiples =
    let Of multiplier upperBound =
        seq {multiplier .. multiplier .. upperBound}

module Say =
    let hello name =
        printfn "Hello %s" name

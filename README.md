# EulerProf-FSharp
a collection of FSharp scripts solving Euler Project problems.

The Library.fs file contains the functions I'm writing to help complete the problems. The actual problems will be solved by using the library in the interactive console. I'm writing these in F# using VSCode with the Ionide plugins.

# Library contents
The library is organized into modules containing related functions
## Multiples
Of: given a multiplier and an upper bound, it generates a seqence of multiples. It's basically just a wrapper around seq {}.
Ex.
let result = libs.Multiples.Of 3 9
//result is [3; 6; 9]
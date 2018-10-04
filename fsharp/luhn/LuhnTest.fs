// This file was auto-generated based on version 1.2.0 of the canonical data.

module LuhnTest

open FsUnit.Xunit
open Xunit

open Luhn

[<Fact>]
let ``Single digit strings can not be valid`` () =
    valid "1" |> should equal false

[<Fact>]
let ``A single zero is invalid`` () =
    valid "0" |> should equal false

[<Fact>]
let ``A simple valid SIN that remains valid if reversed`` () =
    valid "059" |> should equal true

[<Fact>]
let ``A simple valid SIN that becomes invalid if reversed`` () =
    valid "59" |> should equal true

[<Fact>]
let ``A valid Canadian SIN`` () =
    valid "055 444 285" |> should equal true

[<Fact>]
let ``Invalid Canadian SIN`` () =
    valid "055 444 286" |> should equal false

[<Fact>]
let ``Invalid credit card`` () =
    valid "8273 1232 7352 0569" |> should equal false

[<Fact>]
let ``Valid strings with a non-digit included become invalid`` () =
    valid "055a 444 285" |> should equal false

[<Fact>]
let ``Valid strings with punctuation included become invalid`` () =
    valid "055-444-285" |> should equal false

[<Fact>]
let ``Valid strings with symbols included become invalid`` () =
    valid "055£ 444$ 285" |> should equal false

[<Fact>]
let ``Single zero with space is invalid`` () =
    valid " 0" |> should equal false

[<Fact>]
let ``More than a single zero is valid`` () =
    valid "0000 0" |> should equal true

[<Fact>]
let ``Input digit 9 is correctly converted to output digit 9`` () =
    valid "091" |> should equal true

[<Fact>]
let ``Strings with non-digits is invalid`` () =
    valid ":9" |> should equal false


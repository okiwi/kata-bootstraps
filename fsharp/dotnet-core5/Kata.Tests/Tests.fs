module Tests

open FsUnit.Xunit
open Kata
open Xunit

[<Fact>]
let ``Hello test using Xunit`` () =
    Assert.Equal("Hello You", Say.hello "You")

[<Fact>]
let ``Hello world using FsUnit assertion library`` () =
    Say.hello "You"
    |> should equal "Hello You"

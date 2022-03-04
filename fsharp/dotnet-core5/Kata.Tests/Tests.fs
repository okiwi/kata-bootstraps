module Tests

open FsUnit.Xunit
open Kata
open Kata.MarsRoverKata
open Xunit

[<Fact>]
let ``Hello test using Xunit`` () =
    Assert.Equal("Hello You", Say.hello "World")

[<Fact>]
let ``Hello world using FsUnit assertion library`` () =
    Say.hello "You"
    |> should equal "Hello You"

[<Fact>]
let ``A l'arrivée, la position du Rover est (0, 0) et son orientation est le Nord`` () =
    roverJustLanded
    |> should equal {Position = (0, 0); Orientation = North}

[<Fact>]
let ``Je me déplace vers le nord`` () =
    move roverJustLanded [Forward]
    |> should equal {Position = (0, 1); Orientation = North}

[<Fact>]
let ``Je me déplace deux fois vers le nord`` () =
    move roverJustLanded [Forward;Forward]
    |> should equal {Position = (0, 2); Orientation = North}

[<Fact>]
let ``Je ne me déplace pas`` () =
    move roverJustLanded []
    |> should equal roverJustLanded

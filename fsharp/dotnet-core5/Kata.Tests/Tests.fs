module Tests

open FsUnit.Xunit
open Kata
open Kata.GameOfLife
open Xunit

//[<Fact>]
//let ``Hello test using Xunit`` () =
//    Assert.Equal("Hello You", Say.hello "World")

[<Fact>]
let ``Cell with three neighbours is alive``() =
    let cell: Cell = Alive(1, 1)
    let board: Cells = [ cell ]

    GameOfLife.next_generation board cell |> should equal (Alive(1, 1))

[<Fact>]
let ``Dead cell with two neighbours is alive``() =
    let cell: Cell = Dead
    let board: Cells = [ cell ]

    GameOfLife.next_generation board cell |> should equal Dead
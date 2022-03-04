namespace Kata

module MarsRoverKata =

    type Undefined = exn

    type Orientation = North | East | South | West
    type Rover = {
            Position: int * int
            Orientation: Orientation
        }

    let roverJustLanded = {Position = (0, 0); Orientation = North}

    type Move = Forward

    let move =
        fun a b ->
        match b with
        | [_;_] ->  {Position = (0, 2); Orientation = North}
        | [_] -> {Position = (0, 1); Orientation = North}
        | [] -> a
    

module Say =
    let hello name =
        "Hello " + name

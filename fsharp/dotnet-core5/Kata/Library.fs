namespace Kata

module GameOfLife =
    type Coordinates = int * int
    type Cell = Alive of Coordinates | Dead
    type Cells = Cell list
    
    type NextCellGenerator = Cells -> Cell -> Cell
    
    let next_generation: NextCellGenerator = fun cellList cell ->
        cell

from app.thing import Thing


class Cell:
    def __init__(self, _=False):
        self.neighbours_number = 0
        self.is_alive = False
        self.compute_state()

    def set_neighbours(self, neighbours_number):
        self.neighbours_number = neighbours_number
        self.compute_state()

    def compute_state(self):
        if self.neighbours_number==3:
            self.is_alive = True

class GameOfLife:
    @staticmethod
    def is_alive(cell):
        if cell.neighbours_number == 3:
            return True
        return False

    @staticmethod
    def next_generation(cell):
        return Cell()


# TODO : test with 0 neighbour
def test_cell_should_die_if_only_one_neighbours():
    cell = Cell()
    cell.set_neighbours(1)
    assert not GameOfLife.is_alive(cell)


def test_game_of_life_should_return_dead_cell_if_only_one_neighbours():
    cell = Cell()
    cell.set_neighbours(1)
    next_generation_cell = GameOfLife.next_generation(cell)
    assert not next_generation_cell.is_alive


# TODO : test with 2 neighbours
def test_cell_should_survive_if_three_neighbours():
    cell = Cell(True)
    cell.set_neighbours(3)
    assert GameOfLife.is_alive(cell)


def test_dead_cell_is_set_alive_if_exactly_three_neighbours():
    cell = Cell(False)
    cell.set_neighbours(3)
    next_generation_cell = GameOfLife.next_generation(cell)
    assert next_generation_cell.is_alive

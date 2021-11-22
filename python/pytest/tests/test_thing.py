from abc import ABC

from app.verifiesrules import VerifiesRules


class HoldsBasicCellInformation(ABC):
    def __init__(self, x: int, y: int):
        self.x = x
        self.y = y


class CreatesAliveCell(HoldsBasicCellInformation):
    def __init__(self, x: int, y: int):
        super().__init__(x, y)


class CreatesDeadCell(HoldsBasicCellInformation):
    def __init__(self, x: int, y: int):
        super().__init__(x, y)


def test_under_population():
    original_cell = CreatesAliveCell(2, 2)
    rule_verifier = VerifiesRules()
    actual_cell = rule_verifier.under_populated_cell_dies(original_cell)
    assert actual_cell is CreatesDeadCell(2, 2)

import pytest
from app.verifiesrules import VerifiesRules


@pytest.fixture
def thing():
    return VerifiesRules("Bob")


def test_correct_greeting(thing):
    assert "Hello Bob!" == thing.return_hello_name()


def test_fail(thing):
    assert "Wrong!" == thing.return_hello_name()

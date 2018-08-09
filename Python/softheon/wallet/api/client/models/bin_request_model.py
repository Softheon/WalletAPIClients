# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class BinRequestModel(Model):
    """The request model sent by the client for retrieving credit card bin
    information.

    :param card_number: The number on the credit card.
    :type card_number: str
    """

    _validation = {
        'card_number': {'required': True},
    }

    _attribute_map = {
        'card_number': {'key': 'cardNumber', 'type': 'str'},
    }

    def __init__(self, card_number):
        super(BinRequestModel, self).__init__()
        self.card_number = card_number

# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class CreditCardResponseModel(Model):
    """The response model sent to the client when a new credit card is added to
    the platform.

    :param token: The payment token for the credit card
    :type token: str
    :param card_state: The state that the credit card is in. Possible values
     include: 'Unknown', 'New', 'Authorized', 'Expired', 'Deleted', 'Invalid'
    :type card_state: str or ~softheon.wallet.api.client.models.enum
    :param code: The pre-authorization result code.
    :type code: str
    :param message: The pre-authorization result message.
    :type message: str
    :param redirect_url: The URL that the client will be redirected to after
     the credit card has been created.
    :type redirect_url: str
    """

    _attribute_map = {
        'token': {'key': 'token', 'type': 'str'},
        'card_state': {'key': 'cardState', 'type': 'str'},
        'code': {'key': 'code', 'type': 'str'},
        'message': {'key': 'message', 'type': 'str'},
        'redirect_url': {'key': 'redirectUrl', 'type': 'str'},
    }

    def __init__(self, token=None, card_state=None, code=None, message=None, redirect_url=None):
        super(CreditCardResponseModel, self).__init__()
        self.token = token
        self.card_state = card_state
        self.code = code
        self.message = message
        self.redirect_url = redirect_url
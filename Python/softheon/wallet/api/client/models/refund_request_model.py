# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class RefundRequestModel(Model):
    """The request model sent by the client to add a new refund to the platform.

    :param amount: The amount to be refunded.  If an amount less than the
     original payment amount is
     specified, a partial refund will be processed.  If no amount is specified,
     a full refund
     will be processed.
    :type amount: float
    :param reason: The reason for issuing the refund.
    :type reason: str
    """

    _validation = {
        'reason': {'required': True},
    }

    _attribute_map = {
        'amount': {'key': 'amount', 'type': 'float'},
        'reason': {'key': 'reason', 'type': 'str'},
    }

    def __init__(self, reason, amount=None):
        super(RefundRequestModel, self).__init__()
        self.amount = amount
        self.reason = reason

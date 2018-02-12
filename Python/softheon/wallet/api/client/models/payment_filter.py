# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class PaymentFilter(Model):
    """Defines a payment filter when requesting a collection of payments.

    :param reference_id: The client application provided reference ID for the
     payment.
    :type reference_id: str
    :param min_date: The optional lower bound of the range for payment date.
    :type min_date: datetime
    :param max_date: The optional upper bound of the range for payment date.
    :type max_date: datetime
    """

    _validation = {
        'reference_id': {'required': True},
    }

    _attribute_map = {
        'reference_id': {'key': 'referenceId', 'type': 'str'},
        'min_date': {'key': 'minDate', 'type': 'iso-8601'},
        'max_date': {'key': 'maxDate', 'type': 'iso-8601'},
    }

    def __init__(self, reference_id, min_date=None, max_date=None):
        super(PaymentFilter, self).__init__()
        self.reference_id = reference_id
        self.min_date = min_date
        self.max_date = max_date
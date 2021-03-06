# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class PaymentModel(Model):
    """The model sent to the client requests the details of a payment, or adds a
    new payment
    to the platform.

    :param id: The unique ID of the payment.
    :type id: long
    :param account_id: The unique ID of the account that the payment was made
     for.
    :type account_id: int
    :param payment_amount: The payment amount.
    :type payment_amount: float
    :param description: The description of what was paid for.
    :type description: str
    :param reference_id: The client application provided reference ID for the
     payment.
    :type reference_id: str
    :param payment_method: The method of payment.
    :type payment_method:
     ~softheon.wallet.api.client.models.PaymentMethodModel
    :param result: The result of the payment request.
    :type result: ~softheon.wallet.api.client.models.PaymentResultModel
    :param refunds: Gets or sets the refund result.
    :type refunds: list[~softheon.wallet.api.client.models.RefundResultModel]
    :param created_date: The timestamp indicating when the payment was
     created.
    :type created_date: datetime
    :param modified_date: The timestamp indicating the last time that the
     details of the payment were modified.
    :type modified_date: datetime
    """

    _attribute_map = {
        'id': {'key': 'id', 'type': 'long'},
        'account_id': {'key': 'accountId', 'type': 'int'},
        'payment_amount': {'key': 'paymentAmount', 'type': 'float'},
        'description': {'key': 'description', 'type': 'str'},
        'reference_id': {'key': 'referenceId', 'type': 'str'},
        'payment_method': {'key': 'paymentMethod', 'type': 'PaymentMethodModel'},
        'result': {'key': 'result', 'type': 'PaymentResultModel'},
        'refunds': {'key': 'refunds', 'type': '[RefundResultModel]'},
        'created_date': {'key': 'createdDate', 'type': 'iso-8601'},
        'modified_date': {'key': 'modifiedDate', 'type': 'iso-8601'},
    }

    def __init__(self, id=None, account_id=None, payment_amount=None, description=None, reference_id=None, payment_method=None, result=None, refunds=None, created_date=None, modified_date=None):
        super(PaymentModel, self).__init__()
        self.id = id
        self.account_id = account_id
        self.payment_amount = payment_amount
        self.description = description
        self.reference_id = reference_id
        self.payment_method = payment_method
        self.result = result
        self.refunds = refunds
        self.created_date = created_date
        self.modified_date = modified_date

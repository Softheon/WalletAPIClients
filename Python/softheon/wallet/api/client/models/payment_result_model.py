# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class PaymentResultModel(Model):
    """The model sent to the client as a part of the payment model.
    Provides details on the payment result.

    :param status: The current status of the payment. Possible values include:
     'Unknown', 'New', 'Authorized', 'Captured', 'Expired', 'Declined',
     'Failed', 'Cancelled', 'Charge Back', 'Refunded', 'Partially Refunded'
    :type status: str or ~softheon.wallet.api.client.models.enum
    :param code: The payment result code.
    :type code: str
    :param message: The payment result message.
    :type message: str
    :param provider_account_id: The unique ID of the provider account that was
     used to make this payment.
    :type provider_account_id: str
    :param merchant_transaction_id: Tthe merchant transaction identifier.
    :type merchant_transaction_id: str
    :param merchant_transaction_fee: The merchant transaction fee.
    :type merchant_transaction_fee: float
    """

    _attribute_map = {
        'status': {'key': 'status', 'type': 'str'},
        'code': {'key': 'code', 'type': 'str'},
        'message': {'key': 'message', 'type': 'str'},
        'provider_account_id': {'key': 'providerAccountId', 'type': 'str'},
        'merchant_transaction_id': {'key': 'merchantTransactionId', 'type': 'str'},
        'merchant_transaction_fee': {'key': 'merchantTransactionFee', 'type': 'float'},
    }

    def __init__(self, status=None, code=None, message=None, provider_account_id=None, merchant_transaction_id=None, merchant_transaction_fee=None):
        super(PaymentResultModel, self).__init__()
        self.status = status
        self.code = code
        self.message = message
        self.provider_account_id = provider_account_id
        self.merchant_transaction_id = merchant_transaction_id
        self.merchant_transaction_fee = merchant_transaction_fee

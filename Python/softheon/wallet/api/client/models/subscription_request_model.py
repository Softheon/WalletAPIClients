# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class SubscriptionRequestModel(Model):
    """The request model sent by the client for adding new subscription to the
    payment platform.

    :param name: The name of payment subscription.
    :type name: str
    :param description: The description of payment subscription.
    :type description: str
    :param properties: The properties of the payment subscription.
    :type properties: dict[str, str]
    :param run_day: The process day of the payment subscription.
    :type run_day: int
    :param state: The state that payment subscription is in. Possible values
     include: 'Active', 'Inactive', 'Expired'
    :type state: str or ~softheon.wallet.api.client.models.enum
    :param payment_type: The payment type of the payment subscription.
     Possible values include: 'Unknown', 'Credit Card', 'ACH'
    :type payment_type: str or ~softheon.wallet.api.client.models.enum
    :param payment_token: The payment token of the payment subscription.
    :type payment_token: str
    :param amount_type: The amount type of the payment subscription. Possible
     values include: 'Fixed', 'Dynamic'
    :type amount_type: str or ~softheon.wallet.api.client.models.enum
    :param amount: The amount of money to be charged by the payment
     subscription.
    :type amount: float
    :param amount_web_service_url: The url of web api to use to retrieve the
     amount to be charged by the payment subscription.
    :type amount_web_service_url: str
    :param callback_web_service_url: The url of a web api to use to post back
     notifications each time payment subscription is processed.
    :type callback_web_service_url: str
    :param end_date: The date indicating when the payment subscription should
     be stopped.
    :type end_date: datetime
    :param reference_id: The client application provided reference ID for the
     credit card.
    :type reference_id: str
    """

    _validation = {
        'name': {'required': True},
        'run_day': {'required': True, 'maximum': 31, 'minimum': 1},
        'state': {'required': True},
        'payment_type': {'required': True},
        'payment_token': {'required': True},
        'amount_type': {'required': True},
    }

    _attribute_map = {
        'name': {'key': 'name', 'type': 'str'},
        'description': {'key': 'description', 'type': 'str'},
        'properties': {'key': 'properties', 'type': '{str}'},
        'run_day': {'key': 'runDay', 'type': 'int'},
        'state': {'key': 'state', 'type': 'str'},
        'payment_type': {'key': 'paymentType', 'type': 'str'},
        'payment_token': {'key': 'paymentToken', 'type': 'str'},
        'amount_type': {'key': 'amountType', 'type': 'str'},
        'amount': {'key': 'amount', 'type': 'float'},
        'amount_web_service_url': {'key': 'amountWebServiceURL', 'type': 'str'},
        'callback_web_service_url': {'key': 'callbackWebServiceURL', 'type': 'str'},
        'end_date': {'key': 'endDate', 'type': 'iso-8601'},
        'reference_id': {'key': 'referenceId', 'type': 'str'},
    }

    def __init__(self, name, run_day, state, payment_type, payment_token, amount_type, description=None, properties=None, amount=None, amount_web_service_url=None, callback_web_service_url=None, end_date=None, reference_id=None):
        super(SubscriptionRequestModel, self).__init__()
        self.name = name
        self.description = description
        self.properties = properties
        self.run_day = run_day
        self.state = state
        self.payment_type = payment_type
        self.payment_token = payment_token
        self.amount_type = amount_type
        self.amount = amount
        self.amount_web_service_url = amount_web_service_url
        self.callback_web_service_url = callback_web_service_url
        self.end_date = end_date
        self.reference_id = reference_id
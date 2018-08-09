<?php
namespace ;
final class SoftheonWalletAPI
{
    /**
     * @param \Microsoft\Rest\RunTimeInterface $_runTime
     * @param string $subscriptionId
     */
    public function __construct(
        \Microsoft\Rest\RunTimeInterface $_runTime,
        $subscriptionId
    )
    {
        $_client = $_runTime->createClientFromData(
            self::_SWAGGER_OBJECT_DATA,
            ['subscriptionId' => $subscriptionId]
        );
        $this->_GetBankAccountByToken_operation = $_client->createOperation('GetBankAccountByToken');
        $this->_GetBankAccountsByReferenceId_operation = $_client->createOperation('GetBankAccountsByReferenceId');
        $this->_UpdateBankAccount_operation = $_client->createOperation('UpdateBankAccount');
        $this->_CreateBankAccount_operation = $_client->createOperation('CreateBankAccount');
        $this->_GetBin_operation = $_client->createOperation('GetBin');
        $this->_GetCheckout_operation = $_client->createOperation('GetCheckout');
        $this->_CreateCheckout_operation = $_client->createOperation('CreateCheckout');
        $this->_GetCreditCardsByReferenceId_operation = $_client->createOperation('GetCreditCardsByReferenceId');
        $this->_UpdateCreditCard_operation = $_client->createOperation('UpdateCreditCard');
        $this->_CreateCreditCard_operation = $_client->createOperation('CreateCreditCard');
        $this->_GetPayment_operation = $_client->createOperation('GetPayment');
        $this->_GetPaymentsByReferenceId_operation = $_client->createOperation('GetPaymentsByReferenceId');
        $this->_CreatePayment_operation = $_client->createOperation('CreatePayment');
        $this->_GetRefunds_operation = $_client->createOperation('GetRefunds');
        $this->_CreateRefund_operation = $_client->createOperation('CreateRefund');
        $this->_GetSubscription_operation = $_client->createOperation('GetSubscription');
        $this->_GetSubscriptionsByReferenceId_operation = $_client->createOperation('GetSubscriptionsByReferenceId');
        $this->_UpdateSubscription_operation = $_client->createOperation('UpdateSubscription');
        $this->_CreateSubscription_operation = $_client->createOperation('CreateSubscription');
        $this->_GetWallet_operation = $_client->createOperation('GetWallet');
        $this->_UpdateWallet_operation = $_client->createOperation('UpdateWallet');
        $this->_GetWalletByReferenceId_operation = $_client->createOperation('GetWalletByReferenceId');
        $this->_CreateWallet_operation = $_client->createOperation('CreateWallet');
        $this->_AddWalletCreditCard_operation = $_client->createOperation('AddWalletCreditCard');
        $this->_AddWalletBankAccount_operation = $_client->createOperation('AddWalletBankAccount');
        $this->_RemoveWalletBankAccount_operation = $_client->createOperation('RemoveWalletBankAccount');
        $this->_RemoveWalletCreditCard_operation = $_client->createOperation('RemoveWalletCreditCard');
    }
    /**
     * @param string $token
     * @return array
     */
    public function getBankAccountByToken($token)
    {
        return $this->_GetBankAccountByToken_operation->call(['token' => $token]);
    }
    /**
     * @param string $referenceId
     * @return array[]
     */
    public function getBankAccountsByReferenceId($referenceId)
    {
        return $this->_GetBankAccountsByReferenceId_operation->call(['referenceId' => $referenceId]);
    }
    /**
     * @param array $updateBankAccountModel
     */
    public function updateBankAccount(array $updateBankAccountModel)
    {
        return $this->_UpdateBankAccount_operation->call(['updateBankAccountModel' => $updateBankAccountModel]);
    }
    /**
     * @param array $bankAccountRequest
     * @return array
     */
    public function createBankAccount(array $bankAccountRequest)
    {
        return $this->_CreateBankAccount_operation->call(['bankAccountRequest' => $bankAccountRequest]);
    }
    /**
     * @param array $binRequest
     * @return array
     */
    public function getBin(array $binRequest)
    {
        return $this->_GetBin_operation->call(['binRequest' => $binRequest]);
    }
    /**
     * @param integer $checkoutId
     * @return array
     */
    public function getCheckout($checkoutId)
    {
        return $this->_GetCheckout_operation->call(['checkoutId' => $checkoutId]);
    }
    /**
     * @param array $model
     * @return array
     */
    public function createCheckout(array $model)
    {
        return $this->_CreateCheckout_operation->call(['model' => $model]);
    }
    /**
     * @param string $referenceId
     * @return array[]
     */
    public function getCreditCardsByReferenceId($referenceId)
    {
        return $this->_GetCreditCardsByReferenceId_operation->call(['referenceId' => $referenceId]);
    }
    /**
     * @param array $updateCreditCardModel
     */
    public function updateCreditCard(array $updateCreditCardModel)
    {
        return $this->_UpdateCreditCard_operation->call(['updateCreditCardModel' => $updateCreditCardModel]);
    }
    /**
     * @param array $creditCardRequest
     * @return array
     */
    public function createCreditCard(array $creditCardRequest)
    {
        return $this->_CreateCreditCard_operation->call(['creditCardRequest' => $creditCardRequest]);
    }
    /**
     * @param integer $id
     * @return array
     */
    public function getPayment($id)
    {
        return $this->_GetPayment_operation->call(['id' => $id]);
    }
    /**
     * @param string|null $referenceId
     * @param string|null $minDate
     * @param string|null $maxDate
     * @return array[]
     */
    public function getPaymentsByReferenceId(
        $referenceId = null,
        $minDate = null,
        $maxDate = null
    )
    {
        return $this->_GetPaymentsByReferenceId_operation->call([
            'referenceId' => $referenceId,
            'minDate' => $minDate,
            'maxDate' => $maxDate
        ]);
    }
    /**
     * @param array $paymentRequest
     * @return array
     */
    public function createPayment(array $paymentRequest)
    {
        return $this->_CreatePayment_operation->call(['paymentRequest' => $paymentRequest]);
    }
    /**
     * @param integer $id
     * @return array[]
     */
    public function getRefunds($id)
    {
        return $this->_GetRefunds_operation->call(['id' => $id]);
    }
    /**
     * @param integer $id
     * @param array $refundRequestModel
     * @return array
     */
    public function createRefund(
        $id,
        array $refundRequestModel
    )
    {
        return $this->_CreateRefund_operation->call([
            'id' => $id,
            'refundRequestModel' => $refundRequestModel
        ]);
    }
    /**
     * @param string $id
     * @return array
     */
    public function getSubscription($id)
    {
        return $this->_GetSubscription_operation->call(['id' => $id]);
    }
    /**
     * @param string $referenceId
     * @return array[]
     */
    public function getSubscriptionsByReferenceId($referenceId)
    {
        return $this->_GetSubscriptionsByReferenceId_operation->call(['referenceId' => $referenceId]);
    }
    /**
     * @param array $updateSubscriptionModel
     */
    public function updateSubscription(array $updateSubscriptionModel)
    {
        return $this->_UpdateSubscription_operation->call(['updateSubscriptionModel' => $updateSubscriptionModel]);
    }
    /**
     * @param array $subscriptionRequest
     * @return array
     */
    public function createSubscription(array $subscriptionRequest)
    {
        return $this->_CreateSubscription_operation->call(['subscriptionRequest' => $subscriptionRequest]);
    }
    /**
     * @param integer $walletId
     * @return array
     */
    public function getWallet($walletId)
    {
        return $this->_GetWallet_operation->call(['walletId' => $walletId]);
    }
    /**
     * @param integer $walletId
     * @param string $defaultPaymentToken
     */
    public function updateWallet(
        $walletId,
        $defaultPaymentToken
    )
    {
        return $this->_UpdateWallet_operation->call([
            'walletId' => $walletId,
            'defaultPaymentToken' => $defaultPaymentToken
        ]);
    }
    /**
     * @param string $referenceId
     * @return array
     */
    public function getWalletByReferenceId($referenceId)
    {
        return $this->_GetWalletByReferenceId_operation->call(['referenceId' => $referenceId]);
    }
    /**
     * @param array $model
     * @return integer
     */
    public function createWallet(array $model)
    {
        return $this->_CreateWallet_operation->call(['model' => $model]);
    }
    /**
     * @param integer $walletId
     * @param array $request
     * @return array
     */
    public function addWalletCreditCard(
        $walletId,
        array $request
    )
    {
        return $this->_AddWalletCreditCard_operation->call([
            'walletId' => $walletId,
            'request' => $request
        ]);
    }
    /**
     * @param integer $walletId
     * @param array $request
     * @return array
     */
    public function addWalletBankAccount(
        $walletId,
        array $request
    )
    {
        return $this->_AddWalletBankAccount_operation->call([
            'walletId' => $walletId,
            'request' => $request
        ]);
    }
    /**
     * @param integer $walletId
     * @param integer $walletBankAcctId
     */
    public function removeWalletBankAccount(
        $walletId,
        $walletBankAcctId
    )
    {
        return $this->_RemoveWalletBankAccount_operation->call([
            'walletId' => $walletId,
            'walletBankAcctId' => $walletBankAcctId
        ]);
    }
    /**
     * @param integer $walletId
     * @param integer $walletCreditCardId
     */
    public function removeWalletCreditCard(
        $walletId,
        $walletCreditCardId
    )
    {
        return $this->_RemoveWalletCreditCard_operation->call([
            'walletId' => $walletId,
            'walletCreditCardId' => $walletCreditCardId
        ]);
    }
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetBankAccountByToken_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetBankAccountsByReferenceId_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_UpdateBankAccount_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_CreateBankAccount_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetBin_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetCheckout_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_CreateCheckout_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetCreditCardsByReferenceId_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_UpdateCreditCard_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_CreateCreditCard_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetPayment_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetPaymentsByReferenceId_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_CreatePayment_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetRefunds_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_CreateRefund_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetSubscription_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetSubscriptionsByReferenceId_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_UpdateSubscription_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_CreateSubscription_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetWallet_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_UpdateWallet_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_GetWalletByReferenceId_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_CreateWallet_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_AddWalletCreditCard_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_AddWalletBankAccount_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_RemoveWalletBankAccount_operation;
    /**
     * @var \Microsoft\Rest\OperationInterface
     */
    private $_RemoveWalletCreditCard_operation;
    const _SWAGGER_OBJECT_DATA = [
        'host' => 'api-model.softheon.com',
        'paths' => [
            '/v2/bankaccounts/{token}' => ['get' => [
                'operationId' => 'GetBankAccountByToken',
                'parameters' => [[
                    'name' => 'token',
                    'in' => 'path',
                    'required' => TRUE,
                    'type' => 'string'
                ]],
                'responses' => [
                    '200' => ['schema' => ['$ref' => '#/definitions/BankAccountModel']],
                    '401' => [],
                    '403' => [],
                    '404' => []
                ]
            ]],
            '/v2/bankaccounts' => [
                'get' => [
                    'operationId' => 'GetBankAccountsByReferenceId',
                    'parameters' => [[
                        'name' => 'referenceId',
                        'in' => 'query',
                        'required' => TRUE,
                        'type' => 'string'
                    ]],
                    'responses' => [
                        '200' => ['schema' => [
                            'type' => 'array',
                            'items' => ['$ref' => '#/definitions/BankAccountModel']
                        ]],
                        '401' => []
                    ]
                ],
                'put' => [
                    'operationId' => 'UpdateBankAccount',
                    'parameters' => [[
                        'name' => 'updateBankAccountModel',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/UpdateBankAccountModel']
                    ]],
                    'responses' => [
                        '204' => [],
                        '400' => [],
                        '401' => []
                    ]
                ],
                'post' => [
                    'operationId' => 'CreateBankAccount',
                    'parameters' => [[
                        'name' => 'bankAccountRequest',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/BankAccountRequestModel']
                    ]],
                    'responses' => [
                        '200' => ['schema' => ['$ref' => '#/definitions/BankAccountResponseModel']],
                        '400' => [],
                        '401' => []
                    ]
                ]
            ],
            '/v2/bins' => ['post' => [
                'operationId' => 'GetBin',
                'parameters' => [[
                    'name' => 'binRequest',
                    'in' => 'body',
                    'required' => TRUE,
                    'schema' => ['$ref' => '#/definitions/BinRequestModel']
                ]],
                'responses' => [
                    '200' => ['schema' => ['$ref' => '#/definitions/Bin']],
                    '401' => [],
                    '404' => []
                ]
            ]],
            '/v2/checkouts' => [
                'get' => [
                    'operationId' => 'GetCheckout',
                    'parameters' => [[
                        'name' => 'checkoutId',
                        'in' => 'query',
                        'required' => TRUE,
                        'type' => 'integer',
                        'format' => 'int32'
                    ]],
                    'responses' => [
                        '200' => ['schema' => ['$ref' => '#/definitions/CheckoutResponseModel']],
                        '401' => [],
                        '404' => []
                    ]
                ],
                'post' => [
                    'operationId' => 'CreateCheckout',
                    'parameters' => [[
                        'name' => 'model',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/CheckoutRequestModel']
                    ]],
                    'responses' => [
                        '201' => ['schema' => ['$ref' => '#/definitions/CheckoutResponseModel']],
                        '400' => [],
                        '401' => []
                    ]
                ]
            ],
            '/v2/creditcards' => [
                'get' => [
                    'operationId' => 'GetCreditCardsByReferenceId',
                    'parameters' => [[
                        'name' => 'referenceId',
                        'in' => 'query',
                        'required' => TRUE,
                        'type' => 'string'
                    ]],
                    'responses' => [
                        '200' => ['schema' => [
                            'type' => 'array',
                            'items' => ['$ref' => '#/definitions/CreditCardModel']
                        ]],
                        '401' => []
                    ]
                ],
                'put' => [
                    'operationId' => 'UpdateCreditCard',
                    'parameters' => [[
                        'name' => 'updateCreditCardModel',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/UpdateCreditCardModel']
                    ]],
                    'responses' => [
                        '204' => [],
                        '400' => [],
                        '401' => []
                    ]
                ],
                'post' => [
                    'operationId' => 'CreateCreditCard',
                    'parameters' => [[
                        'name' => 'creditCardRequest',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/CreditCardRequestModel']
                    ]],
                    'responses' => [
                        '200' => ['schema' => ['$ref' => '#/definitions/CreditCardResponseModel']],
                        '400' => [],
                        '401' => []
                    ]
                ]
            ],
            '/v2/payments/{id}' => ['get' => [
                'operationId' => 'GetPayment',
                'parameters' => [[
                    'name' => 'id',
                    'in' => 'path',
                    'required' => TRUE,
                    'type' => 'integer',
                    'format' => 'int32'
                ]],
                'responses' => [
                    '200' => ['schema' => ['$ref' => '#/definitions/PaymentModel']],
                    '401' => [],
                    '404' => []
                ]
            ]],
            '/v2/payments' => [
                'get' => [
                    'operationId' => 'GetPaymentsByReferenceId',
                    'parameters' => [
                        [
                            'name' => 'referenceId',
                            'in' => 'query',
                            'required' => FALSE,
                            'type' => 'string'
                        ],
                        [
                            'name' => 'minDate',
                            'in' => 'query',
                            'required' => FALSE,
                            'type' => 'string',
                            'format' => 'date-time'
                        ],
                        [
                            'name' => 'maxDate',
                            'in' => 'query',
                            'required' => FALSE,
                            'type' => 'string',
                            'format' => 'date-time'
                        ]
                    ],
                    'responses' => [
                        '200' => ['schema' => [
                            'type' => 'array',
                            'items' => ['$ref' => '#/definitions/PaymentModel']
                        ]],
                        '401' => []
                    ]
                ],
                'post' => [
                    'operationId' => 'CreatePayment',
                    'parameters' => [[
                        'name' => 'paymentRequest',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/PaymentRequestModel']
                    ]],
                    'responses' => [
                        '201' => ['schema' => ['$ref' => '#/definitions/PaymentModel']],
                        '400' => [],
                        '401' => []
                    ]
                ]
            ],
            '/v2/payments/{id}/refunds' => [
                'get' => [
                    'operationId' => 'GetRefunds',
                    'parameters' => [[
                        'name' => 'id',
                        'in' => 'path',
                        'required' => TRUE,
                        'type' => 'integer',
                        'format' => 'int32'
                    ]],
                    'responses' => [
                        '200' => ['schema' => [
                            'type' => 'array',
                            'items' => ['$ref' => '#/definitions/RefundResultModel']
                        ]],
                        '401' => []
                    ]
                ],
                'post' => [
                    'operationId' => 'CreateRefund',
                    'parameters' => [
                        [
                            'name' => 'id',
                            'in' => 'path',
                            'required' => TRUE,
                            'type' => 'integer',
                            'format' => 'int32'
                        ],
                        [
                            'name' => 'refundRequestModel',
                            'in' => 'body',
                            'required' => TRUE,
                            'schema' => ['$ref' => '#/definitions/RefundRequestModel']
                        ]
                    ],
                    'responses' => [
                        '200' => ['schema' => ['$ref' => '#/definitions/RefundResultModel']],
                        '401' => [],
                        '404' => []
                    ]
                ]
            ],
            '/v2/subscriptions/{id}' => ['get' => [
                'operationId' => 'GetSubscription',
                'parameters' => [[
                    'name' => 'id',
                    'in' => 'path',
                    'required' => TRUE,
                    'type' => 'string'
                ]],
                'responses' => [
                    '200' => ['schema' => ['$ref' => '#/definitions/SubscriptionModel']],
                    '401' => [],
                    '404' => []
                ]
            ]],
            '/v2/subscriptions' => [
                'get' => [
                    'operationId' => 'GetSubscriptionsByReferenceId',
                    'parameters' => [[
                        'name' => 'referenceId',
                        'in' => 'query',
                        'required' => TRUE,
                        'type' => 'string'
                    ]],
                    'responses' => [
                        '200' => ['schema' => [
                            'type' => 'array',
                            'items' => ['$ref' => '#/definitions/SubscriptionModel']
                        ]],
                        '401' => []
                    ]
                ],
                'put' => [
                    'operationId' => 'UpdateSubscription',
                    'parameters' => [[
                        'name' => 'updateSubscriptionModel',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/UpdateSubscriptionModel']
                    ]],
                    'responses' => [
                        '204' => [],
                        '401' => []
                    ]
                ],
                'post' => [
                    'operationId' => 'CreateSubscription',
                    'parameters' => [[
                        'name' => 'subscriptionRequest',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/SubscriptionRequestModel']
                    ]],
                    'responses' => [
                        '200' => ['schema' => ['$ref' => '#/definitions/SubscriptionResponseModel']],
                        '400' => [],
                        '401' => [],
                        '409' => []
                    ]
                ]
            ],
            '/v2/wallet/{walletId}' => [
                'get' => [
                    'operationId' => 'GetWallet',
                    'parameters' => [[
                        'name' => 'walletId',
                        'in' => 'path',
                        'required' => TRUE,
                        'type' => 'integer',
                        'format' => 'int32'
                    ]],
                    'responses' => [
                        '200' => ['schema' => ['$ref' => '#/definitions/WalletModel']],
                        '400' => [],
                        '401' => [],
                        '404' => []
                    ]
                ],
                'put' => [
                    'operationId' => 'UpdateWallet',
                    'parameters' => [
                        [
                            'name' => 'walletId',
                            'in' => 'path',
                            'required' => TRUE,
                            'type' => 'integer',
                            'format' => 'int32'
                        ],
                        [
                            'name' => 'defaultPaymentToken',
                            'in' => 'body',
                            'required' => TRUE,
                            'schema' => ['type' => 'string']
                        ]
                    ],
                    'responses' => [
                        '200' => [],
                        '400' => [],
                        '401' => []
                    ]
                ]
            ],
            '/v2/wallet' => [
                'get' => [
                    'operationId' => 'GetWalletByReferenceId',
                    'parameters' => [[
                        'name' => 'referenceId',
                        'in' => 'query',
                        'required' => TRUE,
                        'type' => 'string'
                    ]],
                    'responses' => [
                        '200' => ['schema' => ['$ref' => '#/definitions/WalletModel']],
                        '400' => [],
                        '401' => []
                    ]
                ],
                'post' => [
                    'operationId' => 'CreateWallet',
                    'parameters' => [[
                        'name' => 'model',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/WalletRequestModel']
                    ]],
                    'responses' => [
                        '200' => ['schema' => [
                            'type' => 'integer',
                            'format' => 'int32'
                        ]],
                        '400' => [],
                        '401' => []
                    ]
                ]
            ],
            '/v2/wallet/{walletId}/CreditCard' => ['post' => [
                'operationId' => 'AddWalletCreditCard',
                'parameters' => [
                    [
                        'name' => 'walletId',
                        'in' => 'path',
                        'required' => TRUE,
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    [
                        'name' => 'request',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/WalletCreditCardRequestModel']
                    ]
                ],
                'responses' => [
                    '200' => ['schema' => ['$ref' => '#/definitions/WalletModel']],
                    '400' => [],
                    '401' => []
                ]
            ]],
            '/v2/wallet/{walletId}/BankAccount' => ['post' => [
                'operationId' => 'AddWalletBankAccount',
                'parameters' => [
                    [
                        'name' => 'walletId',
                        'in' => 'path',
                        'required' => TRUE,
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    [
                        'name' => 'request',
                        'in' => 'body',
                        'required' => TRUE,
                        'schema' => ['$ref' => '#/definitions/WalletBankAccountRequestModel']
                    ]
                ],
                'responses' => [
                    '200' => ['schema' => ['$ref' => '#/definitions/WalletModel']],
                    '400' => [],
                    '401' => []
                ]
            ]],
            '/v2/wallet/{walletId}/BankAccount/{walletBankAcctId}' => ['delete' => [
                'operationId' => 'RemoveWalletBankAccount',
                'parameters' => [
                    [
                        'name' => 'walletId',
                        'in' => 'path',
                        'required' => TRUE,
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    [
                        'name' => 'walletBankAcctId',
                        'in' => 'path',
                        'required' => TRUE,
                        'type' => 'integer',
                        'format' => 'int32'
                    ]
                ],
                'responses' => [
                    '200' => [],
                    '400' => [],
                    '401' => []
                ]
            ]],
            '/v2/wallet/{walletId}/CreditCard/{walletCreditCardId}' => ['delete' => [
                'operationId' => 'RemoveWalletCreditCard',
                'parameters' => [
                    [
                        'name' => 'walletId',
                        'in' => 'path',
                        'required' => TRUE,
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    [
                        'name' => 'walletCreditCardId',
                        'in' => 'path',
                        'required' => TRUE,
                        'type' => 'integer',
                        'format' => 'int32'
                    ]
                ],
                'responses' => [
                    '200' => [],
                    '400' => [],
                    '401' => []
                ]
            ]]
        ],
        'definitions' => [
            'Address' => [
                'properties' => [
                    'address1' => ['type' => 'string'],
                    'address2' => ['type' => 'string'],
                    'city' => ['type' => 'string'],
                    'state' => ['type' => 'string'],
                    'zipCode' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => [
                    'address1',
                    'city',
                    'state',
                    'zipCode'
                ]
            ],
            'BankAccountModel' => [
                'properties' => [
                    'id' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'token' => ['type' => 'string'],
                    'accountNumber' => ['type' => 'string'],
                    'routingNumber' => ['type' => 'string'],
                    'type' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'Checking',
                            'Savings'
                        ]
                    ],
                    'state' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'New',
                            'Pending',
                            'Authorized',
                            'Disabled'
                        ]
                    ],
                    'nickname' => ['type' => 'string'],
                    'accountHolderName' => ['type' => 'string'],
                    'accountHolderAddress' => ['$ref' => '#/definitions/Address'],
                    'email' => ['type' => 'string'],
                    'referenceId' => ['type' => 'string'],
                    'createdTime' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'modifiedTime' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ]
                ],
                'additionalProperties' => FALSE,
                'required' => [
                    'routingNumber',
                    'type',
                    'state',
                    'accountHolderName',
                    'accountHolderAddress',
                    'email'
                ]
            ],
            'UpdateBankAccountModel' => [
                'properties' => [
                    'token' => ['type' => 'string'],
                    'nickname' => ['type' => 'string'],
                    'accountHolderName' => ['type' => 'string'],
                    'accountHolderAddress' => ['$ref' => '#/definitions/Address'],
                    'email' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => [
                    'accountHolderName',
                    'accountHolderAddress',
                    'email'
                ]
            ],
            'BankAccountRequestModel' => [
                'properties' => [
                    'accountNumber' => ['type' => 'string'],
                    'routingNumber' => ['type' => 'string'],
                    'accountHolderName' => ['type' => 'string'],
                    'accountHolderAddress' => ['$ref' => '#/definitions/Address'],
                    'type' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'Checking',
                            'Savings'
                        ]
                    ],
                    'referenceId' => ['type' => 'string'],
                    'nickname' => ['type' => 'string'],
                    'email' => ['type' => 'string'],
                    'redirectUrl' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => [
                    'accountNumber',
                    'routingNumber',
                    'accountHolderName',
                    'accountHolderAddress',
                    'type',
                    'email'
                ]
            ],
            'BankAccountResponseModel' => [
                'properties' => [
                    'token' => ['type' => 'string'],
                    'bankAccountState' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'New',
                            'Pending',
                            'Authorized',
                            'Disabled'
                        ]
                    ],
                    'redirectUrl' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'BinRequestModel' => [
                'properties' => ['cardNumber' => ['type' => 'string']],
                'additionalProperties' => FALSE,
                'required' => ['cardNumber']
            ],
            'Bin' => [
                'properties' => [
                    'bin' => ['type' => 'string'],
                    'brand' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'Visa',
                            'MasterCard',
                            'Amex',
                            'Discover'
                        ]
                    ],
                    'isDebitCard' => ['type' => 'boolean'],
                    'isCheckCard' => ['type' => 'boolean'],
                    'isGiftCard' => ['type' => 'boolean'],
                    'isCorporateCard' => ['type' => 'boolean'],
                    'isFleetCard' => ['type' => 'boolean'],
                    'isPrepaidCard' => ['type' => 'boolean']
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'CheckoutResponseModel' => [
                'properties' => [
                    'checkoutId' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'clientId' => ['type' => 'string'],
                    'redirectUrl' => ['type' => 'string'],
                    'referenceId' => ['type' => 'string'],
                    'amount' => [
                        'type' => 'number',
                        'format' => 'double'
                    ],
                    'nameOnAccount' => ['type' => 'string'],
                    'expirationDate' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'enableBillingInformation' => ['type' => 'boolean'],
                    'billingAddress' => ['$ref' => '#/definitions/Address'],
                    'email' => ['type' => 'string'],
                    'requireEmail' => ['type' => 'boolean'],
                    'enableSaveOption' => ['type' => 'boolean']
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'CheckoutRequestModel' => [
                'properties' => [
                    'redirectUrl' => ['type' => 'string'],
                    'referenceId' => ['type' => 'string'],
                    'amount' => [
                        'type' => 'number',
                        'format' => 'double'
                    ],
                    'nameOnAccount' => ['type' => 'string'],
                    'expirationDate' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'enableBillingInformation' => ['type' => 'boolean'],
                    'billingAddress' => ['$ref' => '#/definitions/Address'],
                    'email' => ['type' => 'string'],
                    'requireEmail' => ['type' => 'boolean'],
                    'enableSaveOption' => ['type' => 'boolean']
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'CreditCardModel' => [
                'properties' => [
                    'id' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'token' => ['type' => 'string'],
                    'cardHolderName' => ['type' => 'string'],
                    'cardNumber' => ['type' => 'string'],
                    'expirationMonth' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'expirationYear' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'billingAddress' => ['$ref' => '#/definitions/Address'],
                    'email' => ['type' => 'string'],
                    'cardState' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'New',
                            'Authorized',
                            'Expired',
                            'Deleted',
                            'Invalid'
                        ]
                    ],
                    'cardType' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'Visa',
                            'MasterCard',
                            'Amex',
                            'Discover'
                        ]
                    ],
                    'referenceId' => ['type' => 'string'],
                    'createdTime' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'modifiedTime' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ]
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'UpdateCreditCardModel' => [
                'properties' => [
                    'token' => ['type' => 'string'],
                    'expirationMonth' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'expirationYear' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'cardHolderName' => ['type' => 'string'],
                    'billingAddress' => ['$ref' => '#/definitions/Address'],
                    'email' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => [
                    'token',
                    'expirationMonth',
                    'expirationYear',
                    'cardHolderName',
                    'billingAddress',
                    'email'
                ]
            ],
            'CreditCardRequestModel' => [
                'properties' => [
                    'cardNumber' => ['type' => 'string'],
                    'securityCode' => ['type' => 'string'],
                    'expirationMonth' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'expirationYear' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'cardHolderName' => ['type' => 'string'],
                    'billingAddress' => ['$ref' => '#/definitions/Address'],
                    'email' => ['type' => 'string'],
                    'referenceId' => ['type' => 'string'],
                    'redirectUrl' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => [
                    'cardNumber',
                    'securityCode',
                    'expirationMonth',
                    'expirationYear',
                    'cardHolderName',
                    'billingAddress',
                    'email'
                ]
            ],
            'CreditCardResponseModel' => [
                'properties' => [
                    'token' => ['type' => 'string'],
                    'cardState' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'New',
                            'Authorized',
                            'Expired',
                            'Deleted',
                            'Invalid'
                        ]
                    ],
                    'code' => ['type' => 'string'],
                    'message' => ['type' => 'string'],
                    'redirectUrl' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'PaymentMethodModel' => [
                'properties' => [
                    'paymentToken' => ['type' => 'string'],
                    'type' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'Credit Card',
                            'ACH'
                        ]
                    ]
                ],
                'additionalProperties' => FALSE,
                'required' => [
                    'paymentToken',
                    'type'
                ]
            ],
            'PaymentResultModel' => [
                'properties' => [
                    'status' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'New',
                            'Authorized',
                            'Captured',
                            'Expired',
                            'Declined',
                            'Failed',
                            'Cancelled',
                            'Charge Back',
                            'Refunded',
                            'Partially Refunded'
                        ]
                    ],
                    'code' => ['type' => 'string'],
                    'message' => ['type' => 'string'],
                    'providerAccountId' => ['type' => 'string'],
                    'merchantTransactionId' => ['type' => 'string'],
                    'merchantTransactionFee' => [
                        'type' => 'number',
                        'format' => 'double'
                    ]
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'RefundResultModel' => [
                'properties' => [
                    'status' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'New',
                            'Authorized',
                            'Captured',
                            'Expired',
                            'Declined',
                            'Failed',
                            'Cancelled',
                            'Charge Back',
                            'Refunded',
                            'Partially Refunded'
                        ]
                    ],
                    'code' => ['type' => 'string'],
                    'message' => ['type' => 'string'],
                    'merchantTransactionId' => ['type' => 'string'],
                    'providerAccountId' => ['type' => 'string'],
                    'amount' => [
                        'type' => 'number',
                        'format' => 'double'
                    ],
                    'reason' => ['type' => 'string'],
                    'createdDate' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ]
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'PaymentModel' => [
                'properties' => [
                    'id' => [
                        'type' => 'integer',
                        'format' => 'int64'
                    ],
                    'accountId' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'paymentAmount' => [
                        'type' => 'number',
                        'format' => 'double'
                    ],
                    'description' => ['type' => 'string'],
                    'referenceId' => ['type' => 'string'],
                    'paymentMethod' => ['$ref' => '#/definitions/PaymentMethodModel'],
                    'result' => ['$ref' => '#/definitions/PaymentResultModel'],
                    'refunds' => [
                        'type' => 'array',
                        'items' => ['$ref' => '#/definitions/RefundResultModel']
                    ],
                    'createdDate' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'modifiedDate' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ]
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'BaseQuery' => [
                'properties' => [
                    'referenceId' => ['type' => 'string'],
                    'minDate' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'maxDate' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ]
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'PaymentRequestModel' => [
                'properties' => [
                    'paymentAmount' => [
                        'type' => 'number',
                        'format' => 'double'
                    ],
                    'description' => ['type' => 'string'],
                    'referenceId' => ['type' => 'string'],
                    'paymentMethod' => ['$ref' => '#/definitions/PaymentMethodModel'],
                    'callbackUrl' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => ['paymentMethod']
            ],
            'RefundRequestModel' => [
                'properties' => [
                    'amount' => [
                        'type' => 'number',
                        'format' => 'double'
                    ],
                    'reason' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => ['reason']
            ],
            'SubscriptionModel' => [
                'properties' => [
                    'id' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'name' => ['type' => 'string'],
                    'description' => ['type' => 'string'],
                    'properties' => [
                        'type' => 'object',
                        'additionalProperties' => ['type' => 'string']
                    ],
                    'runDay' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'state' => [
                        'type' => 'string',
                        'enum' => [
                            'Active',
                            'Inactive',
                            'Expired'
                        ]
                    ],
                    'paymentType' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'Credit Card',
                            'ACH'
                        ]
                    ],
                    'paymentToken' => ['type' => 'string'],
                    'amountType' => [
                        'type' => 'string',
                        'enum' => [
                            'Fixed',
                            'Dynamic'
                        ]
                    ],
                    'amount' => [
                        'type' => 'number',
                        'format' => 'double'
                    ],
                    'amountWebServiceURL' => ['type' => 'string'],
                    'callbackWebServiceURL' => ['type' => 'string'],
                    'referenceId' => ['type' => 'string'],
                    'lastProcessed' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'endDate' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'createdTime' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'modifiedTime' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ]
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'UpdateSubscriptionModel' => [
                'properties' => [
                    'id' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'name' => ['type' => 'string'],
                    'description' => ['type' => 'string'],
                    'properties' => [
                        'type' => 'object',
                        'additionalProperties' => ['type' => 'string']
                    ],
                    'runDay' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'state' => [
                        'type' => 'string',
                        'enum' => [
                            'Active',
                            'Inactive',
                            'Expired'
                        ]
                    ],
                    'paymentType' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'Credit Card',
                            'ACH'
                        ]
                    ],
                    'paymentToken' => ['type' => 'string'],
                    'amountType' => [
                        'type' => 'string',
                        'enum' => [
                            'Fixed',
                            'Dynamic'
                        ]
                    ],
                    'amount' => [
                        'type' => 'number',
                        'format' => 'double'
                    ],
                    'amountWebServiceURL' => ['type' => 'string'],
                    'callbackWebServiceURL' => ['type' => 'string'],
                    'endDate' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'referenceId' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => [
                    'id',
                    'name',
                    'runDay',
                    'state',
                    'paymentType',
                    'paymentToken',
                    'amountType'
                ]
            ],
            'SubscriptionRequestModel' => [
                'properties' => [
                    'name' => ['type' => 'string'],
                    'description' => ['type' => 'string'],
                    'properties' => [
                        'type' => 'object',
                        'additionalProperties' => ['type' => 'string']
                    ],
                    'runDay' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'state' => [
                        'type' => 'string',
                        'enum' => [
                            'Active',
                            'Inactive',
                            'Expired'
                        ]
                    ],
                    'paymentType' => [
                        'type' => 'string',
                        'enum' => [
                            'Unknown',
                            'Credit Card',
                            'ACH'
                        ]
                    ],
                    'paymentToken' => ['type' => 'string'],
                    'amountType' => [
                        'type' => 'string',
                        'enum' => [
                            'Fixed',
                            'Dynamic'
                        ]
                    ],
                    'amount' => [
                        'type' => 'number',
                        'format' => 'double'
                    ],
                    'amountWebServiceURL' => ['type' => 'string'],
                    'callbackWebServiceURL' => ['type' => 'string'],
                    'endDate' => [
                        'type' => 'string',
                        'format' => 'date-time'
                    ],
                    'referenceId' => ['type' => 'string']
                ],
                'additionalProperties' => FALSE,
                'required' => [
                    'name',
                    'runDay',
                    'state',
                    'paymentType',
                    'paymentToken',
                    'amountType'
                ]
            ],
            'SubscriptionResponseModel' => [
                'properties' => [
                    'referenceId' => ['type' => 'string'],
                    'state' => [
                        'type' => 'string',
                        'enum' => [
                            'Active',
                            'Inactive',
                            'Expired'
                        ]
                    ]
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'WalletModel' => [
                'properties' => [
                    'id' => [
                        'type' => 'integer',
                        'format' => 'int32'
                    ],
                    'defaultToken' => ['type' => 'string'],
                    'creditCards' => [
                        'type' => 'array',
                        'items' => ['$ref' => '#/definitions/CreditCardModel']
                    ],
                    'bankAccounts' => [
                        'type' => 'array',
                        'items' => ['$ref' => '#/definitions/BankAccountModel']
                    ]
                ],
                'additionalProperties' => FALSE,
                'required' => ['id']
            ],
            'WalletRequestModel' => [
                'properties' => ['referenceId' => ['type' => 'string']],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'WalletCreditCardRequestModel' => [
                'properties' => [
                    'paymentToken' => ['type' => 'string'],
                    'isDefault' => ['type' => 'boolean']
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ],
            'WalletBankAccountRequestModel' => [
                'properties' => [
                    'paymentToken' => ['type' => 'string'],
                    'isDefault' => ['type' => 'boolean']
                ],
                'additionalProperties' => FALSE,
                'required' => []
            ]
        ]
    ];
}

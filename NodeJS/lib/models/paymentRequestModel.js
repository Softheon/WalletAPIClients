/*
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

const models = require('./index');

/**
 * The request model sent by the client to add a new payment to the platform.
 *
 */
class PaymentRequestModel {
  /**
   * Create a PaymentRequestModel.
   * @member {number} [paymentAmount] The payment amount.
   * @member {string} [description] The description of what will be paid for.
   * @member {string} [referenceId] The client application provided reference
   * ID for the payment.
   * @member {object} paymentMethod The method of payment.
   * @member {string} [paymentMethod.paymentToken] The credit card or bank
   * account token that will be used for payment.
   * @member {string} [paymentMethod.type] The type of funding source that will
   * be used for the payment. Possible values include: 'Unknown', 'Credit
   * Card', 'ACH'
   * @member {string} [callbackUrl] The callback URL where payment
   * notifications will be sent.  Payment notifications are sent when the
   * state of a payment changes.  Notifications will be sent as an HTTP POST to
   * the URL provided and will
   * contain a PaymentId and optional ReferenceId, if one was provided when the
   * payment was created.
   */
  constructor() {
  }

  /**
   * Defines the metadata of PaymentRequestModel
   *
   * @returns {object} metadata of PaymentRequestModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'PaymentRequestModel',
      type: {
        name: 'Composite',
        className: 'PaymentRequestModel',
        modelProperties: {
          paymentAmount: {
            required: false,
            serializedName: 'paymentAmount',
            type: {
              name: 'Number'
            }
          },
          description: {
            required: false,
            serializedName: 'description',
            type: {
              name: 'String'
            }
          },
          referenceId: {
            required: false,
            serializedName: 'referenceId',
            type: {
              name: 'String'
            }
          },
          paymentMethod: {
            required: true,
            serializedName: 'paymentMethod',
            type: {
              name: 'Composite',
              className: 'PaymentMethodModel'
            }
          },
          callbackUrl: {
            required: false,
            serializedName: 'callbackUrl',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = PaymentRequestModel;

/*
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

const models = require('./index');

/**
 * The model sent to the client in response to a GET request for a credit card.
 *
 */
class CreditCardModel {
  /**
   * Create a CreditCardModel.
   * @member {number} [id] Gets or sets the identifier.
   * @member {string} [token] The payment token for the credit card.
   * @member {string} [cardHolderName] The name of the cardholder, as it
   * appears on the front of the credit card.
   * @member {string} [cardNumber] The obfuscated credit card number for the
   * credit card, such as xxxxxxxxxxxx1234
   * @member {number} [expirationMonth] The expiration month of the credit
   * card.
   * @member {number} [expirationYear] The expiration year of the credit card.
   * @member {object} [billingAddress] The billing address for the credit card
   * holder.
   * @member {string} [billingAddress.address1] The first line of the street
   * address.  Typcically contains
   * the number and street name.
   * @member {string} [billingAddress.address2] The second line of the street
   * address.  Typically contains
   * an apartment number, suite number or department.
   * @member {string} [billingAddress.city] The city where the address is
   * situated.
   * @member {string} [billingAddress.state] The state where the address is
   * located.
   * @member {string} [billingAddress.zipCode] The postal code for the address.
   * @member {string} [email] The email address for the credit card holder.
   * @member {string} [cardState] The state that the credit card is in.
   * Possible values include: 'Unknown', 'New', 'Authorized', 'Expired',
   * 'Deleted', 'Invalid'
   * @member {string} [cardType] Gets or sets the type of the card. Possible
   * values include: 'Unknown', 'Visa', 'MasterCard', 'Amex', 'Discover'
   * @member {string} [referenceId] The client application provided reference
   * ID for the credit card.
   * @member {date} [createdTime] The timestamp indicating when the credit card
   * was created.
   * @member {date} [modifiedTime] The timestamp indicating the last time that
   * the details of the credit card were modified.
   */
  constructor() {
  }

  /**
   * Defines the metadata of CreditCardModel
   *
   * @returns {object} metadata of CreditCardModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'CreditCardModel',
      type: {
        name: 'Composite',
        className: 'CreditCardModel',
        modelProperties: {
          id: {
            required: false,
            serializedName: 'id',
            type: {
              name: 'Number'
            }
          },
          token: {
            required: false,
            serializedName: 'token',
            type: {
              name: 'String'
            }
          },
          cardHolderName: {
            required: false,
            serializedName: 'cardHolderName',
            type: {
              name: 'String'
            }
          },
          cardNumber: {
            required: false,
            serializedName: 'cardNumber',
            type: {
              name: 'String'
            }
          },
          expirationMonth: {
            required: false,
            serializedName: 'expirationMonth',
            type: {
              name: 'Number'
            }
          },
          expirationYear: {
            required: false,
            serializedName: 'expirationYear',
            type: {
              name: 'Number'
            }
          },
          billingAddress: {
            required: false,
            serializedName: 'billingAddress',
            type: {
              name: 'Composite',
              className: 'Address'
            }
          },
          email: {
            required: false,
            serializedName: 'email',
            type: {
              name: 'String'
            }
          },
          cardState: {
            required: false,
            serializedName: 'cardState',
            type: {
              name: 'String'
            }
          },
          cardType: {
            required: false,
            serializedName: 'cardType',
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
          createdTime: {
            required: false,
            serializedName: 'createdTime',
            type: {
              name: 'DateTime'
            }
          },
          modifiedTime: {
            required: false,
            serializedName: 'modifiedTime',
            type: {
              name: 'DateTime'
            }
          }
        }
      }
    };
  }
}

module.exports = CreditCardModel;

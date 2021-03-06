/*
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * The response model that is returned to the client when a new payment
 * subscription is added to the platform.
 *
 */
class SubscriptionResponseModel {
  /**
   * Create a SubscriptionResponseModel.
   * @member {string} [referenceId] Gets or sets the reference id.
   * @member {string} [state] Gets or sets the subscription state. Possible
   * values include: 'Active', 'Inactive', 'Expired'
   */
  constructor() {
  }

  /**
   * Defines the metadata of SubscriptionResponseModel
   *
   * @returns {object} metadata of SubscriptionResponseModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'SubscriptionResponseModel',
      type: {
        name: 'Composite',
        className: 'SubscriptionResponseModel',
        modelProperties: {
          referenceId: {
            required: false,
            serializedName: 'referenceId',
            type: {
              name: 'String'
            }
          },
          state: {
            required: false,
            serializedName: 'state',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = SubscriptionResponseModel;

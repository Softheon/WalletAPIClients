# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Softheon.Wallet.Api.Client
  module Models
    #
    # The response model that is returned to the client when a new payment
    # subscription is added to the platform.
    #
    class SubscriptionResponceModel
      # @return [String] Gets or sets the reference id.
      attr_accessor :reference_id

      # @return [Enum] Gets or sets the subscription state. Possible values
      # include: 'Active', 'Inactive', 'Expired'
      attr_accessor :state


      #
      # Mapper for SubscriptionResponceModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'SubscriptionResponceModel',
          type: {
            name: 'Composite',
            class_name: 'SubscriptionResponceModel',
            model_properties: {
              reference_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'referenceId',
                type: {
                  name: 'String'
                }
              },
              state: {
                client_side_validation: true,
                required: false,
                serialized_name: 'state',
                type: {
                  name: 'String'
                }
              }
            }
          }
        }
      end
    end
  end
end
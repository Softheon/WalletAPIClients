# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module WalletApiV2
  module Models
    #
    # Defines a a funding source for a payment request.
    #
    class PaymentMethodModel
      # @return [String] The credit card or bank account token that will be
      # used for payment.
      attr_accessor :payment_token

      # @return [Enum] The type of funding source that will be used for the
      # payment. Possible values include: 'Unknown', 'Credit Card', 'ACH'
      attr_accessor :type


      #
      # Mapper for PaymentMethodModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'PaymentMethodModel',
          type: {
            name: 'Composite',
            class_name: 'PaymentMethodModel',
            model_properties: {
              payment_token: {
                client_side_validation: true,
                required: true,
                serialized_name: 'paymentToken',
                type: {
                  name: 'String'
                }
              },
              type: {
                client_side_validation: true,
                required: true,
                serialized_name: 'type',
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
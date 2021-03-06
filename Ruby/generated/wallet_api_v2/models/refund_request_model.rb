# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module WalletApiV2
  module Models
    #
    # The request model sent by the client to add a new refund to the platform.
    #
    class RefundRequestModel
      # @return [Float] The amount to be refunded.  If an amount less than the
      # original payment amount is
      # specified, a partial refund will be processed.  If no amount is
      # specified, a full refund
      # will be processed.
      attr_accessor :amount

      # @return [String] The reason for issuing the refund.
      attr_accessor :reason


      #
      # Mapper for RefundRequestModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'RefundRequestModel',
          type: {
            name: 'Composite',
            class_name: 'RefundRequestModel',
            model_properties: {
              amount: {
                client_side_validation: true,
                required: false,
                serialized_name: 'amount',
                type: {
                  name: 'Double'
                }
              },
              reason: {
                client_side_validation: true,
                required: true,
                serialized_name: 'reason',
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

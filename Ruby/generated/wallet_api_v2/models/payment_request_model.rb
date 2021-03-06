# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module WalletApiV2
  module Models
    #
    # The request model sent by the client to add a new payment to the
    # platform.
    #
    class PaymentRequestModel
      # @return [Float] The payment amount.
      attr_accessor :payment_amount

      # @return [String] The description of what will be paid for.
      attr_accessor :description

      # @return [String] The client application provided reference ID for the
      # payment.
      attr_accessor :reference_id

      # @return [PaymentMethodModel] The method of payment.
      attr_accessor :payment_method

      # @return [String] The callback URL where payment notifications will be
      # sent.  Payment notifications are sent when the
      # state of a payment changes.  Notifications will be sent as an HTTP POST
      # to the URL provided and will
      # contain a PaymentId and optional ReferenceId, if one was provided when
      # the payment was created.
      attr_accessor :callback_url


      #
      # Mapper for PaymentRequestModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'PaymentRequestModel',
          type: {
            name: 'Composite',
            class_name: 'PaymentRequestModel',
            model_properties: {
              payment_amount: {
                client_side_validation: true,
                required: false,
                serialized_name: 'paymentAmount',
                type: {
                  name: 'Double'
                }
              },
              description: {
                client_side_validation: true,
                required: false,
                serialized_name: 'description',
                type: {
                  name: 'String'
                }
              },
              reference_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'referenceId',
                type: {
                  name: 'String'
                }
              },
              payment_method: {
                client_side_validation: true,
                required: true,
                serialized_name: 'paymentMethod',
                type: {
                  name: 'Composite',
                  class_name: 'PaymentMethodModel'
                }
              },
              callback_url: {
                client_side_validation: true,
                required: false,
                serialized_name: 'callbackUrl',
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

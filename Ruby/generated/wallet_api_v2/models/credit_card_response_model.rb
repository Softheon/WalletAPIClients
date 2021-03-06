# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module WalletApiV2
  module Models
    #
    # The response model sent to the client when a new credit card is added to
    # the platform.
    #
    class CreditCardResponseModel
      # @return [String] The payment token for the credit card
      attr_accessor :token

      # @return [Enum] The state that the credit card is in. Possible values
      # include: 'Unknown', 'New', 'Authorized', 'Expired', 'Deleted',
      # 'Invalid'
      attr_accessor :card_state

      # @return [String] The pre-authorization result code.
      attr_accessor :code

      # @return [String] The pre-authorization result message.
      attr_accessor :message

      # @return [String] The URL that the client will be redirected to after
      # the credit card has been created.
      attr_accessor :redirect_url


      #
      # Mapper for CreditCardResponseModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'CreditCardResponseModel',
          type: {
            name: 'Composite',
            class_name: 'CreditCardResponseModel',
            model_properties: {
              token: {
                client_side_validation: true,
                required: false,
                serialized_name: 'token',
                type: {
                  name: 'String'
                }
              },
              card_state: {
                client_side_validation: true,
                required: false,
                serialized_name: 'cardState',
                type: {
                  name: 'String'
                }
              },
              code: {
                client_side_validation: true,
                required: false,
                serialized_name: 'code',
                type: {
                  name: 'String'
                }
              },
              message: {
                client_side_validation: true,
                required: false,
                serialized_name: 'message',
                type: {
                  name: 'String'
                }
              },
              redirect_url: {
                client_side_validation: true,
                required: false,
                serialized_name: 'redirectUrl',
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

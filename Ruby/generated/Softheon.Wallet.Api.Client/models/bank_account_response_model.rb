# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Softheon.Wallet.Api.Client
  module Models
    #
    # The response model that is returned to the client when a new bank account
    # is added
    # to the platform
    #
    class BankAccountResponseModel
      # @return [String] The payment token for the bank account.
      attr_accessor :token

      # @return [Enum] The state that the bank acocunt is in. Possible values
      # include: 'Unknown', 'New', 'Pending', 'Authorized', 'Disabled'
      attr_accessor :bank_account_state

      # @return [String] The url that the client will be redirected to after
      # the bank account has been created.
      attr_accessor :redirect_url


      #
      # Mapper for BankAccountResponseModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'BankAccountResponseModel',
          type: {
            name: 'Composite',
            class_name: 'BankAccountResponseModel',
            model_properties: {
              token: {
                client_side_validation: true,
                required: false,
                serialized_name: 'token',
                type: {
                  name: 'String'
                }
              },
              bank_account_state: {
                client_side_validation: true,
                required: false,
                serialized_name: 'bankAccountState',
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

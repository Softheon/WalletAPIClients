# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module WalletApiV2
  module Models
    #
    # Wallet Request Model
    #
    class WalletRequestModel
      # @return [String] Gets or sets the reference identifier.
      attr_accessor :reference_id


      #
      # Mapper for WalletRequestModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'WalletRequestModel',
          type: {
            name: 'Composite',
            class_name: 'WalletRequestModel',
            model_properties: {
              reference_id: {
                client_side_validation: true,
                required: false,
                serialized_name: 'referenceId',
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

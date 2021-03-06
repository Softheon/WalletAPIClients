# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module WalletApiV2
  module Models
    #
    # Defines a BIN (bank identification number)
    #
    class Bin
      # @return [String] Gets the bin.
      attr_accessor :bin

      # @return [Enum] Gets or sets the brand. Possible values include:
      # 'Unknown', 'Visa', 'MasterCard', 'Amex', 'Discover'
      attr_accessor :brand

      # @return [Boolean] Gets or sets a value indicating whether this instance
      # is debit.
      attr_accessor :is_debit_card

      # @return [Boolean] Gets or sets a value indicating whether this instance
      # is check card.
      attr_accessor :is_check_card

      # @return [Boolean] Gets or sets a value indicating whether this instance
      # is gift card.
      attr_accessor :is_gift_card

      # @return [Boolean] Gets or sets a value indicating whether this instance
      # is corporate card.
      attr_accessor :is_corporate_card

      # @return [Boolean] Gets or sets a value indicating whether this instance
      # is fleet card.
      attr_accessor :is_fleet_card

      # @return [Boolean] Gets or sets a value indicating whether this instance
      # is prepaid card.
      attr_accessor :is_prepaid_card


      #
      # Mapper for Bin class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'Bin',
          type: {
            name: 'Composite',
            class_name: 'Bin',
            model_properties: {
              bin: {
                client_side_validation: true,
                required: false,
                serialized_name: 'bin',
                type: {
                  name: 'String'
                }
              },
              brand: {
                client_side_validation: true,
                required: false,
                read_only: true,
                serialized_name: 'brand',
                type: {
                  name: 'String'
                }
              },
              is_debit_card: {
                client_side_validation: true,
                required: false,
                serialized_name: 'isDebitCard',
                type: {
                  name: 'Boolean'
                }
              },
              is_check_card: {
                client_side_validation: true,
                required: false,
                serialized_name: 'isCheckCard',
                type: {
                  name: 'Boolean'
                }
              },
              is_gift_card: {
                client_side_validation: true,
                required: false,
                serialized_name: 'isGiftCard',
                type: {
                  name: 'Boolean'
                }
              },
              is_corporate_card: {
                client_side_validation: true,
                required: false,
                serialized_name: 'isCorporateCard',
                type: {
                  name: 'Boolean'
                }
              },
              is_fleet_card: {
                client_side_validation: true,
                required: false,
                serialized_name: 'isFleetCard',
                type: {
                  name: 'Boolean'
                }
              },
              is_prepaid_card: {
                client_side_validation: true,
                required: false,
                serialized_name: 'isPrepaidCard',
                type: {
                  name: 'Boolean'
                }
              }
            }
          }
        }
      end
    end
  end
end

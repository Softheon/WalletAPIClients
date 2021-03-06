# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module WalletApiV2
  module Models
    #
    # The request model sent by the client for updating subscription in the
    # payment platform.
    #
    class UpdateSubscriptionModel
      # @return [Integer] The id of the payment subscription.
      attr_accessor :id

      # @return [String] The name of payment subscription.
      attr_accessor :name

      # @return [String] The description of payment subscription.
      attr_accessor :description

      # @return [Hash{String => String}] The properties of the payment
      # subscription.
      attr_accessor :properties

      # @return [Integer] The process day of the payment subscription.
      attr_accessor :run_day

      # @return [Enum] The state that payment subscription is in. Possible
      # values include: 'Active', 'Inactive', 'Expired'
      attr_accessor :state

      # @return [Enum] The payment type of the payment subscription. Possible
      # values include: 'Unknown', 'Credit Card', 'ACH'
      attr_accessor :payment_type

      # @return [String] The payment token of the payment subscription.
      attr_accessor :payment_token

      # @return [Enum] The amount type of the payment subscription. Possible
      # values include: 'Fixed', 'Dynamic'
      attr_accessor :amount_type

      # @return [Float] The amount of money to be charged by the payment
      # subscription.
      attr_accessor :amount

      # @return [String] The url of web api to use to retrieve the amount to be
      # charged by the payment subscription.
      attr_accessor :amount_web_service_url

      # @return [String] The url of a web api to use to post back notifications
      # each time payment subscription is processed.
      attr_accessor :callback_web_service_url

      # @return [DateTime] The date indicating when the payment subscription
      # should be stopped.
      attr_accessor :end_date

      # @return [String] The client application provided reference ID for the
      # credit card.
      attr_accessor :reference_id


      #
      # Mapper for UpdateSubscriptionModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'UpdateSubscriptionModel',
          type: {
            name: 'Composite',
            class_name: 'UpdateSubscriptionModel',
            model_properties: {
              id: {
                client_side_validation: true,
                required: true,
                serialized_name: 'id',
                type: {
                  name: 'Number'
                }
              },
              name: {
                client_side_validation: true,
                required: true,
                serialized_name: 'name',
                type: {
                  name: 'String'
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
              properties: {
                client_side_validation: true,
                required: false,
                serialized_name: 'properties',
                type: {
                  name: 'Dictionary',
                  value: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'StringElementType',
                      type: {
                        name: 'String'
                      }
                  }
                }
              },
              run_day: {
                client_side_validation: true,
                required: true,
                serialized_name: 'runDay',
                constraints: {
                  InclusiveMaximum: 31,
                  InclusiveMinimum: 1
                },
                type: {
                  name: 'Number'
                }
              },
              state: {
                client_side_validation: true,
                required: true,
                serialized_name: 'state',
                type: {
                  name: 'String'
                }
              },
              payment_type: {
                client_side_validation: true,
                required: true,
                serialized_name: 'paymentType',
                type: {
                  name: 'String'
                }
              },
              payment_token: {
                client_side_validation: true,
                required: true,
                serialized_name: 'paymentToken',
                type: {
                  name: 'String'
                }
              },
              amount_type: {
                client_side_validation: true,
                required: true,
                serialized_name: 'amountType',
                type: {
                  name: 'String'
                }
              },
              amount: {
                client_side_validation: true,
                required: false,
                serialized_name: 'amount',
                type: {
                  name: 'Double'
                }
              },
              amount_web_service_url: {
                client_side_validation: true,
                required: false,
                serialized_name: 'amountWebServiceURL',
                type: {
                  name: 'String'
                }
              },
              callback_web_service_url: {
                client_side_validation: true,
                required: false,
                serialized_name: 'callbackWebServiceURL',
                type: {
                  name: 'String'
                }
              },
              end_date: {
                client_side_validation: true,
                required: false,
                serialized_name: 'endDate',
                type: {
                  name: 'DateTime'
                }
              },
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

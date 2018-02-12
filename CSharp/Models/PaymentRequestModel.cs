// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Softheon.Wallet.Api.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The request model sent by the client to add a new payment to the
    /// platform.
    /// </summary>
    public partial class PaymentRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the PaymentRequestModel class.
        /// </summary>
        public PaymentRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PaymentRequestModel class.
        /// </summary>
        /// <param name="paymentMethod">The method of payment.</param>
        /// <param name="paymentAmount">The payment amount.</param>
        /// <param name="description">The description of what will be paid
        /// for.</param>
        /// <param name="referenceId">The client application provided reference
        /// ID for the payment.</param>
        /// <param name="callbackUrl">The callback URL where payment
        /// notifications will be sent.  Payment notifications are sent when
        /// the
        /// state of a payment changes.  Notifications will be sent as an HTTP
        /// POST to the URL provided and will
        /// contain a PaymentId and optional ReferenceId, if one was provided
        /// when the payment was created.</param>
        public PaymentRequestModel(PaymentMethodModel paymentMethod, double? paymentAmount = default(double?), string description = default(string), string referenceId = default(string), string callbackUrl = default(string))
        {
            PaymentAmount = paymentAmount;
            Description = description;
            ReferenceId = referenceId;
            PaymentMethod = paymentMethod;
            CallbackUrl = callbackUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the payment amount.
        /// </summary>
        [JsonProperty(PropertyName = "paymentAmount")]
        public double? PaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the description of what will be paid for.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the client application provided reference ID for the
        /// payment.
        /// </summary>
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the method of payment.
        /// </summary>
        [JsonProperty(PropertyName = "paymentMethod")]
        public PaymentMethodModel PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the callback URL where payment notifications will be
        /// sent.  Payment notifications are sent when the
        /// state of a payment changes.  Notifications will be sent as an HTTP
        /// POST to the URL provided and will
        /// contain a PaymentId and optional ReferenceId, if one was provided
        /// when the payment was created.
        /// </summary>
        [JsonProperty(PropertyName = "callbackUrl")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PaymentMethod == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PaymentMethod");
            }
            if (PaymentMethod != null)
            {
                PaymentMethod.Validate();
            }
        }
    }
}

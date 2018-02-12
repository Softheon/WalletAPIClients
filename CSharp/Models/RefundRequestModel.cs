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
    /// The request model sent by the client to add a new refund to the
    /// platform.
    /// </summary>
    public partial class RefundRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the RefundRequestModel class.
        /// </summary>
        public RefundRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RefundRequestModel class.
        /// </summary>
        /// <param name="reason">The reason for issuing the refund.</param>
        /// <param name="amount">The amount to be refunded.  If an amount less
        /// than the original payment amount is
        /// specified, a partial refund will be processed.  If no amount is
        /// specified, a full refund
        /// will be processed.</param>
        public RefundRequestModel(string reason, double? amount = default(double?))
        {
            Amount = amount;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the amount to be refunded.  If an amount less than the
        /// original payment amount is
        /// specified, a partial refund will be processed.  If no amount is
        /// specified, a full refund
        /// will be processed.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or sets the reason for issuing the refund.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Reason == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Reason");
            }
        }
    }
}

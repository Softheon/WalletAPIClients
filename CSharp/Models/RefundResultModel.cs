// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Softheon.Wallet.Api.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The model sent to the client as a part of the payment model.
    /// Provides details on the refund result.
    /// </summary>
    public partial class RefundResultModel
    {
        /// <summary>
        /// Initializes a new instance of the RefundResultModel class.
        /// </summary>
        public RefundResultModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RefundResultModel class.
        /// </summary>
        /// <param name="status">The current status of the refund. Possible
        /// values include: 'Unknown', 'New', 'Authorized', 'Captured',
        /// 'Expired', 'Declined', 'Failed', 'Cancelled', 'Charge Back',
        /// 'Refunded', 'Partially Refunded'</param>
        /// <param name="code">The refund result code.</param>
        /// <param name="message">The refund result message.</param>
        /// <param name="merchantTransactionId">The Merchant Transaction ID
        /// number for the payment that is being refunded.</param>
        /// <param name="providerAccountId">The unique ID of the provider
        /// account that was used to make this refund.</param>
        /// <param name="amount">The amount to be refunded.  If an amount less
        /// than the original payment amount is
        /// specified, a partial refund will be processed.  If no amount is
        /// specified, a full refund
        /// will be processed.</param>
        /// <param name="reason">The reason for issuing the refund.</param>
        /// <param name="createdDate">The timestamp indicating when the refund
        /// was created.</param>
        public RefundResultModel(string status = default(string), string code = default(string), string message = default(string), string merchantTransactionId = default(string), string providerAccountId = default(string), double? amount = default(double?), string reason = default(string), System.DateTimeOffset? createdDate = default(System.DateTimeOffset?))
        {
            Status = status;
            Code = code;
            Message = message;
            MerchantTransactionId = merchantTransactionId;
            ProviderAccountId = providerAccountId;
            Amount = amount;
            Reason = reason;
            CreatedDate = createdDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the current status of the refund. Possible values
        /// include: 'Unknown', 'New', 'Authorized', 'Captured', 'Expired',
        /// 'Declined', 'Failed', 'Cancelled', 'Charge Back', 'Refunded',
        /// 'Partially Refunded'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the refund result code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the refund result message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the Merchant Transaction ID number for the payment
        /// that is being refunded.
        /// </summary>
        [JsonProperty(PropertyName = "merchantTransactionId")]
        public string MerchantTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the unique ID of the provider account that was used to
        /// make this refund.
        /// </summary>
        [JsonProperty(PropertyName = "providerAccountId")]
        public string ProviderAccountId { get; set; }

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
        /// Gets or sets the timestamp indicating when the refund was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdDate")]
        public System.DateTimeOffset? CreatedDate { get; set; }

    }
}

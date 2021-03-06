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
    /// Provides details on the payment result.
    /// </summary>
    public partial class PaymentResultModel
    {
        /// <summary>
        /// Initializes a new instance of the PaymentResultModel class.
        /// </summary>
        public PaymentResultModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PaymentResultModel class.
        /// </summary>
        /// <param name="status">The current status of the payment. Possible
        /// values include: 'Unknown', 'New', 'Authorized', 'Captured',
        /// 'Expired', 'Declined', 'Failed', 'Cancelled', 'Charge Back',
        /// 'Refunded', 'Partially Refunded'</param>
        /// <param name="code">The payment result code.</param>
        /// <param name="message">The payment result message.</param>
        /// <param name="providerAccountId">The unique ID of the provider
        /// account that was used to make this payment.</param>
        /// <param name="merchantTransactionId">Tthe merchant transaction
        /// identifier.</param>
        /// <param name="merchantTransactionFee">The merchant transaction
        /// fee.</param>
        public PaymentResultModel(string status = default(string), string code = default(string), string message = default(string), string providerAccountId = default(string), string merchantTransactionId = default(string), double? merchantTransactionFee = default(double?))
        {
            Status = status;
            Code = code;
            Message = message;
            ProviderAccountId = providerAccountId;
            MerchantTransactionId = merchantTransactionId;
            MerchantTransactionFee = merchantTransactionFee;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the current status of the payment. Possible values
        /// include: 'Unknown', 'New', 'Authorized', 'Captured', 'Expired',
        /// 'Declined', 'Failed', 'Cancelled', 'Charge Back', 'Refunded',
        /// 'Partially Refunded'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the payment result code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the payment result message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the unique ID of the provider account that was used to
        /// make this payment.
        /// </summary>
        [JsonProperty(PropertyName = "providerAccountId")]
        public string ProviderAccountId { get; set; }

        /// <summary>
        /// Gets or sets tthe merchant transaction identifier.
        /// </summary>
        [JsonProperty(PropertyName = "merchantTransactionId")]
        public string MerchantTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the merchant transaction fee.
        /// </summary>
        [JsonProperty(PropertyName = "merchantTransactionFee")]
        public double? MerchantTransactionFee { get; set; }

    }
}

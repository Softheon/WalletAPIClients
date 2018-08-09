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
    /// Wallet credit card request model
    /// </summary>
    public partial class WalletCreditCardRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the WalletCreditCardRequestModel
        /// class.
        /// </summary>
        public WalletCreditCardRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WalletCreditCardRequestModel
        /// class.
        /// </summary>
        /// <param name="paymentToken">Gets or sets the payment token.</param>
        /// <param name="isDefault">Gets or sets a value indicating whether
        /// this instance is default.</param>
        public WalletCreditCardRequestModel(string paymentToken = default(string), bool? isDefault = default(bool?))
        {
            PaymentToken = paymentToken;
            IsDefault = isDefault;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the payment token.
        /// </summary>
        [JsonProperty(PropertyName = "paymentToken")]
        public string PaymentToken { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        [JsonProperty(PropertyName = "isDefault")]
        public bool? IsDefault { get; set; }

    }
}

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
    /// Checkout request model
    /// </summary>
    public partial class CheckoutRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the CheckoutRequestModel class.
        /// </summary>
        public CheckoutRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckoutRequestModel class.
        /// </summary>
        /// <param name="redirectUrl">Gets or sets the redirect URL.</param>
        /// <param name="referenceId">Gets or sets the reference
        /// identifier.</param>
        /// <param name="amount">Gets or sets the amount.</param>
        /// <param name="nameOnAccount">Gets or sets the name on
        /// account.</param>
        /// <param name="expirationDate">Gets or sets the expiration
        /// date.</param>
        /// <param name="enableBillingInformation">Gets or sets a value
        /// indicating whether [enable billing information].</param>
        /// <param name="billingAddress">Gets or sets the billing
        /// address.</param>
        /// <param name="email">Gets or sets the email.</param>
        /// <param name="requireEmail">Gets or sets a value indicating whether
        /// [require email].</param>
        /// <param name="enableSaveOption">Gets or sets a value indicating
        /// whether [enable save option].</param>
        public CheckoutRequestModel(string redirectUrl = default(string), string referenceId = default(string), double? amount = default(double?), string nameOnAccount = default(string), System.DateTime? expirationDate = default(System.DateTime?), bool? enableBillingInformation = default(bool?), Address billingAddress = default(Address), string email = default(string), bool? requireEmail = default(bool?), bool? enableSaveOption = default(bool?))
        {
            RedirectUrl = redirectUrl;
            ReferenceId = referenceId;
            Amount = amount;
            NameOnAccount = nameOnAccount;
            ExpirationDate = expirationDate;
            EnableBillingInformation = enableBillingInformation;
            BillingAddress = billingAddress;
            Email = email;
            RequireEmail = requireEmail;
            EnableSaveOption = enableSaveOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the redirect URL.
        /// </summary>
        [JsonProperty(PropertyName = "redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets the reference identifier.
        /// </summary>
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or sets the name on account.
        /// </summary>
        [JsonProperty(PropertyName = "nameOnAccount")]
        public string NameOnAccount { get; set; }

        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        [JsonProperty(PropertyName = "expirationDate")]
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable billing
        /// information].
        /// </summary>
        [JsonProperty(PropertyName = "enableBillingInformation")]
        public bool? EnableBillingInformation { get; set; }

        /// <summary>
        /// Gets or sets the billing address.
        /// </summary>
        [JsonProperty(PropertyName = "billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [require email].
        /// </summary>
        [JsonProperty(PropertyName = "requireEmail")]
        public bool? RequireEmail { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable save option].
        /// </summary>
        [JsonProperty(PropertyName = "enableSaveOption")]
        public bool? EnableSaveOption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BillingAddress != null)
            {
                BillingAddress.Validate();
            }
        }
    }
}
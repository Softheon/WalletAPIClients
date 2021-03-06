<<<<<<< HEAD
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
    /// The model sent to the client in response to a GET request for a credit
    /// card.
    /// </summary>
    public partial class CreditCardModel
    {
        /// <summary>
        /// Initializes a new instance of the CreditCardModel class.
        /// </summary>
        public CreditCardModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreditCardModel class.
        /// </summary>
        /// <param name="id">Gets or sets the identifier.</param>
        /// <param name="token">The payment token for the credit card.</param>
        /// <param name="cardHolderName">The name of the cardholder, as it
        /// appears on the front of the credit card.</param>
        /// <param name="cardNumber">The obfuscated credit card number for the
        /// credit card, such as xxxxxxxxxxxx1234</param>
        /// <param name="expirationMonth">The expiration month of the credit
        /// card.</param>
        /// <param name="expirationYear">The expiration year of the credit
        /// card.</param>
        /// <param name="billingAddress">The billing address for the credit
        /// card holder.</param>
        /// <param name="email">The email address for the credit card
        /// holder.</param>
        /// <param name="cardState">The state that the credit card is in.
        /// Possible values include: 'Unknown', 'New', 'Authorized', 'Expired',
        /// 'Deleted', 'Invalid'</param>
        /// <param name="cardType">Gets or sets the type of the card. Possible
        /// values include: 'Unknown', 'Visa', 'MasterCard', 'Amex',
        /// 'Discover'</param>
        /// <param name="referenceId">The client application provided reference
        /// ID for the credit card.</param>
        /// <param name="createdTime">The timestamp indicating when the credit
        /// card was created.</param>
        /// <param name="modifiedTime">The timestamp indicating the last time
        /// that the details of the credit card were modified.</param>
        public CreditCardModel(int? id = default(int?), string token = default(string), string cardHolderName = default(string), string cardNumber = default(string), int? expirationMonth = default(int?), int? expirationYear = default(int?), Address billingAddress = default(Address), string email = default(string), string cardState = default(string), string cardType = default(string), string referenceId = default(string), System.DateTimeOffset? createdTime = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedTime = default(System.DateTimeOffset?))
        {
            Id = id;
            Token = token;
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            ExpirationMonth = expirationMonth;
            ExpirationYear = expirationYear;
            BillingAddress = billingAddress;
            Email = email;
            CardState = cardState;
            CardType = cardType;
            ReferenceId = referenceId;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the payment token for the credit card.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the name of the cardholder, as it appears on the front
        /// of the credit card.
        /// </summary>
        [JsonProperty(PropertyName = "cardHolderName")]
        public string CardHolderName { get; set; }

        /// <summary>
        /// Gets or sets the obfuscated credit card number for the credit card,
        /// such as xxxxxxxxxxxx1234
        /// </summary>
        [JsonProperty(PropertyName = "cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the expiration month of the credit card.
        /// </summary>
        [JsonProperty(PropertyName = "expirationMonth")]
        public int? ExpirationMonth { get; set; }

        /// <summary>
        /// Gets or sets the expiration year of the credit card.
        /// </summary>
        [JsonProperty(PropertyName = "expirationYear")]
        public int? ExpirationYear { get; set; }

        /// <summary>
        /// Gets or sets the billing address for the credit card holder.
        /// </summary>
        [JsonProperty(PropertyName = "billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets the email address for the credit card holder.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the state that the credit card is in. Possible values
        /// include: 'Unknown', 'New', 'Authorized', 'Expired', 'Deleted',
        /// 'Invalid'
        /// </summary>
        [JsonProperty(PropertyName = "cardState")]
        public string CardState { get; set; }

        /// <summary>
        /// Gets or sets the type of the card. Possible values include:
        /// 'Unknown', 'Visa', 'MasterCard', 'Amex', 'Discover'
        /// </summary>
        [JsonProperty(PropertyName = "cardType")]
        public string CardType { get; set; }

        /// <summary>
        /// Gets or sets the client application provided reference ID for the
        /// credit card.
        /// </summary>
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the timestamp indicating when the credit card was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTimeOffset? CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the timestamp indicating the last time that the
        /// details of the credit card were modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedTime")]
        public System.DateTimeOffset? ModifiedTime { get; set; }

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
=======
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
    /// The model sent to the client in response to a GET request for a credit
    /// card.
    /// </summary>
    public partial class CreditCardModel
    {
        /// <summary>
        /// Initializes a new instance of the CreditCardModel class.
        /// </summary>
        public CreditCardModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreditCardModel class.
        /// </summary>
        /// <param name="id">Gets or sets the identifier.</param>
        /// <param name="token">The payment token for the credit card.</param>
        /// <param name="cardHolderName">The name of the cardholder, as it
        /// appears on the front of the credit card.</param>
        /// <param name="cardNumber">The obfuscated credit card number for the
        /// credit card, such as xxxxxxxxxxxx1234</param>
        /// <param name="expirationMonth">The expiration month of the credit
        /// card.</param>
        /// <param name="expirationYear">The expiration year of the credit
        /// card.</param>
        /// <param name="billingAddress">The billing address for the credit
        /// card holder.</param>
        /// <param name="email">The email address for the credit card
        /// holder.</param>
        /// <param name="cardState">The state that the credit card is in.
        /// Possible values include: 'Unknown', 'New', 'Authorized', 'Expired',
        /// 'Deleted', 'Invalid'</param>
        /// <param name="cardType">Gets or sets the type of the card. Possible
        /// values include: 'Unknown', 'Visa', 'MasterCard', 'Amex',
        /// 'Discover'</param>
        /// <param name="referenceId">The client application provided reference
        /// ID for the credit card.</param>
        /// <param name="createdTime">The timestamp indicating when the credit
        /// card was created.</param>
        /// <param name="modifiedTime">The timestamp indicating the last time
        /// that the details of the credit card were modified.</param>
        public CreditCardModel(int? id = default(int?), string token = default(string), string cardHolderName = default(string), string cardNumber = default(string), int? expirationMonth = default(int?), int? expirationYear = default(int?), Address billingAddress = default(Address), string email = default(string), string cardState = default(string), string cardType = default(string), string referenceId = default(string), System.DateTimeOffset? createdTime = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedTime = default(System.DateTimeOffset?))
        {
            Id = id;
            Token = token;
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            ExpirationMonth = expirationMonth;
            ExpirationYear = expirationYear;
            BillingAddress = billingAddress;
            Email = email;
            CardState = cardState;
            CardType = cardType;
            ReferenceId = referenceId;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the payment token for the credit card.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the name of the cardholder, as it appears on the front
        /// of the credit card.
        /// </summary>
        [JsonProperty(PropertyName = "cardHolderName")]
        public string CardHolderName { get; set; }

        /// <summary>
        /// Gets or sets the obfuscated credit card number for the credit card,
        /// such as xxxxxxxxxxxx1234
        /// </summary>
        [JsonProperty(PropertyName = "cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the expiration month of the credit card.
        /// </summary>
        [JsonProperty(PropertyName = "expirationMonth")]
        public int? ExpirationMonth { get; set; }

        /// <summary>
        /// Gets or sets the expiration year of the credit card.
        /// </summary>
        [JsonProperty(PropertyName = "expirationYear")]
        public int? ExpirationYear { get; set; }

        /// <summary>
        /// Gets or sets the billing address for the credit card holder.
        /// </summary>
        [JsonProperty(PropertyName = "billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets the email address for the credit card holder.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the state that the credit card is in. Possible values
        /// include: 'Unknown', 'New', 'Authorized', 'Expired', 'Deleted',
        /// 'Invalid'
        /// </summary>
        [JsonProperty(PropertyName = "cardState")]
        public string CardState { get; set; }

        /// <summary>
        /// Gets or sets the type of the card. Possible values include:
        /// 'Unknown', 'Visa', 'MasterCard', 'Amex', 'Discover'
        /// </summary>
        [JsonProperty(PropertyName = "cardType")]
        public string CardType { get; set; }

        /// <summary>
        /// Gets or sets the client application provided reference ID for the
        /// credit card.
        /// </summary>
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the timestamp indicating when the credit card was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTimeOffset? CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the timestamp indicating the last time that the
        /// details of the credit card were modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedTime")]
        public System.DateTimeOffset? ModifiedTime { get; set; }

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
>>>>>>> 173eb7b7ca078419efbbaf9aa3d299c46af02203

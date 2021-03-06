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
    /// The request model sent by the client for updating bank accounts in the
    /// payment platform.
    /// </summary>
    public partial class UpdateBankAccountModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateBankAccountModel class.
        /// </summary>
        public UpdateBankAccountModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateBankAccountModel class.
        /// </summary>
        /// <param name="accountHolderName">The name of the individual or
        /// entity that is autorized to make transactions for the bank
        /// account.</param>
        /// <param name="accountHolderAddress">The mailing address for the
        /// account holder.</param>
        /// <param name="email">The email address for the account
        /// holder.</param>
        /// <param name="token">The payment token for the bank account.</param>
        /// <param name="nickname">The aribtrary nickname of the account, used
        /// as a way to identify the account.</param>
        public UpdateBankAccountModel(string accountHolderName, Address accountHolderAddress, string email, string token = default(string), string nickname = default(string))
        {
            Token = token;
            Nickname = nickname;
            AccountHolderName = accountHolderName;
            AccountHolderAddress = accountHolderAddress;
            Email = email;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the payment token for the bank account.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the aribtrary nickname of the account, used as a way
        /// to identify the account.
        /// </summary>
        [JsonProperty(PropertyName = "nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or sets the name of the individual or entity that is autorized
        /// to make transactions for the bank account.
        /// </summary>
        [JsonProperty(PropertyName = "accountHolderName")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// Gets or sets the mailing address for the account holder.
        /// </summary>
        [JsonProperty(PropertyName = "accountHolderAddress")]
        public Address AccountHolderAddress { get; set; }

        /// <summary>
        /// Gets or sets the email address for the account holder.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccountHolderName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountHolderName");
            }
            if (AccountHolderAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountHolderAddress");
            }
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (AccountHolderAddress != null)
            {
                AccountHolderAddress.Validate();
            }
        }
    }
}

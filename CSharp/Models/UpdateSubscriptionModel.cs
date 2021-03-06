<<<<<<< HEAD
// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Softheon.Wallet.Api.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The request model sent by the client for updating subscription in the
    /// payment platform.
    /// </summary>
    public partial class UpdateSubscriptionModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateSubscriptionModel class.
        /// </summary>
        public UpdateSubscriptionModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateSubscriptionModel class.
        /// </summary>
        /// <param name="id">The id of the payment subscription.</param>
        /// <param name="name">The name of payment subscription.</param>
        /// <param name="runDay">The process day of the payment
        /// subscription.</param>
        /// <param name="state">The state that payment subscription is in.
        /// Possible values include: 'Active', 'Inactive', 'Expired'</param>
        /// <param name="paymentType">The payment type of the payment
        /// subscription. Possible values include: 'Unknown', 'Credit Card',
        /// 'ACH'</param>
        /// <param name="paymentToken">The payment token of the payment
        /// subscription.</param>
        /// <param name="amountType">The amount type of the payment
        /// subscription. Possible values include: 'Fixed', 'Dynamic'</param>
        /// <param name="description">The description of payment
        /// subscription.</param>
        /// <param name="properties">The properties of the payment
        /// subscription.</param>
        /// <param name="amount">The amount of money to be charged by the
        /// payment subscription.</param>
        /// <param name="amountWebServiceURL">The url of web api to use to
        /// retrieve the amount to be charged by the payment
        /// subscription.</param>
        /// <param name="callbackWebServiceURL">The url of a web api to use to
        /// post back notifications each time payment subscription is
        /// processed.</param>
        /// <param name="endDate">The date indicating when the payment
        /// subscription should be stopped.</param>
        /// <param name="referenceId">The client application provided reference
        /// ID for the credit card.</param>
        public UpdateSubscriptionModel(int id, string name, int runDay, string state, string paymentType, string paymentToken, string amountType, string description = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>), double? amount = default(double?), string amountWebServiceURL = default(string), string callbackWebServiceURL = default(string), System.DateTimeOffset? endDate = default(System.DateTimeOffset?), string referenceId = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            Properties = properties;
            RunDay = runDay;
            State = state;
            PaymentType = paymentType;
            PaymentToken = paymentToken;
            AmountType = amountType;
            Amount = amount;
            AmountWebServiceURL = amountWebServiceURL;
            CallbackWebServiceURL = callbackWebServiceURL;
            EndDate = endDate;
            ReferenceId = referenceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the properties of the payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets the process day of the payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "runDay")]
        public int RunDay { get; set; }

        /// <summary>
        /// Gets or sets the state that payment subscription is in. Possible
        /// values include: 'Active', 'Inactive', 'Expired'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the payment type of the payment subscription. Possible
        /// values include: 'Unknown', 'Credit Card', 'ACH'
        /// </summary>
        [JsonProperty(PropertyName = "paymentType")]
        public string PaymentType { get; set; }

        /// <summary>
        /// Gets or sets the payment token of the payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "paymentToken")]
        public string PaymentToken { get; set; }

        /// <summary>
        /// Gets or sets the amount type of the payment subscription. Possible
        /// values include: 'Fixed', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "amountType")]
        public string AmountType { get; set; }

        /// <summary>
        /// Gets or sets the amount of money to be charged by the payment
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or sets the url of web api to use to retrieve the amount to be
        /// charged by the payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "amountWebServiceURL")]
        public string AmountWebServiceURL { get; set; }

        /// <summary>
        /// Gets or sets the url of a web api to use to post back notifications
        /// each time payment subscription is processed.
        /// </summary>
        [JsonProperty(PropertyName = "callbackWebServiceURL")]
        public string CallbackWebServiceURL { get; set; }

        /// <summary>
        /// Gets or sets the date indicating when the payment subscription
        /// should be stopped.
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the client application provided reference ID for the
        /// credit card.
        /// </summary>
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (State == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "State");
            }
            if (PaymentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PaymentType");
            }
            if (PaymentToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PaymentToken");
            }
            if (AmountType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AmountType");
            }
            if (RunDay > 31)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "RunDay", 31);
            }
            if (RunDay < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "RunDay", 1);
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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The request model sent by the client for updating subscription in the
    /// payment platform.
    /// </summary>
    public partial class UpdateSubscriptionModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateSubscriptionModel class.
        /// </summary>
        public UpdateSubscriptionModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateSubscriptionModel class.
        /// </summary>
        /// <param name="id">The id of the payment subscription.</param>
        /// <param name="name">The name of payment subscription.</param>
        /// <param name="runDay">The process day of the payment
        /// subscription.</param>
        /// <param name="state">The state that payment subscription is in.
        /// Possible values include: 'Active', 'Inactive', 'Expired'</param>
        /// <param name="paymentType">The payment type of the payment
        /// subscription. Possible values include: 'Unknown', 'Credit Card',
        /// 'ACH'</param>
        /// <param name="paymentToken">The payment token of the payment
        /// subscription.</param>
        /// <param name="amountType">The amount type of the payment
        /// subscription. Possible values include: 'Fixed', 'Dynamic'</param>
        /// <param name="description">The description of payment
        /// subscription.</param>
        /// <param name="properties">The properties of the payment
        /// subscription.</param>
        /// <param name="amount">The amount of money to be charged by the
        /// payment subscription.</param>
        /// <param name="amountWebServiceURL">The url of web api to use to
        /// retrieve the amount to be charged by the payment
        /// subscription.</param>
        /// <param name="callbackWebServiceURL">The url of a web api to use to
        /// post back notifications each time payment subscription is
        /// processed.</param>
        /// <param name="endDate">The date indicating when the payment
        /// subscription should be stopped.</param>
        /// <param name="referenceId">The client application provided reference
        /// ID for the credit card.</param>
        public UpdateSubscriptionModel(int id, string name, int runDay, string state, string paymentType, string paymentToken, string amountType, string description = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>), double? amount = default(double?), string amountWebServiceURL = default(string), string callbackWebServiceURL = default(string), System.DateTimeOffset? endDate = default(System.DateTimeOffset?), string referenceId = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            Properties = properties;
            RunDay = runDay;
            State = state;
            PaymentType = paymentType;
            PaymentToken = paymentToken;
            AmountType = amountType;
            Amount = amount;
            AmountWebServiceURL = amountWebServiceURL;
            CallbackWebServiceURL = callbackWebServiceURL;
            EndDate = endDate;
            ReferenceId = referenceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the properties of the payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets the process day of the payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "runDay")]
        public int RunDay { get; set; }

        /// <summary>
        /// Gets or sets the state that payment subscription is in. Possible
        /// values include: 'Active', 'Inactive', 'Expired'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the payment type of the payment subscription. Possible
        /// values include: 'Unknown', 'Credit Card', 'ACH'
        /// </summary>
        [JsonProperty(PropertyName = "paymentType")]
        public string PaymentType { get; set; }

        /// <summary>
        /// Gets or sets the payment token of the payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "paymentToken")]
        public string PaymentToken { get; set; }

        /// <summary>
        /// Gets or sets the amount type of the payment subscription. Possible
        /// values include: 'Fixed', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "amountType")]
        public string AmountType { get; set; }

        /// <summary>
        /// Gets or sets the amount of money to be charged by the payment
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or sets the url of web api to use to retrieve the amount to be
        /// charged by the payment subscription.
        /// </summary>
        [JsonProperty(PropertyName = "amountWebServiceURL")]
        public string AmountWebServiceURL { get; set; }

        /// <summary>
        /// Gets or sets the url of a web api to use to post back notifications
        /// each time payment subscription is processed.
        /// </summary>
        [JsonProperty(PropertyName = "callbackWebServiceURL")]
        public string CallbackWebServiceURL { get; set; }

        /// <summary>
        /// Gets or sets the date indicating when the payment subscription
        /// should be stopped.
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the client application provided reference ID for the
        /// credit card.
        /// </summary>
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (State == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "State");
            }
            if (PaymentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PaymentType");
            }
            if (PaymentToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PaymentToken");
            }
            if (AmountType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AmountType");
            }
            if (RunDay > 31)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "RunDay", 31);
            }
            if (RunDay < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "RunDay", 1);
            }
        }
    }
}
>>>>>>> 173eb7b7ca078419efbbaf9aa3d299c46af02203

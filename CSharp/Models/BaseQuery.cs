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
    /// A base collection of query parameters
    /// </summary>
    public partial class BaseQuery
    {
        /// <summary>
        /// Initializes a new instance of the BaseQuery class.
        /// </summary>
        public BaseQuery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseQuery class.
        /// </summary>
        /// <param name="referenceId">Gets or sets the reference
        /// identifier.</param>
        /// <param name="minDate">Gets or sets the minimum date.</param>
        /// <param name="maxDate">Gets or sets the maximum date.</param>
        public BaseQuery(string referenceId = default(string), System.DateTimeOffset? minDate = default(System.DateTimeOffset?), System.DateTimeOffset? maxDate = default(System.DateTimeOffset?))
        {
            ReferenceId = referenceId;
            MinDate = minDate;
            MaxDate = maxDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference identifier.
        /// </summary>
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the minimum date.
        /// </summary>
        [JsonProperty(PropertyName = "minDate")]
        public System.DateTimeOffset? MinDate { get; set; }

        /// <summary>
        /// Gets or sets the maximum date.
        /// </summary>
        [JsonProperty(PropertyName = "maxDate")]
        public System.DateTimeOffset? MaxDate { get; set; }

    }
}

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// RetrieveDataEncryptionKeyResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveDataEncryptionKeyResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveDataEncryptionKeyResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveDataEncryptionKeyResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveDataEncryptionKeyResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveDataEncryptionKeyResponse(string encryptionKey = default(string))
        {
            EncryptionKey = encryptionKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EncryptionKey")]
        public string EncryptionKey { get; set; }

    }
}
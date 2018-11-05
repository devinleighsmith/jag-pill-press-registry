// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// msdyn_bcgov_customaddress_knowledgearticl
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynBcgovCustomaddressKnowledgearticl
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynBcgovCustomaddressKnowledgearticl class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynBcgovCustomaddressKnowledgearticl()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynBcgovCustomaddressKnowledgearticl class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynBcgovCustomaddressKnowledgearticl(string bcgovCustomaddressid = default(string), string msdynBcgovCustomaddressKnowledgearticlid = default(string), long? versionnumber = default(long?), string knowledgearticleid = default(string))
        {
            BcgovCustomaddressid = bcgovCustomaddressid;
            MsdynBcgovCustomaddressKnowledgearticlid = msdynBcgovCustomaddressKnowledgearticlid;
            Versionnumber = versionnumber;
            Knowledgearticleid = knowledgearticleid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bcgov_customaddressid")]
        public string BcgovCustomaddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_bcgov_customaddress_knowledgearticlid")]
        public string MsdynBcgovCustomaddressKnowledgearticlid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleid")]
        public string Knowledgearticleid { get; set; }

    }
}
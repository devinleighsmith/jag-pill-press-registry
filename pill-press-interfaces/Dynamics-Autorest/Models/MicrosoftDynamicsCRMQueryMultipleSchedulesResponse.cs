// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// QueryMultipleSchedulesResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMQueryMultipleSchedulesResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMQueryMultipleSchedulesResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMQueryMultipleSchedulesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMQueryMultipleSchedulesResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMQueryMultipleSchedulesResponse(IList<MicrosoftDynamicsCRMTimeInfoCollection> timeInfos = default(IList<MicrosoftDynamicsCRMTimeInfoCollection>))
        {
            TimeInfos = timeInfos;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TimeInfos")]
        public IList<MicrosoftDynamicsCRMTimeInfoCollection> TimeInfos { get; set; }

    }
}
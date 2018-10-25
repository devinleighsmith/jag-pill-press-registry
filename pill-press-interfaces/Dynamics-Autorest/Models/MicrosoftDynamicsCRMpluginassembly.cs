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
    /// pluginassembly
    /// </summary>
    public partial class MicrosoftDynamicsCRMpluginassembly
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMpluginassembly class.
        /// </summary>
        public MicrosoftDynamicsCRMpluginassembly()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMpluginassembly class.
        /// </summary>
        public MicrosoftDynamicsCRMpluginassembly(MicrosoftDynamicsCRMBooleanManagedProperty ishidden = default(MicrosoftDynamicsCRMBooleanManagedProperty), int? sourcetype = default(int?), string _organizationidValue = default(string), string sourcehash = default(string), string introducedversion = default(string), string name = default(string), string publickeytoken = default(string), string _createdbyValue = default(string), int? customizationlevel = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string version = default(string), string description = default(string), string solutionid = default(string), bool? ismanaged = default(bool?), string culture = default(string), string pluginassemblyidunique = default(string), long? versionnumber = default(long?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string pluginassemblyid = default(string), string _modifiedbyValue = default(string), int? major = default(int?), int? componentstate = default(int?), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), string path = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? minor = default(int?), string content = default(string), object contentBinary = default(object), int? isolationmode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMplugintype> pluginassemblyPlugintype = default(IList<MicrosoftDynamicsCRMplugintype>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Ishidden = ishidden;
            Sourcetype = sourcetype;
            this._organizationidValue = _organizationidValue;
            Sourcehash = sourcehash;
            Introducedversion = introducedversion;
            Name = name;
            Publickeytoken = publickeytoken;
            this._createdbyValue = _createdbyValue;
            Customizationlevel = customizationlevel;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Version = version;
            Description = description;
            Solutionid = solutionid;
            Ismanaged = ismanaged;
            Culture = culture;
            Pluginassemblyidunique = pluginassemblyidunique;
            Versionnumber = versionnumber;
            Overwritetime = overwritetime;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Pluginassemblyid = pluginassemblyid;
            this._modifiedbyValue = _modifiedbyValue;
            Major = major;
            Componentstate = componentstate;
            Iscustomizable = iscustomizable;
            Path = path;
            Modifiedon = modifiedon;
            Minor = minor;
            Content = content;
            ContentBinary = contentBinary;
            Isolationmode = isolationmode;
            Createdby = createdby;
            PluginassemblyPlugintype = pluginassemblyPlugintype;
            Organizationid = organizationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ishidden")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Ishidden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourcetype")]
        public int? Sourcetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourcehash")]
        public string Sourcehash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publickeytoken")]
        public string Publickeytoken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "culture")]
        public string Culture { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pluginassemblyidunique")]
        public string Pluginassemblyidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pluginassemblyid")]
        public string Pluginassemblyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "major")]
        public int? Major { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minor")]
        public int? Minor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content_binary")]
        public object ContentBinary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isolationmode")]
        public int? Isolationmode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pluginassembly_plugintype")]
        public IList<MicrosoftDynamicsCRMplugintype> PluginassemblyPlugintype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
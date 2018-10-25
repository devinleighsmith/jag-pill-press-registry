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
    /// ComplexManyToManyRelationshipMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMComplexManyToManyRelationshipMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexManyToManyRelationshipMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexManyToManyRelationshipMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexManyToManyRelationshipMetadata class.
        /// </summary>
        /// <param name="securityTypes">Possible values include: 'None',
        /// 'Append', 'ParentChild', 'Pointer', 'Inheritance'</param>
        /// <param name="relationshipType">Possible values include:
        /// 'OneToManyRelationship', 'ManyToManyRelationship'</param>
        public MicrosoftDynamicsCRMComplexManyToManyRelationshipMetadata(MicrosoftDynamicsCRMAssociatedMenuConfiguration entity1AssociatedMenuConfiguration = default(MicrosoftDynamicsCRMAssociatedMenuConfiguration), MicrosoftDynamicsCRMAssociatedMenuConfiguration entity2AssociatedMenuConfiguration = default(MicrosoftDynamicsCRMAssociatedMenuConfiguration), string entity1LogicalName = default(string), string entity2LogicalName = default(string), string intersectEntityName = default(string), string entity1IntersectAttribute = default(string), string entity2IntersectAttribute = default(string), string entity1NavigationPropertyName = default(string), string entity2NavigationPropertyName = default(string), bool? isCustomRelationship = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isCustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isValidForAdvancedFind = default(bool?), string schemaName = default(string), string securityTypes = default(string), bool? isManaged = default(bool?), string relationshipType = default(string), string introducedVersion = default(string), string metadataId = default(string), bool? hasChanged = default(bool?))
        {
            Entity1AssociatedMenuConfiguration = entity1AssociatedMenuConfiguration;
            Entity2AssociatedMenuConfiguration = entity2AssociatedMenuConfiguration;
            Entity1LogicalName = entity1LogicalName;
            Entity2LogicalName = entity2LogicalName;
            IntersectEntityName = intersectEntityName;
            Entity1IntersectAttribute = entity1IntersectAttribute;
            Entity2IntersectAttribute = entity2IntersectAttribute;
            Entity1NavigationPropertyName = entity1NavigationPropertyName;
            Entity2NavigationPropertyName = entity2NavigationPropertyName;
            IsCustomRelationship = isCustomRelationship;
            IsCustomizable = isCustomizable;
            IsValidForAdvancedFind = isValidForAdvancedFind;
            SchemaName = schemaName;
            SecurityTypes = securityTypes;
            IsManaged = isManaged;
            RelationshipType = relationshipType;
            IntroducedVersion = introducedVersion;
            MetadataId = metadataId;
            HasChanged = hasChanged;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity1AssociatedMenuConfiguration")]
        public MicrosoftDynamicsCRMAssociatedMenuConfiguration Entity1AssociatedMenuConfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity2AssociatedMenuConfiguration")]
        public MicrosoftDynamicsCRMAssociatedMenuConfiguration Entity2AssociatedMenuConfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity1LogicalName")]
        public string Entity1LogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity2LogicalName")]
        public string Entity2LogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntersectEntityName")]
        public string IntersectEntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity1IntersectAttribute")]
        public string Entity1IntersectAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity2IntersectAttribute")]
        public string Entity2IntersectAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity1NavigationPropertyName")]
        public string Entity1NavigationPropertyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entity2NavigationPropertyName")]
        public string Entity2NavigationPropertyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomRelationship")]
        public bool? IsCustomRelationship { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty IsCustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsValidForAdvancedFind")]
        public bool? IsValidForAdvancedFind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Append',
        /// 'ParentChild', 'Pointer', 'Inheritance'
        /// </summary>
        [JsonProperty(PropertyName = "SecurityTypes")]
        public string SecurityTypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsManaged")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'OneToManyRelationship',
        /// 'ManyToManyRelationship'
        /// </summary>
        [JsonProperty(PropertyName = "RelationshipType")]
        public string RelationshipType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntroducedVersion")]
        public string IntroducedVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MetadataId")]
        public string MetadataId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasChanged")]
        public bool? HasChanged { get; set; }

    }
}
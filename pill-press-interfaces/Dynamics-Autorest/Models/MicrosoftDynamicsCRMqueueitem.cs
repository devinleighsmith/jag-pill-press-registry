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
    /// queueitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMqueueitem
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMqueueitem
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMqueueitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMqueueitem
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMqueueitem(string _workeridValue = default(string), string _createdbyValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? adoxioPaymentreceiveddate = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), System.DateTimeOffset? workeridmodifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), object exchangerate = default(object), int? utcconversiontimezonecode = default(int?), string _queueidValue = default(string), int? statecode = default(int?), System.DateTimeOffset? enteredon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string _owneridValue = default(string), int? objecttypecode = default(int?), string queueitemid = default(string), int? statuscode = default(int?), string _objectidValue = default(string), string _owninguserValue = default(string), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string title = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMknowledgearticle objectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMappointment objectidAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcampaignactivity objectidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMsystemuser workeridSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMactivitypointer objectidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMqueue queueid = default(MicrosoftDynamicsCRMqueue), MicrosoftDynamicsCRMincident objectidIncident = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMasyncoperation> queueItemAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMteam workeridTeam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMfax objectidFax = default(MicrosoftDynamicsCRMfax), MicrosoftDynamicsCRMrecurringappointmentmaster objectidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), IList<MicrosoftDynamicsCRMsyncerror> queueItemSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcampaignresponse objectidCampaignresponse = default(MicrosoftDynamicsCRMcampaignresponse), MicrosoftDynamicsCRMserviceappointment objectidServiceappointment = default(MicrosoftDynamicsCRMserviceappointment), MicrosoftDynamicsCRMletter objectidLetter = default(MicrosoftDynamicsCRMletter), MicrosoftDynamicsCRMsocialactivity objectidSocialactivity = default(MicrosoftDynamicsCRMsocialactivity), MicrosoftDynamicsCRMphonecall objectidPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMtask objectidTask = default(MicrosoftDynamicsCRMtask), IList<MicrosoftDynamicsCRMbulkdeletefailure> queueItemBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMemail objectidEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMbulkoperation objectidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMadoxioApplication objectidAdoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioInvestigation objectidAdoxioInvestigation = default(MicrosoftDynamicsCRMadoxioInvestigation))
        {
            this._workeridValue = _workeridValue;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioPaymentreceiveddate = adoxioPaymentreceiveddate;
            Importsequencenumber = importsequencenumber;
            Workeridmodifiedon = workeridmodifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Exchangerate = exchangerate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._queueidValue = _queueidValue;
            Statecode = statecode;
            Enteredon = enteredon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            this._owneridValue = _owneridValue;
            Objecttypecode = objecttypecode;
            Queueitemid = queueitemid;
            Statuscode = statuscode;
            this._objectidValue = _objectidValue;
            this._owninguserValue = _owninguserValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Title = title;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Modifiedon = modifiedon;
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            ObjectidKnowledgearticle = objectidKnowledgearticle;
            Createdby = createdby;
            ObjectidAppointment = objectidAppointment;
            Modifiedby = modifiedby;
            ObjectidCampaignactivity = objectidCampaignactivity;
            WorkeridSystemuser = workeridSystemuser;
            ObjectidActivitypointer = objectidActivitypointer;
            Queueid = queueid;
            ObjectidIncident = objectidIncident;
            QueueItemAsyncOperations = queueItemAsyncOperations;
            WorkeridTeam = workeridTeam;
            ObjectidFax = objectidFax;
            ObjectidRecurringappointmentmaster = objectidRecurringappointmentmaster;
            QueueItemSyncErrors = queueItemSyncErrors;
            Organizationid = organizationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            ObjectidCampaignresponse = objectidCampaignresponse;
            ObjectidServiceappointment = objectidServiceappointment;
            ObjectidLetter = objectidLetter;
            ObjectidSocialactivity = objectidSocialactivity;
            ObjectidPhonecall = objectidPhonecall;
            Transactioncurrencyid = transactioncurrencyid;
            ObjectidTask = objectidTask;
            QueueItemBulkDeleteFailures = queueItemBulkDeleteFailures;
            ObjectidEmail = objectidEmail;
            ObjectidBulkoperation = objectidBulkoperation;
            Createdonbehalfby = createdonbehalfby;
            ObjectidAdoxioApplication = objectidAdoxioApplication;
            ObjectidAdoxioInvestigation = objectidAdoxioInvestigation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_workerid_value")]
        public string _workeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_paymentreceiveddate")]
        public System.DateTimeOffset? AdoxioPaymentreceiveddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workeridmodifiedon")]
        public System.DateTimeOffset? Workeridmodifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_queueid_value")]
        public string _queueidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enteredon")]
        public System.DateTimeOffset? Enteredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueitemid")]
        public string Queueitemid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_objectid_value")]
        public string _objectidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle ObjectidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_appointment")]
        public MicrosoftDynamicsCRMappointment ObjectidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_campaignactivity")]
        public MicrosoftDynamicsCRMcampaignactivity ObjectidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workerid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser WorkeridSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ObjectidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueid")]
        public MicrosoftDynamicsCRMqueue Queueid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_incident")]
        public MicrosoftDynamicsCRMincident ObjectidIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItem_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QueueItemAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workerid_team")]
        public MicrosoftDynamicsCRMteam WorkeridTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_fax")]
        public MicrosoftDynamicsCRMfax ObjectidFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster ObjectidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItem_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> QueueItemSyncErrors { get; set; }

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
        [JsonProperty(PropertyName = "objectid_campaignresponse")]
        public MicrosoftDynamicsCRMcampaignresponse ObjectidCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_serviceappointment")]
        public MicrosoftDynamicsCRMserviceappointment ObjectidServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_letter")]
        public MicrosoftDynamicsCRMletter ObjectidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_socialactivity")]
        public MicrosoftDynamicsCRMsocialactivity ObjectidSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_phonecall")]
        public MicrosoftDynamicsCRMphonecall ObjectidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_task")]
        public MicrosoftDynamicsCRMtask ObjectidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItem_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QueueItemBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_email")]
        public MicrosoftDynamicsCRMemail ObjectidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_bulkoperation")]
        public MicrosoftDynamicsCRMbulkoperation ObjectidBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_application")]
        public MicrosoftDynamicsCRMadoxioApplication ObjectidAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_investigation")]
        public MicrosoftDynamicsCRMadoxioInvestigation ObjectidAdoxioInvestigation { get; set; }

    }
}
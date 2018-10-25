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
    /// recurringappointmentmaster
    /// </summary>
    public partial class MicrosoftDynamicsCRMrecurringappointmentmaster
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMrecurringappointmentmaster class.
        /// </summary>
        public MicrosoftDynamicsCRMrecurringappointmentmaster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMrecurringappointmentmaster class.
        /// </summary>
        public MicrosoftDynamicsCRMrecurringappointmentmaster(int? occurrences = default(int?), int? importsequencenumber = default(int?), string category = default(string), string _ruleidValue = default(string), bool? isregenerate = default(bool?), bool? isnthmonthly = default(bool?), System.DateTimeOffset? endtime = default(System.DateTimeOffset?), int? daysofweekmask = default(int?), int? outlookownerapptid = default(int?), string subscriptionid = default(string), System.DateTimeOffset? effectiveenddate = default(System.DateTimeOffset?), bool? isalldayevent = default(bool?), System.DateTimeOffset? patternenddate = default(System.DateTimeOffset?), System.DateTimeOffset? starttime = default(System.DateTimeOffset?), string globalobjectid = default(string), System.DateTimeOffset? patternstartdate = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? instance = default(int?), int? patternendtype = default(int?), string deletedexceptionslist = default(string), System.DateTimeOffset? nextexpansioninstancedate = default(System.DateTimeOffset?), int? monthofyear = default(int?), System.DateTimeOffset? lastexpandedinstancedate = default(System.DateTimeOffset?), int? duration = default(int?), bool? isweekdaypattern = default(bool?), int? firstdayofweek = default(int?), bool? isnthyearly = default(bool?), bool? seriesstatus = default(bool?), string subcategory = default(string), int? dayofmonth = default(int?), int? expansionstatecode = default(int?), System.DateTimeOffset? effectivestartdate = default(System.DateTimeOffset?), int? recurrencepatterntype = default(int?), string _groupidValue = default(string), string location = default(string), int? interval = default(int?), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementRecurringappointmentmaster = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateRecurringappointmentmaster = default(MicrosoftDynamicsCRMentitlementtemplate), IList<MicrosoftDynamicsCRMpostregarding> recurringappointmentmasterPostRegardings = default(IList<MicrosoftDynamicsCRMpostregarding>), IList<MicrosoftDynamicsCRMpostfollow> recurringappointmentmasterPostFollows = default(IList<MicrosoftDynamicsCRMpostfollow>), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingRecurringappointmentmaster = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderRecurringappointmentmaster = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordRecurringappointmentmaster = default(MicrosoftDynamicsCRMknowledgebaserecord), IList<MicrosoftDynamicsCRMbulkdeletefailure> recurringAppointmentMasterBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMasyncoperation> recurringAppointmentMasterAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMduplicaterecord> recurringAppointmentMasterDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMsystemuser owninguserRecurringappointmentmaster = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamRecurringappointmentmaster = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMcontract regardingobjectidContractRecurringappointmentmaster = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMactivityparty> recurringappointmentmasterActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMduplicaterecord> recurringAppointmentMasterDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMbusinessunit owningbusinessunitRecurringappointmentmaster = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignRecurringappointmentmaster = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceRecurringappointmentmaster = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMservice serviceidRecurringappointmentmaster = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMsystemuser createdonbehalfbyRecurringappointmentmaster = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdbyRecurringappointmentmaster = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleRecurringappointmentmaster = default(MicrosoftDynamicsCRMknowledgearticle), IList<MicrosoftDynamicsCRMappointment> recurringappointmentmasterAppointment = default(IList<MicrosoftDynamicsCRMappointment>), MicrosoftDynamicsCRMaccount regardingobjectidAccountRecurringappointmentmaster = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMqueueitem> recurringAppointmentMasterQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMconnection> recurringappointmentmasterConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyRecurringappointmentmaster = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMlead regardingobjectidLeadRecurringappointmentmaster = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityRecurringappointmentmaster = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidRecurringappointmentmaster = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMcampaignresponse> recurringappointmentmasterCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMconnection> recurringappointmentmasterConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMsyncerror> recurringAppointmentMasterSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMincident regardingobjectidIncidentRecurringappointmentmaster = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMactioncard> recurringappointmentmasterActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderRecurringappointmentmaster = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMquote regardingobjectidQuoteRecurringappointmentmaster = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMcontact regardingobjectidContactRecurringappointmentmaster = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser modifiedbyRecurringappointmentmaster = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationRecurringappointmentmaster = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityRecurringappointmentmaster = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMannotation> recurringAppointmentMasterAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMadoxioAgencycommunication regardingobjectidAdoxioAgencycommunicationRecurringappointmentmaster = default(MicrosoftDynamicsCRMadoxioAgencycommunication), MicrosoftDynamicsCRMadoxioApplication regardingobjectidAdoxioApplicationRecurringappointmentmaster = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioInvestigationstakeholder regardingobjectidAdoxioInvestigationstakeholderRecurringappointmentmaster = default(MicrosoftDynamicsCRMadoxioInvestigationstakeholder), MicrosoftDynamicsCRMadoxioLicences regardingobjectidAdoxioLicencesRecurringappointmentmaster = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioComplaint regardingobjectidAdoxioComplaintRecurringappointmentmaster = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioInvestigation regardingobjectidAdoxioInvestigationRecurringappointmentmaster = default(MicrosoftDynamicsCRMadoxioInvestigation))
        {
            Occurrences = occurrences;
            Importsequencenumber = importsequencenumber;
            Category = category;
            this._ruleidValue = _ruleidValue;
            Isregenerate = isregenerate;
            Isnthmonthly = isnthmonthly;
            Endtime = endtime;
            Daysofweekmask = daysofweekmask;
            Outlookownerapptid = outlookownerapptid;
            Subscriptionid = subscriptionid;
            Effectiveenddate = effectiveenddate;
            Isalldayevent = isalldayevent;
            Patternenddate = patternenddate;
            Starttime = starttime;
            Globalobjectid = globalobjectid;
            Patternstartdate = patternstartdate;
            Overriddencreatedon = overriddencreatedon;
            Instance = instance;
            Patternendtype = patternendtype;
            Deletedexceptionslist = deletedexceptionslist;
            Nextexpansioninstancedate = nextexpansioninstancedate;
            Monthofyear = monthofyear;
            Lastexpandedinstancedate = lastexpandedinstancedate;
            Duration = duration;
            Isweekdaypattern = isweekdaypattern;
            Firstdayofweek = firstdayofweek;
            Isnthyearly = isnthyearly;
            Seriesstatus = seriesstatus;
            Subcategory = subcategory;
            Dayofmonth = dayofmonth;
            Expansionstatecode = expansionstatecode;
            Effectivestartdate = effectivestartdate;
            Recurrencepatterntype = recurrencepatterntype;
            this._groupidValue = _groupidValue;
            Location = location;
            Interval = interval;
            RegardingobjectidEntitlementRecurringappointmentmaster = regardingobjectidEntitlementRecurringappointmentmaster;
            RegardingobjectidEntitlementtemplateRecurringappointmentmaster = regardingobjectidEntitlementtemplateRecurringappointmentmaster;
            RecurringappointmentmasterPostRegardings = recurringappointmentmasterPostRegardings;
            RecurringappointmentmasterPostFollows = recurringappointmentmasterPostFollows;
            RegardingobjectidBookableresourcebookingRecurringappointmentmaster = regardingobjectidBookableresourcebookingRecurringappointmentmaster;
            RegardingobjectidBookableresourcebookingheaderRecurringappointmentmaster = regardingobjectidBookableresourcebookingheaderRecurringappointmentmaster;
            RegardingobjectidKnowledgebaserecordRecurringappointmentmaster = regardingobjectidKnowledgebaserecordRecurringappointmentmaster;
            RecurringAppointmentMasterBulkDeleteFailures = recurringAppointmentMasterBulkDeleteFailures;
            RecurringAppointmentMasterAsyncOperations = recurringAppointmentMasterAsyncOperations;
            RecurringAppointmentMasterDuplicateBaseRecord = recurringAppointmentMasterDuplicateBaseRecord;
            OwninguserRecurringappointmentmaster = owninguserRecurringappointmentmaster;
            OwningteamRecurringappointmentmaster = owningteamRecurringappointmentmaster;
            RegardingobjectidContractRecurringappointmentmaster = regardingobjectidContractRecurringappointmentmaster;
            ActivityidActivitypointer = activityidActivitypointer;
            RecurringappointmentmasterActivityParties = recurringappointmentmasterActivityParties;
            RecurringAppointmentMasterDuplicateMatchingRecord = recurringAppointmentMasterDuplicateMatchingRecord;
            OwningbusinessunitRecurringappointmentmaster = owningbusinessunitRecurringappointmentmaster;
            RegardingobjectidCampaignRecurringappointmentmaster = regardingobjectidCampaignRecurringappointmentmaster;
            RegardingobjectidInvoiceRecurringappointmentmaster = regardingobjectidInvoiceRecurringappointmentmaster;
            ServiceidRecurringappointmentmaster = serviceidRecurringappointmentmaster;
            CreatedonbehalfbyRecurringappointmentmaster = createdonbehalfbyRecurringappointmentmaster;
            CreatedbyRecurringappointmentmaster = createdbyRecurringappointmentmaster;
            RegardingobjectidKnowledgearticleRecurringappointmentmaster = regardingobjectidKnowledgearticleRecurringappointmentmaster;
            RecurringappointmentmasterAppointment = recurringappointmentmasterAppointment;
            RegardingobjectidAccountRecurringappointmentmaster = regardingobjectidAccountRecurringappointmentmaster;
            RecurringAppointmentMasterQueueItem = recurringAppointmentMasterQueueItem;
            RecurringappointmentmasterConnections1 = recurringappointmentmasterConnections1;
            ModifiedonbehalfbyRecurringappointmentmaster = modifiedonbehalfbyRecurringappointmentmaster;
            RegardingobjectidLeadRecurringappointmentmaster = regardingobjectidLeadRecurringappointmentmaster;
            RegardingobjectidOpportunityRecurringappointmentmaster = regardingobjectidOpportunityRecurringappointmentmaster;
            TransactioncurrencyidRecurringappointmentmaster = transactioncurrencyidRecurringappointmentmaster;
            RecurringappointmentmasterCampaignresponse = recurringappointmentmasterCampaignresponse;
            RecurringappointmentmasterConnections2 = recurringappointmentmasterConnections2;
            RecurringAppointmentMasterSyncErrors = recurringAppointmentMasterSyncErrors;
            RegardingobjectidIncidentRecurringappointmentmaster = regardingobjectidIncidentRecurringappointmentmaster;
            StageidProcessstage = stageidProcessstage;
            RecurringappointmentmasterActioncard = recurringappointmentmasterActioncard;
            RegardingobjectidSalesorderRecurringappointmentmaster = regardingobjectidSalesorderRecurringappointmentmaster;
            RegardingobjectidQuoteRecurringappointmentmaster = regardingobjectidQuoteRecurringappointmentmaster;
            RegardingobjectidContactRecurringappointmentmaster = regardingobjectidContactRecurringappointmentmaster;
            ModifiedbyRecurringappointmentmaster = modifiedbyRecurringappointmentmaster;
            RegardingobjectidBulkoperationRecurringappointmentmaster = regardingobjectidBulkoperationRecurringappointmentmaster;
            RegardingobjectidCampaignactivityRecurringappointmentmaster = regardingobjectidCampaignactivityRecurringappointmentmaster;
            RecurringAppointmentMasterAnnotation = recurringAppointmentMasterAnnotation;
            RegardingobjectidAdoxioAgencycommunicationRecurringappointmentmaster = regardingobjectidAdoxioAgencycommunicationRecurringappointmentmaster;
            RegardingobjectidAdoxioApplicationRecurringappointmentmaster = regardingobjectidAdoxioApplicationRecurringappointmentmaster;
            RegardingobjectidAdoxioInvestigationstakeholderRecurringappointmentmaster = regardingobjectidAdoxioInvestigationstakeholderRecurringappointmentmaster;
            RegardingobjectidAdoxioLicencesRecurringappointmentmaster = regardingobjectidAdoxioLicencesRecurringappointmentmaster;
            RegardingobjectidAdoxioComplaintRecurringappointmentmaster = regardingobjectidAdoxioComplaintRecurringappointmentmaster;
            RegardingobjectidAdoxioInvestigationRecurringappointmentmaster = regardingobjectidAdoxioInvestigationRecurringappointmentmaster;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "occurrences")]
        public int? Occurrences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ruleid_value")]
        public string _ruleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isregenerate")]
        public bool? Isregenerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isnthmonthly")]
        public bool? Isnthmonthly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endtime")]
        public System.DateTimeOffset? Endtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daysofweekmask")]
        public int? Daysofweekmask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outlookownerapptid")]
        public int? Outlookownerapptid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveenddate")]
        public System.DateTimeOffset? Effectiveenddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isalldayevent")]
        public bool? Isalldayevent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patternenddate")]
        public System.DateTimeOffset? Patternenddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "starttime")]
        public System.DateTimeOffset? Starttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "globalobjectid")]
        public string Globalobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patternstartdate")]
        public System.DateTimeOffset? Patternstartdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "instance")]
        public int? Instance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patternendtype")]
        public int? Patternendtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deletedexceptionslist")]
        public string Deletedexceptionslist { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nextexpansioninstancedate")]
        public System.DateTimeOffset? Nextexpansioninstancedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "monthofyear")]
        public int? Monthofyear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastexpandedinstancedate")]
        public System.DateTimeOffset? Lastexpandedinstancedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isweekdaypattern")]
        public bool? Isweekdaypattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstdayofweek")]
        public int? Firstdayofweek { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isnthyearly")]
        public bool? Isnthyearly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "seriesstatus")]
        public bool? Seriesstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dayofmonth")]
        public int? Dayofmonth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expansionstatecode")]
        public int? Expansionstatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivestartdate")]
        public System.DateTimeOffset? Effectivestartdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurrencepatterntype")]
        public int? Recurrencepatterntype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_groupid_value")]
        public string _groupidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpostregarding> RecurringappointmentmasterPostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_PostFollows")]
        public IList<MicrosoftDynamicsCRMpostfollow> RecurringappointmentmasterPostFollows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> RecurringAppointmentMasterBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> RecurringAppointmentMasterAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> RecurringAppointmentMasterDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsystemuser OwninguserRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMteam OwningteamRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> RecurringappointmentmasterActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> RecurringAppointmentMasterDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMservice ServiceidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_appointment")]
        public IList<MicrosoftDynamicsCRMappointment> RecurringappointmentmasterAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> RecurringAppointmentMasterQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> RecurringappointmentmasterConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> RecurringappointmentmasterCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> RecurringappointmentmasterConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> RecurringAppointmentMasterSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> RecurringappointmentmasterActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> RecurringAppointmentMasterAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_agencycommunication_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMadoxioAgencycommunication RegardingobjectidAdoxioAgencycommunicationRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_application_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMadoxioApplication RegardingobjectidAdoxioApplicationRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigationstakeholder_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMadoxioInvestigationstakeholder RegardingobjectidAdoxioInvestigationstakeholderRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_licences_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMadoxioLicences RegardingobjectidAdoxioLicencesRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_complaint_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMadoxioComplaint RegardingobjectidAdoxioComplaintRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_adoxio_investigation_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMadoxioInvestigation RegardingobjectidAdoxioInvestigationRecurringappointmentmaster { get; set; }

    }
}
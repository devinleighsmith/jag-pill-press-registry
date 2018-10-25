// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Auto Generated
    /// </summary>
    public partial class DynamicsClient : ServiceClient<DynamicsClient>, IDynamicsClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client subscription.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets the IAccounts.
        /// </summary>
        public virtual IAccounts Accounts { get; private set; }

        /// <summary>
        /// Gets the IAliases.
        /// </summary>
        public virtual IAliases Aliases { get; private set; }

        /// <summary>
        /// Gets the IApplications.
        /// </summary>
        public virtual IApplications Applications { get; private set; }

        /// <summary>
        /// Gets the ICorporatehistorysummaries.
        /// </summary>
        public virtual ICorporatehistorysummaries Corporatehistorysummaries { get; private set; }

        /// <summary>
        /// Gets the ICorporateroles.
        /// </summary>
        public virtual ICorporateroles Corporateroles { get; private set; }

        /// <summary>
        /// Gets the IEstablishments.
        /// </summary>
        public virtual IEstablishments Establishments { get; private set; }

        /// <summary>
        /// Gets the IAdoxiolegalentities.
        /// </summary>
        public virtual IAdoxiolegalentities Adoxiolegalentities { get; private set; }

        /// <summary>
        /// Gets the IAdoxioLicencetypes.
        /// </summary>
        public virtual IAdoxioLicencetypes AdoxioLicencetypes { get; private set; }

        /// <summary>
        /// Gets the ILicenses.
        /// </summary>
        public virtual ILicenses Licenses { get; private set; }

        /// <summary>
        /// Gets the IPersonalhistorysummaries.
        /// </summary>
        public virtual IPersonalhistorysummaries Personalhistorysummaries { get; private set; }

        /// <summary>
        /// Gets the IPolicydocuments.
        /// </summary>
        public virtual IPolicydocuments Policydocuments { get; private set; }

        /// <summary>
        /// Gets the IPreviousaddresses.
        /// </summary>
        public virtual IPreviousaddresses Previousaddresses { get; private set; }

        /// <summary>
        /// Gets the ISpddatarows.
        /// </summary>
        public virtual ISpddatarows Spddatarows { get; private set; }

        /// <summary>
        /// Gets the ISpdexportses.
        /// </summary>
        public virtual ISpdexportses Spdexportses { get; private set; }

        /// <summary>
        /// Gets the IAdoxioTiedhouseassociations.
        /// </summary>
        public virtual IAdoxioTiedhouseassociations AdoxioTiedhouseassociations { get; private set; }

        /// <summary>
        /// Gets the IAdoxioTiedhouseconnections.
        /// </summary>
        public virtual IAdoxioTiedhouseconnections AdoxioTiedhouseconnections { get; private set; }

        /// <summary>
        /// Gets the IWorkers.
        /// </summary>
        public virtual IWorkers Workers { get; private set; }

        /// <summary>
        /// Gets the IContacts.
        /// </summary>
        public virtual IContacts Contacts { get; private set; }

        /// <summary>
        /// Gets the IInvoices.
        /// </summary>
        public virtual IInvoices Invoices { get; private set; }

        /// <summary>
        /// Gets the ISharepointDocumentLocations.
        /// </summary>
        public virtual ISharepointDocumentLocations SharepointDocumentLocations { get; private set; }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DynamicsClient.Dispose(). False: will not dispose provided httpClient</param>
        protected DynamicsClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DynamicsClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DynamicsClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DynamicsClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DynamicsClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DynamicsClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Accounts = new Accounts(this);
            Aliases = new Aliases(this);
            Applications = new Applications(this);
            Corporatehistorysummaries = new Corporatehistorysummaries(this);
            Corporateroles = new Corporateroles(this);
            Establishments = new Establishments(this);
            Adoxiolegalentities = new Adoxiolegalentities(this);
            AdoxioLicencetypes = new AdoxioLicencetypes(this);
            Licenses = new Licenses(this);
            Personalhistorysummaries = new Personalhistorysummaries(this);
            Policydocuments = new Policydocuments(this);
            Previousaddresses = new Previousaddresses(this);
            Spddatarows = new Spddatarows(this);
            Spdexportses = new Spdexportses(this);
            AdoxioTiedhouseassociations = new AdoxioTiedhouseassociations(this);
            AdoxioTiedhouseconnections = new AdoxioTiedhouseconnections(this);
            Workers = new Workers(this);
            Contacts = new Contacts(this);
            Invoices = new Invoices(this);
            SharepointDocumentLocations = new SharepointDocumentLocations(this);
            BaseUri = new System.Uri("http://localhost");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
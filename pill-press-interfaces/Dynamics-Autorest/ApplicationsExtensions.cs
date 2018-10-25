// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Applications.
    /// </summary>
    public static partial class ApplicationsExtensions
    {
            /// <summary>
            /// Get entities from adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Show only the first n items
            /// </param>
            /// <param name='skip'>
            /// Skip only the first n items
            /// </param>
            /// <param name='search'>
            /// Search items by search phrases
            /// </param>
            /// <param name='filter'>
            /// Filter items by property values
            /// </param>
            /// <param name='count'>
            /// Include count of items
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static GetOKResponseModelModel Get(this IApplications operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Show only the first n items
            /// </param>
            /// <param name='skip'>
            /// Skip only the first n items
            /// </param>
            /// <param name='search'>
            /// Search items by search phrases
            /// </param>
            /// <param name='filter'>
            /// Filter items by property values
            /// </param>
            /// <param name='count'>
            /// Include count of items
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetOKResponseModelModel> GetAsync(this IApplications operations, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMadoxioApplication Create(this IApplications operations, MicrosoftDynamicsCRMadoxioApplication body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioApplication> CreateAsync(this IApplications operations, MicrosoftDynamicsCRMadoxioApplication body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete entity from adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this IApplications operations, string adoxioApplicationid, string ifMatch = default(string))
            {
                operations.DeleteAsync(adoxioApplicationid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplications operations, string adoxioApplicationid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(adoxioApplicationid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get entity from adoxio_applications by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioApplication GetByKey(this IApplications operations, string adoxioApplicationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(adoxioApplicationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_applications by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioApplication> GetByKeyAsync(this IApplications operations, string adoxioApplicationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(adoxioApplicationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update entity in adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this IApplications operations, string adoxioApplicationid, MicrosoftDynamicsCRMadoxioApplication body)
            {
                operations.UpdateAsync(adoxioApplicationid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IApplications operations, string adoxioApplicationid, MicrosoftDynamicsCRMadoxioApplication body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(adoxioApplicationid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='fieldname'>
            /// key: fieldname
            /// </param>
            public static void DeleteReference(this IApplications operations, string adoxioApplicationid, string fieldname)
            {
                operations.DeleteReferenceAsync(adoxioApplicationid, fieldname).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='fieldname'>
            /// key: fieldname
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteReferenceAsync(this IApplications operations, string adoxioApplicationid, string fieldname, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteReferenceWithHttpMessagesAsync(adoxioApplicationid, fieldname, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Add reference to adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='fieldname'>
            /// key: fieldname
            /// </param>
            /// <param name='odataid'>
            /// reference value
            /// </param>
            public static void AddReference(this IApplications operations, string adoxioApplicationid, string fieldname, Odataid odataid = default(Odataid))
            {
                operations.AddReferenceAsync(adoxioApplicationid, fieldname, odataid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add reference to adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='fieldname'>
            /// key: fieldname
            /// </param>
            /// <param name='odataid'>
            /// reference value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddReferenceAsync(this IApplications operations, string adoxioApplicationid, string fieldname, Odataid odataid = default(Odataid), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddReferenceWithHttpMessagesAsync(adoxioApplicationid, fieldname, odataid, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Change reference to adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='fieldname'>
            /// key: fieldname
            /// </param>
            /// <param name='odataid'>
            /// reference value
            /// </param>
            public static void ChangeReference(this IApplications operations, string adoxioApplicationid, string fieldname, Odataid odataid = default(Odataid))
            {
                operations.ChangeReferenceAsync(adoxioApplicationid, fieldname, odataid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Change reference to adoxio_applications
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid
            /// </param>
            /// <param name='fieldname'>
            /// key: fieldname
            /// </param>
            /// <param name='odataid'>
            /// reference value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ChangeReferenceAsync(this IApplications operations, string adoxioApplicationid, string fieldname, Odataid odataid = default(Odataid), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ChangeReferenceWithHttpMessagesAsync(adoxioApplicationid, fieldname, odataid, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
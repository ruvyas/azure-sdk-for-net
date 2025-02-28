// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.GuestConfiguration.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary>
    /// A Class representing a GuestConfigurationVmssAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="GuestConfigurationVmssAssignmentResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetGuestConfigurationVmssAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetGuestConfigurationVmssAssignment method.
    /// </summary>
    public partial class GuestConfigurationVmssAssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GuestConfigurationVmssAssignmentResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vmssName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics;
        private readonly GuestConfigurationAssignmentsVmssRestOperations _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient;
        private readonly ClientDiagnostics _guestConfigurationAssignmentReportsVmSSClientDiagnostics;
        private readonly GuestConfigurationAssignmentReportsVmssRestOperations _guestConfigurationAssignmentReportsVmSSRestClient;
        private readonly GuestConfigurationAssignmentData _data;

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationVmssAssignmentResource"/> class for mocking. </summary>
        protected GuestConfigurationVmssAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "GuestConfigurationVmssAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GuestConfigurationVmssAssignmentResource(ArmClient client, GuestConfigurationAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GuestConfigurationVmssAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GuestConfigurationVmssAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSApiVersion);
            _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient = new GuestConfigurationAssignmentsVmssRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSApiVersion);
            _guestConfigurationAssignmentReportsVmSSClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _guestConfigurationAssignmentReportsVmSSRestClient = new GuestConfigurationAssignmentReportsVmssRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.GuestConfiguration/guestConfigurationAssignments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GuestConfigurationAssignmentData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get information about a guest configuration assignment for VMSS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GuestConfigurationVmssAssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationVmssAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a guest configuration assignment for VMSS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GuestConfigurationVmssAssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuestConfigurationVmssAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a guest configuration assignment for VMSS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<GuestConfigurationVmssAssignmentResource>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new GuestConfigurationArmOperation<GuestConfigurationVmssAssignmentResource>(Response.FromValue(new GuestConfigurationVmssAssignmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a guest configuration assignment for VMSS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentsVMSS_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<GuestConfigurationVmssAssignmentResource> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _guestConfigurationVmssAssignmentGuestConfigurationAssignmentsVmSSRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new GuestConfigurationArmOperation<GuestConfigurationVmssAssignmentResource>(Response.FromValue(new GuestConfigurationVmssAssignmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all reports for the VMSS guest configuration assignment, latest report first.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}/reports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentReportsVMSS_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationAssignmentReport" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GuestConfigurationAssignmentReport> GetReportsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _guestConfigurationAssignmentReportsVmSSRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, GuestConfigurationAssignmentReport.DeserializeGuestConfigurationAssignmentReport, _guestConfigurationAssignmentReportsVmSSClientDiagnostics, Pipeline, "GuestConfigurationVmssAssignmentResource.GetReports", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all reports for the VMSS guest configuration assignment, latest report first.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}/reports</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentReportsVMSS_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationAssignmentReport" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GuestConfigurationAssignmentReport> GetReports(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _guestConfigurationAssignmentReportsVmSSRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, GuestConfigurationAssignmentReport.DeserializeGuestConfigurationAssignmentReport, _guestConfigurationAssignmentReportsVmSSClientDiagnostics, Pipeline, "GuestConfigurationVmssAssignmentResource.GetReports", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get a report for the VMSS guest configuration assignment, by reportId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}/reports/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentReportsVMSS_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The GUID for the guest configuration assignment report. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<GuestConfigurationAssignmentReport>> GetReportAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _guestConfigurationAssignmentReportsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentResource.GetReport");
            scope.Start();
            try
            {
                var response = await _guestConfigurationAssignmentReportsVmSSRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a report for the VMSS guest configuration assignment, by reportId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments/{name}/reports/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GuestConfigurationAssignmentReportsVMSS_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The GUID for the guest configuration assignment report. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<GuestConfigurationAssignmentReport> GetReport(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _guestConfigurationAssignmentReportsVmSSClientDiagnostics.CreateScope("GuestConfigurationVmssAssignmentResource.GetReport");
            scope.Start();
            try
            {
                var response = _guestConfigurationAssignmentReportsVmSSRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

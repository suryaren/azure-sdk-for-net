// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SqlPoolWorkloadGroupOperations.
    /// </summary>
    public static partial class SqlPoolWorkloadGroupOperationsExtensions
    {
            /// <summary>
            /// Sql pool's workload group
            /// </summary>
            /// <remarks>
            /// Get a Sql pool's workload group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            public static WorkloadGroup Get(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sql pool's workload group
            /// </summary>
            /// <remarks>
            /// Get a Sql pool's workload group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkloadGroup> GetAsync(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create Or Update workload group
            /// </summary>
            /// <remarks>
            /// Create Or Update a Sql pool's workload group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='parameters'>
            /// The requested workload group state.
            /// </param>
            public static WorkloadGroup CreateOrUpdate(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, WorkloadGroup parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Or Update workload group
            /// </summary>
            /// <remarks>
            /// Create Or Update a Sql pool's workload group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='parameters'>
            /// The requested workload group state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkloadGroup> CreateOrUpdateAsync(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, WorkloadGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove workload group
            /// </summary>
            /// <remarks>
            /// Remove Sql pool's workload group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            public static void Delete(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove workload group
            /// </summary>
            /// <remarks>
            /// Remove Sql pool's workload group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sql pool's workload groups
            /// </summary>
            /// <remarks>
            /// Get list of  Sql pool's workload groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            public static IPage<WorkloadGroup> List(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName)
            {
                return operations.ListAsync(resourceGroupName, workspaceName, sqlPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sql pool's workload groups
            /// </summary>
            /// <remarks>
            /// Get list of  Sql pool's workload groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkloadGroup>> ListAsync(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create Or Update workload group
            /// </summary>
            /// <remarks>
            /// Create Or Update a Sql pool's workload group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='parameters'>
            /// The requested workload group state.
            /// </param>
            public static WorkloadGroup BeginCreateOrUpdate(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, WorkloadGroup parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Or Update workload group
            /// </summary>
            /// <remarks>
            /// Create Or Update a Sql pool's workload group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='parameters'>
            /// The requested workload group state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkloadGroup> BeginCreateOrUpdateAsync(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, WorkloadGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove workload group
            /// </summary>
            /// <remarks>
            /// Remove Sql pool's workload group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            public static void BeginDelete(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName)
            {
                operations.BeginDeleteAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove workload group
            /// </summary>
            /// <remarks>
            /// Remove Sql pool's workload group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace
            /// </param>
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISqlPoolWorkloadGroupOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sql pool's workload groups
            /// </summary>
            /// <remarks>
            /// Get list of  Sql pool's workload groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WorkloadGroup> ListNext(this ISqlPoolWorkloadGroupOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sql pool's workload groups
            /// </summary>
            /// <remarks>
            /// Get list of  Sql pool's workload groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkloadGroup>> ListNextAsync(this ISqlPoolWorkloadGroupOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
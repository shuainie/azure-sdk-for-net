﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.HDInsight.ClusterProvisioning.RestClient.ClustersResource
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.WindowsAzure.Management.HDInsight.ClusterProvisioning.Data;
    using Microsoft.WindowsAzure.Management.HDInsight.ClusterProvisioning.Data.Rdfe;
    using Microsoft.WindowsAzure.Management.HDInsight.ClusterProvisioning.RestClient.ClustersResource;
    using Microsoft.WindowsAzure.Management.HDInsight.Contracts;
    using Microsoft.WindowsAzure.Management.HDInsight.Contracts.May2014;
    using Microsoft.WindowsAzure.Management.HDInsight.Contracts.May2014.Components;
    using Microsoft.WindowsAzure.Management.HDInsight.Framework.Rest;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.WindowsAzure.Management.HDInsight.Framework.Rest.CodeGen.HttpRestClient" +
        "CodeGenerator", "1.0.0.0")]
    internal class RdfeClustersResourceRestClient : HttpRestClient<IRdfeClustersResourceRestClient>, IRdfeClustersResourceRestClient
    {

        public RdfeClustersResourceRestClient(System.Uri baseUri, Microsoft.WindowsAzure.Management.HDInsight.Framework.Rest.HttpRestClientConfiguration configuration) :
            base(baseUri, configuration)
        {
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(72)]
        public virtual Task RegisterSubscriptionIfNotExists(string subscriptionId, string cloudServiceNameWithDeploymentNamespace, CancellationToken cancellationToken)
        {
            return ((Task)(base.CreateAndInvokeRestRequestForParentMethodAsync(subscriptionId, cloudServiceNameWithDeploymentNamespace, cancellationToken)));
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(72)]
        public virtual Task PutCloudServiceAsync(string subscriptionId, string cloudServiceName, CloudService newCloudService, CancellationToken cancellationToken)
        {
            return ((Task)(base.CreateAndInvokeRestRequestForParentMethodAsync(subscriptionId, cloudServiceName, newCloudService, cancellationToken)));
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(72)]
        public virtual Task<CloudServiceList> ListCloudServicesAsync(string subscriptionId, CancellationToken cancellationToken)
        {
            return ((Task<CloudServiceList>)(base.CreateAndInvokeRestRequestForParentMethodAsync<CloudServiceList>(subscriptionId, cancellationToken)));
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(72)]
        public virtual Task CreateCluster(string subscriptionId, string cloudServiceName, string resourceNamespace, string dnsName, RDFEResource cluster, CancellationToken cancellationToken)
        {
            return ((Task)(base.CreateAndInvokeRestRequestForParentMethodAsync(subscriptionId, cloudServiceName, resourceNamespace, dnsName, cluster, cancellationToken)));
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(72)]
        public virtual Task DeleteCluster(string subscriptionId, string cloudServiceName, string resourceNamespace, string dnsName, CancellationToken cancellationToken)
        {
            return ((Task)(base.CreateAndInvokeRestRequestForParentMethodAsync(subscriptionId, cloudServiceName, resourceNamespace, dnsName, cancellationToken)));
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(72)]
        public Task<PassthroughResponse> ChangeClusterSize(string subscriptionId, string cloudServiceName, string resourceNamespace, string dnsName, string roleAction, ClusterRoleCollection clusterRoleCollection, CancellationToken cancellationToken)
        {
            return
                ((Task<PassthroughResponse>)
                 (base.CreateAndInvokeRestRequestForParentMethodAsync<PassthroughResponse>(subscriptionId, cloudServiceName, resourceNamespace, dnsName, roleAction, clusterRoleCollection, cancellationToken)));
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(72)]
        public virtual Task<PassthroughResponse> GetCluster(string subscriptionId, string cloudServiceName, string resourceNamespace, string dnsName, CancellationToken token)
        {
            return ((Task<PassthroughResponse>)(base.CreateAndInvokeRestRequestForParentMethodAsync<PassthroughResponse>(subscriptionId, cloudServiceName, resourceNamespace, dnsName, token)));
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(72)]
        public virtual Task<PassthroughResponse> UpdateComponent(string subscriptionId, string cloudServiceName, string resourceNamespace, string dnsName, string componentName, ClusterComponent request, CancellationToken cancellationToken)
        {
            return ((Task<PassthroughResponse>)(base.CreateAndInvokeRestRequestForParentMethodAsync<PassthroughResponse>(subscriptionId, cloudServiceName, resourceNamespace, dnsName, componentName, request, cancellationToken)));
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(72)]
        public virtual Task<PassthroughResponse> CheckOperation(string subscriptionId, string cloudServiceName, string resourceNamespace, string dnsName, string operationId, CancellationToken cancellationToken)
        {
            return ((Task<PassthroughResponse>)(base.CreateAndInvokeRestRequestForParentMethodAsync<PassthroughResponse>(subscriptionId, cloudServiceName, resourceNamespace, dnsName, operationId, cancellationToken)));
        }

        public Task<PassthroughResponse> EnableDisableRdp(string subscriptionId, string cloudServiceName, string resourceNamespace, string clusterDnsName,
            string actionType, ClusterRoleCollection roleCollection, CancellationToken cancellationToken)
        {
            return ((Task<PassthroughResponse>)(base.CreateAndInvokeRestRequestForParentMethodAsync<PassthroughResponse>(subscriptionId, cloudServiceName, resourceNamespace, clusterDnsName, actionType, roleCollection)));
        }
    }
}

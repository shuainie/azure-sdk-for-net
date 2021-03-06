// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.Automation
{
    public partial interface IAutomationManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Definition of cloud service for the automation extension.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        ICloudServiceOperations CloudServices
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation jobs.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IJobOperations Jobs
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation stream items.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IJobStreamOperation JobStreams
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation runbooks.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IRunbookOperations Runbooks
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation runbook parameters.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IRunbookParameterOperations RunbookParameters
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation runbook versions.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IRunbookVersionOperations RunbookVersions
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation schedules.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
        /// more information)
        /// </summary>
        IScheduleOperations Schedules
        {
            get; 
        }
    }
}

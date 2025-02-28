// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Maintenance;
using Azure.ResourceManager.Maintenance.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Maintenance.Samples
{
    public partial class Sample_ResourceGroupResourceExtensions
    {
        // ConfigurationAssignments_CreateOrUpdateParent
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdateConfigurationAssignmentByParent_ConfigurationAssignmentsCreateOrUpdateParent()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/stable/2021-05-01/examples/ConfigurationAssignments_CreateOrUpdateParent.json
            // this example is just showing the usage of "ConfigurationAssignments_CreateOrUpdateParent" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            string providerName = "Microsoft.Compute";
            string resourceParentType = "virtualMachineScaleSets";
            string resourceParentName = "smdtest1";
            string resourceType = "virtualMachines";
            string resourceName = "smdvm1";
            string configurationAssignmentName = "workervmPolicy";
            MaintenanceConfigurationAssignmentData data = new MaintenanceConfigurationAssignmentData()
            {
                MaintenanceConfigurationId = new ResourceIdentifier("/subscriptions/5b4b650e-28b9-4790-b3ab-ddbd88d727c4/resourcegroups/examplerg/providers/Microsoft.Maintenance/maintenanceConfigurations/policy1"),
            };
            MaintenanceConfigurationAssignmentData result = await resourceGroupResource.CreateOrUpdateConfigurationAssignmentByParentAsync(providerName, resourceParentType, resourceParentName, resourceType, resourceName, configurationAssignmentName, data);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConfigurationAssignments_DeleteParent
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DeleteConfigurationAssignmentByParent_ConfigurationAssignmentsDeleteParent()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/stable/2021-05-01/examples/ConfigurationAssignments_DeleteParent.json
            // this example is just showing the usage of "ConfigurationAssignments_DeleteParent" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            string providerName = "Microsoft.Compute";
            string resourceParentType = "virtualMachineScaleSets";
            string resourceParentName = "smdtest1";
            string resourceType = "virtualMachines";
            string resourceName = "smdvm1";
            string configurationAssignmentName = "workervmConfiguration";
            MaintenanceConfigurationAssignmentData result = await resourceGroupResource.DeleteConfigurationAssignmentByParentAsync(providerName, resourceParentType, resourceParentName, resourceType, resourceName, configurationAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConfigurationAssignments_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdateConfigurationAssignment_ConfigurationAssignmentsCreateOrUpdate()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/stable/2021-05-01/examples/ConfigurationAssignments_CreateOrUpdate.json
            // this example is just showing the usage of "ConfigurationAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            string providerName = "Microsoft.Compute";
            string resourceType = "virtualMachineScaleSets";
            string resourceName = "smdtest1";
            string configurationAssignmentName = "workervmConfiguration";
            MaintenanceConfigurationAssignmentData data = new MaintenanceConfigurationAssignmentData()
            {
                MaintenanceConfigurationId = new ResourceIdentifier("/subscriptions/5b4b650e-28b9-4790-b3ab-ddbd88d727c4/resourcegroups/examplerg/providers/Microsoft.Maintenance/maintenanceConfigurations/configuration1"),
            };
            MaintenanceConfigurationAssignmentData result = await resourceGroupResource.CreateOrUpdateConfigurationAssignmentAsync(providerName, resourceType, resourceName, configurationAssignmentName, data);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConfigurationAssignments_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DeleteConfigurationAssignment_ConfigurationAssignmentsDelete()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/stable/2021-05-01/examples/ConfigurationAssignments_Delete.json
            // this example is just showing the usage of "ConfigurationAssignments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            string providerName = "Microsoft.Compute";
            string resourceType = "virtualMachineScaleSets";
            string resourceName = "smdtest1";
            string configurationAssignmentName = "workervmConfiguration";
            MaintenanceConfigurationAssignmentData result = await resourceGroupResource.DeleteConfigurationAssignmentAsync(providerName, resourceType, resourceName, configurationAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConfigurationAssignments_ListParent
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetConfigurationAssignmentsByParent_ConfigurationAssignmentsListParent()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/stable/2021-05-01/examples/ConfigurationAssignments_ListParent.json
            // this example is just showing the usage of "ConfigurationAssignments_ListParent" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            string providerName = "Microsoft.Compute";
            string resourceParentType = "virtualMachineScaleSets";
            string resourceParentName = "smdtest1";
            string resourceType = "virtualMachines";
            string resourceName = "smdtestvm1";
            await foreach (MaintenanceConfigurationAssignmentData item in resourceGroupResource.GetConfigurationAssignmentsByParentAsync(providerName, resourceParentType, resourceParentName, resourceType, resourceName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ConfigurationAssignments_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetConfigurationAssignments_ConfigurationAssignmentsList()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/stable/2021-05-01/examples/ConfigurationAssignments_List.json
            // this example is just showing the usage of "ConfigurationAssignments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            string providerName = "Microsoft.Compute";
            string resourceType = "virtualMachineScaleSets";
            string resourceName = "smdtest1";
            await foreach (MaintenanceConfigurationAssignmentData item in resourceGroupResource.GetConfigurationAssignmentsAsync(providerName, resourceType, resourceName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApplyUpdatesResourceGroup_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetMaintenanceApplyUpdates_ApplyUpdatesResourceGroupList()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/stable/2021-05-01/examples/ApplyUpdatesResourceGroup_List.json
            // this example is just showing the usage of "ApplyUpdateForResourceGroup_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            await foreach (MaintenanceApplyUpdateResource item in resourceGroupResource.GetMaintenanceApplyUpdatesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MaintenanceApplyUpdateData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Updates_ListParent
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUpdatesByParent_UpdatesListParent()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/stable/2021-05-01/examples/Updates_ListParent.json
            // this example is just showing the usage of "Updates_ListParent" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            string providerName = "Microsoft.Compute";
            string resourceParentType = "virtualMachineScaleSets";
            string resourceParentName = "smdtest1";
            string resourceType = "virtualMachines";
            string resourceName = "1";
            await foreach (MaintenanceUpdate item in resourceGroupResource.GetUpdatesByParentAsync(providerName, resourceParentType, resourceParentName, resourceType, resourceName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Updates_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUpdates_UpdatesList()
        {
            // Generated from example definition: specification/maintenance/resource-manager/Microsoft.Maintenance/stable/2021-05-01/examples/Updates_List.json
            // this example is just showing the usage of "Updates_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            string providerName = "Microsoft.Compute";
            string resourceType = "virtualMachineScaleSets";
            string resourceName = "smdtest1";
            await foreach (MaintenanceUpdate item in resourceGroupResource.GetUpdatesAsync(providerName, resourceType, resourceName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

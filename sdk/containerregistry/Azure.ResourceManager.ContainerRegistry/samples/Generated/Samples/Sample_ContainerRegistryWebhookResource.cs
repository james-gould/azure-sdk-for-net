// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerRegistry.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_ContainerRegistryWebhookResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_WebhookGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/WebhookGet.json
            // this example is just showing the usage of "Webhooks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryWebhookResource created on azure
            // for more information of creating ContainerRegistryWebhookResource, please refer to the document of ContainerRegistryWebhookResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string webhookName = "myWebhook";
            ResourceIdentifier containerRegistryWebhookResourceId = ContainerRegistryWebhookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, webhookName);
            ContainerRegistryWebhookResource containerRegistryWebhook = client.GetContainerRegistryWebhookResource(containerRegistryWebhookResourceId);

            // invoke the operation
            ContainerRegistryWebhookResource result = await containerRegistryWebhook.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryWebhookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_WebhookDelete()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/WebhookDelete.json
            // this example is just showing the usage of "Webhooks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryWebhookResource created on azure
            // for more information of creating ContainerRegistryWebhookResource, please refer to the document of ContainerRegistryWebhookResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string webhookName = "myWebhook";
            ResourceIdentifier containerRegistryWebhookResourceId = ContainerRegistryWebhookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, webhookName);
            ContainerRegistryWebhookResource containerRegistryWebhook = client.GetContainerRegistryWebhookResource(containerRegistryWebhookResourceId);

            // invoke the operation
            await containerRegistryWebhook.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_WebhookUpdate()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/WebhookUpdate.json
            // this example is just showing the usage of "Webhooks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryWebhookResource created on azure
            // for more information of creating ContainerRegistryWebhookResource, please refer to the document of ContainerRegistryWebhookResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string webhookName = "myWebhook";
            ResourceIdentifier containerRegistryWebhookResourceId = ContainerRegistryWebhookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, webhookName);
            ContainerRegistryWebhookResource containerRegistryWebhook = client.GetContainerRegistryWebhookResource(containerRegistryWebhookResourceId);

            // invoke the operation
            ContainerRegistryWebhookPatch patch = new ContainerRegistryWebhookPatch
            {
                Tags =
{
["key"] = "value"
},
                ServiceUri = new Uri("http://myservice.com"),
                CustomHeaders =
{
["Authorization"] = "******"
},
                Status = ContainerRegistryWebhookStatus.Enabled,
                Scope = "myRepository",
                Actions = { ContainerRegistryWebhookAction.Push },
            };
            ArmOperation<ContainerRegistryWebhookResource> lro = await containerRegistryWebhook.UpdateAsync(WaitUntil.Completed, patch);
            ContainerRegistryWebhookResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryWebhookData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Ping_WebhookPing()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/WebhookPing.json
            // this example is just showing the usage of "Webhooks_Ping" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryWebhookResource created on azure
            // for more information of creating ContainerRegistryWebhookResource, please refer to the document of ContainerRegistryWebhookResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string webhookName = "myWebhook";
            ResourceIdentifier containerRegistryWebhookResourceId = ContainerRegistryWebhookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, webhookName);
            ContainerRegistryWebhookResource containerRegistryWebhook = client.GetContainerRegistryWebhookResource(containerRegistryWebhookResourceId);

            // invoke the operation
            ContainerRegistryWebhookEventInfo result = await containerRegistryWebhook.PingAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEvents_WebhookListEvents()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/WebhookListEvents.json
            // this example is just showing the usage of "Webhooks_ListEvents" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryWebhookResource created on azure
            // for more information of creating ContainerRegistryWebhookResource, please refer to the document of ContainerRegistryWebhookResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string webhookName = "myWebhook";
            ResourceIdentifier containerRegistryWebhookResourceId = ContainerRegistryWebhookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, webhookName);
            ContainerRegistryWebhookResource containerRegistryWebhook = client.GetContainerRegistryWebhookResource(containerRegistryWebhookResourceId);

            // invoke the operation and iterate over the result
            await foreach (ContainerRegistryWebhookEvent item in containerRegistryWebhook.GetEventsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCallbackConfig_WebhookGetCallbackConfig()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2025-03-01-preview/examples/WebhookGetCallbackConfig.json
            // this example is just showing the usage of "Webhooks_GetCallbackConfig" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryWebhookResource created on azure
            // for more information of creating ContainerRegistryWebhookResource, please refer to the document of ContainerRegistryWebhookResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string webhookName = "myWebhook";
            ResourceIdentifier containerRegistryWebhookResourceId = ContainerRegistryWebhookResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, webhookName);
            ContainerRegistryWebhookResource containerRegistryWebhook = client.GetContainerRegistryWebhookResource(containerRegistryWebhookResourceId);

            // invoke the operation
            ContainerRegistryWebhookCallbackConfig result = await containerRegistryWebhook.GetCallbackConfigAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

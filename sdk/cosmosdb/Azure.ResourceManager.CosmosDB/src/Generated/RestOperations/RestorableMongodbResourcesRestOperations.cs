// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    internal partial class RestorableMongodbResourcesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RestorableMongodbResourcesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RestorableMongodbResourcesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-12-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, AzureLocation location, Guid instanceId, AzureLocation? restoreLocation, string restoreTimestampInUtc)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.DocumentDB/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/restorableDatabaseAccounts/", false);
            uri.AppendPath(instanceId, true);
            uri.AppendPath("/restorableMongodbResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (restoreLocation != null)
            {
                uri.AppendQuery("restoreLocation", restoreLocation.Value, true);
            }
            if (restoreTimestampInUtc != null)
            {
                uri.AppendQuery("restoreTimestampInUtc", restoreTimestampInUtc, true);
            }
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, AzureLocation location, Guid instanceId, AzureLocation? restoreLocation, string restoreTimestampInUtc)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.DocumentDB/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/restorableDatabaseAccounts/", false);
            uri.AppendPath(instanceId, true);
            uri.AppendPath("/restorableMongodbResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (restoreLocation != null)
            {
                uri.AppendQuery("restoreLocation", restoreLocation.Value, true);
            }
            if (restoreTimestampInUtc != null)
            {
                uri.AppendQuery("restoreTimestampInUtc", restoreTimestampInUtc, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Return a list of database and collection combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read' permission. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RestorableMongoDBResourcesListResult>> ListAsync(string subscriptionId, AzureLocation location, Guid instanceId, AzureLocation? restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListRequest(subscriptionId, location, instanceId, restoreLocation, restoreTimestampInUtc);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestorableMongoDBResourcesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = RestorableMongoDBResourcesListResult.DeserializeRestorableMongoDBResourcesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Return a list of database and collection combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read' permission. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RestorableMongoDBResourcesListResult> List(string subscriptionId, AzureLocation location, Guid instanceId, AzureLocation? restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListRequest(subscriptionId, location, instanceId, restoreLocation, restoreTimestampInUtc);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestorableMongoDBResourcesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = RestorableMongoDBResourcesListResult.DeserializeRestorableMongoDBResourcesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

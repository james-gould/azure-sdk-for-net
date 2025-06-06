// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Developer.LoadTesting
{
    /// <summary> Test run server metrics configuration. </summary>
    public partial class TestRunServerMetricsConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TestRunServerMetricsConfiguration"/>. </summary>
        public TestRunServerMetricsConfiguration()
        {
            Metrics = new ChangeTrackingDictionary<string, ResourceMetric>();
        }

        /// <summary> Initializes a new instance of <see cref="TestRunServerMetricsConfiguration"/>. </summary>
        /// <param name="testRunId"> Test run identifier. </param>
        /// <param name="metrics">
        /// Azure resource metrics collection {metric id : metrics object} (Refer :
        /// https://learn.microsoft.com/en-us/rest/api/monitor/metric-definitions/list#metricdefinition
        /// for metric id).
        /// </param>
        /// <param name="createdDateTime"> The creation datetime(RFC 3339 literal format). </param>
        /// <param name="createdBy"> The user that created. </param>
        /// <param name="lastModifiedDateTime"> The last Modified datetime(RFC 3339 literal format). </param>
        /// <param name="lastModifiedBy"> The user that last modified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TestRunServerMetricsConfiguration(string testRunId, IDictionary<string, ResourceMetric> metrics, DateTimeOffset? createdDateTime, string createdBy, DateTimeOffset? lastModifiedDateTime, string lastModifiedBy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TestRunId = testRunId;
            Metrics = metrics;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
            LastModifiedDateTime = lastModifiedDateTime;
            LastModifiedBy = lastModifiedBy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Test run identifier. </summary>
        public string TestRunId { get; }
        /// <summary>
        /// Azure resource metrics collection {metric id : metrics object} (Refer :
        /// https://learn.microsoft.com/en-us/rest/api/monitor/metric-definitions/list#metricdefinition
        /// for metric id).
        /// </summary>
        public IDictionary<string, ResourceMetric> Metrics { get; }
        /// <summary> The creation datetime(RFC 3339 literal format). </summary>
        public DateTimeOffset? CreatedDateTime { get; }
        /// <summary> The user that created. </summary>
        public string CreatedBy { get; }
        /// <summary> The last Modified datetime(RFC 3339 literal format). </summary>
        public DateTimeOffset? LastModifiedDateTime { get; }
        /// <summary> The user that last modified. </summary>
        public string LastModifiedBy { get; }
    }
}

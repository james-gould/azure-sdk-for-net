// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Azure Active Directory app registration. </summary>
    public partial class AppServiceAadRegistration
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

        /// <summary> Initializes a new instance of <see cref="AppServiceAadRegistration"/>. </summary>
        public AppServiceAadRegistration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceAadRegistration"/>. </summary>
        /// <param name="openIdIssuer">
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </param>
        /// <param name="clientId">
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </param>
        /// <param name="clientSecretSettingName"> The app setting name that contains the client secret of the relying party application. </param>
        /// <param name="clientSecretCertificateThumbprintString">
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </param>
        /// <param name="clientSecretCertificateSubjectAlternativeName">
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </param>
        /// <param name="clientSecretCertificateIssuer">
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceAadRegistration(string openIdIssuer, string clientId, string clientSecretSettingName, string clientSecretCertificateThumbprintString, string clientSecretCertificateSubjectAlternativeName, string clientSecretCertificateIssuer, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OpenIdIssuer = openIdIssuer;
            ClientId = clientId;
            ClientSecretSettingName = clientSecretSettingName;
            ClientSecretCertificateThumbprintString = clientSecretCertificateThumbprintString;
            ClientSecretCertificateSubjectAlternativeName = clientSecretCertificateSubjectAlternativeName;
            ClientSecretCertificateIssuer = clientSecretCertificateIssuer;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        [WirePath("openIdIssuer")]
        public string OpenIdIssuer { get; set; }
        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [WirePath("clientId")]
        public string ClientId { get; set; }
        /// <summary> The app setting name that contains the client secret of the relying party application. </summary>
        [WirePath("clientSecretSettingName")]
        public string ClientSecretSettingName { get; set; }
        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        [WirePath("clientSecretCertificateThumbprint")]
        public string ClientSecretCertificateThumbprintString { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        [WirePath("clientSecretCertificateSubjectAlternativeName")]
        public string ClientSecretCertificateSubjectAlternativeName { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        [WirePath("clientSecretCertificateIssuer")]
        public string ClientSecretCertificateIssuer { get; set; }
    }
}

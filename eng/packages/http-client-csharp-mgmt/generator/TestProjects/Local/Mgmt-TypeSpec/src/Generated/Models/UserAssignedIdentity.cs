// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace MgmtTypeSpec.Models
{
    /// <summary> User assigned identity properties. </summary>
    public partial class UserAssignedIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal UserAssignedIdentity()
        {
        }

        internal UserAssignedIdentity(Guid? clientId, Guid? principalId, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            ClientId = clientId;
            PrincipalId = principalId;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The client ID of the assigned identity. </summary>
        public Guid? ClientId { get; }

        /// <summary> The principal ID of the assigned identity. </summary>
        public Guid? PrincipalId { get; }
    }
}

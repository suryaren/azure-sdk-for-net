// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> List of quotas. </summary>
    public partial class QuantumJobQuotaList
    {
        /// <summary> Quota object. </summary>
        [CodeGenMember("Value")]
        public IReadOnlyList<QuantumJobQuota> Values { get; }
    }
}
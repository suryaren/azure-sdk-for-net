// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> Credentials to present during authentication. </summary>
    public partial class MediaGraphCredentials
    {
        /// <summary> Initializes a new instance of MediaGraphCredentials. </summary>
        public MediaGraphCredentials()
        {
        }

        /// <summary> Initializes a new instance of MediaGraphCredentials. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        internal MediaGraphCredentials(string type)
        {
            Type = type;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string Type { get; set; }
    }
}
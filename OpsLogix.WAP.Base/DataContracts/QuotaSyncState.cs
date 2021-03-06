﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

using System.Runtime.Serialization;

namespace OpsLogix.WAP.Base.DataContracts
{
    /// <summary>
    /// Represent a quota sync state.
    /// </summary>
    [DataContract(Namespace = "http://schemas.microsoft.com/windowsazure")]
    public enum QuotaSyncState
    {
        /// <summary>
        /// The in sync
        /// </summary>
        [EnumMember]
        InSync = 0,

        /// <summary>
        /// The syncing
        /// </summary>
        [EnumMember]
        Syncing,

        /// <summary>
        /// The out of sync
        /// </summary>
        [EnumMember]
        OutOfSync,
    }
}

﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpsLogix.WAP.Base.DataContracts
{
    /// <summary>
    /// Represents a service quota setting list.
    /// </summary>
    [CollectionDataContract(Namespace = "http://schemas.microsoft.com/windowsazure", Name = "ServiceQuotaSettings", ItemName = "ServiceQuotaSetting")]
    public class ServiceQuotaSettingList : List<ServiceQuotaSetting>
    {
    }
}

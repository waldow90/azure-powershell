﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets
{
    internal static class ParamHelpMsg
    {
        internal static class Container
        {
            internal static class Get
            {
                public const string Name = "The name of the resource being managed by the Azure Backup service (for example: resource name of the VM).";
                public const string ResourceGroupName = "The ResourceGroup of the resource being managed by the Azure Backup service (for example: ResourceGroup name of the VM).";
                public const string Status = "The registration status of the Azure Backup container.";
                public const string ContainerType = "The type of the Azure Backup container. This can be a Windows Server, an Azure IaaS VM, or a Data Protection Manager server.";
            }
        }

        internal static class Common
        {
            public const string Vault = "The Azure Backup vault object which is the parent resource.";
        }
    }
}

﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace MLS.Agent.Telemetry.Configurer
{
    public sealed class NopFirstTimeUseNoticeSentinel : IFirstTimeUseNoticeSentinel
    {
        public void CreateIfNotExists()
        {
        }

        public bool Exists()
        {
            return true;
        }
    }
}

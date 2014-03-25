﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Collections;

namespace Microsoft.Data.Entity.Query
{
    public interface IAsyncEnumerable : IEnumerable
    {
        IAsyncEnumerator GetAsyncEnumerator();
    }
}

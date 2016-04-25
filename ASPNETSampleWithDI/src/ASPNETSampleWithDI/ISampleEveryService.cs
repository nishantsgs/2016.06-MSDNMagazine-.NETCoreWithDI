// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace AspNetSampleWithDI
{
    interface ISampleEveryService :
            ISampleService,
            ISampleMultipleService,
            ISampleScopedService,
            ISampleServiceInstance,
            ISampleSingletonService,
            ISampleOpenGenericService<string>
    {
    }
}

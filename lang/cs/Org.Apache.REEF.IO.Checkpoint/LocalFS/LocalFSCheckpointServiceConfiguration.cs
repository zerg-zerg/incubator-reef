﻿// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using Org.Apache.REEF.Tang.Formats;
using Org.Apache.REEF.Tang.Util;
using Org.Apache.REEF.Utilities.Attributes;

namespace Org.Apache.REEF.IO.Checkpoint.LocalFS
{
    [DriverSide]
    public class LocalFSCheckpointServiceConfiguration : ConfigurationModuleBuilder
    {
        // Path to be used to store the checkpoints on file system.
        public static readonly RequiredParameter<string> Path = new RequiredParameter<string>();

        public static readonly ConfigurationModule Conf  = 
            new LocalFSCheckpointServiceConfiguration()
            .BindImplementation(GenericType<ICheckpointService>.Class, GenericType<LocalFSCheckpointService>.Class)
            .BindImplementation(GenericType<ICheckpointNamingService>.Class, GenericType<SimpleNamingService>.Class)
            .BindImplementation(GenericType<ICheckpointID>.Class, GenericType<LocalFSCheckpointID>.Class)
            .BindNamedParameter(GenericType<LocalFSCheckpointService.CheckpointPath>.Class, Path)
            .Build();
    }
}
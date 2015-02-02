﻿/**
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using Org.Apache.Reef.Services;
using Org.Apache.Reef.Tang.Annotations;
using System;
using System.Collections.Generic;

namespace Org.Apache.Reef.Tasks
{
    public class HelloService : IService
    {
        private IList<string> _guests;

        [Inject]
        public HelloService()
        {
            if (_guests == null)
            {
                _guests = new List<string>();
                _guests.Add("MR.SMITH");
            }
        }

        public IList<string> Guests
        {
            get
            {
                return _guests;
            }
        }

        public void AddGuest(string guestName)
        {
            if (string.IsNullOrWhiteSpace(guestName))
            {
                throw new ArgumentException("can't do with empty name.");
            }
            Guests.Add(guestName);
        }
    }
}
﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.DotNet.Interactive.Commands;

namespace Microsoft.DotNet.Interactive.Events
{
    public class ValueNamesProduced : KernelEvent
    {
        public IReadOnlyCollection<ValueDescriptor> ValueDescriptors { get; }

        public ValueNamesProduced(IReadOnlyCollection<ValueDescriptor> valueDescriptors, RequestValueNames command) : base(command)
        {
            ValueDescriptors = valueDescriptors;
        }
    }

    public class ValueDescriptor
    {
        public ValueDescriptor(string name, Type clrValueType = null)
        {
            Name = name;
            ClrValueType = clrValueType;
        }

        public string Name { get; }

        [JsonIgnore]
        public Type ClrValueType { get; }
    }
}
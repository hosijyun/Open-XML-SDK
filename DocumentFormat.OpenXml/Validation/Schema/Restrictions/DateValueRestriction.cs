﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    /// <summary>
    /// DateTime (xsd:date) based value restriction.
    /// </summary>
    [DataContract]
    internal class DateValueRestriction : SimpleValueRestriction<DateTime, DateTimeValue>
    {
        protected override DateTime MinValue => DateTime.MinValue;

        protected override DateTime MaxValue => DateTime.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Date;

        // TODO: validate date.
    }
}

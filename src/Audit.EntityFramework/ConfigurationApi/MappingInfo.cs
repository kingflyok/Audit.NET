﻿using Audit.Core;
using System;

namespace Audit.EntityFramework.ConfigurationApi
{
    internal class MappingInfo
    {
        /// <summary>
        /// The Target (Audit) type 
        /// </summary>
        public Type TargetType { get; set; }
        /// <summary>
        /// The Action to execute for this mapping.
        /// </summary>
        public Func<AuditEvent, EventEntry, object, bool> Action { get; set; }
    }

}

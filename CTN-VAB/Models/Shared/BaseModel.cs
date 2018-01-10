using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTN_VAB.Models.Shared
{
    /// <summary>
    /// Base model for most database objects that contains common metadata such as a timestamp
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// The date/time the object was created
        /// </summary>
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The date/time the object was last updated
        /// </summary>
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Determines if the object is deleted or not
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}
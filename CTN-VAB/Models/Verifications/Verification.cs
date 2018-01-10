using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTN_VAB.Models.Verifications
{
    /// <summary>
    /// Base class for verification objects
    /// </summary>
    public abstract class Verification
    {
        /// <summary>
        /// The Id of the verification
        /// </summary>
        public Guid Id { get; set; } = new Guid();

        /// <summary>
        /// The date/time the verification was validated
        /// </summary>
        public DateTime? ValidatedOn;

        /// <summary>
        /// The human readable label for this verfication type which will appear in the validation message
        /// </summary>
        protected abstract string Label { get; set; }

        /// <summary>
        /// The message to validate against
        /// </summary>
        public string Message
        {
            get
            {
                return string.Format("CTN-{0}-{1}", Label, Convert.ToBase64String(Id.ToByteArray()));
            }
        }

        /// <summary>
        /// The date/time that this verification expires
        /// </summary>
        public DateTime Expiry { get; set; }

        /// <summary>
        /// Validate a verification by passing the signed hash of the message, this will update the ValidatedOn property if the validation succeeds.
        /// </summary>
        /// <param name="signature">the signed message</param>
        /// <returns>True if the validation succeeded, false if not</returns>
        public abstract bool Validate(string signature);
    }
}
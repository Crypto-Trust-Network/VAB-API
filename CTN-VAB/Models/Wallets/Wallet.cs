using CTN_VAB.Models.Shared;
using CTN_VAB.Models.Verifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTN_VAB.Models.Wallets
{
    /// <summary>
    /// A registered wallet
    /// </summary>
    public class Wallet : BaseModel
    {
        /// <summary>
        /// Cryptocurrency wallet type, ie. Bitcoin, Ethereum.
        /// </summary>
        public enum Types
        {
            Bitcoin
        }

        /// <summary>
        /// The internal wallet ID
        /// </summary>
        public Guid Id { get; set; } = new Guid();

        /// <summary>
        /// The type of this cryptocurrency wallet
        /// </summary>
        public Types Type { get; set; }

        /// <summary>
        /// The wallet's address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The most recent verification for this wallet
        /// </summary>
        public Verification CurrentVerification { get; set; }

        /// <summary>
        /// The verification which is validated if the owner reports the wallet as compromised
        /// </summary>
        public Verification PendingVerification { get; set; }

    }
}
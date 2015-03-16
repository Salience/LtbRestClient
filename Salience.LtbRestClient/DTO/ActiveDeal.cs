using System;

namespace Salience.LtbRestClient
{
    public class ActiveDeal
    {
        /// <summary>
        /// Deal key
        /// </summary>
        public string KeyDeal { get; set; }

        /// <summary>
        /// Associated offer key
        /// </summary>
        public string KeyOffer { get; set; }

        /// <summary>
        /// User owner key
        /// </summary>
        public string KeyUser { get; set; }

        /// <summary>
        /// Deal status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Deal title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Deal description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Start date of the deal
        /// </summary>
        public DateTime? DateStart { get; set; }

        /// <summary>
        /// Renewal date of the deal, if renewal is programmed
        /// </summary>
        public DateTime? DateRenewal { get; set; }

        /// <summary>
        /// Previous renewal date of the deal, if any
        /// </summary>
        public DateTime? DateRenewalPrevious { get; set; }

        /// <summary>
        /// End date of the deal, if finite
        /// </summary>
        public DateTime? DateEnd { get; set; }

        /// <summary>
        /// Current stage of the deal
        /// </summary>
        public ActiveStage StageCurrent { get; set; }
    }
}

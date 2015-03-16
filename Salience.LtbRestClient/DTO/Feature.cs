using System;

namespace Salience.LtbRestClient
{
    public class Feature
    {
        /// <summary>
        /// Feature key
        /// </summary>
        public string KeyFeature { get; set; }

        /// <summary>
        /// Feature visibility
        /// </summary>
        public bool IsVisible { get; set; }

        /// <summary>
        /// Feature localized title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Feature localized description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Limitation for this feature
        /// </summary>
        public int? Limitation { get; set; }

        /// <summary>
        /// Start date of the working period
        /// </summary>
        public DateTime? DatePeriodStart { get; set; }

        /// <summary>
        /// End date of the working period
        /// </summary>
        public DateTime? DatePeriodEnd { get; set; }

        /// <summary>
        /// Url for the 'choose an offer' page
        /// </summary>
        public string UrlChooseOffer { get; set; }
    }
}

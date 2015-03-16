using System;

namespace Salience.LtbRestClient
{
    public class Offer
    {
        /// <summary>
        /// Offer key
        /// </summary>
        public string KeyOffer { get; set; }

        /// <summary>
        /// Offer localized title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Offer localized description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Offer currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Url for the 'choose payment' page
        /// </summary>
        public string UrlChoosePayment { get; set; }

        /// <summary>
        /// Stages in this offer
        /// </summary>
        public Stage[] Stages { get; set; }
    }
}

using System;

namespace Salience.LtbRestClient
{
    public class User
    {
        /// <summary>
        /// User key
        /// </summary>
        public string KeyUser { get; set; }

        /// <summary>
        /// User language
        /// </summary>
        public int? Lcid { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        public string NameUser { get; set; }

        /// <summary>
        /// Limitation for this user (if the associated request needs it)
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

        /// <summary>
        /// Url for the 'deals' page
        /// </summary>
        public string UrlDeals { get; set; }

        /// <summary>
        /// Url for the 'invoices' page
        /// </summary>
        public string UrlInvoices { get; set; }
    }
}

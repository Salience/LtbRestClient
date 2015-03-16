using System;

namespace Salience.LtbRestClient
{
    public class Stage
    {
        /// <summary>
        /// Duration of this stage
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Localized unit of duration of this stage
        /// </summary>
        public string UnitDuration { get; set; }

        /// <summary>
        /// Standard unit of duration of this stage (Month, Year, etc.)
        /// </summary>
        public string TypeUnitDuration { get; set; }

        /// <summary>
        /// Number of recurrence of this stage, null for infinite
        /// </summary>
        public int? CountRecurrences { get; set; }

        /// <summary>
        /// Price for this stage
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Features in this stage
        /// </summary>
        public Feature[] Features { get; set; }
    }
}

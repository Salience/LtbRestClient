using System;

namespace Salience.LtbRestClient
{
    public class ActiveStage
    {
        /// <summary>
        /// Duration of this stage
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Standard unit of duration of this stage (Month, Year, etc.)
        /// </summary>
        public string UnitDuration { get; set; }

        /// <summary>
        /// Features in this stage
        /// </summary>
        public Feature[] Features { get; set; }
    }
}

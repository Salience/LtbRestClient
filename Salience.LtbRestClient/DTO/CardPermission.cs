using System;

namespace Salience.LtbRestClient
{
    public class CardPermission
    {
        public string KeyUser { get; set; }
        public DateTime DateExpiration { get; set; }
        public string Indication { get; set; }
        public string TypePermission { get; set; }
    }
}
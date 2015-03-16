using System;

namespace Salience.LtbRestClient
{
    public class WebhookCallback
    {
        public string IdNotification { get; set; }
        public string TokenVerify { get; set; }
        public DateTime DateNotification { get; set; }
        public string TypeNotification { get; set; }
        public string Signature { get; set; }
        public ActiveDeal Deal { get; set; }
    }
}
namespace Salience.LtbRestClient
{
    public partial class LtbClient : ILtbClient
    {
        public User[] GetUsers()
        {
            return GetUsersRequest().Execute();
        }

        public User GetUser(string keyUser)
        {
            return GetUserRequest(keyUser).Execute();
        }

        public User DeclareUser(string keyUser, string nameUser, int lcid)
        {
            return DeclareUserRequest(keyUser, nameUser, lcid).Execute();
        }

        public Feature[] DeclareUserWithTrial(string keyOffer, string keyUser, string nameUser, int lcid, bool forced)
        {
            return DeclareUserWithTrialRequest(keyOffer, keyUser, nameUser, lcid, forced).Execute();
        }

        public User[] GetUsersByFeature(string keyFeature)
        {
            return GetUsersByFeatureRequest(keyFeature).Execute();
        }

        public Feature[] GetFeatures(int lcid)
        {
            return GetFeaturesRequest(lcid).Execute();
        }

        public Feature[] GetFeaturesByUser(string keyUser)
        {
            return GetFeaturesByUserRequest(keyUser).Execute();
        }

        public Feature GetLimitation(string keyFeature, string keyUser)
        {
            return GetLimitationRequest(keyFeature, keyUser).Execute();
        }

        public Offer[] GetOffers(int lcid, bool? visible)
        {
            return GetOffersRequest(lcid, visible).Execute();
        }

        public Offer[] GetOffersByUser(string keyUser, bool? visible)
        {
            return GetOffersByUserRequest(keyUser, visible).Execute();
        }

        public Deal[] GetDealsByUser(string keyUser)
        {
            return GetDealsByUserRequest(keyUser).Execute();
        }
    }
}
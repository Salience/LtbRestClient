using System.Threading.Tasks;

namespace Salience.LtbRestClient
{
    public partial class LtbClient : IAsyncLtbClient
    {
        public Task<User[]> GetUsersAsync()
        {
            return GetUsersRequest().ExecuteAsync();
        }

        public Task<User> GetUserAsync(string keyUser)
        {
            return GetUserRequest(keyUser).ExecuteAsync();
        }

        public Task<User> DeclareUserAsync(string keyUser, string nameUser, int lcid)
        {
            return DeclareUserRequest(keyUser, nameUser, lcid).ExecuteAsync();
        }

        public Task<Feature[]> DeclareUserWithTrialAsync(string keyOffer, string keyUser, string nameUser, int lcid, bool forced)
        {
            return DeclareUserWithTrialRequest(keyOffer, keyUser, nameUser, lcid, forced).ExecuteAsync();
        }

        public Task<User[]> GetUsersByFeatureAsync(string keyFeature)
        {
            return GetUsersByFeatureRequest(keyFeature).ExecuteAsync();
        }

        public Task<Feature[]> GetFeaturesAsync(int lcid)
        {
            return GetFeaturesRequest(lcid).ExecuteAsync();
        }

        public Task<Feature[]> GetFeaturesByUserAsync(string keyUser)
        {
            return GetFeaturesByUserRequest(keyUser).ExecuteAsync();
        }

        public Task<Feature> GetLimitationAsync(string keyFeature, string keyUser)
        {
            return GetLimitationRequest(keyFeature, keyUser).ExecuteAsync();
        }

        public Task<Offer[]> GetOffersAsync(int lcid, bool? visible)
        {
            return GetOffersRequest(lcid, visible).ExecuteAsync();
        }

        public Task<Offer[]> GetOffersByUserAsync(string keyUser, bool? visible)
        {
            return GetOffersByUserRequest(keyUser, visible).ExecuteAsync();
        }

        public Task<Deal[]> GetDealsByUserAsync(string keyUser)
        {
            return GetDealsByUserRequest(keyUser).ExecuteAsync();
        }
    }
}
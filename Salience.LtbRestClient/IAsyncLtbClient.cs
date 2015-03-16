using System.Threading.Tasks;

namespace Salience.LtbRestClient
{
    public interface IAsyncLtbClient
    {
        /// <summary>
        /// Authenticate the client with LTB API credentials
        /// </summary>
        void Authenticate(string businessKey, string apiKey);

        /// <summary>
        /// Get all users
        /// </summary>
        Task<User[]> GetUsersAsync();

        /// <summary>
        /// Get a specific user
        /// </summary>
        Task<User> GetUserAsync(string keyUser);

        /// <summary>
        /// Declare a new user
        /// </summary>
        Task<User> DeclareUserAsync(string keyUser, string nameUser, int lcid = Constants.DefaultLcid);

        /// <summary>
        /// Declare a new user & enable a free trial
        /// </summary>
        /// <returns>Available features of the new user</returns>
        Task<Feature[]> DeclareUserWithTrialAsync(string keyOffer, string keyUser, string nameUser, int lcid = Constants.DefaultLcid, bool forced = false);

        /// <summary>
        /// Get users having access to given feature
        /// </summary>
        Task<User[]> GetUsersByFeatureAsync(string keyFeature);

        /// <summary>
        /// Get all features
        /// </summary>
        Task<Feature[]> GetFeaturesAsync(int lcid = Constants.DefaultLcid);

        /// <summary>
        /// Get features accessible to given user
        /// </summary>
        Task<Feature[]> GetFeaturesByUserAsync(string keyUser);

        /// <summary>
        /// Get a limitation for a feature and a user
        /// </summary>
        Task<Feature> GetLimitationAsync(string keyFeature, string keyUser);

        /// <summary>
        /// Get all offers
        /// </summary>
        /// <param name="lcid">The language in which offer titles and descriptions should be localized.</param>
        /// <param name="visible">If true, returns visible offers only. If false, returns hidden offers only. Leave null to get all offers.</param>
        Task<Offer[]> GetOffersAsync(int lcid = Constants.DefaultLcid, bool? visible = null);

        /// <summary>
        /// Get offers with user-specific urls for a given user
        /// </summary>
        /// <param name="keyUser">The user key.</param>
        /// <param name="visible">If true, returns visible offers only. If false, returns hidden offers only. Leave null to get all offers.</param>
        Task<Offer[]> GetOffersByUserAsync(string keyUser, bool? visible = null);

        /// <summary>
        /// Get deals subscribed by given user
        /// </summary>
        Task<Deal[]> GetDealsByUserAsync(string keyUser);
    }
}
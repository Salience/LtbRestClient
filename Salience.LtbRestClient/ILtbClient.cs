namespace Salience.LtbRestClient
{
    public interface ILtbClient
    {
        /// <summary>
        /// Authenticate the client with LTB API credentials
        /// </summary>
        void Authenticate(string businessKey, string apiKey);

        /// <summary>
        /// Get all users
        /// </summary>
        User[] GetUsers();

        /// <summary>
        /// Get a specific user
        /// </summary>
        User GetUser(string keyUser);

        /// <summary>
        /// Declare a new user
        /// </summary>
        User DeclareUser(string keyUser, string nameUser, int lcid = Constants.DefaultLcid);

        /// <summary>
        /// Declare a new user & enable a free trial
        /// </summary>
        /// <returns>Available features of the new user</returns>
        Feature[] DeclareUserWithTrial(string keyOffer, string keyUser, string nameUser, int lcid = Constants.DefaultLcid, bool forced = false);

        /// <summary>
        /// Get users having access to given feature
        /// </summary>
        User[] GetUsersByFeature(string keyFeature);

        /// <summary>
        /// Get all features
        /// </summary>
        Feature[] GetFeatures(int lcid = Constants.DefaultLcid);

        /// <summary>
        /// Get features accessible to given user
        /// </summary>
        Feature[] GetFeaturesByUser(string keyUser);

        /// <summary>
        /// Get a limitation for a feature and a user
        /// </summary>
        Feature GetLimitation(string keyFeature, string keyUser);

        /// <summary>
        /// Get all offers
        /// </summary>
        /// <param name="lcid">The language in which offer titles and descriptions should be localized.</param>
        /// <param name="visible">If true, returns visible offers only. If false, returns hidden offers only. Leave null to get all offers.</param>
        Offer[] GetOffers(int lcid = Constants.DefaultLcid, bool? visible = null);

        /// <summary>
        /// Get offers with user-specific urls for a given user
        /// </summary>
        /// <param name="keyUser">The user key.</param>
        /// <param name="visible">If true, returns visible offers only. If false, returns hidden offers only. Leave null to get all offers.</param>
        Offer[] GetOffersByUser(string keyUser, bool? visible = null);

        /// <summary>
        /// Get deals subscribed by given user
        /// </summary>
        Deal[] GetDealsByUser(string keyUser);
    }
}
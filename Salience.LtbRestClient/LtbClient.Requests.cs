using Newtonsoft.Json;
using RestSharp;
using Salience.FluentApi;

namespace Salience.LtbRestClient
{
    public partial class LtbClient : FluentClient
    {
        public LtbClient()
            : base(Constants.ApiBaseUrl)
        {
            this.Serializer = new JsonSerializer
            {
                ContractResolver = new Internal.UnderscorePropertyNamesContractResolver(),
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                DateParseHandling = DateParseHandling.DateTime
            };
        }

        public LtbClient(string businessKey, string apiKey)
            : this()
        {
            this.Authenticate(businessKey, apiKey);
        }

        public void Authenticate(string businessKey, string apiKey)
        {
            this.SetAuthenticator(new HttpBasicAuthenticator(businessKey, apiKey));
        }

        private IExecutableRequest<User[]> GetUsersRequest()
        {
            return To("load all users")
                .Get("/v2/users")
                .Expecting<User[]>();
        }

        private IExecutableRequest<User> GetUserRequest(string keyUser)
        {
            return To("load a user")
                .Get("/v2/users/{key_user}", r => r.AddUrlSegment("key_user", keyUser))
                .Expecting<User>();
        }

        private IExecutableRequest<User> DeclareUserRequest(string keyUser, string nameUser, int lcid)
        {
            return To("declare a user")
                .Post("/v2/users/{key_user}", r => r
                    .AddUrlSegment("key_user", keyUser)
                    .AddBody(new
                    {
                        key_user = keyUser,
                        name_user = nameUser,
                        Lcid = lcid
                    }))
                .Expecting<User>();
        }

        private IExecutableRequest<Feature[]> DeclareUserWithTrialRequest(string keyOffer, string keyUser, string nameUser, int lcid, bool forced)
        {
            return To("declare a user with trial offer")
                .Post("/v2/trial/{key_user}", r => r
                    .AddUrlSegment("key_user", keyUser)
                    .AddQueryParameter("forced", forced.ToString())
                    .AddBody(new
                    {
                        key_offer = keyOffer,
                        key_user = keyUser,
                        name_user = nameUser,
                        lcid_user = lcid
                    }))
                .Expecting<Feature[]>();
        }

        private IExecutableRequest<User[]> GetUsersByFeatureRequest(string keyFeature)
        {
            return To("load all users having access to a feature")
                .Get("/v2/users/features/{key_feature}", r => r.AddUrlSegment("key_feature", keyFeature))
                .Expecting<User[]>();
        }

        private IExecutableRequest<Feature[]> GetFeaturesRequest(int lcid)
        {
            return To("load all features")
                .Get("/v2/features/{lcid}", r => r.AddUrlSegment("lcid", lcid.ToString()))
                .Expecting<Feature[]>();
        }

        private IExecutableRequest<Feature[]> GetFeaturesByUserRequest(string keyUser)
        {
            return To("load all features accessible to a user")
                .Get("/v2/features/users/{key_user}", r => r.AddUrlSegment("key_user", keyUser))
                .Expecting<Feature[]>();
        }

        private IExecutableRequest<Feature> GetLimitationRequest(string keyFeature, string keyUser)
        {
            return To("load a limitation")
                .Get("/v2/features/{key_feature}/users/{key_user}", r => r
                    .AddUrlSegment("key_feature", keyFeature)
                    .AddUrlSegment("key_user", keyUser))
                .Expecting<Feature>();
        }

        private IExecutableRequest<Offer[]> GetOffersRequest(int lcid, bool? visible)
        {
            return To("load offers")
                .Get("/v2/offers/{lcid}", r =>
                {
                    r.AddUrlSegment("lcid", lcid.ToString());
                    if(visible.HasValue)
                        r.AddParameter("visible", visible.Value);
                })
                .Expecting<Offer[]>();
        }

        private IExecutableRequest<Offer[]> GetOffersByUserRequest(string keyUser, bool? visible)
        {
            return To("load offers for a user")
                .Get("/v2/offers/users/{key_user}", r =>
                {
                    r.AddUrlSegment("key_user", keyUser);
                    if(visible.HasValue)
                        r.AddParameter("visible", visible.Value);
                })
                .Expecting<Offer[]>();
        }

        private IExecutableRequest<Deal[]> GetDealsByUserRequest(string keyUser)
        {
            return To("load deals concluded by a user")
                .Get("/v2/deals/users/{key_user}", r => r.AddUrlSegment("key_user", keyUser))
                .Expecting<Deal[]>();
        }
    }
}

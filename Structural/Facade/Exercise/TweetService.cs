using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.Exercise
{
    public class TweetService
    {
        public List<Tweet> GetRecentTweets()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken("appKey", "appSecret");
            var accessToken = oauth.GetAccessToken(requestToken);

            var twitterClient = new TwitterClient();
            return twitterClient.GetRecentTweets(accessToken);
        }
    }
}

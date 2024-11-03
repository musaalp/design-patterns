using System;
using System.Collections.Generic;

namespace Facade.AnotherExample;

public class TwitterFacadeService
{
    public void Show()
    {
        var oauth = new OAuthAuthentication();
        var requestToken = oauth.RequestToken("appKey", "appSecret");
        var accessToken = oauth.GetAccessToken(requestToken);

        var client = new TwitterClient();
        var recentTweets = client.GetRecentTweets(accessToken);

        foreach (var tweet in recentTweets)
        {
            Console.WriteLine($"Tweet Id: {tweet.Id}, Tweet Text: {tweet.Text}");
        }
    }
}
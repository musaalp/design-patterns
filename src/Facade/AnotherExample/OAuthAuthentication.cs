using System;

namespace Facade.AnotherExample;

public class OAuthAuthentication
{
    public string RequestToken(string appKey, string appSecret)
    {
        Console.WriteLine("Getting a request token");
        return "Request token";
    }

    public string GetAccessToken(string requestToken)
    {
        Console.WriteLine("Getting an access token");
        return "Access token";
    }
}
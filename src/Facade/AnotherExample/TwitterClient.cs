using System;
using System.Collections.Generic;

namespace Facade.AnotherExample;

public class TwitterClient
{
    public IEnumerable<Tweet> GetRecentTweets(string accessToken)
    {
        Console.WriteLine("Fetching recent tweets");
        return new List<Tweet>
        {
            new Tweet(Guid.NewGuid(), "Tweet #1"),
            new Tweet(Guid.NewGuid(), "Tweet #2"),
            new Tweet(Guid.NewGuid(), "Tweet #3"),
        };
    }
}
using System;

namespace Facade.AnotherExample;

public class Tweet
{
    public Tweet(Guid id, string text)
    {
        Id = id;
        Text = text;
    }

    public Guid Id { get; }
    public String Text { get; }
}
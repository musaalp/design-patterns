namespace Facade.AnotherExample;

public class Demo
{
    public void Run()
    {
        var twitterFacadeService = new TwitterFacadeService();

        twitterFacadeService.Show();
    }
}
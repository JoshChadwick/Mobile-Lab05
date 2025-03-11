namespace MonkeyFinder.Services;
using System.Net.Http.Json;
public class MonkeyService
{
    List<Monkey> monkeyList = new();
    HttpClient httpClient;
    public MonkeyService()
    {
        this.httpClient = new HttpClient();
    }
    public async Task<List<Monkey>> GetMonkeys()
    {
        if (monkeyList?.Count > 0)
            return monkeyList;

        return monkeyList;
    }


}

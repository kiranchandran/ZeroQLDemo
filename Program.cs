
namespace ZeroQLDemo
{
    //https://github.com/byme8/ZeroQL
    class Program
    {
        static async Task Main(string[] args)
        {
            //var httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("https://workshop.chillicream.com/graphql");

            //var client = new TestServerGraphQLClient(httpClient);

            //var response = await client.Query(static o => o.Sessions(null, null, null, null, null, null, o => new Session { Title = "3" }));

            ////var response = await client.Query(o => o.Sessions<Session>(1));
            ////var response = await client.Query(static o => o.Me(o => new { o.Id, o.FirstName, o.LastName }));

            ////var response = await client.Query(static o => o.SpeakersById<Speaker>([1,2], o => new Speaker { Name= "Hello" }));

            //Console.WriteLine($"GraphQL: {response}"); // GraphQL: query { me { id firstName lastName } }
            //Console.WriteLine($"{response?.Data?.Title}"); // 1: Jon Smith

            Console.Read();
        }

    }
}

// See https://aka.ms/new-console-template for more information

using HtmlAgilityPack;

Console.WriteLine("Hello, World!");

// Carrega o HTML da página
var htmlUrl = "https://www.metacritic.com/game/donkey-kong-bananza/";

var games = new List<MetacriticGame>();

var urlList = new[]
{
    "https://www.metacritic.com/game/donkey-kong-bananza",
    "https://www.metacritic.com/game/clair-obscur-expedition-33/"
};

Parallel.ForEach(urlList, htmlUrl =>
{
    games.Add(ScrapGame(htmlUrl).Result);
});

while(games.Count < urlList.Length)
    // Aguarda até que todas as tarefas sejam concluídas
    await Task.Delay(100);

// foreach (var game  in urlList)
// {
//     games.Add(await ScrapGame(game));
// }

games.Add(await ScrapGame(htmlUrl));

async Task<MetacriticGame> ScrapGame(string url)
{
    var web = new HtmlWeb();
    var htmlDoc = await web.LoadFromWebAsync(htmlUrl);
    var title = htmlDoc.DocumentNode.SelectSingleNode("//h1")?.InnerText;

    // Take structure website
    // Console.WriteLine(htmlDoc.DocumentNode.InnerHtml);

    // Console.WriteLine(title);

    var metaScore = htmlDoc.DocumentNode.SelectSingleNode(
        "/html/body/div[1]/div/div/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[4]/div[1]/div/div[1]/div[2]/div/div/span"
    )?.InnerText;

    // Console.WriteLine(metaScore);

    var userScore = htmlDoc.DocumentNode.SelectSingleNode(
        "/html/body/div[1]/div/div/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[4]/div[2]/div[1]/div[2]/div/div/span"
    )?.InnerText;

    // Console.WriteLine(userScore);

    var metaCriticGame = new MetacriticGame(title, metaScore, userScore);
    Console.WriteLine(metaCriticGame.ToString());

    return  metaCriticGame;
}

public record MetacriticGame(string? Title, string? MetaScore, string? UserScore);
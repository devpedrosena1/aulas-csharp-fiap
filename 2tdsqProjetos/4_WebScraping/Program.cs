// See https://aka.ms/new-console-template for more information

using HtmlAgilityPack;

Console.WriteLine("Hello, World!");

var htmlUrl = "https://www.metacritic.com/game/donkey-kong-bananza/";

var web = new HtmlWeb();
var htmlDoc = web.Load(htmlUrl);
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

public record MetacriticGame(string? Title, string? MetaScore, string? UserScore);
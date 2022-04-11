using sgBaseGovPtRestClient;
using sgBaseGovPtRestClient.Entities;
using System.Text.Encodings.Web;
using System.Text.Json;

var Client = new Client();

Console.WriteLine("===========================================================================================");
Console.WriteLine(
    JsonSerializer.Serialize(
        await Client.List<ContractSummary>(1, 5, false), 
        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
    )
);

Console.WriteLine("===========================================================================================");
Console.WriteLine(
    JsonSerializer.Serialize(
        await Client.GetById<Contract>(9180146),
        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
    )
);

Console.WriteLine("===========================================================================================");
Console.WriteLine(
    JsonSerializer.Serialize(
        await Client.List<Entity>(1, 5),
        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
    )
);

Console.WriteLine("===========================================================================================");
Console.WriteLine(
    JsonSerializer.Serialize(
        await Client.GetById<Asset>(6343702),
        new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
    )
);

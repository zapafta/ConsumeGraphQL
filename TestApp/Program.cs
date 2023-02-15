// See https://aka.ms/new-console-template for more information




using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using System.Security.Cryptography;
using System.Xml.Linq;
using TestApp;
using static System.Net.Mime.MediaTypeNames;

string endpoint = "https://apidemo.sagex3.com/demo/service/X3CLOUDV2_SEED/api";


var client = new GraphQLHttpClient(endpoint, new NewtonsoftJsonSerializer());
//client.HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + Convert.ToString(Application.Current.Properties["Login"]));



//Comando SQL
//Comando GRAPH SQL to like sage x3 { xtremX3MasterData { supplier { query (filter:"{ companyName: {_regex:'Pesquisar'}}"){ edges { node { _id companyName } } } } } }



var request = new GraphQLRequest
{
    Query = @"
  {xtremX3MasterData {
    customer {
      query {
        edges {
          node {
            _id
            companyName
          }
        }
      }
    }
  }
}"
};

var response = await client.SendQueryAsync<Data>(request);


Console.WriteLine("Hello, World!");

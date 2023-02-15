using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Customer
    {
        public Query query { get; set; }
    }

    public class Data
    {
        public XtremX3MasterData xtremX3MasterData { get; set; }
    }

    public class Edge
    {
        public Node node { get; set; }
    }

    public class Node
    {
        public string _id { get; set; }
        public string companyName { get; set; }
    }

    public class Query
    {
        public List<Edge> edges { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
    }

    public class XtremX3MasterData
    {
        public Customer customer { get; set; }
    }



}
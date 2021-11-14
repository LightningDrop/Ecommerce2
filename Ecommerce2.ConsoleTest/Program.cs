// See https://aka.ms/new-console-template for more information


//var expandoConverter = new ExpandoObjectConverter();

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var jsonFile = @"C:\Users\AccedeoPix\source\repos\LightningDrop\Ecommerce2\Ecommcerce2.BE\StaticData\Names.json";

var jsonInMem = String.Empty;
using (StreamReader r = new StreamReader(jsonFile))
{
    jsonInMem = r.ReadToEnd();
}


JObject json = (JObject)JsonConvert.DeserializeObject(jsonInMem);
var listNames = json.GetValue("Names").ToList();


List<string> names = new List<string>();
foreach (var obj in listNames)
{
    names.Add(obj.ToString());
}


foreach (var name in names)
{
    Console.WriteLine(name);
}


//foreach (var item in json)
//{
//    //Console.WriteLine(item);
//    if (item.ContainsKey("Names"))
//    {
//        foreach (var name in item)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}
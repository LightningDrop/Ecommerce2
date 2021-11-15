using Ecommcerce2.Core.Interfaces;
using Ecommcerce2.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

namespace Ecommcerce2.Core.Services
{
    public class InMemoryAccountData : IAccountData
    {
        // This can be removed later ... 
        private int genID = 0;

        // This exposes a path that shouldn't be exposed ... find better implementation 
        private string NAMES_PATH_JSON = @"C:\Users\AccedeoPix\source\repos\LightningDrop\Ecommerce2\Ecommcerce2.Core\StaticData\Names.json";
        private string USERNAMES_PATH_JSON = @"C:\Users\AccedeoPix\source\repos\LightningDrop\Ecommerce2\Ecommcerce2.Core\StaticData\UserNames.json";
        private Random rng = new Random();


        readonly List<Account> _accounts;

        public InMemoryAccountData(bool isInitSeedData, [Optional] int numSeedData)
        {
            if (isInitSeedData)
            {
                _accounts = CreateSeedData(numSeedData);
            }

        }

        // START PUBLIC METHODS 
        public Task<IEnumerable<Account>> GetAll()
        {
            IEnumerable<Account> accounts = new List<Account>();
            accounts = _accounts;
            return Task.FromResult(accounts);
        }

        public Task<Account> Get(int id)
        {
            var accountById =
                from account in _accounts
                where account.Id == id
                select account;

            // accountById returns IEnumerable meaning we have to cast it as a single Account 
            return Task.FromResult<Account>((Account)accountById);

        }


        // START PRIVATE METHODS 
        // Get a random date 
        private DateTime RandomDate()
        {
            DateTime start = new DateTime(1990, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rng.Next(range));
        }

        // Get a list based on the key of JSON file 
        private List<string> getListOfDataFromJson(string pathToJson, string dataToExtract)
        {
            var jsonInMem = String.Empty;
            using (StreamReader r = new StreamReader(pathToJson))
            {
                jsonInMem = r.ReadToEnd();
            }

            JObject json = (JObject)JsonConvert.DeserializeObject(jsonInMem);
            var listObjFromJson = json.GetValue(dataToExtract).ToList();

            List<string> stringsFromJson = new List<string>();
            foreach (var obj in listObjFromJson)
            {
                stringsFromJson.Add(obj.ToString());
            }

            return stringsFromJson;

        }

        // Generates a random seed account 
        private Account GenerateSeedAccount()
        {
            // Get list of names 
            var listNames = getListOfDataFromJson(NAMES_PATH_JSON, "Names");

            // Get list of usernames 
            var listUserNames = getListOfDataFromJson(USERNAMES_PATH_JSON, "usernames");

            // Increment ID 
            genID++;

            // Generate Random Index 
            int indexNames = rng.Next(listNames.Count);
            int indexUNames = rng.Next(listUserNames.Count);

            return new Account() { Id = genID, UserName = listUserNames[indexUNames], Name = listNames[indexNames], DateOfBirth = RandomDate() };
        }

        // Creates the Seed Data for service construction 
        private List<Account> CreateSeedData(int numData)
        {
            List<Account> list = new List<Account>();
            for (int i = 0; i < numData; i++) list.Add(GenerateSeedAccount());
            return list;
        }


    }
}

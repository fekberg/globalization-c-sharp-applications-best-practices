using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Domain;
using Newtonsoft.Json;

namespace Infrastructure
{
    public class ProductRepository
    {
        public IEnumerable<Product> Get()
        {

            Assembly assembly = Assembly.GetExecutingAssembly();

            using (var stream = assembly.GetManifestResourceStream("Infrastructure.Data.products.json"))
            using (var reader = new StreamReader(stream))
            {
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(reader.ReadToEnd());


                return products;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace technology_tp1
{
    public class ForgeJSONSeedDeliveryMan : ForgeJSONSeed
    {
        protected override string FileName => "DeliveryManSeed.json";

        protected override JToken CreateJSON()
        {
            JArray jArray = new JArray();
            for (int i = 1; i < 50; i++)
            {
                JObject deliveryMan = new JObject();
                deliveryMan.Add("id", new JValue(i * -1));
                deliveryMan.Add("name", new JValue(Faker.NameFaker.Name()));
                deliveryMan.Add("phone", new JValue(Faker.PhoneFaker.Phone()));
                deliveryMan.Add("isEmployed", new JValue(Faker.BooleanFaker.Boolean()));
                jArray.Add(deliveryMan);
            }

            return jArray;
        }
    }
}

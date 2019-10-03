using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace technology_tp1
{
    public abstract class ForgeJSONSeed
    {
        private const string FilePath = "Seeds/json/";

        protected abstract JToken CreateJSON();

        protected abstract string FileName { get; }

        public bool Exist => File.Exists(FilePath + FileName);

        public JToken JToken
        {
            get
            {
                if (!Exist) return null;
                using (StreamReader streamReader = System.IO.File.OpenText(FilePath + FileName))
                using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
                {
                    return (JArray)JToken.ReadFrom(jsonTextReader);
                }
            }
        }

        public void Forge()
        {
            using (StreamWriter streamWriter = new StreamWriter(System.IO.File.OpenWrite(FilePath + FileName)))
            using (JsonTextWriter jsonTextReader = new JsonTextWriter(streamWriter))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(jsonTextReader, CreateJSON());
            }
        }
    }
}

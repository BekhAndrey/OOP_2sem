using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Lab5
{
    class JsonSerializer<T>
    {
        private readonly DataContractJsonSerializer _formatter;
        private string _fileName;

        public JsonSerializer(string fileName = null)
        {
            _formatter = new DataContractJsonSerializer(typeof(T));
            _fileName = fileName;
        }

        public void Serialize(T obj)
        {
            using (var stream = new FileStream(_fileName, FileMode.Create))
            {
                _formatter.WriteObject(stream, obj);
            }
        }

        public virtual T Deserialize()
        {
            using (var stream = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                return (T)_formatter.ReadObject(stream);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace _6_7_2_.Services
{
    class IOservice 
    {
        private List<BindingList<Cloth>> cloth;
        private readonly string PATH;

        public IOservice(string path)
        {
            PATH = path;
        }

        public BindingList<Cloth> cloth_Data()
        {
            BindingList<Cloth> list = new BindingList<Cloth>();
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<Cloth>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Cloth>>(fileText);
            }
        }

        public void SaveData(BindingList<Cloth> cloth_Data, object obj)
        {
            using (StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(cloth_Data);
                writer.Write(output);
            }

        }
    }
}

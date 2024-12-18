using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Prototype
{
    public class ImageCreator : ICloneable

    {
        public ImageCreator()
        {
            // Burada uzun süren işlemler olabilir.
            // Örneğin, bir resmi diskten okuyup, belleğe yüklemek.

            Console.WriteLine($" nesne oluşmaya başladı: {DateTime.Now}");


            Thread.Sleep(5000);

            Width = 1080;
            Height = 720;

            Console.WriteLine($" nesne oluştu: {DateTime.Now}");
            ImageSettings.Add("Quality", new ImageSetting { Name = "Quality", Value = 100 });
            ImageSettings.Add("Format", new ImageSetting { Name = "Format", Value = 0 });
            ImageSettings.Add("Color", new ImageSetting { Name = "Color", Value = 0 });
        }


        public int Width { get; set; }
        public int Height { get; set; }
        public string ImagePath { get; set; }

        public Dictionary<string, ImageSetting> ImageSettings { get; set; } = new Dictionary<string, ImageSetting>();






        public object Clone()
        {
            return this.MemberwiseClone();

        }

        public object Clone(bool isDeep)
        {
            //shalow copy: sadece primitif tiplerin değerlerini kopyalar.
            return isDeep ? this.MemberwiseClone() : this.DeepClone();
        }

        private object DeepClone()
        {
            //deep copy: nesnenin referanslarını ve bu referanslardaki değerleri de kopyalar.
            var serializedObject = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<ImageCreator>(serializedObject);
        }
    }



    public class ImageSetting
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Value { get; set; }
    }


}

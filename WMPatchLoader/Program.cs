using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMPatchLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZipArchive archive = ZipFile.OpenRead("Test Patch.wmpatch");
            var sample = archive.GetEntry("manifest.json");
            Stream zipEntryStream = sample.Open();
            StreamReader reader = new StreamReader(zipEntryStream);
            string json = reader.ReadToEnd();
            Console.WriteLine(json);
            Console.WriteLine('\n');
            WMManifest manifest = JsonConvert.DeserializeObject<WMManifest>(json);
            Console.WriteLine("manifest: " + manifest.manifest);
            Console.WriteLine("name: " + manifest.name);
            Console.WriteLine("author: " + manifest.author);
            Console.WriteLine("version: " + manifest.version);
            Console.WriteLine("cover: " + manifest.cover);
            Console.WriteLine("userValue: " + manifest.userValue);
            Console.WriteLine("description: " + manifest.description);
            Console.WriteLine('\n');
            Console.WriteLine("Patch Files:");
            foreach (string file in manifest.patchFiles)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}

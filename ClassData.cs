using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;
using static ClientRest_20180140067_Yusuf_Johan_Kelana.Program;

namespace ClientRest_20180140067_Yusuf_Johan_Kelana
{
    class ClassData
    {
        public void getData()
        {
            // var type data yang tidak peduli pada bentuk, tapi isinya
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            /* for (int i = 0; i < data.Count; i++)
             * {
             *      Console.WriteLine(data[i].nama);
             *      Console.WriteLine(data[i].nim);
             *      Console.WriteLine(data[i].prodi);
             *      Console.WriteLine(data[i].angkatan);
             * }
             */

            foreach (var mahasiswa in data)
            {
                Console.WriteLine("NIM: " + mahasiswa.nama);
                Console.WriteLine("Nama: " + mahasiswa.nim);
                Console.WriteLine("Prodi: " + mahasiswa.prodi);
                Console.WriteLine("Angkatan: " + mahasiswa.angkatan);
            }
            Console.ReadLine();
        }
    }
}

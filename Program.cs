using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;

namespace ClientRest_20180140067_Yusuf_Johan_Kelana
{
    class Program
    {
        [DataContract]
        public class Mahasiswa
        {
            private string _nama, _nim, _prodi, _angkatan;

            [DataMember]
            public string nama
            {
                get { return _nama; }
                set { _nama = value; }
            }

            [DataMember]
            public string nim
            {
                get { return _nim; }
                set { _nim = value; }
            }

            [DataMember]
            public string prodi
            {
                get { return _prodi; }
                set { _prodi = value; }
            }

            [DataMember]
            public string angkatan
            {
                get { return _angkatan; }
                set { _angkatan = value; }
            }

        }

        string baseUrl = "http://localhost:1907/";

        void BuatMahasiswa()
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            Console.Write("Masukkan Nama: ");
            mahasiswa.nama = Console.ReadLine();
            Console.Write("Masukkan NIM: ");
            mahasiswa.nim = Console.ReadLine();
            Console.Write("Masukkan Prodi: ");
            mahasiswa.prodi = Console.ReadLine();
            Console.Write("Masukkan Angkatan: ");
            mahasiswa.angkatan = Console.ReadLine();

            var data = JsonConvert.SerializeObject(mahasiswa);
            var postdata = new WebClient();
            postdata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            string response = postdata.UploadString(baseUrl + "Mahasiswa", data);
            Console.WriteLine(response);
        }

        static void Main(string[] args)
        {
            ClassData classData = new ClassData();
            classData.getData();
            Program program = new Program();
            program.BuatMahasiswa();
            Console.ReadLine();
        }
    }
}

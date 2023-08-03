using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Batch35
{
    [Serializable]
    internal class Files2
    {
        public int trainee_id;
        public string trainee_name;

        static void Main(string[] args)
        {
            Files2 f2 = new Files2();
            f2.trainee_id = 1;
            f2.trainee_name = "John";

            IFormatter formatter = new BinaryFormatter();

            Stream s = new FileStream(@"E:\FilesSerialize.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            formatter.Serialize(s, f2);
            s.Close();

            Stream s1 = new FileStream(@"E:\FilesSerialize.txt", FileMode.Open, FileAccess.ReadWrite);
            f2 = (Files2)formatter.Deserialize(s1);
            Console.WriteLine(f2.trainee_id);
            Console.WriteLine(f2.trainee_name);

        }
    }
}

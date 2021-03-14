using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook
{
    class FileHelper
    {
        public static void JsonSerialize(string filename, Student student)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{filename}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, student);
                }
            }
        }

        public static Student JsonDeserialize(string filename)
        {
            Student student = new Student();
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader($"{filename}.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    student = serializer.Deserialize<Student>(jr);
                }
            }
            return student;
        }
    }
}

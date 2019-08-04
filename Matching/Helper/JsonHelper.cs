using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Matching_cs.Helper
{
    public static class JsonHelper
    {
        public static string ParseConvertToByte(byte[] buffer)
        {
            //string jsonStr = Encoding.UTF8.GetString(json);
            string jsonStr = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);

            var json = new Dictionary<int, string>();
            json.Add(2, jsonStr);
            return JsonConvert.SerializeObject(json);

        }

        public static byte[] Read(string fileName, string location)
        {
            string root = "json";
            var path = Path.Combine(
            Directory.GetCurrentDirectory(),
            root,
            location,
            fileName);

            string jsonResult;

            //using (StreamReader streamReader = new StreamReader(path))
            //{
            //    jsonResult = streamReader.ReadToEnd();
            //}
            var json = File.ReadAllText(path);
            var arr = JsonConvert.DeserializeObject<dynamic>(json);

            var byteJson = JsonConvert.SerializeObject(arr.temp_byte);

             byteJson = Encoding.ASCII.GetBytes(byteJson);
            return byteJson;
        }


        public static void Write(string fileName, string location, string jSONString)
        {
            string root = "json";
            var path = Path.Combine(
            Directory.GetCurrentDirectory(),
            root,
            location,
            fileName);

            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(jSONString);
            }
        }
    }

}
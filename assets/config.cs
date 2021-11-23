using System.IO;
using UnityEngine;

namespace config
{
    public class code
    {
        public static string fileDirectory = "BepInEx\\config\\Fly Grapple Config.txt";
        public static string[] fileRead = { "" };
        public static string[] fileWrite = new string[] { "Grapple Fly", "", "", "", "Speed", "8000", "", "speed multiplier(when you press control+F)", "2", "", "For more info check out the github page" };
        public static void run()
        {
            if (!File.Exists(fileDirectory)) Create();
            //  if (File.Exists(fileDirectory)) SetSpeed();
        }
        public static void SetSpeed()
        {
            float x = float.Parse(fileRead[5]);
            float y = float.Parse(fileRead[8]);
            main.code.speed = x;
            main.code.mult = y;
        }
        public static void Create()
        {
            Debug.Log("File created");
            Debug.Log("File writen");
            File.WriteAllLines(fileDirectory, fileWrite);
            fileRead = File.ReadAllLines(fileDirectory);
            SetSpeed();
        }
        public static void DeleteFile(bool remakeFile)
        {
            File.Delete(fileDirectory);
            Debug.Log("Deleted file");
            if (remakeFile) Create();
        }
    }
}

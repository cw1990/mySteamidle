using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace idleApp.Class
{
    public class FileHelper
    {
        byte[] byData = new byte[100];
        char[] charData = new char[1000];

        /// <summary>  
        /// 读文件  
        /// </summary>  
        /// <param name="Path">文件路径</param>  
        /// <returns></returns>  
        public static string ReadFile(string Path)
        {
            try
            {
                StreamReader sr = new StreamReader(Path, Encoding.GetEncoding("utf-8"));
                string content = sr.ReadToEnd().ToString();
                sr.Close();
                return content;
            }
            catch
            {
                return "Error";
            }
        }

        /// <summary>  
        /// 写文件  
        /// </summary>   
        /// <param name="Name">文件名(包括后缀名)</param>  
        /// <param name="content">内容</param>  
        /// <returns></returns>  
        public static bool WriteFile(string Name, string content)
        {
            try
            {
                //string path = Path;
                //if (!Directory.Exists(path))
                //{
                //    Directory.CreateDirectory(path);
                //}
                //string fname = Path + "/" + Name;
                string fname = Name;
                if (!File.Exists(fname))
                {
                    FileStream fs = File.Create(fname);
                    fs.Close();
                }
                StreamWriter sw = new StreamWriter(fname, false, System.Text.Encoding.GetEncoding("utf-8"));
                sw.WriteLine(content);
                sw.Close();
                sw.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

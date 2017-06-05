using System;
using System.Collections.Generic;
using System.IO;

namespace MyAfterSchool.Helper
{
    public class ImageHelper
    {
        public static List<string> GettAllImagesFromFolder( string relativePath)
        {
            try
            {
                List<string> myImagePathList = new List<string>();
                string[] filenames = Directory.GetFiles( Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath)));
                foreach (string file in filenames)
                {
                   string fileName = Path.GetFileName(file);
                   string path = relativePath + fileName;
                    myImagePathList.Add(path);
                }
                return myImagePathList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
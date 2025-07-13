using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class ImageHandler
    {
        public static string SaveImage(string path, string targetDir)
        {
            try
            {
                string extension = path.Substring(path.LastIndexOf("."));
                string newFileName = Guid.NewGuid() + extension;
                string fullTarget = Path.Combine(targetDir, newFileName);
                File.Copy(path, Path.Combine(targetDir, newFileName));
                return fullTarget;
            } catch (Exception e) { }
            return null;
        }
        public static bool DeleteImage(string path)
        {
            try
            {
                File.Delete(path);
                return true;
            } catch(Exception e) { }
            return false;
        }

    }
}

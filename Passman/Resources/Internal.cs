using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace Passman.Resources
{
    internal class Internal
    {
        public static string ExecutableDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static bool Internet;      
        public static bool CheckForInternetConnection(int timeoutMs = 10000, string url = null)
        {
            try
            {
                url ??= CultureInfo.InstalledUICulture switch
                {
                    { Name: var n } when n.StartsWith("fa") => // Iran
                        "http://www.aparat.com",
                    { Name: var n } when n.StartsWith("zh") => // China
                        "http://www.baidu.com",
                    _ =>
                        "http://www.gstatic.com/generate_204",
                };

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Timeout = timeoutMs;
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    Internet = true;
                    return true;
                }                   
            }
            catch
            {
                Internet = false;
                return false;
            }
        }
        public static string GetUserGuid()
        {
            if (Settings1.Default.GUID == "")
            {
                Settings1.Default.GUID = Guid.NewGuid().ToString();
                //Settings1.Default.Save();
            }
            return Settings1.Default.GUID;
        }
    }
    internal class Imaging
    {
        public static string IconDirectory = Path.Combine(Internal.ExecutableDirectory, "Icons");
        public static string GlobeIconPath = Path.Combine(IconDirectory, "world-icon.png");
        public static Image GetIcon(string website)
        {
            foreach (string file in Directory.GetFiles(IconDirectory))
            {
                if (Path.GetFileNameWithoutExtension(file) == website.Split("//")[1])
                {
                    return Image.FromFile(file);
                }
            }
            return null;
        }
        public static void SaveImage(string website, Image image)
        {
            string site = website.Split("//")[1];
            Bitmap bmp = new Bitmap(image);
            bmp.Save(Path.Combine(IconDirectory, site + ".png"), ImageFormat.Png);
        }
        public static bool DoesUrlRespond(string url)
        {
            try
            {
                WebRequest req = WebRequest.Create(url);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                resp.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static Image GetFavIcon(string url)
        {
            Image urlFavIco = null;
            try
            {
                if (DoesUrlRespond(url))
                {
                    Uri thisUrl = new Uri(url);
                    if (thisUrl.HostNameType == UriHostNameType.Dns)
                    {
                        string iconUrl = "http://" + thisUrl.Host + "/favicon.ico";
                        WebRequest req = WebRequest.Create(iconUrl);
                        WebResponse resp = req.GetResponse();
                        urlFavIco = Image.FromStream(resp.GetResponseStream());
                        resp.Close();

                    }
                }
            }
            catch
            { }

            return urlFavIco;
        }
    }
}

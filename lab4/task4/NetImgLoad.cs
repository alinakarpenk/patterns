using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class NetImgLoad : IImageLoad
    {
        public void Load(string href)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(href);
                    Console.WriteLine($"Image loaded from network: {href}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image from network: {href}");
                Console.WriteLine($"Error message: {ex.Message}");
            }
        }
    }
}

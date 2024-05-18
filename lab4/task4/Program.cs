using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImageLoad fileLoader = new FileSysLoad();
            IImageLoad networkLoader = new NetImgLoad();

            Image localImage = new Image(fileLoader, "/path/to/local/image.jpg");
            Image networkImage = new Image(networkLoader, "https://png.pngtree.com/thumb_back/fw800/background/20230610/pngtree-picture-of-a-blue-bird-on-a-black-background-image_2937385.jpg");

            localImage.Display();
            networkImage.Display();
            Console.ReadKey();
        }
    }
}

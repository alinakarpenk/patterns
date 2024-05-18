using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Image
    {
        private IImageLoad _imageLoader;
        private string _href;

        public Image(IImageLoad imageLoader, string href)
        {
            _imageLoader = imageLoader;
            _href = href;
        }

        public void Display()
        {
            _imageLoader.Load(_href);
            Console.WriteLine($"Displaying image: {_href}");
        }
    }
}

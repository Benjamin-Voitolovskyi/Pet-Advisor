using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExpertSystem
{
    class Utils
    {
        public static Bitmap Resize(Image image, Size size)
        {
            double resizeX = (double)size.Width / image.Width;
            double resizeY = (double)size.Height / image.Height;
            double resize = Math.Min(resizeX, resizeY);
            Size newSize = new((int)Math.Round(image.Width * resize), (int)Math.Round(image.Height * resize));
            return new Bitmap(image, newSize);
        }

        public static Image GetImage(string pet)
        {
            return pet switch
            {
                "Dog" => Properties.Resources.Dog,
                "Cat" => Properties.Resources.Cat,
                "Parrot" => Properties.Resources.parrot,
                "Rodent" => Properties.Resources.Rodent,
                "Tortoise" => Properties.Resources.Tortoise,
                "Fish" => Properties.Resources.Fish,
                _ => throw new Exception("Unknown pet"),
            };
        }
    }
}

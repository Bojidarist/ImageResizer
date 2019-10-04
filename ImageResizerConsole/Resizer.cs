using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ImageResizerConsole
{
    public static class Resizer
    {
        public static Image Resize(string path, int width, int height)
        {
            Image image = Image.Load(path);
            image.Mutate(x => x.Resize(width, height));
            return image;
        }
    }
}

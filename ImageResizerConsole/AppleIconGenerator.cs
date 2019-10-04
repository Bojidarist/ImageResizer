using SixLabors.ImageSharp;
using System.IO;

namespace ImageResizerConsole
{
    /// <summary>
    /// Generator for all icon sizes for apple products
    /// </summary>
    public class AppleIconGenerator
    {
        /// <summary>
        /// Saves all image sizes
        /// </summary>
        /// <param name="pathToIcon">The path to the original icon</param>
        /// <param name="iconsDir">The output path</param>
        /// <param name="sizes">The sizes to be generated</param>
        private void SaveImages(string pathToIcon, string iconsDir, string[] sizes)
        {
            if (!Directory.Exists(iconsDir))
            {
                Directory.CreateDirectory(iconsDir);
            }

            foreach (string size in sizes)
            {
                string[] res = size.Split('x');
                int width = int.Parse(res[0]);
                int height = int.Parse(res[1]);
                using Image image = Resizer.Resize(pathToIcon, width, height);
                image.Save($"{Path.Combine(iconsDir, size)}.png");
            }
        }

        /// <summary>
        /// Generates all icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string iconsDir = Path.Combine(outputDirectory, "Apple_Icons");
            string[] sizes = new string[5]
            {
                "180x180", "120x120", "167x167", "152x152", "1024x1024"
            };
            SaveImages(pathToIcon, iconsDir, sizes);
        }

        /// <summary>
        /// Generate all spotlight icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateSpotlightIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string iconsDir = Path.Combine(outputDirectory, "Apple_SpotlightIcons");
            string[] sizes = new string[2]
            {
                "120x120", "80x80"
            };
            SaveImages(pathToIcon, iconsDir, sizes);
        }

        /// <summary>
        /// Generates all settings icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateSettingsIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string iconsDir = Path.Combine(outputDirectory, "Apple_SettingsIcons");
            string[] sizes = new string[2]
            {
                "87x87", "58x58"
            };
            SaveImages(pathToIcon, iconsDir, sizes);
        }

        /// <summary>
        /// Generates all notification icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateNotificationIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string iconsDir = Path.Combine(outputDirectory, "Apple_NotificationIcons");
            string[] sizes = new string[2]
            {
                "60x60", "40x40"
            };
            SaveImages(pathToIcon, iconsDir, sizes);
        }

        /// <summary>
        /// Generate ALL icons (Normal, Spotlight, Notification, Settings)
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateAllIcons(string pathToIcon, string outputDirectory = "Output")
        {
            GenerateIcons(pathToIcon, outputDirectory);
            GenerateNotificationIcons(pathToIcon, outputDirectory);
            GenerateSettingsIcons(pathToIcon, outputDirectory);
            GenerateSpotlightIcons(pathToIcon, outputDirectory);
        }
    }
}

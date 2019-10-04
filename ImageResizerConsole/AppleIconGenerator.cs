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
        /// Generates all icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string launcherIconsDir = Path.Combine(outputDirectory, "Apple_Icons");
            if (!Directory.Exists(launcherIconsDir))
            {
                Directory.CreateDirectory(launcherIconsDir);
            }

            string[] sizes = new string[5]
            {
                "180x180", "120x120", "167x167", "152x152", "1024x1024"
            };

            foreach (string size in sizes)
            {
                string[] res = size.Split('x');
                int width = int.Parse(res[0]);
                int height = int.Parse(res[1]);
                using Image image = Resizer.Resize(pathToIcon, width, height);
                image.Save($"{Path.Combine(launcherIconsDir, size)}.png");
            }
        }

        /// <summary>
        /// Generate all spotlight icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateSpotlightIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string launcherIconsDir = Path.Combine(outputDirectory, "Apple_SpotlightIcons");
            if (!Directory.Exists(launcherIconsDir))
            {
                Directory.CreateDirectory(launcherIconsDir);
            }

            string[] sizes = new string[2]
            {
                "120x120", "80x80"
            };

            foreach (string size in sizes)
            {
                string[] res = size.Split('x');
                int width = int.Parse(res[0]);
                int height = int.Parse(res[1]);
                using Image image = Resizer.Resize(pathToIcon, width, height);
                image.Save($"{Path.Combine(launcherIconsDir, size)}.png");
            }
        }

        /// <summary>
        /// Generates all settings icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateSettingsIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string launcherIconsDir = Path.Combine(outputDirectory, "Apple_SettingsIcons");
            if (!Directory.Exists(launcherIconsDir))
            {
                Directory.CreateDirectory(launcherIconsDir);
            }

            string[] sizes = new string[2]
            {
                "87x87", "58x58"
            };

            foreach (string size in sizes)
            {
                string[] res = size.Split('x');
                int width = int.Parse(res[0]);
                int height = int.Parse(res[1]);
                using Image image = Resizer.Resize(pathToIcon, width, height);
                image.Save($"{Path.Combine(launcherIconsDir, size)}.png");
            }
        }

        /// <summary>
        /// Generates all notification icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateNotificationIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string launcherIconsDir = Path.Combine(outputDirectory, "Apple_NotificationIcons");
            if (!Directory.Exists(launcherIconsDir))
            {
                Directory.CreateDirectory(launcherIconsDir);
            }

            string[] sizes = new string[2]
            {
                "60x60", "40x40"
            };

            foreach (string size in sizes)
            {
                string[] res = size.Split('x');
                int width = int.Parse(res[0]);
                int height = int.Parse(res[1]);
                using Image image = Resizer.Resize(pathToIcon, width, height);
                image.Save($"{Path.Combine(launcherIconsDir, size)}.png");
            }
        }

        /// <summary>
        /// Generate ALL icons (Normal, Spotlight, Notification, Settings)
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateAllIcons(string pathToIcon, string outputDirectory = "Output")
        {
            this.GenerateIcons(pathToIcon, outputDirectory);
            this.GenerateNotificationIcons(pathToIcon, outputDirectory);
            this.GenerateSettingsIcons(pathToIcon, outputDirectory);
            this.GenerateSpotlightIcons(pathToIcon, outputDirectory);
        }
    }
}

using SixLabors.ImageSharp;
using System.IO;

namespace ImageResizerConsole
{
    /// <summary>
    /// Generator for all icon sizes for android
    /// </summary>
    public class AndroidIconGenerator
    {
        /// <summary>
        /// Generates all launcher icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateLauncherIcons(string pathToIcon, string outputDirectory = "Android")
        {
            string launcherIconsDir = Path.Combine(outputDirectory, "LauncherIcons");
            if (!Directory.Exists(launcherIconsDir))
            {
                Directory.CreateDirectory(launcherIconsDir);
            }

            string[] sizes = new string[6]
            {
                "48x48", "72x72", "96x96", "144x144", "192x192", "512x512"
            };

            foreach (string size in sizes)
            {
                string[] res = size.Split('x');
                int width = int.Parse(res[0]);
                int height = int.Parse(res[1]);
                using (Image image = Resizer.Resize(pathToIcon, width, height))
                {
                    image.Save($"{Path.Combine(launcherIconsDir, size)}.png");
                }
            }
        }

        /// <summary>
        /// Generates all action bar, dialog and tab icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateActionBarIcons(string pathToIcon, string outputDirectory = "Android")
        {
            string launcherIconsDir = Path.Combine(outputDirectory, "ActionBar_Dialog_Tab_Icons");
            if (!Directory.Exists(launcherIconsDir))
            {
                Directory.CreateDirectory(launcherIconsDir);
            }

            string[] sizes = new string[5]
            {
                "24x24", "36x36", "48x48", "72x72", "96x96"
            };

            foreach (string size in sizes)
            {
                string[] res = size.Split('x');
                int width = int.Parse(res[0]);
                int height = int.Parse(res[1]);
                using (Image image = Resizer.Resize(pathToIcon, width, height))
                {
                    image.Save($"{Path.Combine(launcherIconsDir, size)}.png");
                }
            }
        }

        /// <summary>
        /// Generates all small contextual icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateSmallContextualIcons(string pathToIcon, string outputDirectory = "Android")
        {
            string launcherIconsDir = Path.Combine(outputDirectory, "SmallContextualIcons");
            if (!Directory.Exists(launcherIconsDir))
            {
                Directory.CreateDirectory(launcherIconsDir);
            }

            string[] sizes = new string[5]
            {
                "16x16", "24x24", "32x32", "48x48", "64x64"
            };

            foreach (string size in sizes)
            {
                string[] res = size.Split('x');
                int width = int.Parse(res[0]);
                int height = int.Parse(res[1]);
                using (Image image = Resizer.Resize(pathToIcon, width, height))
                {
                    image.Save($"{Path.Combine(launcherIconsDir, size)}.png");
                }
            }
        }

        /// <summary>
        /// Generates all notification icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateNotificationIcons(string pathToIcon, string outputDirectory = "Android")
        {
            string launcherIconsDir = Path.Combine(outputDirectory, "NotificationIcons");
            if (!Directory.Exists(launcherIconsDir))
            {
                Directory.CreateDirectory(launcherIconsDir);
            }

            string[] sizes = new string[5]
            {
                "22x22", "33x33", "44x44", "66x66", "88x88"
            };

            foreach (string size in sizes)
            {
                string[] res = size.Split('x');
                int width = int.Parse(res[0]);
                int height = int.Parse(res[1]);
                using (Image image = Resizer.Resize(pathToIcon, width, height))
                {
                    image.Save($"{Path.Combine(launcherIconsDir, size)}.png");
                }
            }
        }

        /// <summary>
        /// Generates all types of icons (Launcher, Action bar, Dialog, Tab, Small contextual, Notification)
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateIcons(string pathToIcon, string outputDirectory = "Android")
        {
            this.GenerateActionBarIcons(pathToIcon, outputDirectory);
            this.GenerateLauncherIcons(pathToIcon, outputDirectory);
            this.GenerateNotificationIcons(pathToIcon, outputDirectory);
            this.GenerateSmallContextualIcons(pathToIcon, outputDirectory);
        }
    }
}

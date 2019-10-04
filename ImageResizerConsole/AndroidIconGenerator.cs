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
        /// Generates all launcher icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateLauncherIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string iconsDir = Path.Combine(outputDirectory, "Android_LauncherIcons");
            string[] sizes = new string[6]
            {
                "48x48", "72x72", "96x96", "144x144", "192x192", "512x512"
            };
            SaveImages(pathToIcon, iconsDir, sizes);
        }

        /// <summary>
        /// Generates all action bar, dialog and tab icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateActionBarIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string iconsDir = Path.Combine(outputDirectory, "Android_ActionBar_Dialog_Tab_Icons");
            string[] sizes = new string[5]
            {
                "24x24", "36x36", "48x48", "72x72", "96x96"
            };
            SaveImages(pathToIcon, iconsDir, sizes);
        }

        /// <summary>
        /// Generates all small contextual icon sizes
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateSmallContextualIcons(string pathToIcon, string outputDirectory = "Output")
        {
            string iconsDir = Path.Combine(outputDirectory, "Android_SmallContextualIcons");
            string[] sizes = new string[5]
            {
                "16x16", "24x24", "32x32", "48x48", "64x64"
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
            string iconsDir = Path.Combine(outputDirectory, "Android_NotificationIcons");
            string[] sizes = new string[5]
            {
                "22x22", "33x33", "44x44", "66x66", "88x88"
            };
            SaveImages(pathToIcon, iconsDir, sizes);
        }

        /// <summary>
        /// Generates all types of icons (Launcher, Action bar, Dialog, Tab, Small contextual, Notification)
        /// </summary>
        /// <param name="pathToIcon">Path to the original icon image</param>
        /// <param name="outputDirectory">The output directory</param>
        public void GenerateIcons(string pathToIcon, string outputDirectory = "Output")
        {
            GenerateActionBarIcons(pathToIcon, outputDirectory);
            GenerateLauncherIcons(pathToIcon, outputDirectory);
            GenerateNotificationIcons(pathToIcon, outputDirectory);
            GenerateSmallContextualIcons(pathToIcon, outputDirectory);
        }
    }
}

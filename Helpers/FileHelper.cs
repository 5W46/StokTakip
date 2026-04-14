using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace StokTakip.Helpers
{
    public static class FileHelper
    {
        private static readonly string ImageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProductImages");
        private static readonly int ThumbWidth = 100;
        private static readonly int ThumbHeight = 100;

        static FileHelper()
        {
            if (!Directory.Exists(ImageFolder))
                Directory.CreateDirectory(ImageFolder);
        }

        public static string SaveProductImage(string sourceFilePath, int productId)
        {
            string extension = Path.GetExtension(sourceFilePath);
            string fileName = $"{productId}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
            string destPath = Path.Combine(ImageFolder, fileName);
            File.Copy(sourceFilePath, destPath, true);

            string thumbPath = Path.Combine(ImageFolder, $"{Path.GetFileNameWithoutExtension(fileName)}_thumb{extension}");
            CreateThumbnail(destPath, thumbPath, ThumbWidth, ThumbHeight);

            return fileName;
        }

        public static void DeleteProductImage(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return;
            
            string fullPath = Path.Combine(ImageFolder, fileName);
            string thumbPath = Path.Combine(ImageFolder, $"{Path.GetFileNameWithoutExtension(fileName)}_thumb{Path.GetExtension(fileName)}");

            // Birkaç milisaniye bekleyerek dosyaların serbest kalmasını sağla
            System.Threading.Thread.Sleep(50);
            
            try
            {
                if (File.Exists(fullPath))
                    File.Delete(fullPath);
                if (File.Exists(thumbPath))
                    File.Delete(thumbPath);
            }
            catch (IOException)
            {
                // Dosya hâlâ kullanılıyorsa, bir saniye sonra tekrar dene
                System.Threading.Thread.Sleep(500);
                if (File.Exists(fullPath))
                    File.Delete(fullPath);
                if (File.Exists(thumbPath))
                    File.Delete(thumbPath);
            }
        }

        public static Image? GetProductThumbnail(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return null;
            string thumbPath = Path.Combine(ImageFolder, $"{Path.GetFileNameWithoutExtension(fileName)}_thumb{Path.GetExtension(fileName)}");
            if (File.Exists(thumbPath))
            {
                // Dosyayı kopyala, çünkü orijinal dosya silinebilir
                using (var fs = new FileStream(thumbPath, FileMode.Open, FileAccess.Read))
                {
                    return Image.FromStream(fs);
                }
            }
            return null;
        }

        private static void CreateThumbnail(string sourcePath, string destPath, int width, int height)
        {
            using (var srcImage = Image.FromFile(sourcePath))
            {
                using (var thumb = srcImage.GetThumbnailImage(width, height, null, IntPtr.Zero))
                {
                    thumb.Save(destPath, ImageFormat.Jpeg);
                }
            }
        }
    }
}
using Microsoft.AspNetCore.Http;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace technology_tp1.Models
{
    public class ItemImage
    {
        public int Id { get; set; }

        public byte[] Small { get; set; }

        public byte[] Medium { get; set; }

        public byte[] Full { get; set; }

        public string GetBase64Encoded(byte[] file)
        {
            string base64 = Convert.ToBase64String(file);
            return String.Format("data:image/gif;base64,{0}", base64);
        }

        public static byte[] ScaleImage(byte[] imageByte, int height, int width)
        {
            using (MemoryStream imageStream = new MemoryStream(imageByte))
            using (MemoryStream scaledImage = new MemoryStream())
            {
                Image image =
                    Image
                    .FromStream(imageStream)
                    .GetThumbnailImage(height,
                        width,
                        null,
                        IntPtr.Zero
                );
                image.Save(scaledImage, ImageFormat.Jpeg);
                return scaledImage.ToArray();
            }
        }

        public static byte[] ParseImage(IFormFile file)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                file.CopyTo(stream);
                return stream.ToArray();
            }
        }
    }
}

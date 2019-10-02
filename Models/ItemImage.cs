using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace technology_tp1.Models
{
    public class ItemImage
    {
        // Limits the maximum file size to 1mb
        public static int MAXIMUM_FILE_SIZE = 1000000;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [NotMapped]
        public byte[] SmallBlob
        {
            get => Convert.FromBase64String(Small);
            set
            {
                Small = Convert.ToBase64String(value);
            }
        }

        [NotMapped]
        public byte[] MediumBlob
        {
            get => Convert.FromBase64String(Medium);
            set
            {
                Medium = Convert.ToBase64String(value);
            }
        }

        [NotMapped]
        public byte[] FullBlob
        {
            get => Convert.FromBase64String(Full);
            set
            {
                Full = Convert.ToBase64String(value);
            }
        }

        [Required]
        public string Small { get; set; }

        [Required]
        public string Medium { get; set; }

        [Required]
        public string Full { get; set; }

        public string GetBase64Encoded(byte[] file)
        {
            string base64 = Convert.ToBase64String(file);
            return string.Format("data:image/gif;base64,{0}", base64);
        }

        public static byte[] ScaleImage(byte[] imageInBytes, int height, int width)
        {
            using (MemoryStream imageStream = new MemoryStream(imageInBytes))
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

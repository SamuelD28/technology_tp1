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

        public byte[] File { get; set; }

        public byte[] Thumbnail { get; set; }

        public string GetBase64Encoded(byte[] file)
        {
            string base64 = Convert.ToBase64String(file);
            return String.Format("data:image/gif;base64,{0}", base64);
        }

        public static byte[] ParseThumbnail(IFormFile file)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                Image thumbnail =
                    Image
                    .FromStream(stream)
                    .GetThumbnailImage(200,
                        200,
                        null,
                        IntPtr.Zero
                    );
                thumbnail.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }

        public static byte[] ParseImage(IFormFile file) { 
            using(MemoryStream stream = new MemoryStream()){
                return stream.ToArray();
            }
        }
    }
}

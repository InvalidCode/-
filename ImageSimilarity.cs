using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Image_similarity_algorithm
{
    class ImageSimilarity
    {

        /// <summary>
        /// 相似度比较
        /// </summary>
        /// <param name="map1">标准图</param>
        /// <param name="map2">欲比较图</param>
        public static float xsdsf(Bitmap map1, Bitmap map2, bool jc)
        {
            int width = map1.Width;
            int height = map1.Height;
            long argv = 0;
            Bitmap imag = new Bitmap(width, height);
            //转换大小
            // map1 = new Bitmap(Resize(map1, width, height));//未打包修改图片大小代码，自行转换，这里屏蔽
            // map2 = new Bitmap(Resize(map2, width, height));
            if (jc)
            {
                //灰度化
                // map1 = ToGray(map1);//未打包修改图片灰度化，自行转换，这里屏蔽
                // map2 = ToGray(map2);
                //二值化
                // map1 = ConvertTo1Bpp1(map1, "10");//未打包修改图片二值化代码，自行转换，这里屏蔽
                // map2 = ConvertTo1Bpp1(map2, "10");
            }
            //将两张图相同像素设置为0，不同像素设置为1
            for (int i = 0; i < map1.Width; i++)
            {
                for (int j = 0; j < map1.Height; j++)
                {
                    Color color1 = map1.GetPixel(i, j);
                    Color color2 = map2.GetPixel(i, j);
                    if (color1.B == color2.B)
                    {
                        imag.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        imag.SetPixel(i, j, Color.FromArgb(1, 1, 1));
                        argv++;
                    }
                }
            }
            long xsh = width * height;
            float butongb = (float)argv / xsh;
            return 1 - butongb;
        }


    }

}

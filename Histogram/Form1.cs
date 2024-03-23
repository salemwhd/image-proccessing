using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using openCV;

namespace Histogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IplImage image1;
        Bitmap bmp;

        private void originalPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void sharpButton_Click(object sender, EventArgs e)
        {
            if (originalPictureBox.Image is Bitmap originalImage)
            {
                int width = originalImage.Width;
                int height = originalImage.Height;

                if (width > 0 && height > 0)
                {
                    Bitmap sharpenedImage = new Bitmap(width, height);

                    for (int x = 1; x < width - 1; x++)
                    {
                        for (int y = 1; y < height - 1; y++)
                        {
                            Color sharpenedColor = ApplySharpenKernel(originalImage, x, y);
                            sharpenedImage.SetPixel(x, y, sharpenedColor);
                        }
                    }

                    processedPictureBox.Image = sharpenedImage;
                }
                else
                {
                    MessageBox.Show("Invalid image dimensions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid image or image format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color ApplySharpenKernel(Bitmap image, int x, int y)
        {
            int[,] sharpenKernel = {
        { 0, -1, 0 },
        { -1, 5, -1 },
        { 0, -1, 0 }
    };

            int kernelSize = 3;
            int offset = kernelSize / 2;

            int totalRed = 0;
            int totalGreen = 0;
            int totalBlue = 0;

            for (int i = 0; i < kernelSize; i++)
            {
                for (int j = 0; j < kernelSize; j++)
                {
                    Color pixelColor = image.GetPixel(x + i - offset, y + j - offset);

                    totalRed += pixelColor.R * sharpenKernel[i, j];
                    totalGreen += pixelColor.G * sharpenKernel[i, j];
                    totalBlue += pixelColor.B * sharpenKernel[i, j];
                }
            }

            // Clamp values to the valid range [0, 255]
            int sharpenedRed = Math.Max(0, Math.Min(255, totalRed));
            int sharpenedGreen = Math.Max(0, Math.Min(255, totalGreen));
            int sharpenedBlue = Math.Max(0, Math.Min(255, totalBlue));

            return Color.FromArgb(sharpenedRed, sharpenedGreen, sharpenedBlue);
        }

        private Color ApplyLaplacianFilter(Bitmap image, int x, int y)
        {
            // Laplacian filter coefficients
            int[,] filter = {
        { -1, -1, -1 },
        { -1,  8, -1 },
        { -1, -1, -1 }
    };

            int filterSize = 3;
            int offset = filterSize / 2;

            int totalRed = 0;
            int totalGreen = 0;
            int totalBlue = 0;

            for (int i = 0; i < filterSize; i++)
            {
                for (int j = 0; j < filterSize; j++)
                {
                    Color pixelColor = image.GetPixel(x + i - offset, y + j - offset);

                    totalRed += pixelColor.R * filter[i, j];
                    totalGreen += pixelColor.G * filter[i, j];
                    totalBlue += pixelColor.B * filter[i, j];
                }
            }

            // Clamp values to the valid range [0, 255]
            int sharpenedRed = Math.Max(0, Math.Min(255, totalRed));
            int sharpenedGreen = Math.Max(0, Math.Min(255, totalGreen));
            int sharpenedBlue = Math.Max(0, Math.Min(255, totalBlue));

            return Color.FromArgb(sharpenedRed, sharpenedGreen, sharpenedBlue);
        }

        private void showHistogramButton_Click(object sender, EventArgs e)
        {
            chart1.Series["Red"].Points.Clear();
            chart1.Series["Green"].Points.Clear();
            chart1.Series["Blue"].Points.Clear();

            Bitmap bmpImg = (Bitmap)originalPictureBox.Image;
            int width = bmpImg.Width;
            int hieght = bmpImg.Height;

            int[] ni_Red = new int[256];
            int[] ni_Green = new int[256];
            int[] ni_Blue = new int[256];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    ni_Red[pixelColor.R]++;
                    ni_Green[pixelColor.G]++;
                    ni_Blue[pixelColor.B]++;

                }
            }

            for (int i = 0; i < 256; i++)
            {
                chart1.Series["Red"].Points.AddY(ni_Red[i]);
                chart1.Series["Green"].Points.AddY(ni_Green[i]);
                chart1.Series["Blue"].Points.AddY(ni_Blue[i]);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp|All|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image1 = cvlib.CvLoadImage(openFileDialog1.FileName, cvlib.CV_LOAD_IMAGE_COLOR);
                CvSize size = new CvSize(originalPictureBox.Width, originalPictureBox.Height);
                IplImage resized_image = cvlib.CvCreateImage(size, image1.depth, image1.nChannels);
                cvlib.CvResize(ref image1, ref resized_image, cvlib.CV_INTER_LINEAR);
                originalPictureBox.Image = (Image)resized_image;
            }
        }

        private void histogramEqualizationButton_Click(object sender, EventArgs e)
        {
            chart2.Series["Red"].Points.Clear();
            chart2.Series["Green"].Points.Clear();
            chart2.Series["Blue"].Points.Clear();

            Bitmap bmpImg = (Bitmap)originalPictureBox.Image;
            int width = bmpImg.Width;
            int hieght = bmpImg.Height;

            int[] ni_Red = new int[256];
            int[] ni_Green = new int[256];
            int[] ni_Blue = new int[256];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    ni_Red[pixelColor.R]++;
                    ni_Green[pixelColor.G]++;
                    ni_Blue[pixelColor.B]++;

                }
            }

            for (int i = 0; i < 256; i++)
            {
                chart2.Series["Red"].Points.AddY(ni_Red[i]);
                chart2.Series["Green"].Points.AddY(ni_Green[i]);
                chart2.Series["Blue"].Points.AddY(ni_Blue[i]);
            }
        }


        private void equalizedImage_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = (Bitmap)image1;
            Bitmap newImage = bmpImg;
            int width = bmpImg.Width;
            int hieght = bmpImg.Height;


            //******************* Calculate N(i) **************//

            int[] ni_Red = new int[256];
            int[] ni_Green = new int[256];
            int[] ni_Blue = new int[256];


            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    ni_Red[pixelColor.R]++;
                    ni_Green[pixelColor.G]++;
                    ni_Blue[pixelColor.B]++;
                }
            }

            //******************* Calculate P(Ni) **************//
            decimal[] prob_ni_Red = new decimal[256];
            decimal[] prob_ni_Green = new decimal[256];
            decimal[] prob_ni_Blue = new decimal[256];

            for (int i = 0; i < 256; i++)
            {
                prob_ni_Red[i] = (decimal)ni_Red[i] / (decimal)(width * hieght);
                prob_ni_Green[i] = (decimal)ni_Green[i] / (decimal)(width * hieght);
                prob_ni_Blue[i] = (decimal)ni_Blue[i] / (decimal)(width * hieght);
            }

            //******************* Calculate CDF **************//

            decimal[] cdf_Red = new decimal[256];
            decimal[] cdf_Green = new decimal[256];
            decimal[] cdf_Blue = new decimal[256];

            cdf_Red[0] = prob_ni_Red[0];
            cdf_Green[0] = prob_ni_Green[0];
            cdf_Blue[0] = prob_ni_Blue[0];

            for (int i = 1; i < 256; i++)
            {
                cdf_Red[i] = prob_ni_Red[i] + cdf_Red[i - 1];
                cdf_Green[i] = prob_ni_Green[i] + cdf_Green[i - 1];
                cdf_Blue[i] = prob_ni_Blue[i] + cdf_Blue[i - 1];
            }


            //******************* Calculate CDF(L-1) **************//


            int red, green, blue;
            int constant = 255;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    red = (int)Math.Round(cdf_Red[pixelColor.R] * constant);
                    green = (int)Math.Round(cdf_Red[pixelColor.G] * constant);
                    blue = (int)Math.Round(cdf_Red[pixelColor.B] * constant);

                    Color newColor = Color.FromArgb(red, green, blue);
                    newImage.SetPixel(i, j, newColor);

                }
            }

            processedPictureBox.Image = (Image)newImage;
        }

        private void convertToGrayButton_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)image1;
            int width = bmp.Width;
            int height = bmp.Height;
            Color p;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int avg = (r + g + b) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));

                    processedPictureBox.Image = (Image)bmp;


                }

            }
        }

        private void red_Click(object sender, EventArgs e)
        {

            IplImage redImage = cvlib.CvCreateImage(new CvSize(image1.width, image1.height), image1.depth, image1.nChannels);

            unsafe
            {
                for (int r = 0; r < redImage.height; r++)
                {
                    for (int c = 0; c < redImage.width; c++)
                    {
                        byte* srcPixel = (byte*)(image1.imageData + r * image1.widthStep + c * image1.nChannels);
                        byte* dstPixel = (byte*)(redImage.imageData + r * redImage.widthStep + c * redImage.nChannels);

                        // Preserve only the red channel
                        dstPixel[0] = 0;   // Blue channel
                        dstPixel[1] = 0;   // Green channel
                        dstPixel[2] = srcPixel[2]; // Red channel
                    }
                }
            }

            CvSize size = new CvSize(processedPictureBox.Width, processedPictureBox.Height);
            IplImage resizedImage = cvlib.CvCreateImage(size, redImage.depth, redImage.nChannels);
            cvlib.CvResize(ref redImage, ref resizedImage, cvlib.CV_INTER_LINEAR);

            processedPictureBox.BackgroundImage = (Image)resizedImage;


        }

        private void green_Click(object sender, EventArgs e)
        {


            IplImage greenImage = cvlib.CvCreateImage(new CvSize(image1.width, image1.height), image1.depth, image1.nChannels);

            unsafe
            {
                for (int r = 0; r < greenImage.height; r++)
                {
                    for (int c = 0; c < greenImage.width; c++)
                    {
                        byte* srcPixel = (byte*)(image1.imageData + r * image1.widthStep + c * image1.nChannels);
                        byte* dstPixel = (byte*)(greenImage.imageData + r * greenImage.widthStep + c * greenImage.nChannels);

                        // Preserve only the green channel
                        dstPixel[0] = 0;   // Blue channel
                        dstPixel[1] = srcPixel[1]; // Green channel
                        dstPixel[2] = 0;   // Red channel
                    }
                }
            }

            CvSize size = new CvSize(processedPictureBox.Width, processedPictureBox.Height);
            IplImage resizedImage = cvlib.CvCreateImage(size, greenImage.depth, greenImage.nChannels);
            cvlib.CvResize(ref greenImage, ref resizedImage, cvlib.CV_INTER_LINEAR);

            processedPictureBox.BackgroundImage = (Image)resizedImage;



        }

        private void blue_Click(object sender, EventArgs e)
        {
           
                IplImage blueImage = cvlib.CvCreateImage(new CvSize(image1.width, image1.height), image1.depth, image1.nChannels);

                unsafe
                {
                    for (int r = 0; r < blueImage.height; r++)
                    {
                        for (int c = 0; c < blueImage.width; c++)
                        {
                            byte* srcPixel = (byte*)(image1.imageData + r * image1.widthStep + c * image1.nChannels);
                            byte* dstPixel = (byte*)(blueImage.imageData + r * blueImage.widthStep + c * blueImage.nChannels);

                            // Preserve only the blue channel
                            dstPixel[0] = srcPixel[0]; // Blue channel
                            dstPixel[1] = 0;   // Green channel
                            dstPixel[2] = 0;   // Red channel
                        }
                    }
                }

                CvSize size = new CvSize(processedPictureBox.Width, processedPictureBox.Height);
                IplImage resizedImage = cvlib.CvCreateImage(size, blueImage.depth, blueImage.nChannels);
                cvlib.CvResize(ref blueImage, ref resizedImage, cvlib.CV_INTER_LINEAR);

                processedPictureBox.BackgroundImage = (Image)resizedImage;
            
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            if (originalPictureBox.Image is Bitmap originalImage)
            {
                int width = originalImage.Width;
                int height = originalImage.Height;

                if (width > 0 && height > 0)
                {
                    Bitmap filteredImage = new Bitmap(width, height);

                    // Define the size of the minimum filter window (e.g., 3x3)
                    int filterSize = 5;

                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            // Apply minimum filter to each pixel
                            Color minColor = GetMinimumColor(originalImage, i, j, filterSize);
                            filteredImage.SetPixel(i, j, minColor);
                        }
                    }

                    processedPictureBox.Image = filteredImage;
                }
                else
                {
                    // Handle the case where the image dimensions are invalid
                    MessageBox.Show("Invalid image dimensions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle the case where processedPictureBox.Image is null or not a Bitmap
                MessageBox.Show("Invalid image or image format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      private  Color GetMinimumColor(Bitmap image, int x, int y, int filterSize)
        {
            int minX = Math.Max(0, x - filterSize / 2);
            int minY = Math.Max(0, y - filterSize / 2);
            int maxX = Math.Min(image.Width - 1, x + filterSize / 2);
            int maxY = Math.Min(image.Height - 1, y + filterSize / 2);

            Color minColor = Color.White;

            for (int i = minX; i <= maxX; i++)
            {
                for (int j = minY; j <= maxY; j++)
                {
                    Color pixelColor = image.GetPixel(i, j);

                    // Update minColor if the current pixel's intensity is smaller
                    minColor = Color.FromArgb(
                        Math.Min(minColor.R, pixelColor.R),
                        Math.Min(minColor.G, pixelColor.G),
                        Math.Min(minColor.B, pixelColor.B)
                    );
                }
            }

            return minColor;
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            if (originalPictureBox.Image is Bitmap originalImage)
            {
                int width = originalImage.Width;
                int height = originalImage.Height;

                if (width > 0 && height > 0)
                {
                    Bitmap filteredImage = new Bitmap(width, height);

                    // Define the size of the maximum filter window (e.g., 3x3)
                    int filterSize = 3;

                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            // Apply maximum filter to each pixel
                            Color maxColor = GetMaximumColor(originalImage, i, j, filterSize);
                            filteredImage.SetPixel(i, j, maxColor);
                        }
                    }

                    processedPictureBox.Image = filteredImage;
                }
                else
                {
                    // Handle the case where the image dimensions are invalid
                    MessageBox.Show("Invalid image dimensions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle the case where processedPictureBox.Image is null or not a Bitmap
                MessageBox.Show("Invalid image or image format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Color GetMaximumColor(Bitmap image, int x, int y, int filterSize)
        {
            int minX = Math.Max(0, x - filterSize / 2);
            int minY = Math.Max(0, y - filterSize / 2);
            int maxX = Math.Min(image.Width - 1, x + filterSize / 2);
            int maxY = Math.Min(image.Height - 1, y + filterSize / 2);

            Color maxColor = Color.Black; // Initialize with minimum intensity

            for (int i = minX; i <= maxX; i++)
            {
                for (int j = minY; j <= maxY; j++)
                {
                    Color pixelColor = image.GetPixel(i, j);

                    // Update maxColor if the current pixel's intensity is larger
                    maxColor = Color.FromArgb(
                        Math.Max(maxColor.R, pixelColor.R),
                        Math.Max(maxColor.G, pixelColor.G),
                        Math.Max(maxColor.B, pixelColor.B)
                    );
                }
            }

            return maxColor;
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            if (originalPictureBox.Image is Bitmap originalImage)
            {
                int width = originalImage.Width;
                int height = originalImage.Height;

                if (width > 0 && height > 0)
                {
                    Bitmap filteredImage = new Bitmap(width, height);

                    // Define the size of the average filter window (e.g., 3x3)
                    int filterSize = 3;

                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            // Apply average filter to each pixel
                            Color avgColor = GetAverageColor(originalImage, i, j, filterSize);
                            filteredImage.SetPixel(i, j, avgColor);
                        }
                    }

                    processedPictureBox.Image = filteredImage;
                }
                else
                {
                    // Handle the case where the image dimensions are invalid
                    MessageBox.Show("Invalid image dimensions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle the case where processedPictureBox.Image is null or not a Bitmap
                MessageBox.Show("Invalid image or image format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }
        private Color GetAverageColor(Bitmap image, int x, int y, int filterSize)
        {
            int minX = Math.Max(0, x - filterSize / 2);
            int minY = Math.Max(0, y - filterSize / 2);
            int maxX = Math.Min(image.Width - 1, x + filterSize / 2);
            int maxY = Math.Min(image.Height - 1, y + filterSize / 2);

            int totalPixels = 0;
            int totalRed = 0;
            int totalGreen = 0;
            int totalBlue = 0;

            for (int i = minX; i <= maxX; i++)
            {
                for (int j = minY; j <= maxY; j++)
                {
                    Color pixelColor = image.GetPixel(i, j);

                    totalPixels++;
                    totalRed += pixelColor.R;
                    totalGreen += pixelColor.G;
                    totalBlue += pixelColor.B;
                }
            }

            // Calculate the average color values
            int avgRed = totalRed / totalPixels;
            int avgGreen = totalGreen / totalPixels;
            int avgBlue = totalBlue / totalPixels;

            return Color.FromArgb(avgRed, avgGreen, avgBlue);
        }

        private void contrastButton_Click(object sender, EventArgs e)
        {
            if (originalPictureBox.Image is Bitmap originalImage)
            {
                int width = originalImage.Width;
                int height = originalImage.Height;

                if (width > 0 && height > 0)
                {
                    Bitmap contrastedImage = new Bitmap(width, height);

                    // Apply auto contrast adjustment to each pixel
                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            Color originalColor = originalImage.GetPixel(x, y);
                            Color adjustedColor = AdjustAutoContrast(originalColor);
                            contrastedImage.SetPixel(x, y, adjustedColor);
                        }
                    }

                    processedPictureBox.Image = contrastedImage;
                }
                else
                {
                    MessageBox.Show("Invalid image dimensions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid image or image format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color AdjustAutoContrast(Color originalColor)
        {
            // Simple heuristic for auto contrast adjustment
            float adjustmentFactor = 1.5f;

            int adjustedRed = (int)(originalColor.R * adjustmentFactor);
            int adjustedGreen = (int)(originalColor.G * adjustmentFactor);
            int adjustedBlue = (int)(originalColor.B * adjustmentFactor);

            // Clamp values to the valid range [0, 255]
            adjustedRed = Math.Max(0, Math.Min(255, adjustedRed));
            adjustedGreen = Math.Max(0, Math.Min(255, adjustedGreen));
            adjustedBlue = Math.Max(0, Math.Min(255, adjustedBlue));

            return Color.FromArgb(adjustedRed, adjustedGreen, adjustedBlue);
        }
    }
  }


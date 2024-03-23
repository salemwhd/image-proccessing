# Image proceessing Application

This application is developed using C# and Windows Forms to perform various image processing tasks, including histogram analysis, image enhancement, color channel manipulation, and filtering operations. It utilizes the OpenCV library for some image processing functionalities.

## Features

### Histogram Analysis
- **Show Histogram:** Generates and displays histograms for the red, green, and blue color channels of the loaded image.
- **Histogram Equalization:** Performs histogram equalization to enhance the contrast of the image.

### Image Enhancement
- **Sharpening:** Applies a sharpening filter to the loaded image.
- **Laplacian Filter:** Applies a Laplacian filter to enhance edges in the image.
- **Auto Contrast Adjustment:** Automatically adjusts the contrast of the image.

### Color Channel Manipulation
- **Convert to Grayscale:** Converts the image to grayscale.
- **Extract Color Channels:** Allows users to extract individual color channels (red, green, blue) from the image.

### Filtering Operations
- **Minimum Filter:** Applies a minimum filter to the image for noise reduction.
- **Maximum Filter:** Applies a maximum filter to the image for noise reduction.
- **Average Filter:** Applies an average filter to the image for smoothing.

## Usage

1. **Open Image:** Click the "Open" button to select an image file (supported formats: jpg, jpeg, png, gif, tif, bmp).
2. **Histogram Analysis:**
   - Click the "Show Histogram" button to display the histograms of the loaded image.
   - Click the "Histogram Equalization" button to perform histogram equalization.
3. **Image Enhancement:**
   - Use the "Sharpen" button to apply a sharpening filter to the image.
   - Use the "Laplacian Filter" button to enhance edges in the image.
   - Use the "Auto Contrast" button to automatically adjust the contrast of the image.
4. **Color Channel Manipulation:**
   - Click the "Convert to Gray" button to convert the image to grayscale.
   - Use the "Red", "Green", and "Blue" buttons to extract individual color channels.
5. **Filtering Operations:**
   - Use the "Minimum Filter", "Maximum Filter", and "Average Filter" buttons to apply respective filters to the image.

## Dependencies

- **OpenCV:** The application uses the OpenCV library for image processing functionalities. Ensure that the OpenCV library is properly installed and configured in the project.

## Note

- This application is intended for educational purposes and may require additional error handling and optimizations for production use.



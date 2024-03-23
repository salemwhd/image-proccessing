namespace Histogram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.processedPictureBox = new System.Windows.Forms.PictureBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contrastButton = new System.Windows.Forms.Button();
            this.sharpButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.histogramEqualizationButton = new System.Windows.Forms.Button();
            this.showHistogramButton = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.convertToGrayButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.equalizedImage = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Location = new System.Drawing.Point(13, 32);
            this.originalPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(349, 210);
            this.originalPictureBox.TabIndex = 1;
            this.originalPictureBox.TabStop = false;
            this.originalPictureBox.Click += new System.EventHandler(this.originalPictureBox_Click);
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(617, 430);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series25.ChartArea = "ChartArea1";
            series25.Color = System.Drawing.Color.Red;
            series25.Legend = "Legend1";
            series25.Name = "Red";
            series26.ChartArea = "ChartArea1";
            series26.Color = System.Drawing.Color.Green;
            series26.Legend = "Legend1";
            series26.Name = "Green";
            series27.ChartArea = "ChartArea1";
            series27.Color = System.Drawing.Color.Blue;
            series27.Legend = "Legend1";
            series27.Name = "Blue";
            this.chart1.Series.Add(series25);
            this.chart1.Series.Add(series26);
            this.chart1.Series.Add(series27);
            this.chart1.Size = new System.Drawing.Size(292, 167);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // processedPictureBox
            // 
            this.processedPictureBox.Location = new System.Drawing.Point(418, 32);
            this.processedPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.processedPictureBox.Name = "processedPictureBox";
            this.processedPictureBox.Size = new System.Drawing.Size(382, 210);
            this.processedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedPictureBox.TabIndex = 3;
            this.processedPictureBox.TabStop = false;
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(617, 253);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series28.ChartArea = "ChartArea1";
            series28.Color = System.Drawing.Color.Red;
            series28.Legend = "Legend1";
            series28.Name = "Red";
            series29.ChartArea = "ChartArea1";
            series29.Color = System.Drawing.Color.Green;
            series29.Legend = "Legend1";
            series29.Name = "Green";
            series30.ChartArea = "ChartArea1";
            series30.Color = System.Drawing.Color.Blue;
            series30.Legend = "Legend1";
            series30.Name = "Blue";
            this.chart2.Series.Add(series28);
            this.chart2.Series.Add(series29);
            this.chart2.Series.Add(series30);
            this.chart2.Size = new System.Drawing.Size(292, 169);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            // 
            // contrastButton
            // 
            this.contrastButton.Location = new System.Drawing.Point(486, 517);
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Size = new System.Drawing.Size(94, 46);
            this.contrastButton.TabIndex = 21;
            this.contrastButton.Text = "Contrast";
            this.contrastButton.UseVisualStyleBackColor = true;
            this.contrastButton.Click += new System.EventHandler(this.contrastButton_Click);
            // 
            // sharpButton
            // 
            this.sharpButton.Location = new System.Drawing.Point(365, 517);
            this.sharpButton.Name = "sharpButton";
            this.sharpButton.Size = new System.Drawing.Size(102, 52);
            this.sharpButton.TabIndex = 20;
            this.sharpButton.Text = "sharp";
            this.sharpButton.UseVisualStyleBackColor = true;
            this.sharpButton.Click += new System.EventHandler(this.sharpButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(251, 517);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(96, 52);
            this.averageButton.TabIndex = 19;
            this.averageButton.Text = "Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(133, 517);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(99, 52);
            this.maxButton.TabIndex = 18;
            this.maxButton.Text = "MAX";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(13, 517);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(97, 52);
            this.minButton.TabIndex = 17;
            this.minButton.Text = "MIN";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // histogramEqualizationButton
            // 
            this.histogramEqualizationButton.Location = new System.Drawing.Point(180, 386);
            this.histogramEqualizationButton.Name = "histogramEqualizationButton";
            this.histogramEqualizationButton.Size = new System.Drawing.Size(118, 75);
            this.histogramEqualizationButton.TabIndex = 16;
            this.histogramEqualizationButton.Text = "histogram Equalization";
            this.histogramEqualizationButton.UseVisualStyleBackColor = true;
            this.histogramEqualizationButton.Click += new System.EventHandler(this.histogramEqualizationButton_Click);
            // 
            // showHistogramButton
            // 
            this.showHistogramButton.Location = new System.Drawing.Point(25, 386);
            this.showHistogramButton.Name = "showHistogramButton";
            this.showHistogramButton.Size = new System.Drawing.Size(118, 75);
            this.showHistogramButton.TabIndex = 15;
            this.showHistogramButton.Text = "show Histogram";
            this.showHistogramButton.UseVisualStyleBackColor = true;
            this.showHistogramButton.Click += new System.EventHandler(this.showHistogramButton_Click);
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(305, 290);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(85, 51);
            this.red.TabIndex = 14;
            this.red.Text = "convert To Red";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // convertToGrayButton
            // 
            this.convertToGrayButton.Location = new System.Drawing.Point(163, 278);
            this.convertToGrayButton.Name = "convertToGrayButton";
            this.convertToGrayButton.Size = new System.Drawing.Size(118, 75);
            this.convertToGrayButton.TabIndex = 13;
            this.convertToGrayButton.Text = "convert To Gray";
            this.convertToGrayButton.UseVisualStyleBackColor = true;
            this.convertToGrayButton.Click += new System.EventHandler(this.convertToGrayButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(25, 278);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(118, 75);
            this.openButton.TabIndex = 12;
            this.openButton.Text = "open Image";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // equalizedImage
            // 
            this.equalizedImage.Location = new System.Drawing.Point(329, 386);
            this.equalizedImage.Name = "equalizedImage";
            this.equalizedImage.Size = new System.Drawing.Size(118, 75);
            this.equalizedImage.TabIndex = 22;
            this.equalizedImage.Text = "image Equalization";
            this.equalizedImage.UseVisualStyleBackColor = true;
            this.equalizedImage.Click += new System.EventHandler(this.equalizedImage_Click);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(418, 293);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(83, 48);
            this.green.TabIndex = 23;
            this.green.Text = "convert To Green";
            this.green.UseVisualStyleBackColor = true;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(516, 293);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(94, 48);
            this.blue.TabIndex = 24;
            this.blue.Text = "convert To Blue";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 612);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.equalizedImage);
            this.Controls.Add(this.contrastButton);
            this.Controls.Add(this.sharpButton);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.histogramEqualizationButton);
            this.Controls.Add(this.showHistogramButton);
            this.Controls.Add(this.red);
            this.Controls.Add(this.convertToGrayButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.processedPictureBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.originalPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox processedPictureBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button contrastButton;
        private System.Windows.Forms.Button sharpButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button histogramEqualizationButton;
        private System.Windows.Forms.Button showHistogramButton;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button convertToGrayButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button equalizedImage;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button blue;
    }
}


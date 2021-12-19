namespace mic
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
            this.stereoAudioWavePainter1 = new NAudio_Plotting.StereoAudioWavePainter();
            this.SuspendLayout();
            // 
            // stereoAudioWavePainter1
            // 
            this.stereoAudioWavePainter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stereoAudioWavePainter1.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            this.stereoAudioWavePainter1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.stereoAudioWavePainter1.DrawMode = NAudio_Plotting.StereoAudioWavePainter.DisplayMode.Point;
            this.stereoAudioWavePainter1.ForeColor = System.Drawing.Color.LawnGreen;
            this.stereoAudioWavePainter1.Gradient = true;
            this.stereoAudioWavePainter1.GradientColor = System.Drawing.Color.Lime;
            this.stereoAudioWavePainter1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.stereoAudioWavePainter1.Location = new System.Drawing.Point(12, 12);
            this.stereoAudioWavePainter1.MiddleLineColor = System.Drawing.Color.Green;
            this.stereoAudioWavePainter1.Name = "stereoAudioWavePainter1";
            this.stereoAudioWavePainter1.Pinch = NAudio_Plotting.StereoAudioWavePainter.PinchMode.None;
            this.stereoAudioWavePainter1.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.stereoAudioWavePainter1.Plot = NAudio_Plotting.StereoAudioWavePainter.Plotmode.PlusMinus;
            this.stereoAudioWavePainter1.QualityMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.stereoAudioWavePainter1.ShowMidLine = false;
            this.stereoAudioWavePainter1.Size = new System.Drawing.Size(1240, 570);
            this.stereoAudioWavePainter1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 594);
            this.Controls.Add(this.stereoAudioWavePainter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NAudio_Plotting.StereoAudioWavePainter stereoAudioWavePainter1;
    }
}


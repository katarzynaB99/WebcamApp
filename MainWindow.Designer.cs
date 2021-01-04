namespace WebcamApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.cameraOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.cameraImageBox = new System.Windows.Forms.PictureBox();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.videoFrameRateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.snapshotFormatLabel = new System.Windows.Forms.Label();
            this.snapshotFileFormatComboBox = new System.Windows.Forms.ComboBox();
            this.connectToCameraButton = new System.Windows.Forms.Button();
            this.videoResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.recordingActiveIconPictureBox = new System.Windows.Forms.PictureBox();
            this.recordingTimeLabel = new System.Windows.Forms.Label();
            this.refreshCameraSettingsButton = new System.Windows.Forms.Button();
            this.stopRecordingButton = new System.Windows.Forms.Button();
            this.startRecordingButton = new System.Windows.Forms.Button();
            this.captureFrameButton = new System.Windows.Forms.Button();
            this.capturedSnapshotGroupBox = new System.Windows.Forms.GroupBox();
            this.capturedSnapshotPictureBox = new System.Windows.Forms.PictureBox();
            this.cameraOutputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraImageBox)).BeginInit();
            this.configurationGroupBox.SuspendLayout();
            this.controlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingActiveIconPictureBox)).BeginInit();
            this.capturedSnapshotGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturedSnapshotPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraOutputGroupBox
            // 
            this.cameraOutputGroupBox.Controls.Add(this.cameraImageBox);
            this.cameraOutputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.cameraOutputGroupBox.Name = "cameraOutputGroupBox";
            this.cameraOutputGroupBox.Size = new System.Drawing.Size(578, 343);
            this.cameraOutputGroupBox.TabIndex = 0;
            this.cameraOutputGroupBox.TabStop = false;
            this.cameraOutputGroupBox.Text = "Camera Output";
            // 
            // cameraImageBox
            // 
            this.cameraImageBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cameraImageBox.Location = new System.Drawing.Point(6, 19);
            this.cameraImageBox.Name = "cameraImageBox";
            this.cameraImageBox.Size = new System.Drawing.Size(565, 318);
            this.cameraImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraImageBox.TabIndex = 2;
            this.cameraImageBox.TabStop = false;
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Controls.Add(this.videoFrameRateComboBox);
            this.configurationGroupBox.Controls.Add(this.label1);
            this.configurationGroupBox.Controls.Add(this.snapshotFormatLabel);
            this.configurationGroupBox.Controls.Add(this.snapshotFileFormatComboBox);
            this.configurationGroupBox.Controls.Add(this.connectToCameraButton);
            this.configurationGroupBox.Controls.Add(this.videoResolutionComboBox);
            this.configurationGroupBox.Controls.Add(this.ResolutionLabel);
            this.configurationGroupBox.Controls.Add(this.deviceComboBox);
            this.configurationGroupBox.Controls.Add(this.deviceLabel);
            this.configurationGroupBox.Location = new System.Drawing.Point(596, 12);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(240, 183);
            this.configurationGroupBox.TabIndex = 1;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Configuration";
            // 
            // videoFrameRateComboBox
            // 
            this.videoFrameRateComboBox.FormattingEnabled = true;
            this.videoFrameRateComboBox.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.videoFrameRateComboBox.Location = new System.Drawing.Point(9, 152);
            this.videoFrameRateComboBox.Name = "videoFrameRateComboBox";
            this.videoFrameRateComboBox.Size = new System.Drawing.Size(225, 21);
            this.videoFrameRateComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Video Frame Rate";
            // 
            // snapshotFormatLabel
            // 
            this.snapshotFormatLabel.AutoSize = true;
            this.snapshotFormatLabel.Location = new System.Drawing.Point(6, 56);
            this.snapshotFormatLabel.Name = "snapshotFormatLabel";
            this.snapshotFormatLabel.Size = new System.Drawing.Size(87, 13);
            this.snapshotFormatLabel.TabIndex = 3;
            this.snapshotFormatLabel.Text = "Snapshot Format";
            // 
            // snapshotFileFormatComboBox
            // 
            this.snapshotFileFormatComboBox.FormattingEnabled = true;
            this.snapshotFileFormatComboBox.Items.AddRange(new object[] {
            "JPEG",
            "PNG",
            "BMP",
            "GIF",
            "TIFF"});
            this.snapshotFileFormatComboBox.Location = new System.Drawing.Point(9, 72);
            this.snapshotFileFormatComboBox.Name = "snapshotFileFormatComboBox";
            this.snapshotFileFormatComboBox.Size = new System.Drawing.Size(225, 21);
            this.snapshotFileFormatComboBox.TabIndex = 4;
            // 
            // connectToCameraButton
            // 
            this.connectToCameraButton.Location = new System.Drawing.Point(159, 32);
            this.connectToCameraButton.Name = "connectToCameraButton";
            this.connectToCameraButton.Size = new System.Drawing.Size(75, 21);
            this.connectToCameraButton.TabIndex = 3;
            this.connectToCameraButton.Text = "Connect";
            this.connectToCameraButton.UseVisualStyleBackColor = true;
            this.connectToCameraButton.Click += new System.EventHandler(this.connectToCameraButton_Click);
            // 
            // videoResolutionComboBox
            // 
            this.videoResolutionComboBox.FormattingEnabled = true;
            this.videoResolutionComboBox.Items.AddRange(new object[] {
            "1280x720",
            "320x180",
            "320x240",
            "352x288",
            "424x240",
            "640x360",
            "640x480",
            "848x480",
            "960x540"});
            this.videoResolutionComboBox.Location = new System.Drawing.Point(9, 112);
            this.videoResolutionComboBox.Name = "videoResolutionComboBox";
            this.videoResolutionComboBox.Size = new System.Drawing.Size(225, 21);
            this.videoResolutionComboBox.TabIndex = 3;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(6, 96);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(57, 13);
            this.ResolutionLabel.TabIndex = 2;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(9, 32);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(144, 21);
            this.deviceComboBox.TabIndex = 1;
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Location = new System.Drawing.Point(6, 16);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(41, 13);
            this.deviceLabel.TabIndex = 0;
            this.deviceLabel.Text = "Device";
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.recordingActiveIconPictureBox);
            this.controlsGroupBox.Controls.Add(this.recordingTimeLabel);
            this.controlsGroupBox.Controls.Add(this.refreshCameraSettingsButton);
            this.controlsGroupBox.Controls.Add(this.stopRecordingButton);
            this.controlsGroupBox.Controls.Add(this.startRecordingButton);
            this.controlsGroupBox.Controls.Add(this.captureFrameButton);
            this.controlsGroupBox.Location = new System.Drawing.Point(12, 361);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(824, 52);
            this.controlsGroupBox.TabIndex = 2;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            // 
            // recordingActiveIconPictureBox
            // 
            this.recordingActiveIconPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recordingActiveIconPictureBox.BackgroundImage")));
            this.recordingActiveIconPictureBox.Location = new System.Drawing.Point(732, 20);
            this.recordingActiveIconPictureBox.Name = "recordingActiveIconPictureBox";
            this.recordingActiveIconPictureBox.Size = new System.Drawing.Size(20, 20);
            this.recordingActiveIconPictureBox.TabIndex = 9;
            this.recordingActiveIconPictureBox.TabStop = false;
            this.recordingActiveIconPictureBox.Visible = false;
            // 
            // recordingTimeLabel
            // 
            this.recordingTimeLabel.AutoSize = true;
            this.recordingTimeLabel.Location = new System.Drawing.Point(758, 24);
            this.recordingTimeLabel.Name = "recordingTimeLabel";
            this.recordingTimeLabel.Size = new System.Drawing.Size(56, 13);
            this.recordingTimeLabel.TabIndex = 8;
            this.recordingTimeLabel.Text = "Recording";
            this.recordingTimeLabel.Visible = false;
            // 
            // refreshCameraSettingsButton
            // 
            this.refreshCameraSettingsButton.Location = new System.Drawing.Point(352, 19);
            this.refreshCameraSettingsButton.Name = "refreshCameraSettingsButton";
            this.refreshCameraSettingsButton.Size = new System.Drawing.Size(141, 23);
            this.refreshCameraSettingsButton.TabIndex = 7;
            this.refreshCameraSettingsButton.Text = "Refresh camera settings";
            this.refreshCameraSettingsButton.UseVisualStyleBackColor = true;
            this.refreshCameraSettingsButton.Click += new System.EventHandler(this.refreshCameraSettingsButton_Click);
            // 
            // stopRecordingButton
            // 
            this.stopRecordingButton.Location = new System.Drawing.Point(243, 19);
            this.stopRecordingButton.Name = "stopRecordingButton";
            this.stopRecordingButton.Size = new System.Drawing.Size(103, 23);
            this.stopRecordingButton.TabIndex = 2;
            this.stopRecordingButton.Text = "Stop Recording";
            this.stopRecordingButton.UseVisualStyleBackColor = true;
            this.stopRecordingButton.Click += new System.EventHandler(this.stopRecordingButton_Click);
            // 
            // startRecordingButton
            // 
            this.startRecordingButton.Location = new System.Drawing.Point(129, 19);
            this.startRecordingButton.Name = "startRecordingButton";
            this.startRecordingButton.Size = new System.Drawing.Size(108, 23);
            this.startRecordingButton.TabIndex = 1;
            this.startRecordingButton.Text = "Start Recording";
            this.startRecordingButton.UseVisualStyleBackColor = true;
            this.startRecordingButton.Click += new System.EventHandler(this.startRecordingButton_Click);
            // 
            // captureFrameButton
            // 
            this.captureFrameButton.Location = new System.Drawing.Point(18, 19);
            this.captureFrameButton.Name = "captureFrameButton";
            this.captureFrameButton.Size = new System.Drawing.Size(105, 23);
            this.captureFrameButton.TabIndex = 0;
            this.captureFrameButton.Text = "Capture Frame";
            this.captureFrameButton.UseVisualStyleBackColor = true;
            this.captureFrameButton.Click += new System.EventHandler(this.captureFrameButton_Click);
            // 
            // capturedSnapshotGroupBox
            // 
            this.capturedSnapshotGroupBox.Controls.Add(this.capturedSnapshotPictureBox);
            this.capturedSnapshotGroupBox.Location = new System.Drawing.Point(596, 201);
            this.capturedSnapshotGroupBox.Name = "capturedSnapshotGroupBox";
            this.capturedSnapshotGroupBox.Size = new System.Drawing.Size(240, 154);
            this.capturedSnapshotGroupBox.TabIndex = 3;
            this.capturedSnapshotGroupBox.TabStop = false;
            this.capturedSnapshotGroupBox.Text = "Captured Snapshot";
            // 
            // capturedSnapshotPictureBox
            // 
            this.capturedSnapshotPictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.capturedSnapshotPictureBox.Location = new System.Drawing.Point(6, 19);
            this.capturedSnapshotPictureBox.Name = "capturedSnapshotPictureBox";
            this.capturedSnapshotPictureBox.Size = new System.Drawing.Size(228, 129);
            this.capturedSnapshotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capturedSnapshotPictureBox.TabIndex = 0;
            this.capturedSnapshotPictureBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 449);
            this.Controls.Add(this.capturedSnapshotGroupBox);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.cameraOutputGroupBox);
            this.Name = "MainWindow";
            this.Text = " Webcam App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.cameraOutputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cameraImageBox)).EndInit();
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingActiveIconPictureBox)).EndInit();
            this.capturedSnapshotGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.capturedSnapshotPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cameraOutputGroupBox;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.PictureBox cameraImageBox;
        private System.Windows.Forms.ComboBox videoResolutionComboBox;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Button connectToCameraButton;
        private System.Windows.Forms.Button captureFrameButton;
        private System.Windows.Forms.Label snapshotFormatLabel;
        private System.Windows.Forms.ComboBox snapshotFileFormatComboBox;
        private System.Windows.Forms.GroupBox capturedSnapshotGroupBox;
        private System.Windows.Forms.PictureBox capturedSnapshotPictureBox;
        private System.Windows.Forms.Button stopRecordingButton;
        private System.Windows.Forms.Button startRecordingButton;
        private System.Windows.Forms.ComboBox videoFrameRateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshCameraSettingsButton;
        private System.Windows.Forms.PictureBox recordingActiveIconPictureBox;
        private System.Windows.Forms.Label recordingTimeLabel;
    }
}


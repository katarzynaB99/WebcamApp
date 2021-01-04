using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using Accord.Video.FFMPEG;
using AForge.Video;
using AForge.Video.DirectShow;


namespace WebcamApp
{
    public partial class MainWindow : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        private VideoFileWriter fileWriter;
        private bool recording = false;
        private DateTime? _firstFrameTime;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
            {
                deviceComboBox.Items.Add(device.Name);
            }

            deviceComboBox.SelectedIndex = 0;
            snapshotFileFormatComboBox.SelectedIndex = 0;
            videoResolutionComboBox.SelectedIndex = 0;
            videoFrameRateComboBox.SelectedIndex = 2;
            FinalFrame = new VideoCaptureDevice();
        }

        private void connectToCameraButton_Click(object sender, EventArgs e)
        {
            SetCameraSettings();
            StartCamera();
        }

        private void SetCameraSettings()
        {
            
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (recording)
                {
                    using (var bitmap = (Bitmap) eventArgs.Frame.Clone())
                    {
                        if (_firstFrameTime != null)
                        {
                            fileWriter.WriteVideoFrame(bitmap,
                                DateTime.Now - _firstFrameTime.Value);
                            
                        }
                        else
                        {
                            fileWriter.WriteVideoFrame(bitmap);
                            _firstFrameTime = DateTime.Now;
                        }

                    }
                }

                using (var bitmap = (Bitmap) eventArgs.Frame.Clone())
                {
                    cameraImageBox.Image = (Bitmap) bitmap.Clone();
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show("Error on FinalFrame_NewFrame:\n" + e.Message, "Error",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //StopCamera();
            }
        }

        private void StartCamera()
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[deviceComboBox.SelectedIndex].MonikerString);
            FinalFrame.VideoResolution = SelectResolution(FinalFrame);
            FinalFrame.SnapshotResolution = SelectResolution(FinalFrame);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            
            FinalFrame.Start();
        }

        private VideoCapabilities SelectResolution(VideoCaptureDevice device)
        {
            foreach (var cap in device.VideoCapabilities)
            {
                if (cap.FrameSize.Height == getHeight() && cap.FrameSize.Width == getWidth())
                {
                    return cap;
                }
            }

            return device.VideoCapabilities.Last();
        }

        private void StopCamera()
        {
            if (FinalFrame.IsRunning)
            {
                FinalFrame.Stop();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void captureFrameButton_Click(object sender, EventArgs e)
        {
            if (cameraImageBox.Image != null)
            {
                switch (snapshotFileFormatComboBox.SelectedIndex)
                {
                    case 0:
                        //JPEG
                        cameraImageBox.Image.Save(@"snapshot.jpeg", ImageFormat.Jpeg);
                        break;
                    case 1:
                        //PNG
                        cameraImageBox.Image.Save(@"snapshot.png", ImageFormat.Png);
                        break;
                    case 2:
                        //BMP
                        cameraImageBox.Image.Save(@"snapshot.bmp", ImageFormat.Bmp);
                        break;
                    case 3:
                        //GIF
                        cameraImageBox.Image.Save(@"snapshot.gif", ImageFormat.Gif);
                        break;
                    case 4:
                        //TIFF
                        cameraImageBox.Image.Save(@"snapshot.tiff", ImageFormat.Tiff);
                        break;
                    default:
                        cameraImageBox.Image.Save(@"snapshot.jpeg", ImageFormat.Jpeg);
                        break;
                }

                capturedSnapshotPictureBox.Image = (Bitmap) cameraImageBox.Image.Clone();
            }
        }

        private void startRecordingButton_Click(object sender, EventArgs e)
        {
            //int width = getWidth();
            //int height = getHeight();
            int width = FinalFrame.VideoResolution.FrameSize.Width;
            int height = FinalFrame.VideoResolution.FrameSize.Height;
            int frameRate = getVideoFrameRate();
            var dialog = new SaveFileDialog();
            dialog.FileName = "video";
            dialog.DefaultExt = ".avi";
            dialog.AddExtension = true;
            var dialogResult = dialog.ShowDialog();
            if (dialogResult.Equals(true))
            {
                return;
            }
            fileWriter = new VideoFileWriter();
            fileWriter.Open(dialog.FileName, width, height, frameRate);
            recording = true;
            recordingActiveIconPictureBox.Visible = true;
            recordingTimeLabel.Visible = true;
        }

        private void stopRecordingButton_Click(object sender, EventArgs e)
        {
            recording = false;
            recordingActiveIconPictureBox.Visible = false;
            recordingTimeLabel.Visible = false;
            _firstFrameTime = null;
            fileWriter.Close();
            fileWriter.Dispose();
        }

        private int getWidth()
        {
            int width = 0;
            switch (videoResolutionComboBox.SelectedIndex)
            {
                case 0:
                    width = 1280;
                    break;
                case 1:
                    width = 320;
                    break;
                case 2:
                    width = 320;
                    break;
                case 3:
                    width = 352;
                    break;
                case 4:
                    width = 424;
                    break;
                case 5:
                    width = 640;
                    break;
                case 6:
                    width = 640;
                    break;
                case 7:
                    width = 848;
                    break;
                case 8:
                    width = 960;
                    break;
            }

            return width;
        }

        private int getHeight()
        {
            int height = 0;
            switch (videoResolutionComboBox.SelectedIndex)
            {
                case 0:
                    height = 720;
                    break;
                case 1:
                    height = 180;
                    break;
                case 2:
                    height = 240;
                    break;
                case 3:
                    height = 288;
                    break;
                case 4:
                    height = 240;
                    break;
                case 5:
                    height = 360;
                    break;
                case 6:
                    height = 480;
                    break;
                case 7:
                    height = 480;
                    break;
                case 8:
                    height = 540;
                    break;
            }

            return height;
        }

        private int getVideoFrameRate()
        {
            int frameRate = 0;
            switch (videoFrameRateComboBox.SelectedIndex)
            {
                case 0:
                    frameRate = 10;
                    break;
                case 1:
                    frameRate = 15;
                    break;
                case 2:
                    frameRate = 20;
                    break;
                case 3:
                    frameRate = 25;
                    break;
                case 4:
                    frameRate = 30;
                    break;
            }

            return frameRate;
        }

        private void refreshCameraSettingsButton_Click(object sender, EventArgs e)
        {
            StopCamera();
            StartCamera();
        }
    }
}

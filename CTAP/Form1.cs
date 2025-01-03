using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CTAP
{
    public partial class Form1 : Form
    {
        private Process ffmpegProcess;
        private Process ffmpegProcess1;
        private Process ffmpegProcess2;
        private Process ffmpegProcess3;

        private bool isStreaming = false;
        private bool isStreaming1 = false;
        private bool isStreaming2 = false;
        private bool isStreaming3 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartStream()
        {
            StartStream(ref ffmpegProcess, ref ffmpegProcess1, ref ffmpegProcess2, ref ffmpegProcess3);
            //StartStreamOne(ref ffmpegProcess);
            //StartStreamTwo(ref ffmpegProcess1);
            //StartStreamThree(ref ffmpegProcess2);
            //StartStreamFour(ref ffmpegProcess3);
        }

        private void btnStopStream_Click(object sender, EventArgs e)
        {
            StopStream(ffmpegProcess, 1);
            picBoxOne.Image = null; // Clear PictureBox

            StopStream(ffmpegProcess1, 2);
            picBoxTwo.Image = null;

            StopStream(ffmpegProcess2, 3);
            picBox3.Image = null;

            StopStream(ffmpegProcess3, 4);
            picBox4.Image = null;
        }

        //--------------- testing multiple inputs simultaneously
        private void StartStream(ref Process ffmpegProcess, ref Process ffmpegProcessTwo, ref Process ffmpegProcessThree, ref Process ffmpegProcessFour)
        {
            string ffmpegPath = @"C:\Users\Ali Saeed\Source\Repos\CTAP\CTAP\ffmpeg\bin\ffmpeg.exe";

            string arguments = $"-f dshow -i video=\"Integrated Camera\" -vf scale=640:480 -vcodec rawvideo -pix_fmt bgr24 -f rawvideo pipe:1";

            ffmpegProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            ffmpegProcess.Start();
            isStreaming = true;
            Task.Run(() => ReadFramesOne(picBoxOne));
            //Asad's phone
            string argumentsTwo = $"-f dshow -i video=\"Android Webcam\" -vf scale=640:480 -vcodec rawvideo -pix_fmt bgr24 -f rawvideo pipe:1";

            ffmpegProcessTwo = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = argumentsTwo,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            
            ffmpegProcessTwo.Start();
            isStreaming1 = true;            
            Task.Run(() => ReadFramesTwo(picBoxTwo));

            //Third Camera details
            string argumentsThree = $"-f dshow -i video=\"Android Webcam\" -vf scale=640:480 -vcodec rawvideo -pix_fmt bgr24 -f rawvideo pipe:1";

            ffmpegProcessThree = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = argumentsThree,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };


            ffmpegProcessThree.Start();
            isStreaming2 = true;
            Task.Run(() => ReadFramesThree(picBox3));

            //Fourth Camera details
            string argumentsFour = $"-f dshow -i video=\"Android Webcam\" -vf scale=640:480 -vcodec rawvideo -pix_fmt bgr24 -f rawvideo pipe:1";

            ffmpegProcessFour = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = argumentsFour,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };


            ffmpegProcessFour.Start();
            isStreaming3 = true;
            Task.Run(() => ReadFramesFour(picBox4));
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            StartStream();
        }

        private void ReadFramesOne(PictureBox pictureBox)
        {
            int width = 640;
            int height = 480;
            int frameSize = width * height * 3;
            byte[] frameBuffer = new byte[frameSize];
            byte[] chunkBuffer = new byte[4096];
            int bytesAccumulated = 0;

            using (Stream outputStream = ffmpegProcess.StandardOutput.BaseStream)
            {
                while (isStreaming)
                {
                    try
                    {
                        int bytesRead = outputStream.Read(chunkBuffer, 0, chunkBuffer.Length);
                        if (bytesRead <= 0) break;

                        Array.Copy(chunkBuffer, 0, frameBuffer, bytesAccumulated, bytesRead);
                        bytesAccumulated += bytesRead;

                        if (bytesAccumulated >= frameSize)
                        {
                            using (Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb))
                            {
                                var bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                                System.Runtime.InteropServices.Marshal.Copy(frameBuffer, 0, bmpData.Scan0, frameSize);
                                bitmap.UnlockBits(bmpData);

                                pictureBox.Invoke((MethodInvoker)(() =>
                                {
                                    pictureBox.Image?.Dispose();
                                    pictureBox.Image = new Bitmap(bitmap);
                                }));
                            }

                            bytesAccumulated = 0; // Reset buffer for the next frame
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        //Console.WriteLine($"Error: {ex.Message}");
                        StopStream(ffmpegProcess, 1);
                    }
                }
            }
        }

        private void ReadFramesTwo(PictureBox pictureBox)
        {
            int width = 640;
            int height = 480;
            int frameSize = width * height * 3;
            byte[] frameBuffer = new byte[frameSize];
            byte[] chunkBuffer = new byte[4096];
            int bytesAccumulated = 0;

            using (Stream outputStream = ffmpegProcess1.StandardOutput.BaseStream)
            {
                while (isStreaming1)
                {
                    try
                    {
                        int bytesRead = outputStream.Read(chunkBuffer, 0, chunkBuffer.Length);
                        if (bytesRead <= 0) break;

                        Array.Copy(chunkBuffer, 0, frameBuffer, bytesAccumulated, bytesRead);
                        bytesAccumulated += bytesRead;

                        if (bytesAccumulated >= frameSize)
                        {
                            using (Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb))
                            {
                                var bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                                System.Runtime.InteropServices.Marshal.Copy(frameBuffer, 0, bmpData.Scan0, frameSize);
                                bitmap.UnlockBits(bmpData);

                                pictureBox.Invoke((MethodInvoker)(() =>
                                {
                                    pictureBox.Image?.Dispose();
                                    pictureBox.Image = new Bitmap(bitmap);
                                }));
                            }

                            bytesAccumulated = 0; // Reset buffer for the next frame
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        //Console.WriteLine($"Error: {ex.Message}");
                        StopStream(ffmpegProcess1, 2);
                    }
                }
            }
        }

        private void ReadFramesThree(PictureBox pictureBox)
        {
            int width = 640;
            int height = 480;
            int frameSize = width * height * 3;
            byte[] frameBuffer = new byte[frameSize];
            byte[] chunkBuffer = new byte[4096];
            int bytesAccumulated = 0;

            using (Stream outputStream = ffmpegProcess2.StandardOutput.BaseStream)
            {
                while (isStreaming2)
                {
                    try
                    {
                        int bytesRead = outputStream.Read(chunkBuffer, 0, chunkBuffer.Length);
                        if (bytesRead <= 0) break;

                        Array.Copy(chunkBuffer, 0, frameBuffer, bytesAccumulated, bytesRead);
                        bytesAccumulated += bytesRead;

                        if (bytesAccumulated >= frameSize)
                        {
                            using (Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb))
                            {
                                var bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                                System.Runtime.InteropServices.Marshal.Copy(frameBuffer, 0, bmpData.Scan0, frameSize);
                                bitmap.UnlockBits(bmpData);

                                pictureBox.Invoke((MethodInvoker)(() =>
                                {
                                    pictureBox.Image?.Dispose();
                                    pictureBox.Image = new Bitmap(bitmap);
                                }));
                            }

                            bytesAccumulated = 0; // Reset buffer for the next frame
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        //Console.WriteLine($"Error: {ex.Message}");
                        StopStream(ffmpegProcess2, 3);
                    }
                }
            }
        }

        private void ReadFramesFour(PictureBox pictureBox)
        {
            int width = 640;
            int height = 480;
            int frameSize = width * height * 3;
            byte[] frameBuffer = new byte[frameSize];
            byte[] chunkBuffer = new byte[4096];
            int bytesAccumulated = 0;

            using (Stream outputStream = ffmpegProcess3.StandardOutput.BaseStream)
            {
                while (isStreaming3)
                {
                    try
                    {
                        int bytesRead = outputStream.Read(chunkBuffer, 0, chunkBuffer.Length);
                        if (bytesRead <= 0) break;

                        Array.Copy(chunkBuffer, 0, frameBuffer, bytesAccumulated, bytesRead);
                        bytesAccumulated += bytesRead;

                        if (bytesAccumulated >= frameSize)
                        {
                            using (Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb))
                            {
                                var bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                                System.Runtime.InteropServices.Marshal.Copy(frameBuffer, 0, bmpData.Scan0, frameSize);
                                bitmap.UnlockBits(bmpData);

                                pictureBox.Invoke((MethodInvoker)(() =>
                                {
                                    pictureBox.Image?.Dispose();
                                    pictureBox.Image = new Bitmap(bitmap);
                                }));
                            }

                            bytesAccumulated = 0; // Reset buffer for the next frame
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        //Console.WriteLine($"Error: {ex.Message}");
                        StopStream(ffmpegProcess3, 4);
                    }
                }
            }
        }

        private void StopStream(Process ffmpegProcess, int cameraId)
        {
            if (cameraId == 1) isStreaming = false;
            if (cameraId == 2) isStreaming1 = false;
            if (cameraId == 3) isStreaming2 = false;
            if (cameraId == 4) isStreaming3 = false;

            if (ffmpegProcess != null && !ffmpegProcess.HasExited)
            {
                ffmpegProcess.Kill();
                ffmpegProcess.Dispose();
            }
        }

    }
}

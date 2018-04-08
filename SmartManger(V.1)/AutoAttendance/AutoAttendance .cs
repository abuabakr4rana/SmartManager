using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using SmartManger_V._1_.HRManger;
using System.Threading;

using AForge.Video;
using AForge.Video.DirectShow;

namespace SmartManger_V._1_.AutoAttendance
{
    public partial class AutoAttendance : Form
    {
        #region Detection Variables
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;

        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name = null;
        #endregion

        #region DevicesList
        private FilterInfoCollection VideoCaptureDevices;
        int CamIndex = 0;
        #endregion

        public AutoAttendance()
        {
            InitializeComponent();
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                MessageBox.Show("Binary Database is empty, press start camera button to train the images ,(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grabber != null)
            {
                Application.Idle -= new EventHandler(FrameGrabber);
                grabber.Dispose();
            }
            //Initialize the capture device
            grabber = new Capture(CamIndex);
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //Trained face counter
            //    ContTrain = ContTrain + 1;

            //    //Get a gray frame from capture device
            //    gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //    //Face Detector
            //    MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
            //    face,
            //    1.2,
            //    10,
            //    Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
            //    new Size(20, 20));

            //    //Action for each element detected
            //    foreach (MCvAvgComp f in facesDetected[0])
            //    {
            //        TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
            //        break;
            //    }

            //    //resize face detected image for force to compare the same size with the 
            //    //test image with cubic interpolation type method
            //    TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //    trainingImages.Add(TrainedFace);
            //    //labels.Add(textBox1.Text);

            //    //Show face added in gray scale
            //    //imageBox1.Image = TrainedFace;

            //    //Write the number of triained faces in a file text for further load
            //    File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

            //    //Write the labels of triained faces in a file text for further load
            //    for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            //    {
            //        trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
            //        File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
            //    }

            //    //MessageBox.Show(textBox1.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch
            //{
            //    MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

        }
        void FrameGrabber(object sender, EventArgs e)
        {
            //label3.Text = "0";
            //label4.Text = "";
            NamePersons.Add("0");


            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(440, 330, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.LightGreen), 2);


                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);

                    name = recognizer.Recognize(result);
                    if (name == "")
                        name = "0";
                    //Draw the label for each face detected and recognized
                    //currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                    if (name != "0")
                    {
                        if (grabber != null)
                        {
                            Application.Idle -= new EventHandler(FrameGrabber);

                        }
                        Attendance.AttendanceForm.MarkAttendanceByCamera(Convert.ToInt32(name), SmartManger.BAL.Common.DateNow(), true);
                        FillEmployeeForm(Convert.ToInt32(name));
                        Application.Idle += new EventHandler(FrameGrabber);

                    }
                }

                NamePersons[t - 1] = name;
                NamePersons.Add("0");


                //Set the number of faces detected on the scene
                //label3.Text = facesDetected[0].Length.ToString();

                /*
                //Set the region of interest on the faces
                        
                gray.ROI = f.rect;
                MCvAvgComp[][] eyesDetected = gray.DetectHaarCascade(
                   eye,
                   1.1,
                   10,
                   Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                   new Size(20, 20));
                gray.ROI = Rectangle.Empty;

                foreach (MCvAvgComp ey in eyesDetected[0])
                {
                    Rectangle eyeRect = ey.rect;
                    eyeRect.Offset(f.rect.X, f.rect.Y);
                    currentFrame.Draw(eyeRect, new Bgr(Color.Blue), 2);
                }
                 */

            }
            t = 0;

            //Names concatenation of persons recognized
            //for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            //{
            //    names = names + NamePersons[nnn] + ", ";
            //}
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
            //label4.Text = names;
            if (t != 0)
            {

            }

            //Clear the list(vector) of names
            NamePersons.Clear();

        }

        private void AutoAttendance_Load(object sender, EventArgs e)
        {
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                cmbDevices.Items.Add(VideoCaptureDevice.Name);

            }

            cmbDevices.SelectedIndex = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
            
        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            CamIndex = cmbDevices.SelectedIndex;
        }

        private void AutoAttendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (grabber != null)
            {
                Application.Idle -= new EventHandler(FrameGrabber);
                grabber.Dispose();
            }
        }
        private void FillEmployeeForm(Int32 employeeId)
        {
            dsView ds = new dsView();
            HRManger.dsViewTableAdapters.vEmployeeGridTableAdapter taEmployee = new HRManger.dsViewTableAdapters.vEmployeeGridTableAdapter();
            taEmployee.FillById(ds.vEmployeeGrid, employeeId);
            var Employee = ds.vEmployeeGrid.NewvEmployeeGridRow();
            if (ds.vEmployeeGrid.Rows.Count > 0)
            {
                Employee = ds.vEmployeeGrid[0];
                tbxEmployeeName.Text = Employee.EmployeeName.ToString();
                tbxCode.Text = Employee.Code.ToString();
                tbxDepartment.Text = Employee.DeptName;
                tbxDesignation.Text = Employee.DesgName;
                pbxEmployee.ImageLocation = Employee.ImageUrl;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ////if (grabber != null)
            ////{
            ////    Application.Idle -= new EventHandler(FrameGrabber);
            ////    grabber.Dispose();
            ////}
            //////Initialize the capture device
            ////grabber = new Capture(CamIndex);
            ////grabber.QueryFrame();
            //////Initialize the FrameGraber event
            ////Application.Idle += new EventHandler(FrameGrabber);
           
        }
    }
}

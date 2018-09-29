using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rorationSimulation;
using XControl;
using System.IO;
using System.Runtime.InteropServices;

namespace FlightSimulator
{
    public partial class FlightSimulator : Form
    {
        [DllImport("winmm")]
        static extern uint timeGetTime();

        [DllImport("winmm")]
        static extern void timeBeginPeriod(int t);
        [DllImport("winmm")]
        static extern void timeEndPeriod(int t);

        [DllImport("kernel32.dll ")]
        static extern bool QueryPerformanceCounter(ref long lpPerformanceCount);

        [DllImport("kernel32")]
        static extern bool QueryPerformanceFrequency(ref long PerformanceFrequency);

        //Train  true    Test  false
        private List<bool> trainOrTest_1 = new List<bool>();
        private List<int> experimentTime_1 = new List<int>();

        private List<bool> trainOrTest_2 = new List<bool>();
        private List<int> experimentTime_2 = new List<int>();

        private List<bool> trainOrTest_3 = new List<bool>();
        private List<int> experimentTime_3 = new List<int>();

        private List<Control> controls;
        //test in step 3
        private List<bool> trainOrTestForTest = new List<bool>();
        private List<int> experimentTimeForTest = new List<int>();


        drawProcess dp;
        drawProcess dp1;
        drawProcess dp2;


        private int upBiasCount = 0;
        private int downBiasCount = 0;
        private float iniBiasValue = 2.5f;

        private int sequenceIndex = 0;

        private Bitmap imageNow;

        //debug mode start
        bool ifStartDebugMode = true;

        //save position and torque point
        private List<float> lpf1 = new List<float>();
        private List<float> lpf2 = new List<float>();

        private List<float> lpf3 = new List<float>();
        private List<float> lpf4 = new List<float>();

        private uint timeIndex = 0;
        private int sequenceIndexForExperiment = 0;
        private Dictionary<int, List<float>> torqueData;
        private Dictionary<int, List<float>> positionData;
        private List<int> expSequence;

        private PortControl pc;

        //false minute, true second
        private bool isSecond_1 = true;
        private bool isSecond_2 = true;
        private bool isSecond_3 = true;

        List<bool> trainOrTestUsed;
        List<int> experimentTimeUsed;

        private bool backToZeroControlSwitch = true;

        //
        private bool isOpenCircle = true;


        public FlightSimulator()
        {
            InitializeComponent();
        }


        private void portDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortDection pt = new PortDection();
            int iActulaWidth = Screen.PrimaryScreen.Bounds.Width;
            int iActulaHeight = Screen.PrimaryScreen.Bounds.Height;
            pt.Location = new Point(iActulaWidth / 2, iActulaHeight / 10);
            pt.Show();
        }

        private void btnSetSAdd_Click(object sender, EventArgs e)
        {
            if (rbTest_1.Checked)
            {
                trainOrTest_1.Add(false);

                if (isSecond_1)
                {
                    experimentTime_1.Add(int.Parse(tbLastTime_1.Text));
                    lbExpSequence_1.Items.Add(trainOrTest_1.Count.ToString("00") + "   " + "Test  " + tbLastTime_1.Text + "s");
                }
                else
                {

                    experimentTime_1.Add(60 * int.Parse(tbLastTime_1.Text));
                    lbExpSequence_1.Items.Add(trainOrTest_1.Count.ToString("00") + "   " + "Test  " + 60 * int.Parse(tbLastTime_1.Text) + "s");

                }


            }
            else
            {
                trainOrTest_1.Add(true);

                if (isSecond_1)
                {
                    experimentTime_1.Add(int.Parse(tbLastTime_1.Text));
                    lbExpSequence_1.Items.Add(trainOrTest_1.Count.ToString("00") + "  " + "Train  " + tbLastTime_1.Text + "s");
                }
                else
                {
                    experimentTime_1.Add(60 * int.Parse(tbLastTime_1.Text));
                    lbExpSequence_1.Items.Add(trainOrTest_1.Count.ToString("00") + "  " + "Train  " + 60 * int.Parse(tbLastTime_1.Text) + "s");
                }


            }
        }

        private void btnSetSDelete_Click(object sender, EventArgs e)
        {
            try
            {
                trainOrTest_1.RemoveAt(lbExpSequence_1.SelectedIndex);
                experimentTime_1.RemoveAt(lbExpSequence_1.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Wrong, no item choosed!");

            }

            lbExpSequence_1.Items.Clear();

            for (int i = 0; i != trainOrTest_1.Count; i++)
            {
                if (trainOrTest_1[i] == true)
                {
                    if (isSecond_1)
                    {
                        lbExpSequence_1.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_1[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_1.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_1[i].ToString() + "m");
                    }

                }
                else
                {
                    if (isSecond_1)
                    {
                        lbExpSequence_1.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_1[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_1.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_1[i].ToString() + "m");
                    }


                }
            }

        }

        private void btnSetSAdd_2_Click(object sender, EventArgs e)
        {
            if (rbTest_2.Checked)
            {
                trainOrTest_2.Add(false);

                if (isSecond_2)
                {
                    experimentTime_2.Add(int.Parse(tbLastTime_2.Text));
                    lbExpSequence_2.Items.Add(trainOrTest_2.Count.ToString("00") + "   " + "Test  " + tbLastTime_2.Text + "s");
                }
                else
                {
                    experimentTime_2.Add(60 * int.Parse(tbLastTime_2.Text));
                    lbExpSequence_2.Items.Add(trainOrTest_2.Count.ToString("00") + "   " + "Test  " + 60 * int.Parse(tbLastTime_2.Text) + "s");
                }


            }
            else
            {
                trainOrTest_2.Add(true);

                if (isSecond_2)
                {
                    experimentTime_2.Add(int.Parse(tbLastTime_2.Text));
                    lbExpSequence_2.Items.Add(trainOrTest_2.Count.ToString("00") + "  " + "Train  " + tbLastTime_2.Text + "s");
                }
                else
                {
                    experimentTime_2.Add(60 * int.Parse(tbLastTime_2.Text));
                    lbExpSequence_2.Items.Add(trainOrTest_2.Count.ToString("00") + "  " + "Train  " + 60 * int.Parse(tbLastTime_2.Text) + "s");
                }


            }
        }

        private void btnSetSAdd_3_Click(object sender, EventArgs e)
        {
            if (rbTest_3.Checked)
            {
                trainOrTest_3.Add(false);

                if (isSecond_3)
                {
                    experimentTime_3.Add(int.Parse(tbLastTime_3.Text));
                    lbExpSequence_3.Items.Add(trainOrTest_3.Count.ToString("00") + "   " + "Test  " + tbLastTime_3.Text + "s");
                }
                else
                {
                    experimentTime_3.Add(60 * int.Parse(tbLastTime_3.Text));
                    lbExpSequence_3.Items.Add(trainOrTest_3.Count.ToString("00") + "   " + "Test  " + 60 * int.Parse(tbLastTime_3.Text) + "s");
                }


            }
            else
            {
                trainOrTest_3.Add(true);

                if (isSecond_3)
                {
                    experimentTime_3.Add(int.Parse(tbLastTime_3.Text));
                    lbExpSequence_3.Items.Add(trainOrTest_3.Count.ToString("00") + "  " + "Train  " + tbLastTime_3.Text + "s");
                }
                else
                {
                    experimentTime_3.Add(60 * int.Parse(tbLastTime_3.Text));
                    lbExpSequence_3.Items.Add(trainOrTest_3.Count.ToString("00") + "  " + "Train  " + 60 * int.Parse(tbLastTime_3.Text) + "m");
                }


            }
        }

        private void btnSetSDelete_2_Click(object sender, EventArgs e)
        {
            try
            {
                trainOrTest_2.RemoveAt(lbExpSequence_2.SelectedIndex);
                experimentTime_2.RemoveAt(lbExpSequence_2.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Wrong, no item choosed!");

            }

            lbExpSequence_2.Items.Clear();

            for (int i = 0; i != trainOrTest_2.Count; i++)
            {
                if (trainOrTest_2[i] == true)
                {
                    if (isSecond_2)
                    {
                        lbExpSequence_2.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_2[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_2.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_2[i].ToString() + "m");
                    }

                }
                else
                {
                    if (isSecond_2)
                    {
                        lbExpSequence_2.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_2[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_2.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_2[i].ToString() + "m");
                    }


                }
            }

        }

        private void btnSetSDelete_3_Click(object sender, EventArgs e)
        {
            try
            {
                trainOrTest_3.RemoveAt(lbExpSequence_3.SelectedIndex);
                experimentTime_3.RemoveAt(lbExpSequence_3.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Wrong, no item choosed!");

            }

            lbExpSequence_3.Items.Clear();

            for (int i = 0; i != trainOrTest_3.Count; i++)
            {
                if (trainOrTest_3[i] == true)
                {
                    if (isSecond_3)
                    {
                        lbExpSequence_3.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_3[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_3.Items.Add((i + 1).ToString("00") + "  " + "Train  " + experimentTime_3[i].ToString() + "m");
                    }

                }
                else
                {
                    if (isSecond_3)
                    {
                        lbExpSequence_3.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_3[i].ToString() + "s");
                    }
                    else
                    {
                        lbExpSequence_3.Items.Add((i + 1).ToString("00") + "   " + "Test  " + experimentTime_3[i].ToString() + "m");
                    }


                }
            }

        }

        private void cbSecondOrMinute_1_CheckedChanged(object sender, EventArgs e)
        {

        }




        private void btnSetSequenceSave_3_Click(object sender, EventArgs e)
        {
            if (trainOrTest_3.Count == 0)
            {
                MessageBox.Show("Not item found");
            }
            else
            {

                FileStream fs3 = new FileStream(Application.StartupPath + "\\set-3.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs3);
                sw.WriteLine(trainOrTest_3.Count);//开始写入值
                for (int i = 0; i < trainOrTest_3.Count; i++)
                {
                    if (trainOrTest_3[i] == true)
                    {
                        sw.WriteLine("Train");
                        sw.WriteLine(experimentTime_3[i].ToString());

                    }
                    else
                    {
                        sw.WriteLine("Test");
                        sw.WriteLine(experimentTime_3[i].ToString());
                    }
                }

                sw.Close();
                fs3.Close();


            }



        }

        private void gbSetSequence_2_Enter(object sender, EventArgs e)
        {

        }

        private void cbSetSeqChoosed_1_Click(object sender, EventArgs e)
        {
            if (cbSetSeqChoosed_1.Checked == true)
            {
                cbSetSeqChoosed_1.Checked = true;
                cbSetSeqChoosed_2.Checked = false;
                cbSetSeqChoosed_3.Checked = false;
            }
            else
            {
                cbSetSeqChoosed_1.Checked = false;

            }
        }

        private void cbSetSeqChoosed_2_Click(object sender, EventArgs e)
        {
            if (cbSetSeqChoosed_2.Checked == true)
            {
                cbSetSeqChoosed_2.Checked = true;
                cbSetSeqChoosed_1.Checked = false;
                cbSetSeqChoosed_3.Checked = false;
            }
            else
            {
                cbSetSeqChoosed_2.Checked = false;

            }
        }

        private void cbSetSeqChoosed_3_Click(object sender, EventArgs e)
        {
            if (cbSetSeqChoosed_3.Checked == true)
            {
                cbSetSeqChoosed_3.Checked = true;
                cbSetSeqChoosed_1.Checked = false;
                cbSetSeqChoosed_2.Checked = false;
            }
            else
            {
                cbSetSeqChoosed_3.Checked = false;

            }
        }

        private void btnChooseDataPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BrowDialog = new FolderBrowserDialog();
            BrowDialog.ShowNewFolderButton = true;
            BrowDialog.Description = "请选择数据保存位置";
            BrowDialog.ShowDialog();
            string path = BrowDialog.SelectedPath;
            lblDPValue.Text = path;
        }

        private void lblDPValue_Click(object sender, EventArgs e)
        {

        }

        private void btnGoStep_2_Click(object sender, EventArgs e)
        {
            string dataPath = this.lblDPValue.Text;
            DirectoryInfo folder = new DirectoryInfo(dataPath);
            string expFileName = this.tbExperimentName.Text + ".txt";
            foreach (FileInfo file in folder.GetFiles("*.txt"))
            {
                if (expFileName.Equals(file.Name, StringComparison.OrdinalIgnoreCase))
                {
                    DialogResult dr = MessageBox.Show("实验名重复，是否重设？", "是", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        tabControl.SelectTab(0);
                    }
                    else
                    {
                        ifFromTab1ToTab2 = false;
                        tabControl.SelectTab(1);
                    }
                }
            }

        }

        public int[] getShufferArr(int number)
        {
            int[] arr = new int[number];
            for (int i = 0; i != arr.Length; i++)
            {
                arr[i] = i + 1;
            }


            int k = 0;
            int[] newarr = new int[number];
            while (k < arr.Length)
            {
                int temp = new Random().Next(0, arr.Length);
                if (arr[temp] != 0)
                {
                    newarr[k] = arr[temp];
                    k++;
                    arr[temp] = 0;
                }
            }

            return newarr;

        }
        private Stimulations vSti;
        private float degree = 0;
        private bool ifStop = false;
        private float troque_trans;
        private void btnTestDrawing_Click(object sender, EventArgs e)
        {

            this.timer3.Stop();
            this.timer1.Stop();
            this.gbSetPar.Enabled = false;
            lblChooseDisplay.Visible = true;
            cbIsPosition.Visible = true;
            cbIsTorque.Visible = true;


            dp1 = new drawProcess(this.pictureBox1.Width, this.pictureBox1.Height, Color.DarkCyan);

            timer2.Interval = 50;
            timer2.Start();
            //while (!ifStop)
            //{
            //    Application.DoEvents();
            //    newStart = timeGetTime();

            //    if (newStart - start >= 100)
            //    {


            //        if (isOpenCircle)
            //        {
            //            degree += degree;
            //        }
            //        float torqueVoltageValue;
            //        float troque = float.Parse(pc.AnalogInput(1, out torqueVoltageValue));
            //        troque = troque / 100;
            //        troque_trans = (troque - 2048) / 2048 * 80;


            //        debug mode
            //        troque_trans = 10;

            //        count++;
            //        start = newStart;

            //        Wert = p1_c1 * p1_c2 * trq + p1_c3 * p1_c4 * p1_bias_  'p1_c1=0/1 (open closed); p1_c2=+1/-1 (norm/inverted); p1_c3=0/1 (p1_bias on/off); p1_c4=+1/-1 (cw/ccw)
            //        dPsi1 = p1_k * Wert * dt_
            //        ArenaPos1 = ArenaPos1 + dPsi1


            //        float k = float.Parse(tbKValue.Text);
            //        degree += troque_trans * k * 0.01f;
            //        this.lblPositionValue.Text = degree.ToString();
            //        this.lblTorqueValue.Text = troque.ToString();
            //        this.lblTroqueTransValue.Text = troque_trans.ToString();

            //        if (degree > 180)
            //        {
            //            degree = degree - 360;
            //        }
            //        if (degree < -180)
            //        {
            //            degree = degree + 360;
            //        }
            //        v.pictureBox1.CreateGraphics().DrawImage(vSti.DrawV_Test(degree), 0, 0);

            //        lpf1.Add(degree);
            //        lpf2.Add(troque_trans);

            //        lpf1.Add(180);
            //        lpf2.Add(10);
            //        if (lpf1.Count == 400)
            //        {
            //            lpf1.Remove(lpf1[0]);
            //        }

            //        if (lpf2.Count == 400)
            //        {
            //            lpf2.Remove(lpf2[0]);
            //        }

            //        this.pictureBox1.CreateGraphics().DrawImage(dp1.drawSignalCurve(lpf1, lpf2), 0, 0);


            //    }

            //    if (count == 20000)
            //    {
            //        ifStop = true;
            //        break;
            //    }



            //}

            //this.pictureBox1.CreateGraphics().DrawImage(dp.drawTest(), 0, 0);
        }
        private CoreControl cc;
        private VisionFigure vf;
        private void Form1_Load(object sender, EventArgs e)
        {
            pc = new PortControl(0);
            pc.AnalogPortConfigurationIn();
            pc.AnalogPortConfigurationOut();
            pc.DigitalConfigurationOut();
            pc.ClearALLDigitalPort();
            torqueData = new Dictionary<int, List<float>>();
            positionData = new Dictionary<int, List<float>>();

            expSequence = new List<int>();
            cc = new CoreControl();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            StreamReader sR = File.OpenText(Application.StartupPath + "\\set-1.txt");
            int length = int.Parse(sR.ReadLine());
            for (int i = 0; i != length; i++)
            {
                string temp = sR.ReadLine();
                if (temp == "Train")
                {
                    trainOrTest_1.Add(true);
                    experimentTime_1.Add(int.Parse(sR.ReadLine()));
                    lbExpSequence_1.Items.Add(trainOrTest_1.Count.ToString("00") + "   " + "Train  " + experimentTime_1[i] + "s");
                }
                else
                {
                    trainOrTest_1.Add(false);
                    experimentTime_1.Add(int.Parse(sR.ReadLine()));
                    lbExpSequence_1.Items.Add(trainOrTest_1.Count.ToString("00") + "   " + "Test   " + experimentTime_1[i] + "s");
                }






            }
            sR.Close();


            StreamReader sR2 = File.OpenText(Application.StartupPath + "\\set-2.txt");
            int length2 = int.Parse(sR2.ReadLine());
            for (int i = 0; i != length2; i++)
            {
                string temp = sR2.ReadLine();
                if (temp == "Train")
                {
                    trainOrTest_2.Add(true);
                    experimentTime_2.Add(int.Parse(sR2.ReadLine()));
                    lbExpSequence_2.Items.Add(trainOrTest_2.Count.ToString("00") + "   " + "Train  " + experimentTime_2[i] + "s");
                }
                else
                {
                    trainOrTest_2.Add(false);
                    experimentTime_2.Add(int.Parse(sR2.ReadLine()));
                    lbExpSequence_2.Items.Add(trainOrTest_2.Count.ToString("00") + "   " + "Test   " + experimentTime_2[i] + "s");
                }






            }
            sR2.Close();

            StreamReader sR3 = File.OpenText(Application.StartupPath + "\\set-2.txt");
            int length3 = int.Parse(sR3.ReadLine());
            for (int i = 0; i != length3; i++)
            {
                string temp = sR3.ReadLine();
                if (temp == "Train")
                {
                    trainOrTest_3.Add(true);
                    experimentTime_3.Add(int.Parse(sR3.ReadLine()));
                    lbExpSequence_3.Items.Add(trainOrTest_3.Count.ToString("00") + "   " + "Train  " + experimentTime_3[i] + "s");
                }
                else
                {
                    trainOrTest_3.Add(false);
                    experimentTime_3.Add(int.Parse(sR3.ReadLine()));
                    lbExpSequence_3.Items.Add(trainOrTest_3.Count.ToString("00") + "   " + "Test   " + experimentTime_3[i] + "s");
                }






            }
            sR3.Close();



            vf = new VisionFigure();
            vf.Size = new System.Drawing.Size(1044, 330);
            vf.Show();

            vf.Location = new Point(3043, 439);
            //vf.Location = new Point(10, 10);
            vf.pbCanvas.Size = new System.Drawing.Size(1022, 330);
            //vf.Location = new Point(3043, 439);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            float torqueVoltageValue;
            float troque = float.Parse(pc.AnalogInput(1, out torqueVoltageValue));
            //troque = troque / 100;
            troque_trans = (troque - 2048) / 2048 * 80;


            this.lblPositionValue.Text = degreeForClosedLoop.ToString();

            this.lblTorqueValue.Text = troque.ToString();
            this.lblTroqueTransValue.Text = troque_trans.ToString();
            try
            {
                k = float.Parse(this.tbKValue.Text);
            }
            catch
            {
                k = -11;
            }

            if (ifDegreeForDebugUp)
            {
                degreeForClosedLoop += 2;
            }
            else if (ifDegreeForDebugDown)
            {
                degreeForClosedLoop -= 2;
            }
            else
            {
                degreeForClosedLoop += troque_trans * k * 0.01f;
            }


            if (degreeForClosedLoop >= 180)
            {
                degreeForClosedLoop = 360 - degreeForClosedLoop;
            }
            if (degreeForClosedLoop <= -180)
            {
                degreeForClosedLoop = 360 + degreeForClosedLoop;
            }

            lpf1.Add(degreeForClosedLoop);
            lpf2.Add(troque_trans);

            //lpf1.Add(180);
            //lpf2.Add(10);
            if (lpf1.Count == 400)
            {
                lpf1.Remove(lpf1[0]);
            }

            if (lpf2.Count == 400)
            {
                lpf2.Remove(lpf2[0]);
            }

            this.pictureBox1.CreateGraphics().DrawImage(dp1.drawSignalCurve(lpf1, lpf2), 0, 0);



            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            this.lblDebugTime.Text = ts.Milliseconds.ToString();



        }

        private void cbIsPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsPosition.Checked)
            {
                dp1.isPosition = true;
            }
            else
            {
                dp1.isPosition = false;
            }
        }

        private void cbIsTorque_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsTorque.Checked)
            {
                dp1.isTorque = true;
            }
            else
            {
                dp1.isTorque = false;
            }
        }

        private void OpenLoop()
        {
            pc.DigitOutput(3, MccDaq.DigitalLogicState.Low);
            pc.DigitOutput(4, MccDaq.DigitalLogicState.High);
            pc.DigitOutput(2, MccDaq.DigitalLogicState.High);
        }

        private void ClosedLoop()
        {
            pc.DigitOutput(3, MccDaq.DigitalLogicState.High);
            pc.DigitOutput(4, MccDaq.DigitalLogicState.Low);
            pc.DigitOutput(2, MccDaq.DigitalLogicState.High);
        }

        private void cbOpenOrClosed_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbOpenOrClosed.Checked)
            //{
            //    cbOpenOrClosed.Text = "Closed";
            //    isOpenCircle = false;



            //}
            //else
            //{
            //    cbOpenOrClosed.Text = "Open";
            //    isOpenCircle = true;

            //}
        }

        private void btnGoStep_3_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            tabControl.SelectTab(2);
            k = float.Parse(tbKValue.Text);
        }



        /// <summary>
        /// save data after finished a sigle experiment
        /// </summary>
        private void DataSave(int[] expOrder, int circleNumber)
        {
            string ExpFinishTime = DateTime.Now.ToString();

            List<int> ExpTime = experimentTimeUsed;

            List<bool> TrainOrTest = trainOrTestUsed;
            string ExpName = tbExperimentName.Text;

            //positionForEverySequence
            //torqueForEverySequence


            string path = this.lblDPValue.Text.ToString() + "\\" + ExpName + "_" + (circleNumber + 1).ToString() + ".txt";

            SigleExpResultPre serp = new SigleExpResultPre(ExpFinishTime, ExpName, ExpTime, TrainOrTest, path, positionData, torqueData, expOrder);

            serp.showResult();
            serp.Show();


            //FileInfo myFile = new FileInfo(path);
            //StreamWriter sW = myFile.CreateText();

            //sW.WriteLine("ExpName: " + ExpName);
            //sW.WriteLine("Date: "+ExpFinishTime);

            //sW.Write("ExpSequence: ");
            //foreach (var item in TrainOrTest)
            //{
            //    if (item)
            //    {
            //        sW.Write("Te;");
            //    }
            //    else
            //    {
            //        sW.Write("Tr;");
            //    }
            //}

            //sW.WriteLine();
            //sW.Write("TimeSequence: ");
            //foreach (var item in ExpTime)
            //{
            //    sW.Write(item.ToString() + ";");
            //}

            //sW.WriteLine();
            //sW.Write("If_T_Punishment: " + (ifTPunishment ? 1 : 0).ToString());

            //sW.WriteLine();
            //sW.WriteLine();

            //int index = positionForEverySequence.Count;
            //for (int i = 0; i != index; i++)
            //{
            //    int indexInside = positionForEverySequence[i].Count;
            //    for (int j = 0; j != indexInside; j++)
            //    {
            //        sW.WriteLine(positionForEverySequence[i][j].ToString("00.00") + "," + torqueForEverySequence[i][j].ToString("00.00"));
            //    }
            //}

            //sW.Close();



        }


        /// <summary>
        /// control the port to punish the fruit fly
        /// </summary>
        private void punishmentByHeat()
        {
            //this.pc.DigitOutput(0, MccDaq.DigitalLogicState.High);
        }
        private void unPunishmentByHeat()
        {
            //this.pc.DigitOutput(0, MccDaq.DigitalLogicState.Low);
        }

        System.Diagnostics.Stopwatch sw;
        private int count = 0;
        private float settingDegree = 0;
        private float oritation = 1;
        private float degreeForClosedLoop = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            float torqueVoltageValue;
            float troque = float.Parse(pc.AnalogInput(1, out torqueVoltageValue));
            //troque = troque / 100;
            troque_trans = (troque - 2048) / 2048 * 80;


            this.lblPositionValue.Text = settingDegree.ToString();

            this.lblTorqueValue.Text = troque.ToString();
            this.lblTroqueTransValue.Text = troque_trans.ToString();

            settingDegree += oritation * 2;

            if (settingDegree > 90)
            {
                oritation = -1;
            }
            if (settingDegree < -90)
            {
                oritation = 1;
            }

            lpf1.Add(settingDegree);
            lpf2.Add(troque_trans);

            //lpf1.Add(180);
            //lpf2.Add(10);
            if (lpf1.Count == 400)
            {
                lpf1.Remove(lpf1[0]);
            }

            if (lpf2.Count == 400)
            {
                lpf2.Remove(lpf2[0]);
            }

            this.pictureBox1.CreateGraphics().DrawImage(dp1.drawSignalCurve(lpf1, lpf2), 0, 0);



            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            this.lblDebugTime.Text = ts.Milliseconds.ToString();



            //degree += troque_trans * k * 0.01f;

            //lpf3.Add(degree);
            //lpf4.Add(troque_trans);

            //if (lpf3.Count == 400)
            //{
            //    lpf3.Remove(lpf3[0]);
            //}

            //if (lpf4.Count == 400)
            //{
            //    lpf4.Remove(lpf4[0]);
            //}


            //this.lblEXPStateP.Text = degree.ToString();
            //this.lblEXPStateTRaw.Text = troque.ToString();
            //this.lblEXPSTateT.Text = troque_trans.ToString();

            //if (degree > 180)
            //{
            //    degree = degree - 180;
            //}
            //if (degree < -180)
            //{
            //    degree = degree + 180;
            //}
            ////debug mode
            ////degree += 1;

            //this.pbPosition.CreateGraphics().DrawImage(dp1.drawSignalCurve(lpf3, lpf4), 0, 0);
            ////v.pictureBox1.CreateGraphics().DrawImage(vSti.DrawV_Test(degree), 0, 0);



            //if (count == 5 * 20)
            //{
            //    count = 0;

            //    lpf3.Clear();
            //    lpf4.Clear();
            //    settingDegree = 0;
            //    oritation = -1;
            //    if (expIndex == 6)
            //    {


            //        DataSave(expOrder, TotalCircle);

            //        TotalCircle++;
            //        if (TotalCircle == 3)
            //        {
            //            ifStop = true;
            //            this.btnStep3Start.Enabled = true;
            //            pc.ClearALLDigitalPort();
            //            //OpenLoop();
            //            cbOpenOrClosed.Checked = false;
            //            cbOpenOrClosed.Text = "Open";

            //        }

            //        positionData.Clear();
            //        torqueData.Clear();
            //        expOrder = getShufferArr(6);
            //        expIndex = 0;

            //        expID = expOrder[expIndex];
            //        torqueData.Add(expID, new List<float>());
            //        positionData.Add(expID, new List<float>());


            //    }
            //    else
            //    {

            //    }
            //    isExpModule = true;
            //    isInterModule = false;



            //}




            //if (lpf3.Count == 400)
            //{
            //    lpf3.Remove(lpf3[0]);
            //}

            //if (lpf4.Count == 400)
            //{
            //    lpf4.Remove(lpf4[0]);
            //}

            //this.pbPosition.CreateGraphics().DrawImage(dp1.drawSignalCurve(lpf3, lpf4), 0, 0);
            ////imageNow = dp2.drawCommunitivePoint(degree, false,sequenceIndexForExperiment);
            ////this.pbCommunitive.CreateGraphics().DrawImage(imageNow, 0, 0);

            //this.vf.pbCanvas.CreateGraphics().DrawImage(vf.getBlackBarWhiteBackground(degree), 0, 0);
            //this.vf.simpleOpenGlControl1.Refresh();

        }


        //bar move  1
        //background move 2
        //both move 3
        //black bar 0





        private float k;
        private const int expCircle = 3;
        private const int intervalTime = 5;
        private const int expTime_20_pps = 10;
        private const int expTime_50_pps = 4;

        private const int expCount = 1;
        private bool ifClosedLoop = false;
        private bool isExpModule = true;
        private bool isInterModule = false;
        private int[] expOrder;
        private int TotalCircle;
        private void btnStep3Start_Click(object sender, EventArgs e)
        {
            lblChooseDisplay.Visible = true;
            cbIsPosition.Visible = true;
            cbIsTorque.Visible = true;

            //vSti = new Stimulations(v.pictureBox1.Width, v.pictureBox1.Height, 1);

            timeBeginPeriod(1);
            uint start = timeGetTime();
            uint newStart;
            int count = 0;
            int i = 0, j = 0;
            ifStop = false;

            dp1 = new drawProcess(this.pbPosition.Width, this.pbPosition.Height, Color.DarkCyan);
            //dp2 = new drawProcess(this.pbCommunitive.Width, this.pbCommunitive.Height, Color.DarkCyan);

            lpf3.Clear();
            lpf4.Clear();
            torqueData.Clear();
            positionData.Clear();

            expSequence.Clear();
            sequenceIndexForExperiment = 0;


            expOrder = getShufferArr(12);
            int expIndex = 0;

            expID = expOrder[expIndex];
            torqueData.Add(expID, new List<float>());
            positionData.Add(expID, new List<float>());

            this.btnStep3Start.Enabled = false;
            vf.expId = 12;
            isExpModule = false;
            isInterModule = true;

            TotalCircle = 0;
            time = 1000 / 27;
            timer4.Interval = 10;
            this.timer4.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tpStep1_Click(object sender, EventArgs e)
        {

        }

        private void lblSecondOrMinute_1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeOrMi_1_Click(object sender, EventArgs e)
        {
            if (isSecond_1)
            {
                this.btnSeOrMi_1.Text = "M";
                isSecond_1 = false;
            }
            else
            {
                this.btnSeOrMi_1.Text = "S";
                isSecond_1 = true;
            }
        }

        private void btnSeOrMi_2_Click(object sender, EventArgs e)
        {
            if (isSecond_2)
            {
                this.btnSeOrMi_2.Text = "M";
                isSecond_2 = false;
            }
            else
            {
                this.btnSeOrMi_2.Text = "S";
                isSecond_2 = true;
            }
        }

        private void btnSeOrMi_3_Click(object sender, EventArgs e)
        {
            if (isSecond_3)
            {
                this.btnSeOrMi_3.Text = "M";
                isSecond_3 = false;
            }
            else
            {
                this.btnSeOrMi_3.Text = "S";
                isSecond_3 = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void resultBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultBrowser rb = new ResultBrowser();
            rb.Show();
        }

        private void btnSetSequenceSave_1_Click(object sender, EventArgs e)
        {
            if (trainOrTest_1.Count == 0)
            {
                MessageBox.Show("Not item found");
            }
            else
            {

                FileStream fs1 = new FileStream(Application.StartupPath + "\\set-1.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(trainOrTest_1.Count);//开始写入值
                for (int i = 0; i < trainOrTest_1.Count; i++)
                {
                    if (trainOrTest_1[i] == true)
                    {
                        sw.WriteLine("Train");
                        sw.WriteLine(experimentTime_1[i].ToString());

                    }
                    else
                    {
                        sw.WriteLine("Test");
                        sw.WriteLine(experimentTime_1[i].ToString());
                    }
                }

                sw.Close();
                fs1.Close();


            }









        }

        private void btnSetSequenceSave_2_Click(object sender, EventArgs e)
        {
            if (trainOrTest_2.Count == 0)
            {
                MessageBox.Show("Not item found");
            }
            else
            {

                FileStream fs1 = new FileStream(Application.StartupPath + "\\set-2.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(trainOrTest_2.Count);//开始写入值
                for (int i = 0; i < trainOrTest_2.Count; i++)
                {
                    if (trainOrTest_2[i] == true)
                    {
                        sw.WriteLine("Train");
                        sw.WriteLine(experimentTime_2[i].ToString());

                    }
                    else
                    {
                        sw.WriteLine("Test");
                        sw.WriteLine(experimentTime_2[i].ToString());
                    }
                }

                sw.Close();
                fs1.Close();


            }




        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createRecordFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordFileSetting rfs = new RecordFileSetting();
            rfs.Show();
        }

        private void debugModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (debugModeToolStripMenuItem.Checked)
            {
                debugModeToolStripMenuItem.Checked = false;
                ifStartDebugMode = false;
            }
            else
            {
                debugModeToolStripMenuItem.Checked = true;
                ifStartDebugMode = true;
            }
        }

        private void btnBiasUp_Click(object sender, EventArgs e)
        {

            degree += 5;
        }

        private void btnBiasDown_Click(object sender, EventArgs e)
        {

            degree -= 5;



        }


        //private void backToZeroTimer()
        //{
        //    timeBeginPeriod(1);
        //    uint start = timeGetTime();
        //    uint newStart;

        //    while (!isTheardCircleClosed)
        //    {

        //        float positionVoltageValue;
        //        endPosition = float.Parse(pc.AnalogInput(0, out positionVoltageValue));

        //        timeCount++;
        //        if (timeCount > 100)
        //        {
        //            if (UpOrDown)
        //            {
        //                if (endPosition > iniPosition)
        //                {

        //                    isTheardCircleClosed = true;
        //                    newStart = timeGetTime();
        //                    timeSpent = newStart - start;
        //                    this.lblTimespan.Text = timeSpent.ToString();
        //                    pc.VOutput(0, 2.5f);
        //                    Close();
        //                    timer1.Stop();
        //                    t.Abort();

        //                }
        //            }
        //            else
        //            {
        //                if (endPosition < iniPosition)
        //                {

        //                    isTheardCircleClosed = true;
        //                    newStart = timeGetTime();
        //                    timeSpent = newStart - start;
        //                    this.lblTimespan.Text = timeSpent.ToString();
        //                    pc.VOutput(0, 2.5f);
        //                    Close();
        //                    timer1.Stop();
        //                    t.Abort();
        //                }
        //            }
        //        }

        //    }


        //}



        private void btnBack_Click(object sender, EventArgs e)
        {

            degree = 0;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            float positionVoltageValue;
            float position = float.Parse(pc.AnalogInput(0, out positionVoltageValue));
            int centerValue = 1420;
            if (backToZeroControlSwitch)
            {
                if (Math.Abs((int)position - centerValue) < 30)
                {

                    pc.VOutput(0, 2.52f);

                }
                if (Math.Abs((int)position - centerValue) < 5)
                {
                    pc.VOutput(0, 2.5f);
                    iniBiasValue = 2.5f;

                    pc.DigitOutput(3, MccDaq.DigitalLogicState.Low);
                    pc.DigitOutput(4, MccDaq.DigitalLogicState.Low);
                    pc.DigitOutput(2, MccDaq.DigitalLogicState.Low);
                    timerForBackToZero.Stop();
                }
            }
            else
            {
                if (Math.Abs((int)position - centerValue) < 30)
                {

                    pc.VOutput(0, 2.48f);

                }
                if (Math.Abs((int)position - centerValue) < 5)
                {
                    pc.VOutput(0, 2.5f);
                    iniBiasValue = 2.5f;

                    pc.DigitOutput(3, MccDaq.DigitalLogicState.Low);
                    pc.DigitOutput(4, MccDaq.DigitalLogicState.Low);
                    pc.DigitOutput(2, MccDaq.DigitalLogicState.Low);
                    timerForBackToZero.Stop();
                }
            }

        }

        private void btnStopRotating_Click(object sender, EventArgs e)
        {
            timer3.Stop();

        }

        private void speedDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeedDetection sd = new SpeedDetection();
            sd.Show();
        }

        private void replayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replay r = new Replay();
            r.Show();
        }

        private void btnSetSettings_Click(object sender, EventArgs e)
        {

        }

        private void tpSetp3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void rbUpT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FlightSimulator_FormClosed(object sender, FormClosedEventArgs e)
        {
            ifStop = true;
            Application.Exit();
        }

        private void FlightSimulator_FormClosing(object sender, FormClosingEventArgs e)
        {
            ifStop = true;
        }

        private bool selectPatternIfStop;
        private void btnRunPattern_Click(object sender, EventArgs e)
        {


            //vSti = new Stimulations(v.pictureBox1.Width, v.pictureBox1.Height, 1);

            //this.pbChoosedPattern.BackgroundImage = vSti.DrawV_Test(0);
        }

        private void tpStep2_Click(object sender, EventArgs e)
        {
            ;
        }

        private bool ifFromTab1ToTab2 = true;
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedIndex == 1 & ifFromTab1ToTab2)
            {
                string dataPath = this.lblDPValue.Text;
                DirectoryInfo folder = new DirectoryInfo(dataPath);
                string expFileName = this.tbExperimentName.Text + ".txt";
                foreach (FileInfo file in folder.GetFiles("*.txt"))
                {
                    if (expFileName.Equals(file.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        DialogResult dr = MessageBox.Show("实验名重复，是否重设？", "是", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.OK)
                        {
                            tabControl.SelectTab(0);
                        }
                        else
                        {
                            tabControl.SelectTab(1);
                        }
                    }
                }
                ifFromTab1ToTab2 = false;
            }
            if (tabControl.SelectedIndex == 0)
            {
                ifFromTab1ToTab2 = true;
            }

            if (tabControl.SelectedIndex == 2)
            {
                timer2.Stop();
                k = float.Parse(tbKValue.Text);
            }

        }

        private void btnEXPStop_Click(object sender, EventArgs e)
        {
            btnStep3Start.Enabled = true;
            ifStop = true;
        }

        private void btnSaveSettingInStep2_Click(object sender, EventArgs e)
        {

        }

        private void btnRecorectBias_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Stop();
            this.gbSetPar.Enabled = false;
            lblChooseDisplay.Visible = true;
            cbIsPosition.Visible = true;
            cbIsTorque.Visible = true;


            dp1 = new drawProcess(this.pictureBox1.Width, this.pictureBox1.Height, Color.DarkCyan);

            timer3.Interval = 50;
            timer3.Start();
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {

            float torqueVoltageValue;
            float troque = float.Parse(pc.AnalogInput(1, out torqueVoltageValue));
            //troque = troque / 100;
            troque_trans = (troque - 2048) / 2048 * 80;

            degree = 0;
            this.lblPositionValue.Text = settingDegree.ToString();
            this.lblTorqueValue.Text = troque.ToString();
            this.lblTroqueTransValue.Text = troque_trans.ToString();




            lpf1.Add(degree);
            lpf2.Add(troque_trans);

            if (lpf1.Count == 400)
            {
                lpf1.Remove(lpf1[0]);
            }

            if (lpf2.Count == 400)
            {
                lpf2.Remove(lpf2[0]);
            }

            this.pictureBox1.CreateGraphics().DrawImage(dp1.drawSignalCurve(lpf1, lpf2), 0, 0);


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr = getShufferArr(6);
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            Console.WriteLine("divideLine");
        }

        private bool ifDegreeForDebugUp = false;
        private bool ifDegreeForDebugDown = false;
        private void btnDegreeUp_Click(object sender, EventArgs e)
        {
            ifDegreeForDebugUp = true;
            ifDegreeForDebugDown = false;
        }

        private void btnDegreeDown_Click(object sender, EventArgs e)
        {
            ifDegreeForDebugDown = true;
            ifDegreeForDebugUp = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ifDegreeForDebugDown = false;
            ifDegreeForDebugUp = false;
        }

        private void btnClosedTest_Click(object sender, EventArgs e)
        {
            this.timer3.Stop();
            this.timer2.Stop();
            this.gbSetPar.Enabled = true;
            lblChooseDisplay.Visible = true;
            cbIsPosition.Visible = true;
            cbIsTorque.Visible = true;

            degreeForClosedLoop = float.Parse(tbIniDegree.Text);
            dp1 = new drawProcess(this.pictureBox1.Width, this.pictureBox1.Height, Color.DarkCyan);
            //vf.SetRandomPoint();
            timer1.Interval = 50;
            timer1.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.gbSetPar.Enabled = false;
        }

        private float ValueToDegree(float value)
        {
            return (value - vf.Width / 2) * 360 / Width;

        }


        private int expID = 0;
        private int expIndex = 0;
        //int[] expOrder = getShufferArr(6);

        private int time;

        private void timer4_Tick(object sender, EventArgs e)
        {
            float torqueVoltageValue;
            float troque = float.Parse(pc.AnalogInput(1, out torqueVoltageValue));
            float degreeNow = ValueToDegree(vf.position);
            //troque = troque / 100;
            troque_trans = (troque - 2048) / 2048 * 80;
            lpf3.Add(degreeNow);
            lpf4.Add(troque_trans);
            if (lpf4.Count == 400)
            {
                lpf4.Remove(lpf4[0]);
            }
            if (lpf3.Count == 400)
            {
                lpf3.Remove(lpf3[0]);
            }

            //debug mode
            //troque_trans = 10;

            count++;

            this.lblEXPStateP.Text = degreeNow.ToString();
            this.lblEXPStateTRaw.Text = troque.ToString();
            this.lblEXPSTateT.Text = troque_trans.ToString();

            //label1.Text = this.expID.ToString();

            if (isExpModule)
            {

                
                torqueData[expID].Add(troque_trans);
                positionData[expID].Add(degreeNow);


                this.pbPosition.CreateGraphics().DrawImage(dp1.drawSignalCurve(lpf3, lpf4), 0, 0);

                if (count == time * 5)
                {
                    count = 0;

                    lpf3.Clear();
                    lpf4.Clear();
                    vf.position = 0;


                    expIndex++;
                    if (expIndex < 12)
                    {
                        expID = expOrder[expIndex];

                        torqueData.Add(expID, new List<float>());
                        positionData.Add(expID, new List<float>());
                    }
                    else
                    {
                        ;
                    }
                    isExpModule = false;
                    isInterModule = true;



                }


                vf.expId = expID;
               


            }

            if (isInterModule)
            {

                vf.expId = 12;
                vf.position = 0;

                


                //debug mode
                //degree += 1;

                this.pbPosition.CreateGraphics().DrawImage(dp1.drawSignalCurve(lpf3, lpf4), 0, 0);
                //v.pictureBox1.CreateGraphics().DrawImage(vSti.DrawV_Test(degree), 0, 0);



                if (count == (int)(3.5 * time))
                {
                    count = 0;

                    lpf3.Clear();
                    lpf4.Clear();

                    if (expIndex == 12)
                    {

                        DataSave(expOrder, TotalCircle);

                        TotalCircle++;
                        if (TotalCircle == 1)
                        {
                            timer4.Stop();
                            this.btnStep3Start.Enabled = true;
                            pc.ClearALLDigitalPort();
                            //OpenLoop();


                        }

                        positionData.Clear();
                        torqueData.Clear();
                        expOrder = getShufferArr(12);
                        expIndex = 0;

                        expID = expOrder[expIndex];
                        torqueData.Add(expID, new List<float>());
                        positionData.Add(expID, new List<float>());

                    }
                    else
                    {

                    }
                    isExpModule = true;
                    isInterModule = false;
                    this.vf.expId = expID;

                }

            }

            vf.drawFigure();
          
            
        }
    }
}

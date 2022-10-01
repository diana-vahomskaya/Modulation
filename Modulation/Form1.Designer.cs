namespace Modulation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart_Signal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CrossCorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chart_OffSignal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SUIS_CHART = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AM_Mod = new System.Windows.Forms.RadioButton();
            this.PM2_Mod = new System.Windows.Forms.RadioButton();
            this.FM_Mod = new System.Windows.Forms.RadioButton();
            this.V_BYTE = new System.Windows.Forms.TextBox();
            this.Sample_Rate = new System.Windows.Forms.TextBox();
            this.AMPL2 = new System.Windows.Forms.TextBox();
            this.N_bytes = new System.Windows.Forms.TextBox();
            this.AMPL1 = new System.Windows.Forms.TextBox();
            this.Noise_Signal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TIMEMS = new System.Windows.Forms.CheckBox();
            this.ByteText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TIME_DELAY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Freq_FM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Carrier_Freq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TIME_DELAY_OUT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SUISTDELAY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.STEP = new System.Windows.Forms.TextBox();
            this.REPEATS = new System.Windows.Forms.TextBox();
            this.NOISE_MIN = new System.Windows.Forms.TextBox();
            this.NOISE_MAX = new System.Windows.Forms.TextBox();
            this.Sustainbility = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Signal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossCorChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_OffSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUIS_CHART)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart_Signal
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.Chart_Signal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 9.056603F;
            legend1.Position.Width = 12.36802F;
            legend1.Position.X = 84.63197F;
            legend1.Position.Y = 3F;
            this.Chart_Signal.Legends.Add(legend1);
            this.Chart_Signal.Location = new System.Drawing.Point(24, 25);
            this.Chart_Signal.Name = "Chart_Signal";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.Legend = "Legend1";
            series1.Name = "Signal";
            this.Chart_Signal.Series.Add(series1);
            this.Chart_Signal.Size = new System.Drawing.Size(664, 266);
            this.Chart_Signal.TabIndex = 0;
            this.Chart_Signal.Text = "chart1";
            // 
            // CrossCorChart
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.CrossCorChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 9.056603F;
            legend2.Position.Width = 13.273F;
            legend2.Position.X = 83.727F;
            legend2.Position.Y = 3F;
            this.CrossCorChart.Legends.Add(legend2);
            this.CrossCorChart.Location = new System.Drawing.Point(707, 25);
            this.CrossCorChart.Name = "CrossCorChart";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.CrossCorChart.Series.Add(series2);
            this.CrossCorChart.Size = new System.Drawing.Size(664, 266);
            this.CrossCorChart.TabIndex = 1;
            this.CrossCorChart.Text = "chart2";
            // 
            // Chart_OffSignal
            // 
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.Chart_OffSignal.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            legend3.Position.Auto = false;
            legend3.Position.Height = 9.411765F;
            legend3.Position.Width = 17.19457F;
            legend3.Position.X = 79.80543F;
            legend3.Position.Y = 3F;
            this.Chart_OffSignal.Legends.Add(legend3);
            this.Chart_OffSignal.Location = new System.Drawing.Point(24, 317);
            this.Chart_OffSignal.Name = "Chart_OffSignal";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series3.Legend = "Legend1";
            series3.Name = "Offset Signal";
            this.Chart_OffSignal.Series.Add(series3);
            this.Chart_OffSignal.Size = new System.Drawing.Size(664, 266);
            this.Chart_OffSignal.TabIndex = 2;
            this.Chart_OffSignal.Text = "chart3";
            // 
            // SUIS_CHART
            // 
            chartArea4.Name = "ChartArea1";
            this.SUIS_CHART.ChartAreas.Add(chartArea4);
            legend4.DockedToChartArea = "ChartArea1";
            legend4.Name = "Legend1";
            legend4.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.SUIS_CHART.Legends.Add(legend4);
            this.SUIS_CHART.Location = new System.Drawing.Point(707, 317);
            this.SUIS_CHART.Name = "SUIS_CHART";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "AM";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "FM";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "PM2";
            this.SUIS_CHART.Series.Add(series4);
            this.SUIS_CHART.Series.Add(series5);
            this.SUIS_CHART.Series.Add(series6);
            this.SUIS_CHART.Size = new System.Drawing.Size(664, 266);
            this.SUIS_CHART.TabIndex = 3;
            this.SUIS_CHART.Text = "chart4";
            // 
            // AM_Mod
            // 
            this.AM_Mod.AutoSize = true;
            this.AM_Mod.Checked = true;
            this.AM_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AM_Mod.Location = new System.Drawing.Point(98, 218);
            this.AM_Mod.Name = "AM_Mod";
            this.AM_Mod.Size = new System.Drawing.Size(46, 21);
            this.AM_Mod.TabIndex = 7;
            this.AM_Mod.TabStop = true;
            this.AM_Mod.Text = "AM";
            this.AM_Mod.UseVisualStyleBackColor = true;
            // 
            // PM2_Mod
            // 
            this.PM2_Mod.AutoSize = true;
            this.PM2_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PM2_Mod.Location = new System.Drawing.Point(168, 218);
            this.PM2_Mod.Name = "PM2_Mod";
            this.PM2_Mod.Size = new System.Drawing.Size(54, 21);
            this.PM2_Mod.TabIndex = 8;
            this.PM2_Mod.Text = "PM2";
            this.PM2_Mod.UseVisualStyleBackColor = true;
            // 
            // FM_Mod
            // 
            this.FM_Mod.AutoSize = true;
            this.FM_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FM_Mod.Location = new System.Drawing.Point(240, 218);
            this.FM_Mod.Name = "FM_Mod";
            this.FM_Mod.Size = new System.Drawing.Size(45, 21);
            this.FM_Mod.TabIndex = 9;
            this.FM_Mod.Text = "FM";
            this.FM_Mod.UseVisualStyleBackColor = true;
            // 
            // V_BYTE
            // 
            this.V_BYTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.V_BYTE.Location = new System.Drawing.Point(136, 154);
            this.V_BYTE.Name = "V_BYTE";
            this.V_BYTE.Size = new System.Drawing.Size(100, 23);
            this.V_BYTE.TabIndex = 10;
            this.V_BYTE.Text = "9600";
            // 
            // Sample_Rate
            // 
            this.Sample_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Sample_Rate.Location = new System.Drawing.Point(235, 215);
            this.Sample_Rate.Name = "Sample_Rate";
            this.Sample_Rate.Size = new System.Drawing.Size(100, 23);
            this.Sample_Rate.TabIndex = 11;
            this.Sample_Rate.Text = "400";
            // 
            // AMPL2
            // 
            this.AMPL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AMPL2.Location = new System.Drawing.Point(235, 92);
            this.AMPL2.Name = "AMPL2";
            this.AMPL2.Size = new System.Drawing.Size(100, 23);
            this.AMPL2.TabIndex = 12;
            this.AMPL2.Text = "1";
            // 
            // N_bytes
            // 
            this.N_bytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.N_bytes.Location = new System.Drawing.Point(116, 39);
            this.N_bytes.Name = "N_bytes";
            this.N_bytes.Size = new System.Drawing.Size(100, 23);
            this.N_bytes.TabIndex = 13;
            this.N_bytes.Text = "40";
            // 
            // AMPL1
            // 
            this.AMPL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AMPL1.Location = new System.Drawing.Point(235, 63);
            this.AMPL1.Name = "AMPL1";
            this.AMPL1.Size = new System.Drawing.Size(100, 23);
            this.AMPL1.TabIndex = 14;
            this.AMPL1.Text = "0,25";
            // 
            // Noise_Signal
            // 
            this.Noise_Signal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Noise_Signal.Location = new System.Drawing.Point(235, 157);
            this.Noise_Signal.Name = "Noise_Signal";
            this.Noise_Signal.Size = new System.Drawing.Size(100, 23);
            this.Noise_Signal.TabIndex = 15;
            this.Noise_Signal.Text = "10";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.TIMEMS);
            this.groupBox1.Controls.Add(this.ByteText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.N_bytes);
            this.groupBox1.Controls.Add(this.V_BYTE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FM_Mod);
            this.groupBox1.Controls.Add(this.PM2_Mod);
            this.groupBox1.Controls.Add(this.AM_Mod);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(24, 612);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 255);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задание битов/графиков";
            // 
            // TIMEMS
            // 
            this.TIMEMS.AutoSize = true;
            this.TIMEMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TIMEMS.Location = new System.Drawing.Point(94, 189);
            this.TIMEMS.Name = "TIMEMS";
            this.TIMEMS.Size = new System.Drawing.Size(191, 21);
            this.TIMEMS.TabIndex = 16;
            this.TIMEMS.Text = "Зависимость от времени";
            this.TIMEMS.UseVisualStyleBackColor = true;
            // 
            // ByteText
            // 
            this.ByteText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ByteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ByteText.Location = new System.Drawing.Point(23, 80);
            this.ByteText.Multiline = true;
            this.ByteText.Name = "ByteText";
            this.ByteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ByteText.Size = new System.Drawing.Size(383, 56);
            this.ByteText.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Число бит:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(20, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "V бит (бит/с):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(891, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Оценка временной задержки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Pink;
            this.groupBox2.Controls.Add(this.TIME_DELAY);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.c);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Noise_Signal);
            this.groupBox2.Controls.Add(this.Freq_FM);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Carrier_Freq);
            this.groupBox2.Controls.Add(this.AMPL2);
            this.groupBox2.Controls.Add(this.AMPL1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Sample_Rate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(472, 612);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 255);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры сигнала";
            // 
            // TIME_DELAY
            // 
            this.TIME_DELAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TIME_DELAY.Location = new System.Drawing.Point(235, 186);
            this.TIME_DELAY.Name = "TIME_DELAY";
            this.TIME_DELAY.Size = new System.Drawing.Size(100, 23);
            this.TIME_DELAY.TabIndex = 21;
            this.TIME_DELAY.Text = "8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(21, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Задержка (мс):";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.c.Location = new System.Drawing.Point(21, 160);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(120, 17);
            this.c.TabIndex = 19;
            this.c.Text = "Сигнал/шум (дБ):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(21, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Амплитуда (АМ2):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(21, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Амплитуда (АМ1):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(21, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Частота дискретизации (кГц):";
            // 
            // Freq_FM
            // 
            this.Freq_FM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Freq_FM.Location = new System.Drawing.Point(235, 125);
            this.Freq_FM.Name = "Freq_FM";
            this.Freq_FM.Size = new System.Drawing.Size(100, 23);
            this.Freq_FM.TabIndex = 15;
            this.Freq_FM.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(21, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Частота отклонения (кГц):";
            // 
            // Carrier_Freq
            // 
            this.Carrier_Freq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Carrier_Freq.Location = new System.Drawing.Point(235, 34);
            this.Carrier_Freq.Name = "Carrier_Freq";
            this.Carrier_Freq.Size = new System.Drawing.Size(100, 23);
            this.Carrier_Freq.TabIndex = 13;
            this.Carrier_Freq.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(21, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Несущая частота (кГц):";
            // 
            // TIME_DELAY_OUT
            // 
            this.TIME_DELAY_OUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TIME_DELAY_OUT.Location = new System.Drawing.Point(1245, 611);
            this.TIME_DELAY_OUT.Name = "TIME_DELAY_OUT";
            this.TIME_DELAY_OUT.ReadOnly = true;
            this.TIME_DELAY_OUT.Size = new System.Drawing.Size(100, 23);
            this.TIME_DELAY_OUT.TabIndex = 19;
            this.TIME_DELAY_OUT.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(1132, 614);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Задержка (мс):";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.SUISTDELAY);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.STEP);
            this.groupBox3.Controls.Add(this.REPEATS);
            this.groupBox3.Controls.Add(this.NOISE_MIN);
            this.groupBox3.Controls.Add(this.NOISE_MAX);
            this.groupBox3.Location = new System.Drawing.Point(986, 653);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 177);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Устойчивость алгоритма к шуму";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(24, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "+- к задержке:";
            // 
            // SUISTDELAY
            // 
            this.SUISTDELAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SUISTDELAY.Location = new System.Drawing.Point(193, 145);
            this.SUISTDELAY.Name = "SUISTDELAY";
            this.SUISTDELAY.Size = new System.Drawing.Size(100, 23);
            this.SUISTDELAY.TabIndex = 24;
            this.SUISTDELAY.Text = "0,5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(24, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Шаг:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(24, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Кол-во повторений:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(24, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Сигнал/шум мин. (дБ):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(24, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Сигнал/шум макс. (дБ):";
            // 
            // STEP
            // 
            this.STEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.STEP.Location = new System.Drawing.Point(193, 117);
            this.STEP.Name = "STEP";
            this.STEP.Size = new System.Drawing.Size(100, 23);
            this.STEP.TabIndex = 19;
            this.STEP.Text = "2";
            // 
            // REPEATS
            // 
            this.REPEATS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.REPEATS.Location = new System.Drawing.Point(193, 88);
            this.REPEATS.Name = "REPEATS";
            this.REPEATS.Size = new System.Drawing.Size(100, 23);
            this.REPEATS.TabIndex = 18;
            this.REPEATS.Text = "10";
            // 
            // NOISE_MIN
            // 
            this.NOISE_MIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NOISE_MIN.Location = new System.Drawing.Point(193, 59);
            this.NOISE_MIN.Name = "NOISE_MIN";
            this.NOISE_MIN.Size = new System.Drawing.Size(100, 23);
            this.NOISE_MIN.TabIndex = 17;
            this.NOISE_MIN.Text = "-10";
            // 
            // NOISE_MAX
            // 
            this.NOISE_MAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NOISE_MAX.Location = new System.Drawing.Point(193, 30);
            this.NOISE_MAX.Name = "NOISE_MAX";
            this.NOISE_MAX.Size = new System.Drawing.Size(100, 23);
            this.NOISE_MAX.TabIndex = 16;
            this.NOISE_MAX.Text = "10";
            // 
            // Sustainbility
            // 
            this.Sustainbility.Location = new System.Drawing.Point(908, 836);
            this.Sustainbility.Name = "Sustainbility";
            this.Sustainbility.Size = new System.Drawing.Size(220, 31);
            this.Sustainbility.TabIndex = 22;
            this.Sustainbility.Text = "Устойчивость алгоритма";
            this.Sustainbility.UseVisualStyleBackColor = true;
            this.Sustainbility.Click += new System.EventHandler(this.Sustainbility_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1135, 834);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(240, 33);
            this.progressBar1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 897);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Sustainbility);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TIME_DELAY_OUT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SUIS_CHART);
            this.Controls.Add(this.Chart_OffSignal);
            this.Controls.Add(this.CrossCorChart);
            this.Controls.Add(this.Chart_Signal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Signal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossCorChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_OffSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUIS_CHART)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Signal;
        private System.Windows.Forms.DataVisualization.Charting.Chart CrossCorChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_OffSignal;
        private System.Windows.Forms.DataVisualization.Charting.Chart SUIS_CHART;
        private System.Windows.Forms.RadioButton AM_Mod;
        private System.Windows.Forms.RadioButton PM2_Mod;
        private System.Windows.Forms.RadioButton FM_Mod;
        private System.Windows.Forms.TextBox V_BYTE;
        private System.Windows.Forms.TextBox Sample_Rate;
        private System.Windows.Forms.TextBox AMPL2;
        private System.Windows.Forms.TextBox N_bytes;
        private System.Windows.Forms.TextBox AMPL1;
        private System.Windows.Forms.TextBox Noise_Signal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ByteText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Carrier_Freq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Freq_FM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox TIME_DELAY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox TIMEMS;
        private System.Windows.Forms.TextBox TIME_DELAY_OUT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox STEP;
        private System.Windows.Forms.TextBox REPEATS;
        private System.Windows.Forms.TextBox NOISE_MIN;
        private System.Windows.Forms.TextBox NOISE_MAX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Sustainbility;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SUISTDELAY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}


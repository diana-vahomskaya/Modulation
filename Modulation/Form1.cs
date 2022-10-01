using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace Modulation
{
    public partial class Form1 : Form
    {
        public double[] signal;
        public double[] full_signal;
        public int BitLength;
        public double CarrierFreq;
        public double SampleRate;
        public double BitSpeed;
        public double AMP1;
        public double AMP2;
        public double FM_FREQ;
        public double Noise_Perc;
        public double[] noise_signal;
        public double[] noise_signal_full;
        public double time_delay;
        public double Noise_Max;
        public double Noise_Min;
        public double step;
        public double repeat_count;
        public double delay_suis;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Choose_Signal();
        }

        private void Choose_Signal()
        {
            BitLength = Convert.ToInt32(N_bytes.Text);
            CarrierFreq = Convert.ToDouble(Carrier_Freq.Text);
            SampleRate = Convert.ToDouble(Sample_Rate.Text);
            BitSpeed = Convert.ToDouble(V_BYTE.Text);
            AMP1 = Convert.ToDouble(AMPL1.Text);
            AMP2 = Convert.ToDouble(AMPL2.Text);
            FM_FREQ = Convert.ToDouble(Freq_FM.Text);
            Noise_Perc = Convert.ToDouble(Noise_Signal.Text);
            time_delay = Convert.ToDouble(TIME_DELAY.Text);

            var modulation = new Modulation(BitLength, CarrierFreq, SampleRate, BitSpeed, AMP1, AMP2, FM_FREQ);
            signal = modulation.CreateSignal(AM_Mod.Checked, FM_Mod.Checked, PM2_Mod.Checked);
            var noise = new Noise();
            noise_signal = noise.AddNoise(signal, Noise_Perc);

            full_signal = modulation.CreateSignalWithGarbage(time_delay, AM_Mod.Checked, FM_Mod.Checked, PM2_Mod.Checked);
            noise_signal_full = noise.AddNoise(full_signal, Noise_Perc);

            ByteText.Text = modulation.BitSequence;

            var Corr = CrossCorrelation.Run(noise_signal, noise_signal_full);
            TIME_DELAY_OUT.Text = CrossCorrelation.FindMaxMs(Corr, SampleRate).ToString();
            if (TIMEMS.Checked)
            {
                Chart_Signal.Series[0].Points.Clear();
                for (int i = 0; i < modulation.SignalCounts; i++)
                {
                    Chart_Signal.Series[0].Points.AddXY(modulation.GetTimeMs(i), noise_signal[i]);
                }
                Chart_OffSignal.Series[0].Points.Clear();
                for (int i = 0; i < modulation.TemporaryDelaySignalCounts; i++)
                {
                    Chart_OffSignal.Series[0].Points.AddXY(modulation.GetTimeMs(i), noise_signal_full[i]);
                }
                CrossCorChart.Series[0].Points.Clear();
                for(int i = 0; i < Corr.Length; i++)
                {
                    CrossCorChart.Series[0].Points.AddXY(modulation.GetTimeMs(i), Corr[i]);
                }
            }
            else
            {
                Chart_Signal.Series[0].Points.Clear();
                for (int i = 0; i < modulation.SignalCounts; i++)
                {
                    Chart_Signal.Series[0].Points.AddXY(i, noise_signal[i]);
                }
                Chart_OffSignal.Series[0].Points.Clear();
                for (int i = 0; i < modulation.TemporaryDelaySignalCounts; i++)
                {
                    Chart_OffSignal.Series[0].Points.AddXY(i, noise_signal_full[i]);
                }
                CrossCorChart.Series[0].Points.Clear();
                for (int i = 0; i < Corr.Length; i++)
                {
                    CrossCorChart.Series[0].Points.AddXY(i, Corr[i]);
                }
            }
        }

        private void Sustainbility_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public double Sustainbility_ALg(double[] array, double delay_original, double delayshift)
        {
            int succes_count = 0;
            double delay_min = delay_original - delayshift;
            double delay_max = delay_original + delayshift;
            for(int i = 0; i < array.Length; i++)
            {
                if(delay_min <= array[i] && array[i] <= delay_max) succes_count++;
            }
            return succes_count/(double)array.Length; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Noise_Max = Convert.ToDouble(NOISE_MAX.Text);
            Noise_Min = Convert.ToDouble(NOISE_MIN.Text);
            step = Convert.ToDouble(STEP.Text);
            repeat_count = Convert.ToDouble(REPEATS.Text);
            BitLength = Convert.ToInt32(N_bytes.Text);
            CarrierFreq = Convert.ToDouble(Carrier_Freq.Text);
            SampleRate = Convert.ToDouble(Sample_Rate.Text);
            BitSpeed = Convert.ToDouble(V_BYTE.Text);
            AMP1 = Convert.ToDouble(AMPL1.Text);
            AMP2 = Convert.ToDouble(AMPL2.Text);
            FM_FREQ = Convert.ToDouble(Freq_FM.Text);
            Noise_Perc = Convert.ToDouble(Noise_Signal.Text);
            time_delay = Convert.ToDouble(TIME_DELAY.Text);
            delay_suis = Convert.ToDouble(SUISTDELAY.Text);

            var modulation = new Modulation(BitLength, CarrierFreq, SampleRate, BitSpeed, AMP1, AMP2, FM_FREQ);
            modulation.CreateSignal_Task2();
            modulation.CreateSignalWithGarbage_Task2(time_delay);
            var noise = new Noise();
            SUIS_CHART.Series[0].Points.Clear();
            SUIS_CHART.Series[1].Points.Clear();
            SUIS_CHART.Series[2].Points.Clear();

            var count = (int)((SampleRate * 1000) / BitSpeed);
            var time_delay_by_time_bytes = delay_suis * modulation.GetTimeMs(count);

            progressBar1.Maximum = 100;
            progressBar1.Step = (int)(100 / (Noise_Min < 0 ? (Noise_Min * -1 + Noise_Max)/step : (Noise_Min + Noise_Max) / step));

            for (int i = (int)Noise_Min; i <= (int)Noise_Max; i += (int)step)
            {
                double[] TimeDelayRepeats_AM = new double[(int)repeat_count];
                double[] TimeDelayRepeats_FM = new double[(int)repeat_count];
                double[] TimeDelayRepeats_PM2 = new double[(int)repeat_count];
                for (int j = 0; j < repeat_count; j++)
                {
                    var noise_sign_suis_am = noise.AddNoise(modulation.AM_Signal_Task2, i);
                    var noise_sign_suis_fm = noise.AddNoise(modulation.FM_Signal_Task2, i);
                    var noise_sign_suis_pm2 = noise.AddNoise(modulation.PM2_Signal_Task2, i);

                    var noise_signal_garb_am = noise.AddNoise(modulation.TemporaryDelaySignalAM, i);
                    var noise_signal_garb_fm = noise.AddNoise(modulation.TemporaryDelaySignalFM, i);
                    var noise_signal_garb_pm2 = noise.AddNoise(modulation.TemporaryDelaySignalPM2, i);

                    var Corr_AM = CrossCorrelation.Run(noise_sign_suis_am, noise_signal_garb_am);
                    var Corr_FM = CrossCorrelation.Run(noise_sign_suis_fm, noise_signal_garb_fm);
                    var Corr_PM2 = CrossCorrelation.Run(noise_sign_suis_pm2, noise_signal_garb_pm2);

                    var corr_delay_am = CrossCorrelation.FindMaxMs(Corr_AM, SampleRate);
                    var corr_delay_fm = CrossCorrelation.FindMaxMs(Corr_FM, SampleRate);
                    var corr_delay_pm2 = CrossCorrelation.FindMaxMs(Corr_PM2, SampleRate);

                    TimeDelayRepeats_AM[j] = corr_delay_am;
                    TimeDelayRepeats_FM[j] = corr_delay_fm;
                    TimeDelayRepeats_PM2[j] = corr_delay_pm2;
                }
                progressBar1.PerformStep();
                SUIS_CHART.Series[0].Points.AddXY(i, Sustainbility_ALg(TimeDelayRepeats_AM, time_delay, time_delay_by_time_bytes));
                SUIS_CHART.Series[1].Points.AddXY(i, Sustainbility_ALg(TimeDelayRepeats_FM, time_delay, time_delay_by_time_bytes));
                SUIS_CHART.Series[2].Points.AddXY(i, Sustainbility_ALg(TimeDelayRepeats_PM2, time_delay, time_delay_by_time_bytes));
            }
            timer1.Stop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Modulation
{
    public class Modulation
    {
        private readonly double AMP1; //амплитуда первая для амплитудной модуляции
        private readonly double AMP2; //амплитуда вторая для амплитудной модуляции
        private readonly int BitLength; //кол-во бит в последовательности
        private readonly double CarrierFreq; //несущая частота
        private readonly double FREQ1; //частота первая для частотной модуляции
        private readonly double FREQ2; //частота вторая для частотной модуляции
        private readonly double SampleRate; //частота дискретизации сигнала
        private readonly double BitSpeed; //скорость передачи битов: бит/с
        private readonly int[] bitSequence; //битовая последовательность
        private int FirstBit;//первый бит последовательности
        
        public Modulation(int BitLength, double CarrierFreq, double SampleRate, double BitSpeed, double AMP1, double AMP2, double FREQ_Mod)
        {
            this.BitLength = BitLength;
            this.CarrierFreq = CarrierFreq * 1000; // в Гц;
            this.SampleRate = SampleRate * 1000; // в Гц;
            this.BitSpeed = BitSpeed;
            this.AMP1 = AMP1;
            this.AMP2 = AMP2;
            bitSequence = Bytes.Generate_Byte_Array(BitLength);
            FirstBit = bitSequence[0];
            SignalCounts = 0;
            FREQ1 = FREQ_Mod * -1000;// в Гц;
            FREQ2 = FREQ_Mod * 1000;// в Гц;
        }


        private int CountNumOneBit; //кол-во отсчетов приходящееся на один бит
        private double RoundSmartErrCounter;
        public int SignalCounts { get; private set; }
        public double[] TemporaryDelaySignal { get; private set; } //сигнал с задержкой
        public double[] TemporaryDelaySignalAM { get; private set; } //сигнал с задержкой
        public double[] TemporaryDelaySignalFM { get; private set; } //сигнал с задержкой
        public double[] TemporaryDelaySignalPM2 { get; private set; } //сигнал с задержкой
        private int TemporaryDelayCounts; //кол-во отсчетов в одном сигнале с задержкой
        public int TemporaryDelaySignalCounts => SignalCounts + 2 * TemporaryDelayCounts; //кол-во остчетов в полном сигнале задержка+сигнал+задержка
        public double[] Signal { get; private set; }
        public double[] AM_Signal_Task2 { get; private set; }
        public double[] FM_Signal_Task2 { get; private set; }
        public double[] PM2_Signal_Task2 { get; private set; }
        public string BitSequence => Bytes.Byte_Array_ToString(bitSequence);
        public int get_time;
        public double GetTimeMs(int x) => x / SampleRate * 1000;


        public double[] CreateSignal(bool Am, bool Pm, bool Fm)
        {
            CalcCountsForOneBit();
            Signal = new double[SignalCounts];
            if (Am)
            {
                amplitude_modulaton(bitSequence, Signal, CountNumOneBit);
            }
            else if(Pm)
            {
                phase_modulation(bitSequence, Signal, CountNumOneBit);
            }    
            else if(Fm)
            {
                frequency_modulation(bitSequence, Signal, CountNumOneBit);
            }
            return Signal;
        }

        public double[] phase_modulation(int[]_bits, double[] _signal, int countperbit)
        {
            int[] bits = _bits;
            double phase = 0;

            for(int i = 0; i < bits.Length; i++)
            {
                for(int k = 0; k < countperbit; k++)
                {
                    _signal[i * countperbit + k] = 1 * Math.Sin(phase);
                    phase += 2.0 * Math.PI * CarrierFreq / SampleRate;
                }
                if (i != bits.Length - 1)
                    if (bits[i] != bits[i + 1]) phase += Math.PI;
                if (phase > Math.PI * 2.0) phase -= Math.PI * 2.0;
            }
            return _signal;
        }

        public double[] amplitude_modulaton(int[] _bits, double[] _signal, int countperbit)
        {
            int[] bits = _bits;
            double phase = 0;
            for(int i = 0; i < bits.Length; i++)
            {
                var amp = bits[i] == 0 ? AMP1 : AMP2;
                for(int k = 0; k < countperbit; k++)
                {
                    _signal[i * countperbit + k] = amp * Math.Sin(phase);
                    phase += 2.0 * Math.PI * CarrierFreq / SampleRate;
                }
                if (phase > 2.0 * Math.PI) phase -= 2.0 * Math.PI;
            }
            return _signal;
        }

        public double[] frequency_modulation(int[] _bits, double[] _signal, int countperbit)
        {
            int[] bits = _bits;
            double phase = 0;
            for(int i = 0; i < bits.Length; i ++)
            {
                var fr = bits[i] == 0 ? FREQ1 : FREQ2;
                for(int k = 0; k < countperbit; k++)
                {
                    _signal[i * countperbit + k] = 1 * Math.Sin(phase);
                    phase += 2.0 * Math.PI * (CarrierFreq + fr) / SampleRate;
                }
                if (phase > Math.PI * 2.0) phase -= Math.PI * 2.0;
            }
            return _signal;
        }
        public void CreateSignal_Task2() //для второй части
        {
            CalcCountsForOneBit();

            AM_Signal_Task2 = new double[SignalCounts];
            FM_Signal_Task2 = new double[SignalCounts];
            PM2_Signal_Task2 = new double[SignalCounts];

            amplitude_modulaton(bitSequence, AM_Signal_Task2, CountNumOneBit);
            frequency_modulation(bitSequence, FM_Signal_Task2, CountNumOneBit);
            phase_modulation(bitSequence, PM2_Signal_Task2, CountNumOneBit);
        }
        public double[] CreateSignalWithGarbage(double delay, bool am, bool fm, bool pm)
        {
            var delaySec = delay / 1000.0; // в секунды
            TemporaryDelayCounts = (int)Math.Ceiling(delaySec * SampleRate);
            var tr = 1.0 / BitSpeed;
            var oneBitCounts = tr * SampleRate;
            var bitsNum = (int)Math.Ceiling(TemporaryDelayCounts / oneBitCounts);

            var garbageSeq = Bytes.Generate_Byte_Array(bitsNum);
            var Garbage = new double[TemporaryDelayCounts];

            if(am) amplitude_modulaton(garbageSeq, Garbage, (int)oneBitCounts);
            else if(fm) frequency_modulation(garbageSeq, Garbage, (int)oneBitCounts);
            else if(pm) phase_modulation(garbageSeq, Garbage, (int)oneBitCounts);

            TemporaryDelaySignal = CopyToGarbageSignal(Signal, Garbage);
            return TemporaryDelaySignal;
        }
        public void CreateSignalWithGarbage_Task2(double delay)
        {
            var delaySec = delay / 1000.0; // в секунды
            TemporaryDelayCounts = (int)Math.Ceiling(delaySec * SampleRate);
            var tr = 1.0 / BitSpeed;
            var oneBitCounts = tr * SampleRate;
            var bitsNum = (int)Math.Ceiling(TemporaryDelayCounts / oneBitCounts);

            var garbageSeq = Bytes.Generate_Byte_Array(bitsNum);

            var Garbage_AM = new double[TemporaryDelayCounts];
            var Garbage_FM = new double[TemporaryDelayCounts];
            var Garbage_PM2 = new double[TemporaryDelayCounts];

            amplitude_modulaton(garbageSeq, Garbage_AM, (int)oneBitCounts);
            frequency_modulation(garbageSeq, Garbage_FM, (int)oneBitCounts);
            phase_modulation(garbageSeq, Garbage_PM2, (int)oneBitCounts);

            TemporaryDelaySignalAM = CopyToGarbageSignal(AM_Signal_Task2, Garbage_AM);
            TemporaryDelaySignalFM = CopyToGarbageSignal(FM_Signal_Task2, Garbage_FM);
            TemporaryDelaySignalPM2 = CopyToGarbageSignal(PM2_Signal_Task2, Garbage_PM2);
        }
        private double[] CopyToGarbageSignal(double[] signal, double[] garbage)
        {
            var result = new double[TemporaryDelaySignalCounts];

            garbage.CopyTo(result, 0);
            signal.CopyTo(result, garbage.Length);
            garbage.CopyTo(result, garbage.Length + signal.Length);

            return result;
        }
        private void CalcCountsForOneBit() //подсчет отчетов на 1 бит, создание массива
        {
            CountNumOneBit = 0;
            var tr = 1.0 / BitSpeed;

            SignalCounts = 0;
            CountNumOneBit = RoundSmart(tr * SampleRate);
            SignalCounts = CountNumOneBit * BitLength;
        }

        private int RoundSmart(double input) //округление
        {
            RoundSmartErrCounter += input - Math.Floor(input);
            if (RoundSmartErrCounter < 1.0) return (int)Math.Floor(input);

            RoundSmartErrCounter -= 1.0;
            return (int)(Math.Floor(input) + 1);
        }
    }
}

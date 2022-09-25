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


        private List<int> CountNumOneBit; //кол-во отсчетов приходящееся на один бит
        private double RoundSmartErrCounter;
        public int SignalCounts { get; private set; }
        public double[] TemporaryDelaySignal { get; private set; } //сигнал с задержкой
        private int TemporaryDelayCounts; //кол-во отсчетов в одном сигнале с задержкой
        public int TemporaryDelaySignalCounts => SignalCounts + 2 * TemporaryDelayCounts; //кол-во остчетов в полном сигнале задержка+сигнал+задержка
        private double AMPhase;
        private double PMPhase;
        private double FMPhase;
        public double[] Signal { get; private set; }
        public string BitSequence => Bytes.Byte_Array_ToString(bitSequence);
        public int get_time;
        public double GetTimeMs(int x) => x / SampleRate * 1000;
        private void ResetPhase()
        {
            AMPhase = 0;
            PMPhase = 0;
            FMPhase = 0;
        }
        public double[] CreateSignal(bool AM, bool FM, bool PH)
        {
            CalcCountsForOneBit();
            ResetPhase();
            var ii = 0;
            if (AM)
            {
                Signal = new double[SignalCounts];
                for (var i = 0; i < BitLength; i++)
                    for (var j = 0; j < CountNumOneBit[i]; j++)
                    {
                        Signal[ii] = AMP_Modulation(bitSequence[i]); 
                        ii++;
                    }
            }
            else if(FM)
            {
                Signal = new double[SignalCounts];
                for (var i = 0; i < BitLength; i++)
                    for (var j = 0; j < CountNumOneBit[i]; j++)
                    {
                        Signal[ii] = Freq_Modulation(bitSequence[i]); 
                        ii++;
                    }
            }
            else if(PH)
            {
                Signal = new double[SignalCounts];
                for (var i = 0; i < BitLength; i++)
                    for (var j = 0; j < CountNumOneBit[i]; j++)
                    {
                        Signal[ii] = Phase_Modulation(bitSequence[i]); 
                        ii++;
                    }
            }
            return Signal;
        }


        private double AMP_Modulation(int bit)
        {
            var amp = bit == 0 ? AMP1 : AMP2;
            var sin = amp * Math.Sin(AMPhase);
            //пересчёт фазы (смещение в соответствии с текущей част. сигнала и част. дискр.)
            AMPhase += 2 * Math.PI * CarrierFreq / SampleRate;
            AMPhase %= 2 * Math.PI; //ограничение по фазе до 2п
            return sin;
        }

        private double Phase_Modulation(int bit)
        {
            var sin = 1 * Math.Sin(PMPhase);
            //пересчёт фазы (смещение в соответствии с текущей част. сигнала и част. дискр.)
            PMPhase += 2 * Math.PI * CarrierFreq / SampleRate;
            if (FirstBit != bit)
            {
                PMPhase *= Math.PI;
                FirstBit = bit;
            }

            PMPhase %= 2 * Math.PI; //ограничение по фазе до 2п
            return sin;
        }

        private double Freq_Modulation(int bit)
        {
            var fr = bit == 0 ? FREQ1 : FREQ2;
            var sin = 1 * Math.Sin(FMPhase);
            //пересчёт фазы (смещение в соответствии с текущей част. сигнала и част. дискр.)
            FMPhase += 2 * Math.PI * (CarrierFreq + fr) / SampleRate;
            FMPhase %= 2 * Math.PI; //ограничение по фазе до 2п
            return sin;
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

            ResetPhase();

            var ii = 0;
            for (var i = 0; i < bitsNum; i++)
            {
                for (var j = 0; j < oneBitCounts; j++)
                {
                    if (ii == TemporaryDelayCounts) break;
                    if (am)
                    {
                        Garbage[ii] = AMP_Modulation(garbageSeq[i]); ii++;
                    }
                    else if (fm)
                    {
                        Garbage[ii] = Freq_Modulation(garbageSeq[i]); ii++;
                    }
                    else if (pm)
                    {
                        Garbage[ii] = Phase_Modulation(garbageSeq[i]); ii++;
                    }
                }
            }

            TemporaryDelaySignal = CopyToGarbageSignal(Signal, Garbage);
            return TemporaryDelaySignal;
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
            CountNumOneBit = new List<int>();
            var tr = 1.0 / BitSpeed;

            SignalCounts = 0;
            for (var i = 0; i < BitLength; i++)
            {
                CountNumOneBit.Add(RoundSmart(tr * SampleRate));
                SignalCounts += CountNumOneBit[i];
            }
        }

        private int RoundSmart(double input) //округление
        {
            RoundSmartErrCounter += input - Math.Floor(input);
            if (RoundSmartErrCounter < 1) return (int)Math.Floor(input);

            RoundSmartErrCounter -= 1.0;
            return (int)(Math.Floor(input) + 1);
        }
    }
}

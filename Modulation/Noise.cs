using System;

namespace Modulation
{
    public class Noise
    {
        private readonly Random _rnd;

        public Noise()
        {
            _rnd = new Random();
        }

        private double GetRandom()
        {
            return _rnd.NextDouble() * 2 - 1;
        }

        private double GetDistribution()
        {
            var ksi = 0.0;
            for (var i = 0; i < 12; i++) ksi += GetRandom() * (1.0 / 12.0);
            return ksi;
        }

        public double[] AddNoise(double[] signal, double snr)
        {
            var signalLength = signal.Length;
            var noise = new double[signalLength];
            for (var i = 0; i < signalLength; i++) noise[i] = GetDistribution();

            var energySignal = 0.0;
            for (var i = 0; i < signalLength; i++) energySignal += signal[i] * signal[i];

            var energyNoise = 0.0;
            for (var i = 0; i < signalLength; i++) energyNoise += noise[i] * noise[i];

            var noiseCoeff = Math.Sqrt(energySignal / energyNoise * Math.Pow(10, -snr / 10.0));

            var res = new double[signalLength];
            for (var i = 0; i < signalLength; i++) res[i] = signal[i] + noiseCoeff * noise[i];
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Variabel_lyd
{
    public partial class Form1 : Form
    {

        private IWavePlayer player;
        private readonly SineWaveProvider sineProvider;
        public double sliderOffset, sliderVolume;
        public int sliderFrequency;

        public Form1()
        {
            InitializeComponent();
            ReadFrequencySlider();
            ReadOffsetSlider();
            ReadVolumeSlider();
            
            sineProvider = new SineWaveProvider(sliderVolume,sliderFrequency,sliderOffset);
            
            UpdateGraph();
            trackBar1_ValueChanged(null, null);
            trackBarVolume_ValueChanged(null, null);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (player == null)
            {
                var waveOutEvent = new WaveOutEvent();
                waveOutEvent.NumberOfBuffers = 2;
                waveOutEvent.DesiredLatency = 100;
                player = waveOutEvent;
                player.Init(new SampleToWaveProvider(sineProvider));
            }
            player.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (player == null)
                return;
            player.Dispose();
            player = null;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int value = trackBarFrequency.Value * trackBarFrequency.Value;
            sineProvider.Frequency = value;
            lblHz.Text = value.ToString() + "Hz";
        }
       
        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            float value = (float)(trackBarVolume.Value)/1000;
            sineProvider.volume = value;
            lblVolume.Text = (value*100).ToString() + "%";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player?.Pause();
        }

        private void btnUpdatewaveShape_Click(object sender, EventArgs e)
        {
            //ReadOffsetSlider();
            //sineProvider.GenerateNewWaveTable( sliderOffset);
            UpdateGraph();
        }
        void ReadOffsetSlider()
        {
            sliderOffset = ((double)trackBarWaveShape.Value) / 1000;
        }
        void ReadVolumeSlider()
        {
            sliderVolume = ((double)trackBarVolume.Value) / 1000;
        }
        void ReadFrequencySlider()
        {
            sliderFrequency =  trackBarFrequency.Value* trackBarFrequency.Value;
        }

        private void trackBarWaveShape_ValueChanged(object sender, EventArgs e)
        {
            ReadOffsetSlider();
            sineProvider.Offset = sliderOffset;
            sineProvider.GenerateNewWaveTable(sliderOffset);
            UpdateGraph();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sineProvider.selectedWave = cmbChooseWave.SelectedIndex;
            sineProvider.GenerateNewWaveTable(sliderOffset);
            UpdateGraph();
        }

        private void btnAddSine_Click(object sender, EventArgs e) //Lag nytt vindu for å angi ny sinusbølge
        {
            AddSine ValuesForm = new AddSine();
            ValuesForm.ValuesEntered += new AddSine.SineHandler(GetSinewave);
            ValuesForm.Show();
            
        }
        private void GetSinewave(SineCalculator input) //Eventhandler som kjøres når en ny sinusbølge legges til.
        {
            sineProvider.graphs2.Add(input);
            UpdateGraph();
        }

        private void UpdateGraph()
        {
            sineProvider.GenerateNewWaveTable(sliderOffset);
            List<float> currentTable = sineProvider.CompressedWaveTable;
            chart1.Series["Series1"].Points.DataBindY(currentTable);
        }
    }
    class SineWaveProvider : ISampleProvider
    {
        private float[] waveTable;
        private double phase;
        private double currentPhaseStep;
        private double targetPhaseStep;
        private double frequency;

        public int selectedWave;
        private double phaseStepDelta;
        private bool seekFreq;
        private int sampleRate;
        public List<SineCalculator> graphs2 = new List<SineCalculator>();

        public SineWaveProvider(double volume, int frequency, double offset, int sampleRate = 44100)
        {
            
            this.sampleRate = sampleRate;
            WaveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, 1);
            waveTable = new float[sampleRate];
            this.Frequency = frequency;
            this.volume = (float)volume;
            
            //for (int index = 0; index < sampleRate; ++index)
            //    waveTable[index] = (float)(Math.Sin(2 * Math.PI * (double)index / sampleRate) + Math.Sin(2 * Math.PI * (double)index / sampleRate + Math.PI/3));
            // For sawtooth instead of sine: waveTable[index] = (float)index / sampleRate;
            
            PortamentoTime = 0.2; // thought this was in seconds, but glide seems to take a bit longer
            GenerateNewWaveTable(offset);
        }

        public void GenerateNewWaveTable(double offset, int sampleRate = 44100)
        {
            
            for (int index = 0; index < sampleRate; ++index)
            {
                float yValue = 0;
                double attack = offset;

                double percentage = (double)index / sampleRate;
                double parabel = 0.5-Math.Pow(10*(percentage - offset), 2);
                int choice = selectedWave;
                if (choice == 0)
                {
                    double dampen = Math.Pow(0.5 * Math.Log((frequency) / sampleRate), 2);
                    if (index <= attack * sampleRate)
                    {
                        yValue = (float)(index / (sampleRate * attack));
                    }
                    else
                    {
                        yValue = (float)Math.Pow((1 - ((index - (sampleRate * attack)) / (sampleRate * (1 - attack)))), dampen);
                    }
                    waveTable[index] = yValue;
                }
                else if (choice == 1)
                {
                    yValue += (float)(Math.Sin(2 * Math.PI * (double)index / sampleRate + (2 * Math.PI * offset)) );
                    waveTable[index] = yValue;
                }
                else if (choice == 2)
                {
                    if (index <= offset*sampleRate)
                    {
                        yValue = (float)1.0;
                    }
                    else
                    {
                        yValue = (float)0.0;
                    }
                    waveTable[index] = yValue;
                }
                else if (choice == 3)
                {
                    if (index <= offset * sampleRate)
                    {
                        yValue = ((float)index) / (float)(sampleRate*offset);
                    }
                    else
                    {
                        yValue = (float)(sampleRate-(index)) / (float)(sampleRate - (offset*sampleRate));
                    }
                    //yValue += (float)(Math.Sin(2 * Math.PI * (double)index / sampleRate + (2 * Math.PI * offset)));

                    waveTable[index] = yValue;
                }
                else if (choice == 4)
                {
                    
                    yValue += (float)(Math.Sin(2 * Math.PI * (double)index / sampleRate)+ (Math.Sin(4 * Math.PI * (double)index / sampleRate)+ (Math.Sin(6 * Math.PI * (double)index / sampleRate)*offset)))/2;

                    waveTable[index] = yValue;
                }
                else if (choice == 5)
                {
                    foreach (SineCalculator item in graphs2)
                    {
                        yValue += item.ReturnYValue((double)index / sampleRate);
                    }
                    
                    waveTable[index] = yValue / graphs2.Count;
                }
            }
        }
        public double Offset
        {
            
            set { if (graphs2.Count > 0)graphs2[graphs2.Count - 1].Offset = (float)value; }
        }
        public List<float> CompressedWaveTable{
            get{
                List<float> temp = new List<float>();
                for (int i = 0; i < waveTable.GetUpperBound(0); i = i + 100)
                {
                    temp.Add(waveTable[i]);
                }
                return temp;
               }
            }
        
        public double PortamentoTime { get; set; }

        public float[] Wavetable { get { return waveTable; } }
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                frequency = value;
                seekFreq = true;
            }
        }

        public float volume { get; set; }

        public WaveFormat WaveFormat { get; private set; }

        public int Read(float[] buffer, int offset, int count)
        {
            if (seekFreq) // process frequency change only once per call to Read
            {
                targetPhaseStep = waveTable.Length * (frequency / WaveFormat.SampleRate);

                phaseStepDelta = (targetPhaseStep - currentPhaseStep) / (WaveFormat.SampleRate * PortamentoTime);
                seekFreq = false;
            }
            var vol = volume; // process volume change only once per call to Read
            for (int n = 0; n < count; ++n)
            {
                int waveTableIndex = (int)phase % waveTable.Length;
                buffer[n + offset] = this.waveTable[waveTableIndex] * vol;
                phase += currentPhaseStep;
                if (this.phase > (double)this.waveTable.Length)
                    this.phase -= (double)this.waveTable.Length;
                if (currentPhaseStep != targetPhaseStep)
                {
                    currentPhaseStep += phaseStepDelta;
                    if (phaseStepDelta > 0.0 && currentPhaseStep > targetPhaseStep)
                        currentPhaseStep = targetPhaseStep;
                    else if (phaseStepDelta < 0.0 && currentPhaseStep < targetPhaseStep)
                        currentPhaseStep = targetPhaseStep;
                }
            }
            return count;
        }
    }
    public class SineCalculator
    {
        int periods;
        float amplitude, offset;
        public SineCalculator(int periods = 1, float amplitude = 1, float offset = 0)
        {
            this.periods = periods;
            this.amplitude = amplitude;
            this.offset = offset;
        }
        public float ReturnYValue(double percentage)
        {
            return (float)Math.Sin(2 * Math.PI * percentage * periods + (offset*2*Math.PI));
        }
        public float Amplitude
        {
            set { amplitude = value; }
        }
        public float Offset
        {
            set { offset = value; }
        }
        public int Periods
        {
            set { periods = value; }
        }
    }
}

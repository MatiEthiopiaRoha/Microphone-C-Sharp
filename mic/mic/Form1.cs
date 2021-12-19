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

namespace mic
{
    public partial class Form1 : Form
      
    {

        private readonly WaveInEvent _audioSource;
        private readonly BufferedWaveProvider _provider;
        private readonly WaveOut _player;
        private int _count;
        private const int Speed = 1;
        private float _leftMax, _rightMax;
        private readonly object _sampleObject;
        private readonly NotifyingSampleProvider _notify; 
        public Form1()
        {
            InitializeComponent();
            _audioSource = new WaveInEvent { WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(0).Channels) };
            _audioSource.DataAvailable += _audioSource_DataAvailable ;
            _provider = new BufferedWaveProvider(new WaveFormat());
            _player = new WaveOut();
            _sampleObject = new object();
            _notify = new NotifyingSampleProvider(_provider.ToSampleProvider());
            _notify.Sample += DrawAudioWave;

        }

        private void BufferPlay(byte[] recv)
        {
if (recv.Length > 0)
            {
                _provider.AddSamples(recv, 0, recv.Length);
            }

        }

        private void StartAudio()
        {
            _audioSource.StartRecording();
            _player.Init(_notify);
            _player.Play();
        }
        void _audioSource_DataAvailable(object sender, WaveInEventArgs e)

        {
            BufferPlay(e.Buffer);
        }

        private void StopAudio()
        {
            if (_player == null) return;
            _player.Dispose();
            _player.Stop();
            _provider.ClearBuffer();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            StartAudio();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopAudio();
        }

        private void DrawAudioWave(object sender,SampleEventArgs e)
        {
            lock (_sampleObject)
            {
                if (_count >= Speed)
                {
                    stereoAudioWavePainter1.AddLeftRight(_leftMax, _rightMax);
                    _leftMax = 0;
                    _rightMax = 0;
                    _count = 0;
                }
                else

                {
                    if ( Math.Abs(e.Left) + Math.Abs(e.Right) > Math.Abs(_leftMax) + Math.Abs(_rightMax))
                    {
                        _leftMax = e.Left;
                        _rightMax = e.Right;
                    }
                    _count++;
                }
            }
        }
    }
}

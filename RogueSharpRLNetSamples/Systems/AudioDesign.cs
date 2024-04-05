using System;
using System.Security.Cryptography.X509Certificates;
using RLNET;
using RogueSharp.Random;
using RogueSharpRLNetSamples.Core;
using RogueSharpRLNetSamples.Items;
using RogueSharpRLNetSamples.Systems;
using NAudio.Wave;
using System.Deployment.Internal;
using System.Threading;

namespace RogueSharpRLNetSamples.Systems
{
    public class AudioDesign
    {
        private WaveOut waveOut;
        private AudioFileReader audioFile;

        public AudioDesign(string audioFilePath)
        {
            audioFile = new AudioFileReader(audioFilePath);
            waveOut = new WaveOut();
            waveOut.Volume = 0.2f;
            waveOut.Init(audioFile);
            waveOut.PlaybackStopped += OnPlaybackStopped;
        }

        public void HandleAudioPlayback()
        {
            // Starte die Wiedergabe, wenn sie abgeschlossen ist
            if (waveOut.PlaybackState != PlaybackState.Playing)
            {
                waveOut.Play();
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            Dispose();
        }

        public void Dispose()
        {
            waveOut.Dispose();
            audioFile.Dispose();

            HandleAudioPlayback();
        }
    }
}

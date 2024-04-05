using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using NAudio.Wave;
using RLNET;
using RogueSharp;
using RogueSharp.DiceNotation;
using RogueSharpRLNetSamples.Core;
using RogueSharpRLNetSamples.Equipment;
using RogueSharpRLNetSamples.Interfaces;
using RogueSharpRLNetSamples.Items;

namespace RogueSharpRLNetSamples.Items
{
   public class RevealMapScroll : Item
   {
      public RevealMapScroll()
      {
         Name = "Magic Map";
         RemainingUses = 1;
      }

      protected override bool UseItem()
      {
            var waveOut = new WaveOut();
            var audioFile = new AudioFileReader("C:\\Users\\elias\\source\\repos\\LA1304RPG\\RogueSharpRLNetSamples\\Sounds\\Terraria - Magic Mirror Sound.wav");

            waveOut.Volume = 0.2f;
            waveOut.Init(audioFile);
            waveOut.Play();

         DungeonMap map = Game.DungeonMap;

         Game.MessageLog.Add( $"{Game.Player.Name} reads a {Name} and gains knowledge of the surrounding area" );

         foreach ( Cell cell in map.GetAllCells() )
         {
            if ( cell.IsWalkable )
            {
               map.SetCellProperties( cell.X, cell.Y, cell.IsTransparent, cell.IsWalkable, true );
            }
         }
         
         RemainingUses--;

         return true;
      }
   }
}

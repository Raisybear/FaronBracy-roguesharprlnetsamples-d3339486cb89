﻿using System.Drawing;

namespace RogueSharpRLNetSamples.Interfaces
{
   public interface ITreasure
   {
      bool PickUp(IActor actor);
   }
}
using RogueSharp.DiceNotation;
using RogueSharpRLNetSamples.Core;

namespace RogueSharpRLNetSamples.Monsters
{
    internal class Dragon : Monster
    {
        public static Dragon Create(int level)
        {
            //easy dragons for the first 9 levels
            if (level < 10)
            {
                int health = 0;
                int gold = 0;

                for (int i = 0; i < level; i++)
                {
                    health++;
                    gold++;
                }

                return new Dragon
                {
                    Attack = Dice.Roll("1D2") + level / 3,
                    AttackChance = Dice.Roll("10D5"),
                    Awareness = 10,
                    Color = Colors.DragonColor,
                    Defense = Dice.Roll("1D2") + level / 3,
                    DefenseChance = Dice.Roll("10D10"),
                    Gold = gold,
                    Health = health,
                    MaxHealth = health,
                    Name = "Dragon",
                    Speed = 20,
                    Symbol = 'D'
                };
            }

            //overpowered dragons for the final level
            else
            {
                int health = 20;
                int gold = 999;

                return new Dragon
                {
                    Attack = Dice.Roll("1D2") + level / 2,
                    AttackChance = Dice.Roll("10D5"),
                    Awareness = 20,
                    Color = Colors.DragonColor,
                    Defense = Dice.Roll("1D2") + level / 2,
                    DefenseChance = Dice.Roll("10D10"),
                    Gold = gold,
                    Health = health * 2,
                    MaxHealth = health * 2,
                    Name = "Dragon",
                    Speed = 20,
                    Symbol = 'D'
                };
            }
        }
    }
}

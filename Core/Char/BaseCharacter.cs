using Core.Char;
using System.Collections.Generic;

namespace Core
{
    public abstract class BaseCharacter
    {
        public AbilityScore Strength = new(10);
        public AbilityScore Dexterity = new(10);
        public AbilityScore Constitution = new(10);
        public AbilityScore Intelligence = new(10);
        public AbilityScore Wisdom = new(10);
        public AbilityScore Charisma = new(10);

        public int HealthMax = 0;
        public int CurrentHealth = 0;
        public int TempHealth = 0;

        public int Speed = 0;

        public SizeCat Size;

        public int AcBase = 10;
        public int AcArmour = 0;
        public int AcShield = 0;
        public int AcNatural = 0;
        public int AcDeflection = 0;
        public int AcMisc = 0;

        //public List<JobInstance> Levels = new List<JobInstance>();

        public int ArmourClass =>
            AcBase +
            AcArmour +
            AcShield +
            AcDeflection +
            AcNatural +
            AcMisc +
            Dexterity.ScoreMod +
            SizeCat.Mod;
    }
}
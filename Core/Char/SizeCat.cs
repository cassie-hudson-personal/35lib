namespace Core
{
    public class SizeCat
    {
        public static int Mod { get; internal set; }

        public SizeCat(SizeTypes types)
        {
            Mod = types switch
            {
                SizeTypes.Medium => 0,
                SizeTypes.Large => -1,
                SizeTypes.Small => 1,
                _ => Mod
            };
        }
    }
}
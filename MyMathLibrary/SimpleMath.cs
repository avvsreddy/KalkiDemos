namespace MyMathLibrary
{
    public class SimpleMath // BL
    {
        public static int FindMax(int fno, int sno)
        {
            int max = 0;
            if (fno > sno)
            {
                max = fno;
            }
            else
            {
                max = sno;
            }
            return max;
        } // BL
    }
}

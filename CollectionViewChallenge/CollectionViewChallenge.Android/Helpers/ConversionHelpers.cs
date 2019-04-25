using Android.App;

namespace CollectionViewChallenge.Droid.Helpers
{
    public static class ConversionHelper
    {
        public static int ConvertDPToPixels(int dp)
        {
            float scale = Application.Context.Resources.DisplayMetrics.Density;

            return (int)(dp * scale + 0.5);
        }
    }
}
using Xamarin.Forms;

namespace ProjectStyles.Resources.Dictionary
{
    public partial class Sizes : ResourceDictionary
    {
        public Sizes()
        {
            // SIZES
            TryAddIntResource(Constants.Controls.Button.HEIGHT, 48);
            TryAddIntResource(Constants.Controls.Button.OUTLINED_BORDERWIDTH, 1);
            TryAddIntResource(Constants.Controls.Button.CORNER_RADIUS, 4);
        }

        private void TryAddIntResource(string key, double value)
        {
            Add(key, value);
        }
    }
}
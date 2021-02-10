using ProjectStyles.Resources.Configuration;
using Xamarin.Forms;

namespace ProjectStyles.Resources.Dictionary
{
    public partial class Colors : ResourceDictionary
    {
        internal Colors(ColorConfiguration colorConfiguration)
        {
            // COLORS CONFIGURATION
            TryAddColorResource(Constants.Color.PRIMARY, colorConfiguration.Primary);
            TryAddColorResource(Constants.Color.PRIMARY_VARIANT, colorConfiguration.PrimaryVariant);
            TryAddColorResource(Constants.Color.ON_PRIMARY, colorConfiguration.OnPrimary);
            TryAddColorResource(Constants.Color.SECONDARY, colorConfiguration.Secondary);
            TryAddColorResource(Constants.Color.SECONDARY_VARIANT, colorConfiguration.SecondaryVariant);
            TryAddColorResource(Constants.Color.ON_SECONDARY, colorConfiguration.OnSecondary);
            TryAddColorResource(Constants.Color.BACKGROUND, colorConfiguration.Background);
            TryAddColorResource(Constants.Color.ON_BACKGROUND, colorConfiguration.OnBackground);
            TryAddColorResource(Constants.Color.SURFACE, colorConfiguration.Surface);
            TryAddColorResource(Constants.Color.ON_SURFACE, colorConfiguration.OnSurface);
            TryAddColorResource(Constants.Color.ERROR, colorConfiguration.Error);
            TryAddColorResource(Constants.Color.ON_ERROR, colorConfiguration.OnError);

            // OTHERS
            TryAddColorResource(Constants.Controls.Button.OUTLINED_BORDER, Color.FromHex("#1E000000"));
        }

        private void TryAddColorResource(string key, Color color)
        {
            if (key == null || color.IsDefault)
            {
                return;
            }

            Add(key, color);
        }
    }
}
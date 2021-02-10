using Xamarin.Forms;

namespace ProjectStyles.Resources.Configuration
{
    /// <inheritdoc />
    /// <summary>
    /// Class that provides theme configuration that will be applied in the current App.
    /// </summary>
    public class Configuration : BindableObject
    {
        /// <summary>
        /// Backing field for the bindable property <see cref="FontConfiguration"/>.
        /// </summary>
        public static readonly BindableProperty FontConfigurationProperty = BindableProperty.Create(nameof(FontConfiguration), typeof(FontConfiguration), typeof(FontConfiguration));

        /// <summary>
        /// Backing field for the bindable property <see cref="ColorConfiguration"/>.
        /// </summary>
        public static readonly BindableProperty ColorConfigurationProperty = BindableProperty.Create(nameof(ColorConfiguration), typeof(ColorConfiguration), typeof(ColorConfiguration));

        /// <summary>
        /// Gets or sets the font configuration of the theme.
        /// </summary>
        public FontConfiguration FontConfiguration
        {
            get => (FontConfiguration)GetValue(FontConfigurationProperty);
            set => SetValue(FontConfigurationProperty, value);
        }

        /// <summary>
        /// Gets or sets the color configuration of the theme.
        /// </summary>
        public ColorConfiguration ColorConfiguration
        {
            get => (ColorConfiguration)GetValue(ColorConfigurationProperty);
            set => SetValue(ColorConfigurationProperty, value);
        }
    }
}

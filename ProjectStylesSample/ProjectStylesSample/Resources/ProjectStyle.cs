using ProjectStyles.Resources.Configuration;
using ProjectStyles.Resources.Dictionary;
using ProjectStylesSample.Resources.Style;
using System;
using Xamarin.Forms;

namespace ProjectStyles.Resources
{
    public class ProjectStyle
    {
        private ResourceDictionary _resources;

        internal ProjectStyle(Application app, StyleConfiguration config = null)
        {
            _resources = app.Resources;
            MergeDictionaries(config, config == null);
        }

        /// <summary>
        /// Configure's the current app's resources by merging pre-defined  resources.
        /// </summary>
        /// <param name="app">The cross-platform mobile application that is running.</param>
        /// <exception cref="ArgumentNullException" />
        public static void Init(Application app, string configurationResourceKey = "")
        {
            if (!string.IsNullOrEmpty(configurationResourceKey))
            {
                var config = GetResource<StyleConfiguration>(app, configurationResourceKey);
                new ProjectStyle(app ?? throw new ArgumentNullException(nameof(app)), config ?? throw new ArgumentNullException(nameof(config)));
                return;
            }
            
            new ProjectStyle(app ?? throw new ArgumentNullException(nameof(app)));            
        }

        /// <summary>
        /// Configure's the current app's resources by merging pre-defined  resources and creating new resources based on the <see cref="Configuration"/>'s properties.
        /// </summary>
        /// <param name="app">The cross-platform mobile application that is running.</param>
        /// <param name="config">The object containing the <see cref="ColorConfiguration"/> and <see cref="FontConfiguration"/>.</param>
        /// <exception cref="ArgumentNullException" />
        public static void Init(Application app, StyleConfiguration config)
        {
            new ProjectStyle(app ?? throw new ArgumentNullException(nameof(app)), config ?? throw new ArgumentNullException(nameof(config)));
        }

        Lazy<Colors> defaultColors = new Lazy<Colors>(() => new Colors(new ColorConfiguration()));
        Lazy<Typography> defaultTypos = new Lazy<Typography>(() => new Typography(new FontConfiguration()));
        Lazy<Sizes> defaultSizes = new Lazy<Sizes>(() => new Sizes());

        private void MergeDictionaries(StyleConfiguration config, bool addDefaults)
        {
            if (config != null)
            {
                if (config.ColorConfiguration != null)
                {
                    _resources.MergedDictionaries.Remove(defaultColors.Value);
                    _resources.MergedDictionaries.Add(new Colors(config.ColorConfiguration));
                }
                else if (addDefaults && !_resources.MergedDictionaries.Contains((defaultColors.Value)))
                    _resources.MergedDictionaries.Add(defaultColors.Value);

                if (config.FontConfiguration != null)
                {
                    _resources.MergedDictionaries.Remove(defaultTypos.Value);
                    _resources.MergedDictionaries.Add(new Typography(config.FontConfiguration));
                }
                else if (addDefaults && !_resources.MergedDictionaries.Contains((defaultTypos.Value)))
                    _resources.MergedDictionaries.Add(defaultTypos.Value);
            }

            if (addDefaults)
            {
                if (config == null)
                {
                    if (!_resources.MergedDictionaries.Contains((defaultColors.Value)))
                        _resources.MergedDictionaries.Add(defaultColors.Value);

                    if (!_resources.MergedDictionaries.Contains((defaultTypos.Value)))
                        _resources.MergedDictionaries.Add(defaultTypos.Value);
                }

                if (!_resources.MergedDictionaries.Contains((defaultSizes.Value)))
                    _resources.MergedDictionaries.Add(defaultSizes.Value);
            }

            // MERGE YOUR PREDEFINED STYLES HERE
            _resources.MergedDictionaries.Add(new Base());
        }

        private static T GetResource<T>(Application app, string key)
        {
            if (app?.Resources == null)
                throw new Exception("You must call one of the Init() methods in App.xaml.cs after InitializeComponent()");

            if (app.Resources.TryGetValue(key ?? throw new ArgumentNullException(nameof(key)), out var value)
                && value is T resource)
                return resource;

            if (value != null)
                throw new InvalidCastException($"The resource retrieved was not of the type {typeof(T)}. Use {value.GetType()} instead.");

            return default;
        }
    }
}

using ProjectStyles.Resources.Configuration;
using Xamarin.Forms;

namespace ProjectStyles.Resources.Dictionary
{
    public partial class Typography : ResourceDictionary
    {
        internal Typography(FontConfiguration fontFamily)
        {
            // FONT SIZES
            TryAddIntResource(Constants.FontSize.H1, 96);
            TryAddIntResource(Constants.FontSize.H2, 60);
            TryAddIntResource(Constants.FontSize.H3, 48);
            TryAddIntResource(Constants.FontSize.H4, 34);
            TryAddIntResource(Constants.FontSize.H5, 24);
            TryAddIntResource(Constants.FontSize.H6, 20);
            TryAddIntResource(Constants.FontSize.SUBTITLE1, 16);
            TryAddIntResource(Constants.FontSize.SUBTITLE2, 14);
            TryAddIntResource(Constants.FontSize.BODY1, 16);
            TryAddIntResource(Constants.FontSize.BODY2, 14);
            TryAddIntResource(Constants.FontSize.BUTTON, 14);
            TryAddIntResource(Constants.FontSize.CAPTION, 12);
            TryAddIntResource(Constants.FontSize.OVERLINE, 10);

            // LETTER SPACING
            TryAddIntResource(Constants.LetterSpacing.H1, 1.5);
            TryAddIntResource(Constants.LetterSpacing.H2, 0.5);
            TryAddIntResource(Constants.LetterSpacing.H3, 0);
            TryAddIntResource(Constants.LetterSpacing.H4, 0.25);
            TryAddIntResource(Constants.LetterSpacing.H5, 0);
            TryAddIntResource(Constants.LetterSpacing.H6, 0.15);
            TryAddIntResource(Constants.LetterSpacing.SUBTITLE1, 0.15);
            TryAddIntResource(Constants.LetterSpacing.SUBTITLE2, 0.1);
            TryAddIntResource(Constants.LetterSpacing.BODY1, 0.5);
            TryAddIntResource(Constants.LetterSpacing.BODY2, 0.25);
            TryAddIntResource(Constants.LetterSpacing.BUTTON, 1.25);
            TryAddIntResource(Constants.LetterSpacing.CAPTION, 0.4);
            TryAddIntResource(Constants.LetterSpacing.OVERLINE, 1.5);
            TryAddIntResource(Constants.LetterSpacing.NONE, 0);

            if (fontFamily == null)
            {
                return;
            }

            // FONT FAMILY
            TryAddStringResource(Constants.FontFamily.H1, fontFamily.H1);
            TryAddStringResource(Constants.FontFamily.H2, fontFamily.H2);
            TryAddStringResource(Constants.FontFamily.H3, fontFamily.H3);
            TryAddStringResource(Constants.FontFamily.H4, fontFamily.H4);
            TryAddStringResource(Constants.FontFamily.H5, fontFamily.H5);
            TryAddStringResource(Constants.FontFamily.H6, fontFamily.H6);
            TryAddStringResource(Constants.FontFamily.SUBTITLE1, fontFamily.Subtitle1);
            TryAddStringResource(Constants.FontFamily.SUBTITLE2, fontFamily.Subtitle2);
            TryAddStringResource(Constants.FontFamily.BODY1, fontFamily.Body1);
            TryAddStringResource(Constants.FontFamily.BODY2, fontFamily.Body2);
            TryAddStringResource(Constants.FontFamily.BUTTON, fontFamily.Button);
            TryAddStringResource(Constants.FontFamily.CAPTION, fontFamily.Caption);
            TryAddStringResource(Constants.FontFamily.OVERLINE, fontFamily.Overline);

            // OTHERS
            Add(Constants.FONTATTRIBUTE_BOLD, FontAttributes.Bold);
        }

        private void TryAddStringResource(string key, string value)
        {
            Add(key, value);
        }

        private void TryAddIntResource(string key, double value)
        {
            Add(key, value);
        }
    }
}
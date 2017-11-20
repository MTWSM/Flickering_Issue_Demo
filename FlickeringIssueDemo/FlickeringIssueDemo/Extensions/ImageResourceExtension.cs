using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlickeringIssueDemo.Extensions
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        #region Public Properties

        public string Source { get; set; }

        #endregion

        #region Public Methods

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null) return null;

            return ImageSource.FromResource(Source);
        }

        #endregion
    }
}
using System.Globalization;

namespace i18n.Core.Abstractions
{
    /// <summary>
    /// Contract to manage the localization.
    /// </summary>
    public interface ILocalizationManager
    {
        /// <summary>
        /// Disables cache. This is usefull during development.
        /// </summary>
        bool DisableCache { get; set; }
        /// <summary>
        /// Retrieves a dictionary for a specified culture.
        /// </summary>
        /// <param name="culture">The <see cref="CulureInfo"/>.</param>
        /// <returns>A <see cref="CultureDictionary"/> for the specified culture.</returns>
        CultureDictionary GetDictionary(CultureInfo culture);
    }
}

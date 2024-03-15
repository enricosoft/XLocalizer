using XLocalizer.ErrorMessages;

namespace XLocalizer
{
    /// <summary>
    /// Express localization options
    /// </summary>
    public class XLocalizerOptions
    {
        /// <summary>
        /// The path to the resources folder e.g. "LocalizationResources"
        /// </summary>
        public string ResourcesPath { get; set; } = "LocalizationResources";

        /// <summary>
        /// If the key string is not found, it will be inserted autoamtically.
        /// default: false
        /// </summary>
        public bool AutoAddKeys { get; set; } = false;
       
        /// <summary>
        /// ExpressMemory cache helps speeding up getting localized values from data stores.
        /// It is helpful to set to false during development mode and to true in production.
        /// Default value: true.
        /// </summary>
        public bool UseExpressMemoryCache { get; set; } = true;
 
        /// <summary>
        /// When set to true the default culture (or source translation culture) will be localized (use case; when using CODE keys instead of texts.).
        /// Default value is false (default culture not localized).
        /// </summary>
        public bool LocalizeDefaultCulture { get; set; } = false;

        /// <summary>
        /// Customize all valdiation error messages.
        /// </summary>
        public ValidationErrors ValidationErrors { get; set; } = new ValidationErrors();

        /// <summary>
        /// identity describer error messages
        /// </summary>
        public IdentityErrors IdentityErrors { get; set; } = new IdentityErrors();

        /// <summary>
        /// Model Binding Error Messages
        /// </summary>
        public ModelBindingErrors ModelBindingErrors { get; set; } = new ModelBindingErrors();
    }
}

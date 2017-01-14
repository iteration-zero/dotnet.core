using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace IterationZero.Core.Resources
{
    /// <summary>
    /// Contains all of the available localized resources.
    /// </summary>
    public class ResourceRegistry
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ResourceRegistry"/> class.
        /// </summary>
        private ResourceRegistry()
        {

            _registry = new Dictionary<string, ResourceRoot> {{_defaultName, new ResourceRoot()}};
        }

        /// <summary>
        /// Gets the default singleton instance.
        /// </summary>
        public static ResourceRegistry Instance { get; } = new ResourceRegistry();

        /// <summary>
        /// Registers a resource root.
        /// </summary>
        /// <param name="name">
        /// The name of the resource root.
        /// </param>
        /// <param name="root">
        /// The root object containing a set of compatible localized resources.
        /// </param>
        public void RegisterResourceRoot(string name, ResourceRoot root)
        {
            _registry.Add(name, root);
        }

        public ResourceRoot GetCurrent()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            return Get(culture.Name);
        }

        /// <summary>
        /// Gets the resource root based on the supplied <paramref name="name"/>.
        /// </summary>
        /// <param name="name">
        /// The name of the resource root to get.
        /// </param>
        /// <returns></returns>
        public ResourceRoot Get(string name)
        {
            return _registry.ContainsKey(name)
                ? _registry[name]
                : _registry[_defaultName];
        }

        private readonly Dictionary<string, ResourceRoot> _registry;
        private const string _defaultName = "en-US";
    }
}

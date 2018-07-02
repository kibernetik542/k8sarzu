// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// NodeConfigSource specifies a source of node configuration. Exactly one
    /// subfield (excluding metadata) must be non-nil.
    /// </summary>
    public partial class V1NodeConfigSource
    {
        /// <summary>
        /// Initializes a new instance of the V1NodeConfigSource class.
        /// </summary>
        public V1NodeConfigSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1NodeConfigSource class.
        /// </summary>
        /// <param name="configMap">ConfigMap is a reference to a Node's
        /// ConfigMap</param>
        public V1NodeConfigSource(V1ConfigMapNodeConfigSource configMap = default(V1ConfigMapNodeConfigSource))
        {
            ConfigMap = configMap;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets configMap is a reference to a Node's ConfigMap
        /// </summary>
        [JsonProperty(PropertyName = "configMap")]
        public V1ConfigMapNodeConfigSource ConfigMap { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConfigMap != null)
            {
                ConfigMap.Validate();
            }
        }
    }
}

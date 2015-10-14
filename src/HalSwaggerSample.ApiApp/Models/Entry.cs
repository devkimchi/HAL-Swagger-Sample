namespace HalSwaggerSample.ApiApp.Models
{
    /// <summary>
    /// This represents the model entity for entry.
    /// </summary>
    public class Entry
    {
        /// <summary>
        /// Gets or sets the link for product collection.
        /// </summary>
        public Link Products { get; set; }

        /// <summary>
        /// Gets or sets the link for product.
        /// </summary>
        public Link Product { get; set; }
    }
}
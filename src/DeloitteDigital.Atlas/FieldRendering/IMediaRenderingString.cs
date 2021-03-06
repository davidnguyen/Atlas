﻿using Sitecore.Data.Items;

namespace DeloitteDigital.Atlas.FieldRendering
{
    /// <summary>
    /// Represents a field rendering wrapper for media field type (image) as a string
    /// </summary>
    public interface IMediaRenderingString : IFieldRenderingString
    {
        /// <summary>
        /// Instructs the renderer to render the media URL only, not the image control or page editor control
        /// </summary>
        /// <returns>The field's media url</returns>
        string UrlOnly();

        /// <summary>
        /// Scales the image size by a specified percentage
        /// </summary>
        /// <param name="percent">The percent.</param>
        /// <returns>itself.</returns>
        IFieldRenderingString Scale(float percent);

        MediaItem MediaItem { get; }
    }
}

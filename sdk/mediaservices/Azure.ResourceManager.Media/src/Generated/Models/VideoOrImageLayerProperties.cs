// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The encoder can be configured to produce video and/or images (thumbnails) at different resolutions, by specifying a layer for each desired resolution. A layer represents the properties for the video or image at a resolution. </summary>
    public partial class VideoOrImageLayerProperties
    {
        /// <summary> Initializes a new instance of VideoOrImageLayerProperties. </summary>
        public VideoOrImageLayerProperties()
        {
        }

        /// <summary> Initializes a new instance of VideoOrImageLayerProperties. </summary>
        /// <param name="width"> The width of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in width as the input. </param>
        /// <param name="height"> The height of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in height as the input. </param>
        /// <param name="label"> The alphanumeric label for this layer, which can be used in multiplexing different video and audio layers, or in naming the output file. </param>
        internal VideoOrImageLayerProperties(string width, string height, string label)
        {
            Width = width;
            Height = height;
            Label = label;
        }

        /// <summary> The width of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in width as the input. </summary>
        public string Width { get; set; }
        /// <summary> The height of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in height as the input. </summary>
        public string Height { get; set; }
        /// <summary> The alphanumeric label for this layer, which can be used in multiplexing different video and audio layers, or in naming the output file. </summary>
        public string Label { get; set; }
    }
}

using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CloudinaryDotNet.Actions
{
    /// <summary>
    /// Search response with information about the assets matching the search criteria.
    /// </summary>
    [DataContract]
    public class SearchResult : BaseResult
    {
        /// <summary>
        /// The total count of assets matching the search criteria.
        /// </summary>
        [DataMember(Name = "total_count")]
        public int TotalCount { get; protected set; }

        /// <summary>
        /// The time taken to process the request.
        /// </summary>
        [DataMember(Name = "time")]
        public long Time { get; protected set; }

        /// <summary>
        /// The details of each of the assets (resources) found.
        /// </summary>
        [DataMember(Name = "resources")]
        public List<SearchResource> Resources { get; protected set; }

        /// <summary>
        /// When a search request has more results to return than max_results, the next_cursor value is returned as
        /// part of the response.
        /// </summary>
        [DataMember(Name = "next_cursor")]
        public string NextCursor { get; protected set; }
        
    }

    /// <summary>
    /// The details of the asset (resource) found.
    /// </summary>
    [DataContract]
    public class SearchResource
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "resource_type")]
        protected string m_resourceType;

        /// <summary>
        /// The public id of the asset.
        /// </summary>
        [DataMember(Name = "public_id")]
        public string PublicId { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "folder")]
        public string Folder { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "filename")]
        public string FileName { get; protected set; }

        /// <summary>
        /// Date when asset was created.
        /// </summary>
        [DataMember(Name = "created_at")]
        public string Created { get; protected set; }

        /// <summary>
        /// The format of the asset (png, mp4, etc...).
        /// </summary>
        [DataMember(Name = "format")]
        public string Format { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "version")]
        public string Version { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        public ResourceType ResourceType
        {
            get { return Api.ParseCloudinaryParam<ResourceType>(m_resourceType); }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "uploaded_at")]
        public string Uploaded { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "backup_bytes")]
        public int BackupBytes { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "width")]
        public int Width { get; protected set; }

        /// <summary>
        /// Width of the media asset.
        /// </summary>
        [DataMember(Name = "height")]
        public int Height { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "aspect_ratio")]
        public double AspectRatio { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "pixels")]
        public int Pixels { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "tags")]
        public string[] Tags { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "context")]
        public JToken Context { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "image_analysis")]
        public JToken ImageAnalysis { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "image_metadata")]
        public Dictionary<string, string> Metadata { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "secure_url")]
        public string SecureUrl { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "status")]
        public string Status { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "access_mode")]
        public string AccessMode { get; protected set; }

        /// <summary>
        /// The size of the asset.
        /// </summary>
        [DataMember(Name = "bytes")]
        public long Length { get; protected set; }
    }
}

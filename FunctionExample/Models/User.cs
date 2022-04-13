using System;
using System.Text.Json.Serialization;

namespace FunctionExample.Models
{
    public class User
    {
        [JsonPropertyName("login")]
        public string Login { get; set; }
        [JsonPropertyName("id")] 
        public int Id { get; set; }
        [JsonPropertyName("node_id")]
        public string NodeId { get; set; }
        [JsonPropertyName("avatarUrl")]
        public string AvatarUrl { get; set; }
        [JsonPropertyName("gravatar_id")]
        public string GravatarId { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("htmlUrl")]
        public string HtmlUrl { get; set; }
        [JsonPropertyName("followersUrl")]
        public string FollowersUrl { get; set; }
        [JsonPropertyName("followingUrl")]
        public string FollowingUrl { get; set; }
        [JsonPropertyName("gistsUrl")]
        public string GistsUrl { get; set; }
        [JsonPropertyName("starredUrl")]
        public string StarredUrl { get; set; }
        [JsonPropertyName("subscriptionsUrl")]
        public string SubscriptionsUrl { get; set; }
        [JsonPropertyName("organizationsUrl")]
        public string OrganizationsUrl { get; set; }
        [JsonPropertyName("reposUrl")]
        public string ReposUrl { get; set; }
        [JsonPropertyName("eventsUrl")]
        public string EventsUrl { get; set; }
        [JsonPropertyName("received_eventsUrl")]
        public string ReceivedEventsUrl { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("site_admin")]
        public bool SiteAdmin { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("company")]
        public object Company { get; set; }
        [JsonPropertyName("blog")]
        public string Blog { get; set; }
        [JsonPropertyName("location")]
        public string Location { get; set; }
        [JsonPropertyName("email")]
        public object Email { get; set; }
        [JsonPropertyName("hireable")]
        public object Hireable { get; set; }
        [JsonPropertyName("bio")]
        public string Bio { get; set; }
        [JsonPropertyName("twitter_username")]
        public object TwitterUsername { get; set; }
        [JsonPropertyName("public_repos")]
        public int PublicRepos { get; set; }
        [JsonPropertyName("public_gists")]
        public int PublicGists { get; set; }
        [JsonPropertyName("followers")]
        public int Followers { get; set; }
        [JsonPropertyName("following")]
        public int Following { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }


}

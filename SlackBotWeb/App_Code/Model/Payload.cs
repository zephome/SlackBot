using Newtonsoft.Json;
using System.Collections.Generic;

/// <summary>
/// Payload의 요약 설명입니다.
/// </summary>
[JsonObject(Title = "attachments")]
public class Payload
{
    /*
        https://api.slack.com/docs/formatting
        https://api.slack.com/docs/attachments
    */

    [JsonProperty("channel")]
    public string Channel { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("icon_url")]
    public string IconUrl { get; set; }
    
    
    //public Attachments attachments { get; set; } 

    public List<object> attachments { get; set; }
}
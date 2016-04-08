using System;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.Collections.Generic;

/// <summary>
/// SlackBot의 요약 설명입니다.
/// </summary>
public class SlackBot
{
    private readonly Uri _uri = new Uri("Slack Income WebHooks URL");
    private readonly Encoding _encoding = new UTF8Encoding();

    /*public SlackBot(string urlWithAccessToken)
    {
        _uri = new Uri(urlWithAccessToken);
    }*/

    /*
        // https://api.slack.com/docs/formatting/builder?msg=%7B%22username%22%3A%22Coresoft%22%2C%22icon_url%22%3A%22http%3A%2F%2F210.109.97.108%3A10000%2Fredmine%2Fcoreicon.png%22%2C%22attachments%22%3A%5B%7B%22fallback%22%3A%222016.%204.%208%20Coresoft%20Lunch%20Bot%EC%9D%98%20%EC%B6%94%EC%B2%9C%20%EB%A9%94%EB%89%B4%22%2C%22pretext%22%3A%222016.%204.%208%20Coresoft%20Lunch%20Bot%EC%9D%98%20%EC%B6%94%EC%B2%9C%20%EB%A9%94%EB%89%B4%22%2C%22color%22%3A%22%23dd00ff%22%2C%22title%22%3A%22%EC%B6%94%EC%B2%9C%EC%A0%90%EC%8B%AC%20%EB%A9%94%EB%89%B4%22%2C%22text%22%3A%221.%20%EA%B9%80%EC%B9%98%EC%B0%8C%EA%B0%9C%5Cn2.%20%EC%88%9C%EB%91%90%EB%B6%80%5Cn3.%20%EB%90%9C%EC%9E%A5%EC%B0%8C%EA%B0%9C%22%7D%5D%7D
        { "channel": "#test",
          "username": "Coresoft", 
          "icon_url": "아이콘 URL" ,
	      "attachments": [
            {  
                "fallback": "2016. 4. 8 Coresoft Lunch Bot의 추천 메뉴", 
                "pretext": "2016. 4. 8 Coresoft Lunch Bot의 추천 메뉴", 
                "color": "#dd00ff", 
                "title": "추천점심 메뉴", 
                "text": "1. 김치찌개\n2. 순두부\n3. 된장찌개"
            }
        ]
    }
    */

    public void PostMessage(string title, string text, string fallback, string username = null, string channel = null, string iconurl = null)
    {
        Payload payload = new Payload()
        {
            Channel = channel,
            Username = username,
            IconUrl = iconurl
        };

        // attachment Child Node 생성
        payload.attachments = new List<object>();
        payload.attachments.Add(new
        {
            fallback = fallback,
            pretext = fallback,
            color = "#dd00ff",
            title = title,
            text = text
        });

        PostMessage(payload);
    }
    
    private void PostMessage(Payload payload)
    {
        string payloadJson = JsonConvert.SerializeObject(payload, Formatting.Indented);

        using (WebClient client = new WebClient())
        {
            NameValueCollection data = new NameValueCollection();
            data["payload"] = payloadJson;

            var response = client.UploadValues(_uri, "POST", data);
            
            string responseText = _encoding.GetString(response);
        }
    }
}
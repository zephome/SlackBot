using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 금일날자
        DateTime now = DateTime.Now;

        // SlackBot API Send
        SlackBot slackBot = new SlackBot();
        Lunch lunch = new Lunch();

        slackBot.PostMessage(title: "추천점심 메뉴",
                             username: "Coresoft",
                             fallback: now.ToShortDateString() + " Lunch Bot의 추천 메뉴",
                             text: "오늘의 점심 " + lunch.LunchSelect() + " 어떠세요?",
                             channel: "#test",
                             iconurl: "아이콘 URL");
    }
}
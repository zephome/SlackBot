# SlackBot
Slack Lunch Bot (점심 추천 봇)

## Description
Slack Income Webhook을 이용하여 점심메뉴를 선택해주는 Slack Bot

- Method: https://api.slack.com/methods/chat.postMessage
- Message Formatting: https://api.slack.com/docs/formatting
- Message Attachments: https://api.slack.com/docs/attachments

## Configuration
- App_Code/SlackBot.cs > _uri를 Slack Income Webhooks URL로 수정
- Slack icon 변경 시 Default.aspx.cs > PostMessage(iconurl) 변경

## To Do List
- Webhooks URL, JSON(icon_url, attachments.color) 공통 변수로 분리

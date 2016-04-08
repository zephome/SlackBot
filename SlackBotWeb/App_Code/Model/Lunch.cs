using System;

/// <summary>
/// Lunch의 요약 설명입니다.
/// </summary>
public class Lunch
{
    public string[] lunchMenu = new string[]
    {
        "김치찌개",
        "동태찌개",
        "오징어볶음",
        "대성",
        "SK",
        "돼지불백",
        "짬뽕",
        "짜장면"
    };

    public string LunchSelect()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, lunchMenu.Length);

        return lunchMenu[randomNumber];
    }
}
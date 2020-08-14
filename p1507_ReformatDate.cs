public class Solution {
     public string ReformatDate(string date)
        {
            var splitDate = date.Split(' ');

            var months = new string[]
            {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct",
                "Nov",
                "Dec"
            };

            var formattedDate = new StringBuilder();

            formattedDate.Append(splitDate[2]);

            formattedDate.Append("-");
            for (int i = 0; i < months.Length; ++i)
            {
                if (splitDate[1].CompareTo(months[i]) == 0)
                {
                    if (i < 9)
                    {
                        formattedDate.Append("0");
                    }
                    formattedDate.Append(i + 1);
                    break;
                }
            }
            formattedDate.Append("-");

            var day = splitDate[0].Substring(0, splitDate[0].Length - 2);
            if (day.Length < 2)
                formattedDate.Append("0");
            formattedDate.Append(day);
            return formattedDate.ToString();
        }
}
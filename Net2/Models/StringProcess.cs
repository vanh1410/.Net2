namespace Net2.Models
{
    public class StringProcess
    {
        public string RemoveRemainingWhiteSpace(string strInput)
        {
            string strResult = "";
            strInput = strInput.Trim();
            while (strInput.IndexOf("  ") > 0)
            {
                strInput = strInput.Replace("  ", " ");
            }
            strResult = strInput;
            return strResult;
        }

        public string LowerToUpper(string strInput)
        {
            return strInput.ToUpper();
        }

        public string UpperToLower(string strInput)
        {
            return strInput.ToLower();
        }

        public string CapitalizeOneFirstCharacter(string strInput)
        {
            return strInput.Substring(0, 1).ToUpper() + strInput.Substring(1);
        }

        public string CapitalizeFirstCharacter(string strInput)
        {
            string result = "";
            for (int i = 1; i < strInput.Length; i++)
            {
                if (strInput[i - 1] == ' ')
                {
                    result += strInput.Substring(i, 1).ToUpper();
                }
                else
                {
                    result += strInput[i];
                }
            }
            return result;
        }

        public string RemoveVietnamese(string strInput)
        {

            string[] VietnameseSigns = new string[]
            {
                "aAeEoOuUiIdDyY",
                "áàạảãâấầậẩẫăắằặẳẵ",
                "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                "éèẹẻẽêếềệểễ",
                "ÉÈẸẺẼÊẾỀỆỂỄ",
                "óòọỏõôốồộổỗơớờợởỡ",
                "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                "úùụủũưứừựửữ",
                "ÚÙỤỦŨƯỨỪỰỬỮ",
                "íìịỉĩ",
                "ÍÌỊỈĨ",
                "đ",
                "Đ",
                "ýỳỵỷỹ",
                "ÝỲỴỶỸ"
            };
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    strInput = strInput.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return strInput;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WateringWeb.Pages
{
    public class testIndex1Model : PageModel
    {
        public string WateringStatus { get; set; }
        public string StatusColor { get; set; }

        public void OnGet()
        {
            WateringStatus = GetWateringStatus();
            StatusColor = GetStatusColor(WateringStatus);
        }

        private string GetWateringStatus()
        {
            // 實現此方法以返回實際的灑水器狀態
            // 這可能是從數據庫、API 請求或其他位置獲取的狀態信息
            return "待機"; // 例如，假設灑水器當前正在運轉
        }

        private string GetStatusColor(string status)
        {
            switch (status)
            {
                case "運轉中":
                    return "red";
                case "待機":
                    return "green";
                default:
                    return "gray";
            }
        }
    }
}

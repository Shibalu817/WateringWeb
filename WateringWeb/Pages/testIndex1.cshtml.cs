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
            // ��{����k�H��^��ڪ��x�������A
            // �o�i��O�q�ƾڮw�BAPI �ШD�Ψ�L��m��������A�H��
            return "�ݾ�"; // �Ҧp�A���]�x������e���b�B��
        }

        private string GetStatusColor(string status)
        {
            switch (status)
            {
                case "�B�त":
                    return "red";
                case "�ݾ�":
                    return "green";
                default:
                    return "gray";
            }
        }
    }
}

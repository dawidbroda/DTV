using System;

namespace DTV_App.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}


//@section Scripts {
//    <partial name = "_ValidationScriptsPartial" />
//}
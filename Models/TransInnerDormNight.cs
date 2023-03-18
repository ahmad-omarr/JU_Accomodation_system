using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class TransInnerDormNight
    {
        public int TransInnerDormNightId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Zahraa Title")]

        public string TransZahraaDormNightRoomTitle { get; set; }
        [DisplayName("Zahraa Brief")]

        public string TransZahraaDormNightRoomBrief { get; set; }
        [DisplayName("Zahraa Image")]
        public string TransZahraaDormNightRoomImage { get; set; }
        [DisplayName("Zahraa LinkUrl")]
        public string TransZahraaDormNightRoomLinkUrl { get; set; }
        [DisplayName("Andalus Title")]
        public string TransAndalusDormNightRoomTitle { get; set; }
        [DisplayName("Andalus Brief")]
        public string TransAndalusDormNightRoomBrief { get; set; }
        [DisplayName("Andalus Image")]
        public string TransAndalusDormNightRoomImage { get; set; }
        [DisplayName("Andalus LinkUrl")]
        public string TransAndalusDormNightRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }
    }
}

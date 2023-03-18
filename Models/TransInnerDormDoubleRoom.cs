using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class TransInnerDormDoubleRoom
    {
        public int TransInnerDormDoubleRoomId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Zahraa Title")]
        public string TransZahraaDormDoubleRoomTitle { get; set; }
        [DisplayName("Zahraa Brief")]
        public string TransZahraaDormDoubleRoomBrief { get; set; }
        [DisplayName("Zahraa Image")]
        public string TransZahraaDormDoubleRoomImage { get; set; }
        [DisplayName("Zahraa LinkUrl")]
        public string TransZahraaDormDoubleRoomLinkUrl { get; set; }
        [DisplayName("Andalus Title")]
        public string TransAndalusDormDoubleRoomTitle { get; set; }
        [DisplayName("Andalus Brief")]
        public string TransAndalusDormDoubleRoomBrief { get; set; }
        [DisplayName("Andalus Image")]
        public string TransAndalusDormDoubleRoomImage { get; set; }
        [DisplayName("Andalus LinkUrl")]
        public string TransAndalusDormDoubleRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }
    }
}

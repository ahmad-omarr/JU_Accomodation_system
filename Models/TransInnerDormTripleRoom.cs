using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class TransInnerDormTripleRoom
    {
        public int TransInnerDormTripleRoomId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Zahraa Title")]
        public string TransZahraaDormTripleRoomTitle { get; set; }
        [DisplayName("Zahraa Brief")]
        public string TransZahraaDormTripleRoomBrief { get; set; }
        [DisplayName("Zahraa Image")]
        public string TransZahraaDormTripleRoomImage { get; set; }
        [DisplayName("Zahraa LinkUrl")]
        public string TransZahraaDormTripleRoomLinkUrl { get; set; }
        [DisplayName("Andalus Title")]
        public string TransAndalusDormTripleRoomTitle { get; set; }
        [DisplayName("Andalus Brief")]
        public string TransAndalusDormTripleRoomBrief { get; set; }
        [DisplayName("Andalus Image")]
        public string TransAndalusDormTripleRoomImage { get; set; }
        [DisplayName("Andalus LinkUrl")]
        public string TransAndalusDormTripleRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }
    }
}

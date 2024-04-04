using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.Announcement
{
    public class ViewAnnouncementDto
    {
        public int AnnouncementID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateAnnouncement { get; set; }
        public bool Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationManagementSystem
{
    public class PermamentCardHolder
    {
        public string CardNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BloodGroup { get; set; }

        public string Cadre { get; set; }

        public string Crew { get; set; }

        public string DateOfBirth { get; set;}

        public string Department { get; set; }

        public string Designation { get; set;}

        public string EmergancyContactNumber { get; set; }

        public string CNICNumber { get; set; }

        public string PNumber { get; set; }

        public string Section { get; set; }

        public bool GallagherCardHolder { get; set; }

        public List<CheckInAndOutInfo> CheckInInfos { get; set; }

        public List<BlockedPersonInfo> BlockedInfos { get; set; }
    }
}

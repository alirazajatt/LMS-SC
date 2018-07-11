using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationManagementSystem
{
    public class ContractorCardHolder
    {
        public string CardNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CompanyName { get; set; }

        public string Cadre { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public string EmergancyContactNumber { get; set; }

        public string CNICNumber { get; set; }

        public string WONumber { get; set; }

        public string Section { get; set; }

        public bool GallagherCardHolder { get; set; }

        public List<BlockedPersonInfo> BlockedPersonsInfos { get; set; }

        public List<CheckInAndOutInfo> CheckInInfos { get; set; }
    }
}

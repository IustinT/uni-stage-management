using System;
using System . Configuration;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Stage_Management_Aplication
{
    class AplicationSettings : ApplicationSettingsBase
    {

        /// <summary>
        /// Keeps track of the last - opened file
        /// </summary>
        [UserScopedSetting()]
        public String RecordsFile
        {
            get
            {
                return ( (String) this ["RecordsFile"] );
            }
            set
            {
                this ["RecordsFile"] = (String) value;
            }
        }
    }
}

using KB.Suleymanov.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Suleymanov.Model
{
    public class Monitor : BaseModel
    {
        // фирма монитора
        public string MonitorName { get; set; }

        // модель монитора
        public string MonitorModel { get; set; }

        // дата выпуска монитора
        public string DateOfCreate { get; set; }

    }
}

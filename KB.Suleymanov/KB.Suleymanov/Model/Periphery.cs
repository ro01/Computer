using KB.Suleymanov.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Suleymanov.Model
{
    public class Periphery : BaseModel
    {
        // наименование периферийных устройств
        public string PeripheryName { get; set; }

        // модель периферийных устройств
        public string PeripheryModel { get; set; }

        // дата выпуска периферийных устройств
        public string DateOfCreate { get; set; }
    }
}

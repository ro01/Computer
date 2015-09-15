using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Suleymanov.Model.Common
{
    public abstract class BaseModel
    {
        // считываем с БД наименование (ID) и другие данные товаров
        public int Id { get; set; }
    }
}

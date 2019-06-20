using DoNotGiveUp.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNotGiveUp.DAL.ORM.Interface
{
    public interface IBaseEntity
    {
        Guid ID { get; set; }
        DateTime AddDate { get; set; }
        DateTime UpdateDate { get; set; }
        DateTime DeleteDate { get; set; }
        Status Status { get; set; }
    }
}

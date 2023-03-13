using CoimbatoreFinanceAPI.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.Models
{

    public class AreaInsert
    {
        public AreaInsert(AreaModel Params)
        {
            Area.AreaInsert(Params.UserCode, Params.AreaName, Params.AreaCode, Params.LineID);
        }
    }
    public class AreaUpdate
    {
        public AreaUpdate(AreaModel Params)
        {
            Area.AreaUpdate(Params.UserCode, Params.AreaName, Params.AreaCode, Params.LineID, Params.AreaID);
        }
    }
    public class AreaList
    {
        public List<AreaModel> GeneralList { get; set; }
        public AreaList(AreaModel Params)
        {
            DataTable dt = Area.AreaList(Params.AreaID);
            GeneralList = dt.ToList<AreaModel>();
        }
    }
    public class AreaDelete
    {
        public AreaDelete(AreaModel Params)

        {
            Area.AreaDelete(Params.UserCode, Params.AreaID);
        }
    }
    public class AreaModel
    {
        public int AreaID { get; set; }
        public int UserCode { get; set; }
        public string AreaName { get; set; }
        public string AreaCode { get; set; }
        public int LineID { get; set; }
    }
}
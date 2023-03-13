using CoimbatoreFinanceAPI.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.Models
{
    public class LineInsert
    {
        public LineInsert(LineModel Params)
        {
            Line.LineInsert(Params.UserCode
                                            , Params.LineCode
                                            , Params.LineName);
        }
    }
    public class LineUpdate
    {
        public LineUpdate(LineModel Params)
        {
            Line.LineUpdate(Params.UserCode
                                            , Params.LineCode
                                            , Params.LineName
                                            , Params.LineID);
        }
    }
    public class LineList
    {
        public List<LineModel> GeneralList { get; set; }
        public LineList(LineModel Params)
        {
            DataTable dt = Line.LineList(Params.LineID);
            GeneralList = dt.ToList<LineModel>();
        }
    }
    public class LineDelete
    {
        public LineDelete(LineModel Params)

        {
            Line.LineDelete(Params.UserCode, Params.LineID);
        }
    }
    public class LineModel
    {
        public int UserCode { get; set; }
        public string LineCode { get; set; }
        public string LineName { get; set; }
        public int LineID { get; set; }
    }
}
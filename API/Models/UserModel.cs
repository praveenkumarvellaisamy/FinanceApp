using CoimbatoreFinanceAPI.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebAPI_Montensseri.Frameworks;

namespace CoimbatoreFinanceAPI.Models
{
    public class UserInsert
    {
        public UserInsert(UserModel Params)
        {
            User.UserInsert(Params.UserCode
                                 , Params.FirstName
                                 , Params.LastName
                                 , Params.UserName
                                 , Params.Password
                                 , Params.UserTypeID
                                 , Params.UserType
                                 , Params.ApplicableCompanyID
                                 , Params.ApplicableCompany
                                 , Params.Phonenumber
                                 , Params.DefaultCompanyID
                                 , Params.ApplicableArea
                                 , Params.ProfilePicPath);
        }
    }
    public class UserUpdate
    {
        public UserUpdate(UserModel Params)
        {
            User.UserUpdate(Params.UserCode
                                 , Params.FirstName
                                 , Params.LastName
                                 , Params.UserName
                                 , Params.Password
                                 , Params.UserTypeID
                                 , Params.UserType
                                 , Params.ApplicableCompanyID
                                 , Params.ApplicableCompany
                                 , Params.Phonenumber
                                 , Params.DefaultCompanyID
                                 , Params.ApplicableArea
                                 , Params.ProfilePicPath
                                 , Params.UserCodeID );
        }
    }
    public class UserList
    {
        public List<UserModel> GeneralList { get; set; }
        public UserList(UserModel Params)
        {
            DataTable dt = User.UserList(Params.UserCodeID);
            GeneralList = dt.ToList<UserModel>();
        }
    }
    public class UserDelete
    {
        public UserDelete(UserModel Params)

        {
            User.UserDelete(Params.UserCodeID);
        }
    }
    public class UserModel
    {
        public int UserCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserTypeID { get; set; }
        public string UserType { get; set; }
        public int ApplicableCompanyID { get; set; }
        public string ApplicableCompany { get; set; }
        public string Phonenumber { get; set; }
        public int DefaultCompanyID { get; set; }
        public string ApplicableArea { get; set; }
        public string ProfilePicPath { get; set; }
        public int UserCodeID { get; set; }
    }
}
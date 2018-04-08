using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SmartManager.Models;
using SmartManger.DAL;
namespace SmartManger.BAL
{
    public class LoginBAL
    {
        public Int32 SaveUser(LoginModel _objModel)
        {
            LoginDAL _objDAL = new LoginDAL();
            try
            {
                return _objDAL.SaveUser(_objModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                _objDAL = null;
            }
        }

        public SqlDataReader GetUsers()
        {
            LoginDAL _objDAL = new LoginDAL();
            try
            {
                return _objDAL.GetUsers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //_objDAL = null;
            }
        }

        public Int32 UpdateUser(LoginModel _objModel) 
        {
            LoginDAL _objDAL = new LoginDAL();
            try
            {
                return _objDAL.UpdateUser(_objModel);
            }
            catch(Exception ex) 
            {
                throw ex;
            }
            finally
            {
                _objDAL = null;
            }
           
        }

        public Int32 DeleteUser(Int32 _LoginID)
        {
            LoginDAL _objDAL = new LoginDAL();
            try
            {
                return _objDAL.DeleteUser(_LoginID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _objDAL = null;
            }
        }

        public LoginModel SearchUser(Int32 _LoginID) 
        {LoginModel _objModel=new LoginModel();
            LoginDAL _objDAL = new LoginDAL();
            try
            {
                DataTable dt= _objDAL.SearchUser(_LoginID);
                foreach (DataRow item in dt.Rows)
                {
                   _objModel._Username  = item["Username"].ToString();
                   _objModel._Password = item["Password"].ToString();
                   _objModel._EmailAddress = item["EmailAddress"].ToString();
                   _objModel._ModifiedDate = Convert.ToDateTime(item["ModifiedDate"].ToString());
                   _objModel._UserRole = Convert.ToInt32(item["UserRole"].ToString());
                }
                return _objModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _objDAL = null;
            }
        }

        public DataTable FillRoleList()
        {
            LoginDAL _objDAL = new LoginDAL();
            try
            {
                return _objDAL.FillRoleList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _objDAL = null;
            }
        }

        public LoginModel SearchByUserNme(string _UserName) 
        {
            LoginDAL _ObjDAL = new LoginDAL();
            DataTable dt = _ObjDAL.SearchByUsername(_UserName);
            
            LoginModel obj = new LoginModel();
            foreach (DataRow item in dt.Rows)
            {
                obj._Username = item["Username"].ToString();
                obj._Password = item["Password"].ToString();
                obj._EmailAddress = item["EmailAddress"].ToString();
                obj._ModifiedDate = Convert.ToDateTime(item["ModifiedDate"].ToString());
            }
            return obj;
        }

    }
}

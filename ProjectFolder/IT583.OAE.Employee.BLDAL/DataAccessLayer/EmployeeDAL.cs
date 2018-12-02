using IT583.OAE.Employee.BLDAL.BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT583.OAE.Employee.BLDAL.DataAccessLayer
{
    public class EmployeeDAL : DBHelper
    {
        #region Fields

        private SqlConnection _sqlConn;

        #endregion

        #region Constructors

        public EmployeeDAL()
        {
            _sqlConn = base._basesqlConn;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Inserts a record to the Employee table.
        /// </summary>
        public bool Employee_Insert(Employees employee)
        {
            bool status = false;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "usp_Employee_Insert";
                sqlCmd.Connection = this._sqlConn;
                sqlCmd.Parameters.AddWithValue("@LastName", employee.LastName);
                sqlCmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                sqlCmd.Parameters.AddWithValue("@Gender", ((employee.Gender != null) ? (object)employee.Gender : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@Middlename", ((employee.MiddleName != null) ? (object)employee.MiddleName : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@HiredDate", employee.HiredDate);
                if (this._sqlConn.State == ConnectionState.Closed)
                {
                    this._sqlConn.Open();
                }
                int numberOfRecordsAffected = sqlCmd.ExecuteNonQuery();
                if (numberOfRecordsAffected > 0)
                {
                    status = true;
                }
                this._sqlConn.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                status = false;
            }
            return status;
        }


        /// <summary>
        /// Updates a record in the Employee table.
        /// </summary>
        public bool Employee_Update(Employees employee)
        {
            bool status = false;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "usp_Employee_Update";
                sqlCmd.Connection = this._sqlConn;
                sqlCmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                sqlCmd.Parameters.AddWithValue("@LastName", employee.LastName);
                sqlCmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                sqlCmd.Parameters.AddWithValue("@Gender", ((employee.Gender != null) ? (object)employee.Gender : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@Middlename", ((employee.MiddleName != null) ? (object)employee.MiddleName : DBNull.Value));
                sqlCmd.Parameters.AddWithValue("@HiredDate", employee.HiredDate);
                if (this._sqlConn.State == ConnectionState.Closed)
                {
                    this._sqlConn.Open();
                }
                int numberOfRecordsAffected = sqlCmd.ExecuteNonQuery();
                if (numberOfRecordsAffected > 0)
                {
                    status = true;
                }
                this._sqlConn.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                status = false;
            }
            return status;
        }

        /// <summary>
        /// Deletes a record from the Employee table by its primary key.
        /// </summary>
        public bool Employee_Delete(Employees employee)
        {
            bool status = false;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "usp_Employee_Delete";
                sqlCmd.Connection = this._sqlConn;
                sqlCmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                if (this._sqlConn.State == ConnectionState.Closed)
                {
                    this._sqlConn.Open();
                }
                int numberOfRecordsAffected = sqlCmd.ExecuteNonQuery();
                if (numberOfRecordsAffected > 0)
                {
                    status = true;
                }
                this._sqlConn.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                status = false;
            }
            return status;
        }


        /// <summary>
        /// Selects a record from the Employee table by its primary key.
        /// </summary>
        public SqlDataReader Employee_Select(Employees employee)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "usp_Employee_Select";
            sqlCmd.Connection = this._sqlConn;
            sqlCmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
            if (this._sqlConn.State == ConnectionState.Closed)
            {
                this._sqlConn.Open();
            }
            SqlDataReader rd = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            return rd;
        }


        /// <summary>
        /// Selects all records from the Employee table by its primary key.
        /// </summary>
        public SqlDataReader Employee_SelectList()
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "usp_Employee_SelectList";
            sqlCmd.Connection = this._sqlConn;
            if (this._sqlConn.State == ConnectionState.Closed)
            {
                this._sqlConn.Open();
            }
            SqlDataReader rd = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            return rd;
        }

        #endregion
    }
}

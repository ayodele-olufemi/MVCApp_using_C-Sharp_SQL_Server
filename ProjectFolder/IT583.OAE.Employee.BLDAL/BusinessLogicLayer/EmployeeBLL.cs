using IT583.OAE.Employee.BLDAL.BusinessObjectLayer;
using IT583.OAE.Employee.BLDAL.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT583.OAE.Employee.BLDAL.BusinessLogicLayer
{
    public class EmployeeBLL
    {
        #region Constructor

        public EmployeeBLL()
        {

        }

        #endregion


        #region Methods


        /// <summary>
		/// Inserts a record to the Employee table.
		/// </summary>
		public static bool Employee_Insert(Employees _employeee)
        {
            EmployeeDAL IO = new EmployeeDAL();
            return IO.Employee_Insert(_employeee);
        }


        /// <summary>
		/// Updates a record to the Employee table.
		/// </summary>
		public static bool Employee_Update(Employees _employee)
        {
            EmployeeDAL IO = new EmployeeDAL();
            return IO.Employee_Update(_employee);
        }


        /// <summary>
		/// Deletes a record from the Employee table by its primary key.
		/// </summary>
		public static bool Employee_Delete(Employees _employee)
        {
            EmployeeDAL IO = new EmployeeDAL();
            return IO.Employee_Delete(_employee);
        }


        /// <summary>
        /// Selects a record from the Employee table.
        /// </summary>
        public static Employees Employee_Select(Employees _employee)
        {
            Employees employee = new Employees();
            try
            {
                EmployeeDAL IO = new EmployeeDAL();
                SqlDataReader myReader = IO.Employee_Select(_employee);
                while (myReader.Read())
                {
                    if (myReader["EmployeeID"] != DBNull.Value)
                    {
                        employee.EmployeeID = (int)myReader["EmployeeID"];
                    }
                    if (myReader["LastName"] != DBNull.Value)
                    {
                        employee.LastName = (string)myReader["LastName"];
                    }
                    if (myReader["FirstName"] != DBNull.Value)
                    {
                        employee.FirstName = (string)myReader["FirstName"];
                    }
                    if (myReader["Gender"] != DBNull.Value)
                    {
                        employee.Gender = (string)myReader["Gender"];
                    }
                    if (myReader["MiddleName"] != DBNull.Value)
                    {
                        employee.MiddleName = (string)myReader["MiddleName"];
                    }
                    if (myReader["HiredDate"] != DBNull.Value)
                    {
                        employee.HiredDate = (DateTime)myReader["HiredDate"];
                    }
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                return new Employees();
            }
            return employee;
        }


        /// <summary>
        /// Select all records to the Supplier table.
        /// </summary>
        public static List<Employees> Employee_SelectList()
        {
            List<Employees> EmployeeList = new List<Employees>();
            try
            {
                EmployeeDAL IO = new EmployeeDAL();
                SqlDataReader myReader = IO.Employee_SelectList();
                while (myReader.Read())
                {
                    Employees employee = new Employees();
                    if (myReader["EmployeeID"] != DBNull.Value)
                    {
                        employee.EmployeeID = (int)myReader["EmployeeID"];
                    }
                    if (myReader["FirstName"] != DBNull.Value)
                    {
                        employee.FirstName = (string)myReader["FirstName"];
                    }
                    if (myReader["LastName"] != DBNull.Value)
                    {
                        employee.LastName = (string)myReader["LastName"];
                    }
                    if (myReader["MiddleName"] != DBNull.Value)
                    {
                        employee.MiddleName = (string)myReader["MiddleName"];
                    }
                    if (myReader["Gender"] != DBNull.Value)
                    {
                        employee.Gender = (string)myReader["Gender"];
                    }
                    if (myReader["HiredDate"] != DBNull.Value)
                    {
                        employee.HiredDate = (DateTime)myReader["HiredDate"];
                    }
                    EmployeeList.Add(employee);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
                return new List<Employees>();
            }
            return EmployeeList;
        }

        #endregion
    }
}

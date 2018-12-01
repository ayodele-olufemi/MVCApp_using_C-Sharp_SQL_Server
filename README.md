# MVCApp_using_C-_SQL_Server
## Class assignment for IT583

Instructions: To recreate this app, do the following: 
-----------------------------------------------------

* Create a database named **Employee** in Microsoft SQL server. 
* Download and execute `EmployeeDB.sql` file in SQL server. This creates and populates an Employee table in the **Employee** database.
* Create a login named **EmployeeUser** in SQL Server and grant the user permission to use the Employee database.
	* In the Object Explorer, Expand **Security** (The main Security folder, not that under Employee), then right-click **Logins**, then click **New Login...**.
	* In the New Login dialog: 
		* Enter **EmployeeUser** as Login name;
		* Select **SQL Server authentication** and enter `employee123` as password and confirm password; 
		* Uncheck **Enforce password policy**;
		* Set default database to **Employee**;
		* In the menu on the left side, click `User Mapping` and select **Employee** checkbox.
		* Click OK.
* Test the created user login.
	* Disconnect Database Engine.
	* Reconnect using SQL Server Authentication. Enter the `EmployeeUser` and `employee123` in the Login and Password fields respectively. Then connect.
	* It should connect. If it doesn't, you may do the following to resolve the issue: 
		* Connect using Windows Authentication.
		* Right-click your server-name (top object in the Object Explorer) and select `Properties`. 
		* Select the Security tab and check the `SQL Server and Windows Authentication mode`, then select OK.
		* Close SSMS. 
		* From Windows menu, search and launch `Services`, then scroll and search for `SQL Server (MSSQLSERVER).
		* Right-click and select **Restart** to restart the service. 
		* Relauch your SSMS and try to login using the created user. It should work now. 
	





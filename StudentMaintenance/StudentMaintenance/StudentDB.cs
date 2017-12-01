using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentMaintenance
{
    public static class StudentDB
    {
        public static Student GetCustomer(int customerID)
        {
            MySqlConnection connection = BPUBDB.GetConnection();
            string selectStatement
                = "SELECT CustomerID, Name, Address, City, State, ZipCode "
                + "FROM Customers "
                + "WHERE CustomerID = @CustomerID";
            // must use @ because they are using a parameterized query, if they don't, SQLInjection can come into play
            // parameterized queries are the first guard against SQL injections
            MySqlCommand selectCommand =
                new MySqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@StudentID", studentID);
            //this creates parameters against SQL injections
            try
            {
                connection.Open();
                MySqlDataReader custReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow); //What is this?!
                // calling th execute reader method
                if (custReader.Read())
                {
                    Student student = new Student();
                    student.StudentID = (int)custReader["StudentID"];
                    student.FirstName = custReader["FirstName"].ToString();
                    student.LastName = custReader["FirstName"].ToString();
                    student.Address = custReader["Address"].ToString();
                    student.City = custReader["City"].ToString();
                    student.State = custReader["State"].ToString();
                    student.Zip = custReader["Zip"].ToString();
                    return student;
                    // capitilization matters
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int AddCustomer(Student customer)
        {
            MySqlConnection connection = BPUBDB.GetConnection();
            string insertStatement =
                "INSERT Customers " +
                "(FirstName, LastName, Address, City, State, Zip) " +
                "VALUES (@FirstName, @LastName, @Address, @City, @State, @Zip)";
            MySqlCommand insertCommand =
                new MySqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@FirstName", customer.FirstName);
            insertCommand.Parameters.AddWithValue(
                "@LastName", customer.LastName);
            insertCommand.Parameters.AddWithValue(
                "@Address", customer.Address);
            insertCommand.Parameters.AddWithValue(
                "@City", customer.City);
            insertCommand.Parameters.AddWithValue(
                "@State", customer.State);
            insertCommand.Parameters.AddWithValue(
                "@Zip", customer.Zip);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Student') FROM Student";
                //string nextID = "SELECT MAX(SID) FROM Student";
                MySqlCommand selectCommand =
                    new MySqlCommand(selectStatement, connection);
                int studentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return studentID;
                //How??
            }//this won't work in our solution, NEED to go find the MAX(ID)+ 1, Then you can insert data into it
            //must be two qeuries, can't do it in the same lines
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        
        public static bool UpdateCustomer(Student oldStudent,
            Student newStudent)
        {
            MySqlConnection connection = BPUBDB.GetConnection();
            string updateStatement =
                "UPDATE Student SET " +
                "FirstName = @NewFirstName, " +
                "LastName = @NewLastName, " +
                "Address = @NewAddress, " +
                "City = @NewCity, " +
                "State = @NewState, " +
                "Zip = @NewZip " +
                "WHERE Student = @oldStudentID " + //must be = the primary key
                "AND Name = @OldName " +
                "AND Address = @OldAddress " +
                "AND City = @OldCity " +
                "AND State = @OldState " +
                "AND Zip = @OldZip ";//make sure there are spaces and commas
            MySqlCommand updateCommand =
                new MySqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@NewFirstName", newStudent.FirstName);
            updateCommand.Parameters.AddWithValue(
               "@NewLastName", newStudent.LastName);
            updateCommand.Parameters.AddWithValue(
                "@NewAddress", newStudent.Address);
            updateCommand.Parameters.AddWithValue(
                "@NewCity", newStudent.City);
            updateCommand.Parameters.AddWithValue(
                "@NewState", newStudent.State);
            updateCommand.Parameters.AddWithValue(
                "@NewZip", newStudent.Zip);
            updateCommand.Parameters.AddWithValue(
                "@OldStudentID", oldStudent.StudentID);
            updateCommand.Parameters.AddWithValue(
                "@OldFirstName", oldStudent.FirstName);
            updateCommand.Parameters.AddWithValue(
                "@OldLastName", oldStudent.LastName);
            updateCommand.Parameters.AddWithValue(
                "@OldAddress", oldStudent.Address);
            updateCommand.Parameters.AddWithValue(
                "@OldCity", oldStudent.City);
            updateCommand.Parameters.AddWithValue(
                "@OldState", oldStudent.State);
            updateCommand.Parameters.AddWithValue(
                "@OldZip", oldStudent.Zip);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool DeleteCustomer(Student student)
        {
            MySqlConnection connection = BPUBDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Customers " +
                "WHERE CustomerID = @CustomerID " +
                "AND Name = @Name " +
                "AND Address = @Address " +
                "AND City = @City " +
                "AND State = @State " +
                "AND ZipCode = @ZipCode";
            MySqlCommand deleteCommand =
                new MySqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue(
                "@CustomerID", student.StudentID);
            deleteCommand.Parameters.AddWithValue(
                "@FirstName", student.FirstName);
            deleteCommand.Parameters.AddWithValue(
                "@LastName", student.LastName);
            deleteCommand.Parameters.AddWithValue(
                "@Address", student.Address);
            deleteCommand.Parameters.AddWithValue(
                "@City", student.City);
            deleteCommand.Parameters.AddWithValue(
                "@State", student.State);
            deleteCommand.Parameters.AddWithValue(
                "@Zip", student.Zip);
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
}

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
        public static Student GetStudent(int sid)
        {
            MySqlConnection connection = BPUBDB.GetConnection();
            string selectStatement
                = "SELECT SID, Fname, Lname, Street, City, State, Zip "
                + "FROM Student "
                + "WHERE SID = @SID";
            // must use @ because they are using a parameterized query, if they don't, SQLInjection can come into play
            // parameterized queries are the first guard against SQL injections
            MySqlCommand selectCommand =
                new MySqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@SID", sid);
            //this creates parameters against SQL injections
            try
            {
                connection.Open();
                MySqlDataReader stuReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow); //What is this?!
                // calling th execute reader method
                if (stuReader.Read())
                {
                    Student student = new Student();
                    student.SID = (int)stuReader["StudentID"];
                    student.Fname = stuReader["Fname"].ToString();
                    student.Lname = stuReader["Lname"].ToString();
                    student.Street = stuReader["Street"].ToString();
                    student.City = stuReader["City"].ToString();
                    student.State = stuReader["State"].ToString();
                    student.Zip = stuReader["Zip"].ToString();
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
                "INSERT Student " +
                "(Fname, Lname, Street, City, State, Zip) " +
                "VALUES (@Fname, @Lname, @Street, @City, @State, @Zip)";
            MySqlCommand insertCommand =
                new MySqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@Fname", customer.Fname);
            insertCommand.Parameters.AddWithValue(
                "@Lname", customer.Lname);
            insertCommand.Parameters.AddWithValue(
                "@Street", customer.Street);
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
                int sid = Convert.ToInt32(selectCommand.ExecuteScalar());
                return sid;
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
                "Fname = @NewFname, " +
                "Lname = @NewLname, " +
                "Street = @NewStreet, " +
                "City = @NewCity, " +
                "State = @NewState, " +
                "Zip = @NewZip " +
                "WHERE SID = @oldSID " + //must be = the primary key
                "AND Fname = @OldFname " +
                "AND Lname = @OldLname " +
                "AND Street = @OldStreet " +
                "AND City = @OldCity " +
                "AND State = @OldState " +
                "AND Zip = @OldZip ";//make sure there are spaces and commas
            MySqlCommand updateCommand =
                new MySqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@NewFname", newStudent.Fname);
            updateCommand.Parameters.AddWithValue(
               "@NewLname", newStudent.Lname);
            updateCommand.Parameters.AddWithValue(
                "@NewStreet", newStudent.Street);
            updateCommand.Parameters.AddWithValue(
                "@NewCity", newStudent.City);
            updateCommand.Parameters.AddWithValue(
                "@NewState", newStudent.State);
            updateCommand.Parameters.AddWithValue(
                "@NewZip", newStudent.Zip);
            updateCommand.Parameters.AddWithValue(
                "@OldSID", oldStudent.SID);
            updateCommand.Parameters.AddWithValue(
                "@OldFname", oldStudent.Fname);
            updateCommand.Parameters.AddWithValue(
                "@OldLname", oldStudent.Lname);
            updateCommand.Parameters.AddWithValue(
                "@OldStreet", oldStudent.Street);
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
        
    }
}


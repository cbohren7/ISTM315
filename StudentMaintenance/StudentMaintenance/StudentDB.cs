using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentMaintenance
{
    public static class StudentDB
    {
        /// <summary>
        /// This is opening the BPUBDB connection and using queries to access the following fields: SID, Fname, 
        /// Lname, Suffix, City, State, Zip, buyer, and seller
        /// </summary>
        /// <param name="SID"></param>
        /// <returns></returns>
        public static Student GetStudent(string SID)
        {
            MySqlConnection connection = BPUBDB.GetConnection();
            string selectStatement
                = "SELECT SID, Fname, Lname, Suffix, Street, City, State, Zip, buyer, seller "
                + "FROM Student "
                + "WHERE SID = @SID";

            MySqlCommand selectCommand =
                new MySqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@SID", SID);

            try
            {
                connection.Open(); //opening the DB connection
                MySqlDataReader stuReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow); 
                if (stuReader.Read())
                {
                    Student student = new Student();
                    student.SID = stuReader["SID"].ToString();
                    student.Fname = stuReader["Fname"].ToString();
                    student.Lname = stuReader["Lname"].ToString();
                    student.Suffix = stuReader["Suffix"].ToString();
                    student.Street = stuReader["Street"].ToString();
                    student.City = stuReader["City"].ToString();
                    student.State = stuReader["State"].ToString();
                    student.Zip = stuReader["Zip"].ToString();
                    student.Buyer = Convert.ToBoolean(stuReader["Buyer"]);
                    student.Seller = Convert.ToBoolean(stuReader["Seller"]);
                    return student;

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
                connection.Close(); //closing the DB connection
            }
        }
        /// <summary>
        /// THis is adding a student's information to the BPUBDB
        /// </summary>
        /// <param name="student"></param>
        public static void AddStudent(Student student)
        {
            MySqlConnection connection = BPUBDB.GetConnection();
            string insertStatement =
                "INSERT Student " +
                "(SID, Fname, Lname, Suffix, Street, City, State, Zip, buyer, seller) " + //do the buyer seller fields have '?' 
                "VALUES (@SID, @Fname, @Lname, @Suffix, @Street, @City, @State, @Zip, @Buyer, @Seller)";
            MySqlCommand insertCommand =
                new MySqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@SID", student.SID);
            insertCommand.Parameters.AddWithValue(
                "@Fname", student.Fname);
            insertCommand.Parameters.AddWithValue(
                "@Lname", student.Lname);
            insertCommand.Parameters.AddWithValue(
                "@Suffix", student.Suffix);
            insertCommand.Parameters.AddWithValue(
                "@Street", student.Street);
            insertCommand.Parameters.AddWithValue(
                "@City", student.City);
            insertCommand.Parameters.AddWithValue(
                "@State", student.State);
            insertCommand.Parameters.AddWithValue(
                "@Zip", student.Zip);
            insertCommand.Parameters.AddWithValue(
               "@Buyer", student.Buyer);
            insertCommand.Parameters.AddWithValue(
                "@Seller", student.Seller);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Student') FROM Student";
                MySqlCommand selectCommand =
                    new MySqlCommand(selectStatement, connection);
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
        /// <summary>
        /// This is accessing the BPUBDB and updating the changed fields.
        /// </summary>
        /// <param name="oldStudent"></param>
        /// <param name="newStudent"></param>
        /// <returns></returns>
        public static bool UpdateStudent(Student oldStudent,
            Student newStudent)
        {
            MySqlConnection connection = BPUBDB.GetConnection();
            string updateStatement =
                "UPDATE Student SET " +
                "SID = @NewSID, " +
                "Fname = @NewFname, " +
                "Lname = @NewLname, " +
                "Suffix = @NewSuffix, " +
                "Street = @NewStreet, " +
                "City = @NewCity, " +
                "State = @NewState, " +
                "Zip = @NewZip, " +
                "Buyer = @NewBuyer, " +
                "Seller = @NewSeller " +
                "WHERE SID = @oldSID " + //must be = the primary key
                "AND Fname = @OldFname " +
                "AND Lname = @OldLname " +
                "AND Street = @OldStreet " +
                "AND City = @OldCity " +
                "AND State = @OldState " + 
                "AND Zip = @OldZip " +
            "AND Buyer = @OldBuyer " +
            "AND Seller = @OldSeller ";
            MySqlCommand updateCommand =
                new MySqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@NewSID", newStudent.SID);
            updateCommand.Parameters.AddWithValue(
                "@NewFname", newStudent.Fname);
            updateCommand.Parameters.AddWithValue(
               "@NewLname", newStudent.Lname);
            updateCommand.Parameters.AddWithValue(
               "@NewSuffix", newStudent.Suffix);
            updateCommand.Parameters.AddWithValue(
                "@NewStreet", newStudent.Street);
            updateCommand.Parameters.AddWithValue(
                "@NewCity", newStudent.City);
            updateCommand.Parameters.AddWithValue(
                "@NewState", newStudent.State);
            updateCommand.Parameters.AddWithValue(
                "@NewZip", newStudent.Zip);
            updateCommand.Parameters.AddWithValue(
               "@NewBuyer", newStudent.Buyer);
            updateCommand.Parameters.AddWithValue(
                "@NewSeller", newStudent.Seller);
            updateCommand.Parameters.AddWithValue(
                "@OldSID", oldStudent.SID);
            updateCommand.Parameters.AddWithValue(
                "@OldFname", oldStudent.Fname);
            updateCommand.Parameters.AddWithValue(
                "@OldLname", oldStudent.Lname);
            updateCommand.Parameters.AddWithValue(
                "@OldSuffix", oldStudent.Suffix);
            updateCommand.Parameters.AddWithValue(
                "@OldStreet", oldStudent.Street);
            updateCommand.Parameters.AddWithValue(
                "@OldCity", oldStudent.City);
            updateCommand.Parameters.AddWithValue(
                "@OldState", oldStudent.State);
            updateCommand.Parameters.AddWithValue(
                "@OldZip", oldStudent.Zip);
            updateCommand.Parameters.AddWithValue(
             "@OldBuyer", oldStudent.Buyer);
            updateCommand.Parameters.AddWithValue(
                "@OldSeller", oldStudent.Seller);
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


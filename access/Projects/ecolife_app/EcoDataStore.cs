using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace EcoLife_App
{
    public static class EcoDataStore
    {
        public static string CurrentMember { get; set; } = "";

        // Connection string (SAFE)
        private static readonly string _connStr =
            $@"Provider=Microsoft.ACE.OLEDB.12.0;
               Data Source={Path.Combine(Application.StartupPath, "EcoDB.accdb")};
               Persist Security Info=False;";

        // ==============================
        // DATABASE INITIALIZATION
        // ==============================
        public static void InitializeDatabase()
        {
            try
            {
                using (var conn = new OleDbConnection(_connStr))
                {
                    conn.Open();

                    // --- MEMBERS TABLE ---
                    if (!TableExists(conn, "Members"))
                    {
                        using (var cmd = new OleDbCommand(
                            @"CREATE TABLE Members (
                                ID COUNTER PRIMARY KEY,
                                Username TEXT(50),
                                PassKey TEXT(50),
                                JoinDate DATETIME,
                                DailyGoal DOUBLE DEFAULT 0
                              )", conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // --- ECOLOGS TABLE ---
                    if (!TableExists(conn, "EcoLogs"))
                    {
                        using (var cmd = new OleDbCommand(
                            @"CREATE TABLE EcoLogs (
                                ID COUNTER PRIMARY KEY,
                                MemberName TEXT(50),
                                ActionType TEXT(50),
                                ImpactScore DOUBLE,
                                LogTime DATETIME
                              )", conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Init Error:\n" + ex.Message);
            }
        }

        private static bool TableExists(OleDbConnection conn, string tableName)
        {
            var schema = conn.GetSchema("Tables",
                new string[] { null, null, tableName, "TABLE" });
            return schema.Rows.Count > 0;
        }

        // ==============================
        // ACCOUNT
        // ==============================
        public static void CreateAccount(string username, string password)
        {
            using (var conn = new OleDbConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(
                    "INSERT INTO Members (Username, PassKey, JoinDate, DailyGoal) VALUES (?, ?, ?, 0)", conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.Add("@d", OleDbType.Date).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool ValidateUser(string username, string password)
        {
            using (var conn = new OleDbConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(
                    "SELECT COUNT(*) FROM Members WHERE Username=? AND PassKey=?", conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // ==============================
        // GOALS
        // ==============================
        public static void SetUserGoal(double goal)
        {
            using (var conn = new OleDbConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(
                    "UPDATE Members SET DailyGoal=? WHERE Username=?", conn))
                {
                    cmd.Parameters.AddWithValue("@g", goal);
                    cmd.Parameters.AddWithValue("@u", CurrentMember);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static double GetUserGoal()
        {
            using (var conn = new OleDbConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(
                    "SELECT DailyGoal FROM Members WHERE Username=?", conn))
                {
                    cmd.Parameters.AddWithValue("@u", CurrentMember);
                    var res = cmd.ExecuteScalar();
                    return (res != null && res != DBNull.Value)
                        ? Convert.ToDouble(res)
                        : 0;
                }
            }
        }

        // ==============================
        // ECO LOGGING
        // ==============================
        public static void LogEcoAction(string action, double score)
        {
            using (var conn = new OleDbConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(
                    "INSERT INTO EcoLogs (MemberName, ActionType, ImpactScore, LogTime) VALUES (?, ?, ?, ?)", conn))
                {
                    cmd.Parameters.AddWithValue("@m", CurrentMember);
                    cmd.Parameters.AddWithValue("@a", action);
                    cmd.Parameters.AddWithValue("@s", score);
                    cmd.Parameters.Add("@t", OleDbType.Date).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static double GetTotalImpact()
        {
            using (var conn = new OleDbConnection(_connStr))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(
                    "SELECT SUM(ImpactScore) FROM EcoLogs WHERE MemberName=?", conn))
                {
                    cmd.Parameters.AddWithValue("@m", CurrentMember);
                    var res = cmd.ExecuteScalar();
                    return (res != null && res != DBNull.Value)
                        ? Convert.ToDouble(res)
                        : 0;
                }
            }
        }
    }
}

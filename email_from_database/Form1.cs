using System;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace email_from_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {

            // Replace with your actual SQL Server connection string
            string connectionString = "Data Source=Amaze\\SQLEXPRESS;Initial Catalog=email_db;Integrated Security=True";

            // Create a new SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();
                    //Console.WriteLine("Connected to the database.");
                    lbl_connect_db.Text = "Connected to db";

                    // Define your SQL query
                    string sqlQuery = "SELECT * FROM dbo.tbl_user";

                    // Create a SqlCommand with the query and the connection
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        // Execute the query and get a SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if there are rows in the result set
                            if (reader.HasRows)
                            {
                                // Iterate through the rows and output data
                                while (reader.Read())
                                {
                                    // Example: assuming you have a column named "ColumnName"
                                    string recipientEmail = reader["email"].ToString();
                                    send_email(recipientEmail);
                                    lbl_email.Text = recipientEmail;

                                    
                                    //Console.WriteLine($"Value from database: {columnNameValue}");
                                }
                            }
                            else
                            {
                                lbl_email.Text = "No emails found!";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    // Ensure the connection is closed, whether an exception occurs or not
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Connection closed.");
                        lbl_email.Text = "Emails sent successfully!";
                    }
                }
            }

        }

        private void send_email(string recipientEmail)
        {

            // Set up the sender's email address and password
            string senderEmail = "<username>";
            string senderPassword = "<app password>";            
            
            // Create a new MailMessage
            MailMessage mail = new MailMessage(senderEmail, recipientEmail);

            // Set the subject and body of the email
            mail.Subject = "From a db email";
            mail.Body = "This is a test email sent from C#.";

            // Set up the SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587; // Use 587 for Gmail
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true;

            try
            {
                // Send the email
                smtpClient.Send(mail);
                lbl_email.Text = "Email sent successfully!";
                //Console.WriteLine("Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}

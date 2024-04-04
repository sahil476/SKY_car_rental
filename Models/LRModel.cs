using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace SKY_car_rental.Models
{
    public class LRModel
    {

        [Key]
        public int UserID { get; set; }


        public string? Username { get; set; }

        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$",
       ErrorMessage = "Password must be Minimum eight characters, at least one letter, one number and one special character.")]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        SqlConnection con = new SqlConnection("Server=COOLKEVIN\\SQLEXPRESS;Database=CarRental;Trusted_Connection=True;TrustServerCertificate=True");

        public bool InsertData(LRModel model)
        {
            using (SqlConnection con = new SqlConnection("Server=COOLKEVIN\\SQLEXPRESS;Database=CarRental;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.registration (name, email, password) VALUES (@name, @email, @password)");
                cmd.Connection = con; // Assign connection to the command
                cmd.Parameters.AddWithValue("@name", model.Username);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@password", model.Password);

                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public bool Login(LRModel model)
        {
            using (SqlConnection con = new SqlConnection("Server=COOLKEVIN\\SQLEXPRESS;Database=CarRental;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.registration WHERE email = @email AND password = @password", con);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@password", model.Password);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }



    }
}

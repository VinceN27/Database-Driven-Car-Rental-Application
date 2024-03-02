using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hw2Draft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            SqlConnection myconn = new SqlConnection();
            string ConnStringName = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\vince\\source\\repos\\Hw2Draft\\Hw2Draft\\Database1.mdf;Integrated Security=True";
            myconn.ConnectionString = ConnStringName;
            myconn.Open();
            MessageBox.Show("Opened successfully");


            SqlCommand mycommand = new SqlCommand();
            mycommand.CommandText = "Select LicensePlate, CarType, ExtraCharge, RentDate, ReturnDate, TotalPrice from Rentals";
            mycommand.Connection = myconn;

            SqlDataAdapter myadapter = new SqlDataAdapter();
            myadapter.SelectCommand = mycommand;

            DataTable mydt = new DataTable();
            myadapter.Fill(mydt);


            dataGridView1.DataSource = mydt;

        }

        private void PlaceRental_Click(object sender, EventArgs e)
        {
            String Plate = textBox1.Text; //LicensePlate
            int carType = 0; // Compact, SUV, SportsCar
            int pricePerDay = 0; // Compact = 25 // SUV =40 // SportsCar=60
            int extraDriver = 0;



            //Car Option
            if (radioButton1.Checked)
            {
                carType = 1;
                pricePerDay = 25;
            }
            else if (radioButton2.Checked)
            {
                carType = 2;
                pricePerDay = 40;
            }
            else if (radioButton3.Checked)
            {
                carType = 3;
                pricePerDay = 60;
            }
            else
            {
                MessageBox.Show("Please Choose Car Type");
            }


            //ExtraDriver Option
            if (checkBox1.Checked)
            {
                extraDriver = 25;
            }
            else
            {
                extraDriver = 0;
            }


            //DateTime
            DateTime RentDate = dateTimePicker1.Value.Date;
            DateTime ReturnDate = dateTimePicker2.Value.Date;
            int DurationRent = ((TimeSpan)(ReturnDate - RentDate)).Days;

            int TotalPrice = pricePerDay * DurationRent + extraDriver;
           


            MessageBox.Show(Plate + "\nCar Type: " + carType.ToString() +
                "\nPrice Per Day " + pricePerDay.ToString() +
                "\nExtraDriver " + extraDriver.ToString() +
                "\nRent Date " + RentDate.ToString() +
                "\nReturn Date " + ReturnDate.ToString() +
                "\nRent Duration " + DurationRent.ToString() +
                "\nTotalPrice " + TotalPrice.ToString());

            //EVERYTHING IS STORED IN THE VARIABLE
            //NEXT STEP IS TO TAKE THOSE VARIABLES AND INSERT IT INTO TABLES AS RECORDS


            //Insert Record
            string ConnStringName = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\vince\\source\\repos\\Hw2Draft\\Hw2Draft\\Database1.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(ConnStringName))
            {
                connection.Open();
                string sqlQuery = "INSERT INTO Rentals (LicensePlate, CarType, PricePerDay, RentDate, ReturnDate, RentDuration, ExtraCharge, TotalPrice) VALUES (@LicensePlate, @CarType, @PricePerDay, @RentDate, @ReturnDate, @RentDuration, @ExtraCharge, @TotalPrice)";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@LicensePlate", Plate);
                    command.Parameters.AddWithValue("@CarType", carType);
                    command.Parameters.AddWithValue("@PricePerDay", pricePerDay);
                    command.Parameters.AddWithValue("@RentDate", RentDate);
                    command.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                    command.Parameters.AddWithValue("@RentDuration", DurationRent);
                    command.Parameters.AddWithValue("@ExtraCharge", extraDriver);
                    command.Parameters.AddWithValue("@TotalPrice", TotalPrice);

                    command.ExecuteNonQuery();

                }

            }
        }


    }
}
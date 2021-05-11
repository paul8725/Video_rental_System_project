using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_System_project
{
    public partial class Form1 : Form
    {
        Client client = null;
        Movie movie = null;
        Booking booking = null;

        SqlConnection sqlconn;

        // connection string connecting with database 
        String conStr = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=VideoProject;Integrated Security=True";

        // command we will use insert, update and delete operation 
        SqlCommand sqlcmd;

        // data reader var 
        SqlDataReader DReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (TxtName_cus.Text.Equals("") && textBox_mobile.Text.Equals("") && Address_video.Text.Equals(""))
            {
                MessageBox.Show("Need to fill the details");
            }
            else
            {
                client = new Client(0, TxtName_cus.Text, textBox_mobile.Text, Address_video.Text);
                sqlconn = new SqlConnection(conStr);
                sqlconn.Open();
                sqlcmd = new SqlCommand("insert into Client(Name,Mobile,Address)values('" + client.Name + "','" + client.Mobile + "','" + client.address + "')", sqlconn);
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
                MessageBox.Show("Client record Stored ");
                TxtName_cus.Text = "";
                textBox_mobile.Text = "";
                Address_video.Text = "";

            }

        }

        // customer deletion operation 

        private void delCustomer_Click(object sender, EventArgs e)
        {
            if (TxtName_cus.Text.Equals("") && textBox_mobile.Text.Equals("") && Address_video.Text.Equals(""))
            {
                MessageBox.Show("Need to fill the details");
            }
            else
            {
                client = new Client(Convert.ToInt32(CustomerID.Text), TxtName_cus.Text, textBox_mobile.Text, Address_video.Text);
                sqlconn = new SqlConnection(conStr);
                sqlconn.Open();
                sqlcmd = new SqlCommand("delete from Client where ClientID=" + client.ID + "", sqlconn);
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
                MessageBox.Show("Client record Deleted  ");
                TxtName_cus.Text = "";
                textBox_mobile.Text = "";
                Address_video.Text = "";

            }

        }

        // update customer operation

        private void updateCustomer_Click(object sender, EventArgs e)
        {

            if (TxtName_cus.Text.Equals("") && textBox_mobile.Text.Equals("") && Address_video.Text.Equals(""))
            {
                MessageBox.Show("Need to fill the details");
            }
            else
            {
                client = new Client(Convert.ToInt32(CustomerID.Text), TxtName_cus.Text, textBox_mobile.Text, Address_video.Text);
                sqlconn = new SqlConnection(conStr);
                sqlconn.Open();
                sqlcmd = new SqlCommand("update Client set Name='" + client.Name + "',Mobile='" + client.Mobile + "',Address='" + client.address + "' where ClientID=" + client.ID + "", sqlconn);
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
                MessageBox.Show("Client record Updated ");
                TxtName_cus.Text = "";
                textBox_mobile.Text = "";
                Address_video.Text = "";
                CustomerID.Text = "";
            }

        }

        // add video operation

        private void AddVideo_Click(object sender, EventArgs e)
        {
            if (Txttitle.Text.Equals("") && rating_txt.Text.Equals("") && txtYer.Value > 0 && txtCost.Value > 0 && txtCopies.Value > 0 && TxtGenre.Text.Equals(""))
            {
                MessageBox.Show("Need to fill proper Details");
            }
            else
            {

                movie = new Movie(0, Txttitle.Text, rating_txt.Text, Convert.ToInt32(txtYer.Value), Convert.ToInt32(txtCost.Value), Convert.ToInt32(txtCopies.Value), TxtGenre.Text);
                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();
                sqlcmd = new SqlCommand("insert into Movie(Title,Ratting,Year,Cost,Copies,Genre)values('" + movie.Title + "','" + movie.Ratting + "'," + movie.Year + "," + movie.Cost + "," + movie.Copies + ",'" + movie.Genre + "')", sqlconn);

                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Movie record Stored");

                txtCopies.Value = 0;
                txtCost.Value = 0;
                txtYer.Value = 0;
                TxtGenre.Text = "";
                MovieID.Text = "";
                Txttitle.Text = "";
                rating_txt.Text = "";


            }
        }

        // delete video operation on button click

        private void delVideo_Click(object sender, EventArgs e)
        {
            if (Txttitle.Text.Equals("") && rating_txt.Text.Equals("") && txtYer.Value > 0 && txtCost.Value > 0 && txtCopies.Value > 0 && TxtGenre.Text.Equals(""))
            {
                MessageBox.Show("Need to fill proper Details");
            }
            else
            {

                movie = new Movie(Convert.ToInt32(MovieID.Text), Txttitle.Text, rating_txt.Text, Convert.ToInt32(txtYer.Value), Convert.ToInt32(txtCost.Value), Convert.ToInt32(txtCopies.Value), TxtGenre.Text);
                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();
                sqlcmd = new SqlCommand("delete from Movie where MovieID=" + Convert.ToInt32(movie.ID) + "", sqlconn);

                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Movie record Removed ");

                txtCopies.Value = 0;
                txtCost.Value = 0;
                txtYer.Value = 0;
                TxtGenre.Text = "";
                MovieID.Text = "";
                Txttitle.Text = "";
                rating_txt.Text = "";


            }
        }

        // update video operation on click

        private void updateVideo_Click(object sender, EventArgs e)
        {
            if (Txttitle.Text.Equals("") && rating_txt.Text.Equals("") && txtYer.Value > 0 && txtCost.Value > 0 && txtCopies.Value > 0 && TxtGenre.Text.Equals(""))
            {
                MessageBox.Show("Need to fill proper Details");
            }
            else
            {

                movie = new Movie(Convert.ToInt32(MovieID.Text), Txttitle.Text, rating_txt.Text, Convert.ToInt32(txtYer.Value), Convert.ToInt32(txtCost.Value), Convert.ToInt32(txtCopies.Value), TxtGenre.Text);
                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();

                sqlcmd = new SqlCommand("update Movie set Title='" + movie.Title + "',Ratting='" + movie.Ratting + "',Year=" + movie.Year + ",Cost=" + movie.Cost + ",Copies=" + movie.Copies + ",Genre='" + movie.Genre + "' where MovieID=" + Convert.ToInt32(movie.ID) + "", sqlconn);

                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show("Movie record Upated");

                txtCopies.Value = 0;
                txtCost.Value = 0;
                txtYer.Value = 0;
                TxtGenre.Text = "";
                MovieID.Text = "";
                Txttitle.Text = "";
                rating_txt.Text = "";

            }


        }

        // issue video on rent

        private void rentalIssueVideo_Click(object sender, EventArgs e)
        {
            if (CustomerID.Text.Equals("") && MovieID.Text.Equals(""))
            {
                MessageBox.Show("Need to select the Movie First ");
            }
            else
            {
                DataTable tbl = new DataTable();

                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();

                sqlcmd = new SqlCommand("select * from booking where MovieID="+Convert.ToInt32(MovieID.Text)+ " and ReturnDt='Book'", sqlconn);

                DReader = sqlcmd.ExecuteReader();

                tbl.Load(DReader);
                
                sqlconn.Close();

                DataTable tblmovie = new DataTable();

                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();

                sqlcmd = new SqlCommand("select * from Movie where MovieID=" + Convert.ToInt32(MovieID.Text) + "", sqlconn);

                DReader = sqlcmd.ExecuteReader();

                tblmovie.Load(DReader);
                
                sqlconn.Close();

                int copies =Convert.ToInt32(tblmovie.Rows[0]["Copies"].ToString());

                if (copies > tbl.Rows.Count - 1)
                {


                    booking = new Booking(0, Convert.ToInt32(CustomerID.Text), Convert.ToInt32(MovieID.Text), IssueMovie.Text, "Book");
                    sqlconn = new SqlConnection(conStr);

                    sqlconn.Open();


                    sqlcmd = new SqlCommand("insert into booking(ClientID,MovieID,BookingDt,ReturnDt) values(" + booking.ClientID + "," + booking.MovieID + ",'" + booking.BookingDt + "','" + booking.ReturnDt + "') ", sqlconn);

                    sqlcmd.ExecuteNonQuery();
                    sqlconn.Close();

                    MessageBox.Show("Movie is Issued on rent ");


                }
                else {
                    MessageBox.Show("all Sample booked ");
                
                }

                txtCopies.Value = 0;
                txtCost.Value = 0;
                txtYer.Value = 0;
                TxtGenre.Text = "";
                MovieID.Text = "";
                Txttitle.Text = "";
                rating_txt.Text = "";
                TxtName_cus.Text = "";
                textBox_mobile.Text = "";
                Address_video.Text = "";
                CustomerID.Text = "";


            }

        }

        // to delete video on delete

        private void rentalVideoDelete_Click(object sender, EventArgs e)
        {
            if (CustomerID.Text.Equals("") && MovieID.Text.Equals(""))
            {
                MessageBox.Show("Need to select the Movie First ");
            }
            else
            {
                booking = new Booking(Convert.ToInt32(lblBookingID.Text), Convert.ToInt32(CustomerID.Text), Convert.ToInt32(MovieID.Text), IssueMovie.Text, "Book");
                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();


                sqlcmd = new SqlCommand("delete from  booking  where BookingID=" + Convert.ToInt32(booking.BookID) + "", sqlconn);

                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show(" Issued movie is removed  ");

                txtCopies.Value = 0;
                txtCost.Value = 0;
                txtYer.Value = 0;
                TxtGenre.Text = "";
                MovieID.Text = "";
                Txttitle.Text = "";
                rating_txt.Text = "";
                TxtName_cus.Text = "";
                textBox_mobile.Text = "";
                Address_video.Text = "";
                CustomerID.Text = "";
                lblBookingID.Text = "";

            }

        }

        // to return a video that is on rental

        private void rentalReturnVideo_Click(object sender, EventArgs e)
        {
            if (CustomerID.Text.Equals("") && MovieID.Text.Equals(""))
            {
                MessageBox.Show("Need to select the Movie First ");
            }
            else
            {
                DataTable tblmovie = new DataTable();

                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();

                sqlcmd = new SqlCommand("select * from Movie where MovieID=" + Convert.ToInt32(MovieID.Text) + "", sqlconn);

                DReader = sqlcmd.ExecuteReader();

                tblmovie.Load(DReader);

                sqlconn.Close();

                int cost = Convert.ToInt32(tblmovie.Rows[0]["Cost"].ToString());





                DateTime current_date = DateTime.Now;

                //convert the old date from string to Date fromat
                DateTime prev_date = Convert.ToDateTime(IssueMovie.Text);


                //get the difference in the days fromat
                String Daysdiff = (current_date - prev_date).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));

                int total = cost * Convert.ToInt32(DaysInterval);



                booking = new Booking(Convert.ToInt32(lblBookingID.Text), Convert.ToInt32(CustomerID.Text), Convert.ToInt32(MovieID.Text), IssueMovie.Text, ReturnMovie.Text);
                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();


                sqlcmd = new SqlCommand("update booking set ClientID=" + booking.ClientID + ",MovieID=" + booking.MovieID + ",BookingDt='" + booking.BookingDt + "',ReturnDt='" + booking.ReturnDt + "' where BookingID=" + Convert.ToInt32(booking.BookID) + "", sqlconn);



                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();

                MessageBox.Show(" Issued movie is returned and the cost is =" + total);

                txtCopies.Value = 0;
                txtCost.Value = 0;
                txtYer.Value = 0;
                TxtGenre.Text = "";
                MovieID.Text = "";
                Txttitle.Text = "";
                rating_txt.Text = "";
                TxtName_cus.Text = "";
                textBox_mobile.Text = "";
                Address_video.Text = "";
                CustomerID.Text = "";
                lblBookingID.Text = "";
            }
        }

        // show data when customer is checked true

        private void Customer_show_CheckedChanged(object sender, EventArgs e)
        {
            if (Customer_show.Checked==true) {
                DataTable tbl = new DataTable();

                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();

                sqlcmd = new SqlCommand("select * from Client", sqlconn);

                DReader = sqlcmd.ExecuteReader();

                tbl.Load(DReader);
                dataGridView1.DataSource = tbl;
                sqlconn.Close();
            }
        }

        private void Video_show_CheckedChanged(object sender, EventArgs e)
        {
            if (Video_show.Checked == true)
            {
                DataTable tbl = new DataTable();

                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();

                sqlcmd = new SqlCommand("select * from Movie", sqlconn);

                DReader = sqlcmd.ExecuteReader();

                tbl.Load(DReader);
                dataGridView1.DataSource = tbl;
                sqlconn.Close();
            }
        }

        // show videos on rent when checked box is true

        private void Rental_show_CheckedChanged(object sender, EventArgs e)
        {
            if (Rental_show.Checked == true)
            {
                DataTable tbl = new DataTable();

                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();

                sqlcmd = new SqlCommand("select * from booking", sqlconn);

                DReader = sqlcmd.ExecuteReader();

                tbl.Load(DReader);
                dataGridView1.DataSource = tbl;
                sqlconn.Close();
            }

        }

        // cost according to the year entered 

        private void txtYer_ValueChanged(object sender, EventArgs e)
        {
            try {
                DateTime Now = DateTime.Now;

                int presntyear = Now.Year;

                int diffYear = presntyear - Convert.ToInt32(txtYer.Text);
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;
                }

                txtCost.Value = cost;
            }
            catch (Exception ex) { 
            

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Customer_show.Checked==true) {
                CustomerID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtName_cus.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_mobile.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Address_video.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();


            }
            if (Rental_show.Checked==true)
            {
                lblBookingID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                CustomerID.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                MovieID.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                IssueMovie.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
            if (Video_show.Checked==true) { 
            MovieID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txttitle.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                rating_txt.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtYer.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                txtCost.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                txtCopies.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                TxtGenre.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();

            }

            Video_show.Checked = false;
            Rental_show.Checked = false;
            Customer_show.Checked = false;
        }

        private void best_video_Click(object sender, EventArgs e)
        {

            int x = 0, y = 0, cunt = 0;
            String Title = "";

            DataTable tblvideo = new DataTable();

            sqlconn = new SqlConnection(conStr);

            sqlconn.Open();

            sqlcmd = new SqlCommand("select * from Movie", sqlconn);

            DReader = sqlcmd.ExecuteReader();

            tblvideo.Load(DReader);

            sqlconn.Close();


            for (x = 0; x < tblvideo.Rows.Count; x++)
            {
                DataTable tblrentl = new DataTable();

                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();

                sqlcmd = new SqlCommand("select * from booking where MovieID=" + Convert.ToInt32(tblvideo.Rows[x]["MovieID"]) + "", sqlconn);

                DReader = sqlcmd.ExecuteReader();

                tblrentl.Load(DReader);

                sqlconn.Close();
                if (tblrentl.Rows.Count > cunt)
                {

                    Title = tblvideo.Rows[x]["Title"].ToString();
                    cunt = tblrentl.Rows.Count;

                }

            }


            MessageBox.Show("Best Movie is ==" + Title);


        }

        private void best_custo_Click(object sender, EventArgs e)
        {

            int x = 0, y = 0, cunt = 0;
            String Title = "";

            DataTable tblvideo = new DataTable();

            sqlconn = new SqlConnection(conStr);

            sqlconn.Open();

            sqlcmd = new SqlCommand("select * from Client", sqlconn);

            DReader = sqlcmd.ExecuteReader();

            tblvideo.Load(DReader);

            sqlconn.Close();


            for (x = 0; x < tblvideo.Rows.Count; x++)
            {
                DataTable tblrentl = new DataTable();

                sqlconn = new SqlConnection(conStr);

                sqlconn.Open();

                sqlcmd = new SqlCommand("select * from booking where ClientID=" + Convert.ToInt32(tblvideo.Rows[x]["ClientID"]) + "", sqlconn);

                DReader = sqlcmd.ExecuteReader();

                tblrentl.Load(DReader);

                sqlconn.Close();
                if (tblrentl.Rows.Count > cunt)
                {

                    Title = tblvideo.Rows[x]["Name"].ToString();
                    cunt = tblrentl.Rows.Count;

                }

            }


            MessageBox.Show("Best Client is ==" + Title);

        }
    }
}


namespace Video_rental_System_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.best_custo = new System.Windows.Forms.Button();
            this.best_video = new System.Windows.Forms.Button();
            this.Rental_show = new System.Windows.Forms.RadioButton();
            this.Video_show = new System.Windows.Forms.RadioButton();
            this.Customer_show = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.MovieID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.ReturnMovie = new System.Windows.Forms.DateTimePicker();
            this.IssueMovie = new System.Windows.Forms.DateTimePicker();
            this.rentalVideoDelete = new System.Windows.Forms.Button();
            this.rentalReturnVideo = new System.Windows.Forms.Button();
            this.rentalIssueVideo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_mobile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.delCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.Address_video = new System.Windows.Forms.TextBox();
            this.TxtName_cus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.delVideo = new System.Windows.Forms.Button();
            this.updateVideo = new System.Windows.Forms.Button();
            this.AddVideo = new System.Windows.Forms.Button();
            this.TxtGenre = new System.Windows.Forms.TextBox();
            this.rating_txt = new System.Windows.Forms.TextBox();
            this.Txttitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCost = new System.Windows.Forms.NumericUpDown();
            this.txtCopies = new System.Windows.Forms.NumericUpDown();
            this.txtYer = new System.Windows.Forms.NumericUpDown();
            this.lblBookingID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYer)).BeginInit();
            this.SuspendLayout();
            // 
            // best_custo
            // 
            this.best_custo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.best_custo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_custo.Location = new System.Drawing.Point(565, 10);
            this.best_custo.Name = "best_custo";
            this.best_custo.Size = new System.Drawing.Size(135, 64);
            this.best_custo.TabIndex = 271;
            this.best_custo.Text = "Customer Best";
            this.best_custo.UseVisualStyleBackColor = false;
            this.best_custo.Click += new System.EventHandler(this.best_custo_Click);
            // 
            // best_video
            // 
            this.best_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.best_video.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_video.Location = new System.Drawing.Point(375, 10);
            this.best_video.Name = "best_video";
            this.best_video.Size = new System.Drawing.Size(184, 64);
            this.best_video.TabIndex = 270;
            this.best_video.Text = "Most Viewed Video";
            this.best_video.UseVisualStyleBackColor = false;
            this.best_video.Click += new System.EventHandler(this.best_video_Click);
            // 
            // Rental_show
            // 
            this.Rental_show.AutoSize = true;
            this.Rental_show.BackColor = System.Drawing.Color.Black;
            this.Rental_show.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rental_show.ForeColor = System.Drawing.Color.White;
            this.Rental_show.Location = new System.Drawing.Point(829, 412);
            this.Rental_show.Name = "Rental_show";
            this.Rental_show.Size = new System.Drawing.Size(82, 27);
            this.Rental_show.TabIndex = 269;
            this.Rental_show.TabStop = true;
            this.Rental_show.Text = "Rental";
            this.Rental_show.UseVisualStyleBackColor = false;
            this.Rental_show.CheckedChanged += new System.EventHandler(this.Rental_show_CheckedChanged);
            // 
            // Video_show
            // 
            this.Video_show.AutoSize = true;
            this.Video_show.BackColor = System.Drawing.Color.Black;
            this.Video_show.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video_show.ForeColor = System.Drawing.Color.White;
            this.Video_show.Location = new System.Drawing.Point(734, 412);
            this.Video_show.Name = "Video_show";
            this.Video_show.Size = new System.Drawing.Size(78, 27);
            this.Video_show.TabIndex = 268;
            this.Video_show.TabStop = true;
            this.Video_show.Text = "Video";
            this.Video_show.UseVisualStyleBackColor = false;
            this.Video_show.CheckedChanged += new System.EventHandler(this.Video_show_CheckedChanged);
            // 
            // Customer_show
            // 
            this.Customer_show.AutoSize = true;
            this.Customer_show.BackColor = System.Drawing.Color.Black;
            this.Customer_show.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_show.ForeColor = System.Drawing.Color.White;
            this.Customer_show.Location = new System.Drawing.Point(188, 412);
            this.Customer_show.Name = "Customer_show";
            this.Customer_show.Size = new System.Drawing.Size(110, 27);
            this.Customer_show.TabIndex = 267;
            this.Customer_show.TabStop = true;
            this.Customer_show.Text = "Customer";
            this.Customer_show.UseVisualStyleBackColor = false;
            this.Customer_show.CheckedChanged += new System.EventHandler(this.Customer_show_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(799, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 24);
            this.label17.TabIndex = 266;
            this.label17.Text = "Rentals";
            // 
            // MovieID
            // 
            this.MovieID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieID.Location = new System.Drawing.Point(891, 111);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(154, 32);
            this.MovieID.TabIndex = 265;
            // 
            // CustomerID
            // 
            this.CustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(891, 65);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(154, 32);
            this.CustomerID.TabIndex = 264;
            // 
            // ReturnMovie
            // 
            this.ReturnMovie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnMovie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnMovie.Location = new System.Drawing.Point(891, 191);
            this.ReturnMovie.Name = "ReturnMovie";
            this.ReturnMovie.Size = new System.Drawing.Size(154, 32);
            this.ReturnMovie.TabIndex = 263;
            // 
            // IssueMovie
            // 
            this.IssueMovie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueMovie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssueMovie.Location = new System.Drawing.Point(891, 154);
            this.IssueMovie.Name = "IssueMovie";
            this.IssueMovie.Size = new System.Drawing.Size(154, 32);
            this.IssueMovie.TabIndex = 262;
            // 
            // rentalVideoDelete
            // 
            this.rentalVideoDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalVideoDelete.Location = new System.Drawing.Point(758, 269);
            this.rentalVideoDelete.Name = "rentalVideoDelete";
            this.rentalVideoDelete.Size = new System.Drawing.Size(274, 37);
            this.rentalVideoDelete.TabIndex = 261;
            this.rentalVideoDelete.Text = "Delete";
            this.rentalVideoDelete.UseVisualStyleBackColor = true;
            this.rentalVideoDelete.Click += new System.EventHandler(this.rentalVideoDelete_Click);
            // 
            // rentalReturnVideo
            // 
            this.rentalReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalReturnVideo.Location = new System.Drawing.Point(878, 231);
            this.rentalReturnVideo.Name = "rentalReturnVideo";
            this.rentalReturnVideo.Size = new System.Drawing.Size(154, 32);
            this.rentalReturnVideo.TabIndex = 260;
            this.rentalReturnVideo.Text = "Return";
            this.rentalReturnVideo.UseVisualStyleBackColor = true;
            this.rentalReturnVideo.Click += new System.EventHandler(this.rentalReturnVideo_Click);
            // 
            // rentalIssueVideo
            // 
            this.rentalIssueVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalIssueVideo.Location = new System.Drawing.Point(756, 231);
            this.rentalIssueVideo.Name = "rentalIssueVideo";
            this.rentalIssueVideo.Size = new System.Drawing.Size(101, 32);
            this.rentalIssueVideo.TabIndex = 259;
            this.rentalIssueVideo.Text = "Issue";
            this.rentalIssueVideo.UseVisualStyleBackColor = true;
            this.rentalIssueVideo.Click += new System.EventHandler(this.rentalIssueVideo_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(743, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 24);
            this.label14.TabIndex = 258;
            this.label14.Text = "Date of Return ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(743, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 24);
            this.label15.TabIndex = 257;
            this.label15.Text = "Date of Issue";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(752, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 24);
            this.label19.TabIndex = 256;
            this.label19.Text = "Movie ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(752, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 24);
            this.label20.TabIndex = 255;
            this.label20.Text = "Customer ID";
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mobile.Location = new System.Drawing.Point(174, 114);
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(154, 32);
            this.textBox_mobile.TabIndex = 254;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(99, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 251;
            this.label9.Text = "Customers";
            // 
            // delCustomer
            // 
            this.delCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCustomer.Location = new System.Drawing.Point(52, 256);
            this.delCustomer.Name = "delCustomer";
            this.delCustomer.Size = new System.Drawing.Size(274, 37);
            this.delCustomer.TabIndex = 250;
            this.delCustomer.Text = "Delete";
            this.delCustomer.UseVisualStyleBackColor = true;
            this.delCustomer.Click += new System.EventHandler(this.delCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomer.Location = new System.Drawing.Point(174, 218);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(154, 32);
            this.updateCustomer.TabIndex = 249;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(55, 218);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(101, 32);
            this.addCustomer.TabIndex = 247;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // Address_video
            // 
            this.Address_video.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_video.Location = new System.Drawing.Point(174, 170);
            this.Address_video.Name = "Address_video";
            this.Address_video.Size = new System.Drawing.Size(154, 32);
            this.Address_video.TabIndex = 248;
            // 
            // TxtName_cus
            // 
            this.TxtName_cus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName_cus.Location = new System.Drawing.Point(172, 69);
            this.TxtName_cus.Name = "TxtName_cus";
            this.TxtName_cus.Size = new System.Drawing.Size(154, 32);
            this.TxtName_cus.TabIndex = 246;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(50, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 245;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(48, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 24);
            this.label12.TabIndex = 244;
            this.label12.Text = "Phone No.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(48, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 24);
            this.label13.TabIndex = 243;
            this.label13.Text = " Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(451, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 24);
            this.label18.TabIndex = 241;
            this.label18.Text = "Videos";
            // 
            // delVideo
            // 
            this.delVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delVideo.Location = new System.Drawing.Point(570, 391);
            this.delVideo.Name = "delVideo";
            this.delVideo.Size = new System.Drawing.Size(85, 32);
            this.delVideo.TabIndex = 240;
            this.delVideo.Text = "Delete";
            this.delVideo.UseVisualStyleBackColor = true;
            this.delVideo.Click += new System.EventHandler(this.delVideo_Click);
            // 
            // updateVideo
            // 
            this.updateVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVideo.Location = new System.Drawing.Point(474, 391);
            this.updateVideo.Name = "updateVideo";
            this.updateVideo.Size = new System.Drawing.Size(85, 32);
            this.updateVideo.TabIndex = 239;
            this.updateVideo.Text = "Update";
            this.updateVideo.UseVisualStyleBackColor = true;
            this.updateVideo.Click += new System.EventHandler(this.updateVideo_Click);
            // 
            // AddVideo
            // 
            this.AddVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideo.Location = new System.Drawing.Point(383, 391);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(85, 32);
            this.AddVideo.TabIndex = 238;
            this.AddVideo.Text = "Add";
            this.AddVideo.UseVisualStyleBackColor = true;
            this.AddVideo.Click += new System.EventHandler(this.AddVideo_Click);
            // 
            // TxtGenre
            // 
            this.TxtGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenre.Location = new System.Drawing.Point(501, 333);
            this.TxtGenre.Name = "TxtGenre";
            this.TxtGenre.Size = new System.Drawing.Size(154, 32);
            this.TxtGenre.TabIndex = 237;
            // 
            // rating_txt
            // 
            this.rating_txt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_txt.Location = new System.Drawing.Point(501, 167);
            this.rating_txt.Name = "rating_txt";
            this.rating_txt.Size = new System.Drawing.Size(154, 32);
            this.rating_txt.TabIndex = 233;
            // 
            // Txttitle
            // 
            this.Txttitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttitle.Location = new System.Drawing.Point(501, 129);
            this.Txttitle.Name = "Txttitle";
            this.Txttitle.Size = new System.Drawing.Size(154, 32);
            this.Txttitle.TabIndex = 232;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(400, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 231;
            this.label7.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(401, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 229;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(400, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 228;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 227;
            this.label3.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(400, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 226;
            this.label8.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(400, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 225;
            this.label16.Text = "Title";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Magenta;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1047, 204);
            this.dataGridView1.TabIndex = 224;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox4.Location = new System.Drawing.Point(719, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(340, 343);
            this.pictureBox4.TabIndex = 223;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox3.Location = new System.Drawing.Point(358, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(355, 359);
            this.pictureBox3.TabIndex = 222;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 299);
            this.pictureBox2.TabIndex = 221;
            this.pictureBox2.TabStop = false;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(501, 248);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(154, 26);
            this.txtCost.TabIndex = 272;
            // 
            // txtCopies
            // 
            this.txtCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopies.Location = new System.Drawing.Point(501, 291);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(154, 26);
            this.txtCopies.TabIndex = 273;
            // 
            // txtYer
            // 
            this.txtYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYer.Location = new System.Drawing.Point(501, 209);
            this.txtYer.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtYer.Name = "txtYer";
            this.txtYer.Size = new System.Drawing.Size(154, 26);
            this.txtYer.TabIndex = 274;
            this.txtYer.ValueChanged += new System.EventHandler(this.txtYer_ValueChanged);
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.BackColor = System.Drawing.Color.Black;
            this.lblBookingID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.Color.White;
            this.lblBookingID.Location = new System.Drawing.Point(845, 318);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(0, 24);
            this.lblBookingID.TabIndex = 275;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1075, 658);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.txtYer);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.best_custo);
            this.Controls.Add(this.best_video);
            this.Controls.Add(this.Rental_show);
            this.Controls.Add(this.Video_show);
            this.Controls.Add(this.Customer_show);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.ReturnMovie);
            this.Controls.Add(this.IssueMovie);
            this.Controls.Add(this.rentalVideoDelete);
            this.Controls.Add(this.rentalReturnVideo);
            this.Controls.Add(this.rentalIssueVideo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox_mobile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.delCustomer);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.Address_video);
            this.Controls.Add(this.TxtName_cus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.delVideo);
            this.Controls.Add(this.updateVideo);
            this.Controls.Add(this.AddVideo);
            this.Controls.Add(this.TxtGenre);
            this.Controls.Add(this.rating_txt);
            this.Controls.Add(this.Txttitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "0";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button best_custo;
        private System.Windows.Forms.Button best_video;
        private System.Windows.Forms.RadioButton Rental_show;
        private System.Windows.Forms.RadioButton Video_show;
        private System.Windows.Forms.RadioButton Customer_show;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox MovieID;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.DateTimePicker ReturnMovie;
        private System.Windows.Forms.DateTimePicker IssueMovie;
        private System.Windows.Forms.Button rentalVideoDelete;
        private System.Windows.Forms.Button rentalReturnVideo;
        private System.Windows.Forms.Button rentalIssueVideo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_mobile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button delCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.TextBox Address_video;
        private System.Windows.Forms.TextBox TxtName_cus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button delVideo;
        private System.Windows.Forms.Button updateVideo;
        private System.Windows.Forms.Button AddVideo;
        private System.Windows.Forms.TextBox TxtGenre;
        private System.Windows.Forms.TextBox rating_txt;
        private System.Windows.Forms.TextBox Txttitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown txtCost;
        private System.Windows.Forms.NumericUpDown txtCopies;
        private System.Windows.Forms.NumericUpDown txtYer;
        private System.Windows.Forms.Label lblBookingID;
    }
}


namespace HotelOrder
{
    partial class frmBooking
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cbxCountry = new ComboBox();
            cbxCity = new ComboBox();
            label3 = new Label();
            cbxHotel = new ComboBox();
            btnCountryNext = new Button();
            btnPaymentNext = new Button();
            btnHotelNext = new Button();
            btnCityNext = new Button();
            btnRoomNext = new Button();
            cbxRoom = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            tbxPayment = new TextBox();
            label6 = new Label();
            btnVoucherPrint = new Button();
            btnOrderReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 113);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "City";
            // 
            // cbxCountry
            // 
            cbxCountry.DisplayMember = "Name";
            cbxCountry.FormattingEnabled = true;
            cbxCountry.Location = new Point(116, 38);
            cbxCountry.Name = "cbxCountry";
            cbxCountry.Size = new Size(121, 23);
            cbxCountry.TabIndex = 3;
            cbxCountry.ValueMember = "Id,";
            cbxCountry.SelectedIndexChanged += cbxCountry_SelectedIndexChanged;
            // 
            // cbxCity
            // 
            cbxCity.DisplayMember = "CityName";
            cbxCity.FormattingEnabled = true;
            cbxCity.Location = new Point(116, 111);
            cbxCity.Name = "cbxCity";
            cbxCity.Size = new Size(121, 23);
            cbxCity.TabIndex = 4;
            cbxCity.ValueMember = "CountryId, CityId";
            cbxCity.SelectedIndexChanged += cbxCity_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(27, 187);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Hotel";
            // 
            // cbxHotel
            // 
            cbxHotel.DisplayMember = "HotelName";
            cbxHotel.FormattingEnabled = true;
            cbxHotel.Location = new Point(116, 184);
            cbxHotel.Name = "cbxHotel";
            cbxHotel.Size = new Size(121, 23);
            cbxHotel.TabIndex = 6;
            cbxHotel.ValueMember = "CountryId, CityId, HotelId";
            cbxHotel.SelectedIndexChanged += cbxHotel_SelectedIndexChanged;
            // 
            // btnCountryNext
            // 
            btnCountryNext.BackColor = Color.PeachPuff;
            btnCountryNext.Location = new Point(116, 67);
            btnCountryNext.Name = "btnCountryNext";
            btnCountryNext.Size = new Size(49, 23);
            btnCountryNext.TabIndex = 7;
            btnCountryNext.Text = "Next";
            btnCountryNext.UseVisualStyleBackColor = false;
            btnCountryNext.Click += btnCountryNext_Click;
            // 
            // btnPaymentNext
            // 
            btnPaymentNext.Location = new Point(116, 360);
            btnPaymentNext.Name = "btnPaymentNext";
            btnPaymentNext.Size = new Size(49, 23);
            btnPaymentNext.TabIndex = 9;
            btnPaymentNext.Text = "Next";
            btnPaymentNext.UseVisualStyleBackColor = true;
            btnPaymentNext.Click += btnPaymentNext_Click;
            // 
            // btnHotelNext
            // 
            btnHotelNext.Location = new Point(116, 213);
            btnHotelNext.Name = "btnHotelNext";
            btnHotelNext.Size = new Size(49, 23);
            btnHotelNext.TabIndex = 10;
            btnHotelNext.Text = "Next";
            btnHotelNext.UseVisualStyleBackColor = true;
            btnHotelNext.Click += btnHotelNext_Click;
            // 
            // btnCityNext
            // 
            btnCityNext.BackColor = Color.Gainsboro;
            btnCityNext.Location = new Point(116, 140);
            btnCityNext.Name = "btnCityNext";
            btnCityNext.Size = new Size(49, 23);
            btnCityNext.TabIndex = 11;
            btnCityNext.Text = "Next";
            btnCityNext.UseVisualStyleBackColor = false;
            btnCityNext.Click += btnCityNext_Click;
            // 
            // btnRoomNext
            // 
            btnRoomNext.Location = new Point(116, 287);
            btnRoomNext.Name = "btnRoomNext";
            btnRoomNext.Size = new Size(49, 23);
            btnRoomNext.TabIndex = 14;
            btnRoomNext.Text = "Next";
            btnRoomNext.UseVisualStyleBackColor = true;
            btnRoomNext.Click += btnRoomNext_Click;
            // 
            // cbxRoom
            // 
            cbxRoom.DisplayMember = "RoomNumber";
            cbxRoom.FormattingEnabled = true;
            cbxRoom.Location = new Point(116, 258);
            cbxRoom.Name = "cbxRoom";
            cbxRoom.Size = new Size(121, 23);
            cbxRoom.TabIndex = 13;
            cbxRoom.ValueMember = "CountryId, CityId, HotelId, RoomNumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(27, 261);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 12;
            label4.Text = "Room";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(27, 334);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 15;
            label5.Text = "Payment";
            // 
            // tbxPayment
            // 
            tbxPayment.Location = new Point(116, 331);
            tbxPayment.Name = "tbxPayment";
            tbxPayment.Size = new Size(121, 23);
            tbxPayment.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(26, 416);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 17;
            label6.Text = "Voucher";
            // 
            // btnVoucherPrint
            // 
            btnVoucherPrint.Location = new Point(116, 412);
            btnVoucherPrint.Name = "btnVoucherPrint";
            btnVoucherPrint.Size = new Size(121, 23);
            btnVoucherPrint.TabIndex = 18;
            btnVoucherPrint.Text = "Voucher Print";
            btnVoucherPrint.UseVisualStyleBackColor = true;
            btnVoucherPrint.Click += btnVoucherPrint_Click;
            // 
            // btnOrderReset
            // 
            btnOrderReset.BackColor = Color.DarkSeaGreen;
            btnOrderReset.Location = new Point(116, 463);
            btnOrderReset.Name = "btnOrderReset";
            btnOrderReset.Size = new Size(118, 30);
            btnOrderReset.TabIndex = 19;
            btnOrderReset.Text = "Order Reset";
            btnOrderReset.UseVisualStyleBackColor = false;
            btnOrderReset.Click += btnOrderReset_Click;
            // 
            // frmBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 518);
            Controls.Add(btnOrderReset);
            Controls.Add(btnVoucherPrint);
            Controls.Add(label6);
            Controls.Add(tbxPayment);
            Controls.Add(label5);
            Controls.Add(btnRoomNext);
            Controls.Add(cbxRoom);
            Controls.Add(label4);
            Controls.Add(btnCityNext);
            Controls.Add(btnHotelNext);
            Controls.Add(btnPaymentNext);
            Controls.Add(btnCountryNext);
            Controls.Add(cbxHotel);
            Controls.Add(label3);
            Controls.Add(cbxCity);
            Controls.Add(cbxCountry);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBooking";
            Text = "Booking Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbxCountry;
        private ComboBox cbxCity;
        private Label label3;
        private ComboBox cbxHotel;
        private Button btnCountryNext;
        private Button btnPaymentNext;
        private Button btnHotelNext;
        private Button btnCityNext;
        private Button btnRoomNext;
        private ComboBox cbxRoom;
        private Label label4;
        private Label label5;
        private TextBox tbxPayment;
        private Label label6;
        private Button btnVoucherPrint;
        private Button btnOrderReset;
    }
}

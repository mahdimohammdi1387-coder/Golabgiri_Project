namespace Golabgiri.App.Customer
{
    partial class frmAddOrEditcustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditcustomer));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblsubject = new System.Windows.Forms.Label();
            this.btnsabt = new Guna.UI2.WinForms.Guna2Button();
            this.lblpersonfamily = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtfamily = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtphonenumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblcompanyphne = new System.Windows.Forms.Label();
            this.lblcompany = new System.Windows.Forms.Label();
            this.txtcompanyphne = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcompanny = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnclose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblsubject.Location = new System.Drawing.Point(13, 12);
            this.lblsubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(153, 25);
            this.lblsubject.TabIndex = 7;
            this.lblsubject.Text = "اضافه کردن طرف حساب";
            // 
            // btnsabt
            // 
            this.btnsabt.BorderColor = System.Drawing.Color.White;
            this.btnsabt.BorderRadius = 10;
            this.btnsabt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsabt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsabt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsabt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsabt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsabt.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9F, System.Drawing.FontStyle.Bold);
            this.btnsabt.ForeColor = System.Drawing.Color.White;
            this.btnsabt.Location = new System.Drawing.Point(64, 566);
            this.btnsabt.Name = "btnsabt";
            this.btnsabt.Size = new System.Drawing.Size(158, 44);
            this.btnsabt.TabIndex = 8;
            this.btnsabt.Text = "ثبت طرف حساب";
            this.btnsabt.Click += new System.EventHandler(this.btnsabt_Click);
            // 
            // lblpersonfamily
            // 
            this.lblpersonfamily.AutoSize = true;
            this.lblpersonfamily.Location = new System.Drawing.Point(595, 142);
            this.lblpersonfamily.Name = "lblpersonfamily";
            this.lblpersonfamily.Size = new System.Drawing.Size(167, 25);
            this.lblpersonfamily.TabIndex = 10;
            this.lblpersonfamily.Text = ":نام خانوادگی طرف حساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = ":تلفن طرف حساب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = ":آدرس طرف حساب";
            // 
            // txtname
            // 
            this.txtname.Animated = true;
            this.txtname.BorderRadius = 12;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.IconRight = global::Golabgiri.App.Properties.Resources.icons8_Name_64px;
            this.txtname.IconRightSize = new System.Drawing.Size(23, 23);
            this.txtname.Location = new System.Drawing.Point(18, 76);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtname.Name = "txtname";
            this.txtname.PlaceholderText = "نام";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(728, 47);
            this.txtname.TabIndex = 2;
            // 
            // txtfamily
            // 
            this.txtfamily.Animated = true;
            this.txtfamily.BorderRadius = 12;
            this.txtfamily.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfamily.DefaultText = "";
            this.txtfamily.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfamily.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfamily.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfamily.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfamily.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfamily.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10F);
            this.txtfamily.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfamily.IconRight = global::Golabgiri.App.Properties.Resources.icons8_Name_64px;
            this.txtfamily.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtfamily.IconRightSize = new System.Drawing.Size(23, 23);
            this.txtfamily.Location = new System.Drawing.Point(18, 172);
            this.txtfamily.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.PlaceholderText = "نام خانوادگی";
            this.txtfamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfamily.SelectedText = "";
            this.txtfamily.Size = new System.Drawing.Size(728, 49);
            this.txtfamily.TabIndex = 3;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Animated = true;
            this.txtphonenumber.BorderRadius = 12;
            this.txtphonenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphonenumber.DefaultText = "";
            this.txtphonenumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphonenumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphonenumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphonenumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphonenumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphonenumber.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10F);
            this.txtphonenumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphonenumber.IconRight = global::Golabgiri.App.Properties.Resources.icons8_Cell_Phone_64px;
            this.txtphonenumber.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtphonenumber.IconRightSize = new System.Drawing.Size(23, 23);
            this.txtphonenumber.Location = new System.Drawing.Point(18, 271);
            this.txtphonenumber.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.PlaceholderText = "شماره تلفن یا موبایل";
            this.txtphonenumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtphonenumber.SelectedText = "";
            this.txtphonenumber.Size = new System.Drawing.Size(728, 48);
            this.txtphonenumber.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Animated = true;
            this.txtAddress.BorderRadius = 12;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.IconRight = global::Golabgiri.App.Properties.Resources.icons8_Address_64px;
            this.txtAddress.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtAddress.IconRightSize = new System.Drawing.Size(23, 23);
            this.txtAddress.Location = new System.Drawing.Point(14, 370);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAddress.PlaceholderText = "  ...آدرسی برای طرف حساب بیافزایید";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(733, 189);
            this.txtAddress.TabIndex = 6;
            // 
            // lblcompanyphne
            // 
            this.lblcompanyphne.AutoSize = true;
            this.lblcompanyphne.BackColor = System.Drawing.Color.Transparent;
            this.lblcompanyphne.Location = new System.Drawing.Point(629, 192);
            this.lblcompanyphne.Name = "lblcompanyphne";
            this.lblcompanyphne.Size = new System.Drawing.Size(119, 25);
            this.lblcompanyphne.TabIndex = 16;
            this.lblcompanyphne.Text = ":تلفن طرف حساب";
            this.lblcompanyphne.Visible = false;
            // 
            // lblcompany
            // 
            this.lblcompany.AutoSize = true;
            this.lblcompany.BackColor = System.Drawing.Color.Transparent;
            this.lblcompany.Location = new System.Drawing.Point(634, 43);
            this.lblcompany.Name = "lblcompany";
            this.lblcompany.Size = new System.Drawing.Size(109, 25);
            this.lblcompany.TabIndex = 15;
            this.lblcompany.Text = ":نام طرف حساب";
            // 
            // txtcompanyphne
            // 
            this.txtcompanyphne.Animated = true;
            this.txtcompanyphne.BackColor = System.Drawing.Color.Transparent;
            this.txtcompanyphne.BorderRadius = 12;
            this.txtcompanyphne.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcompanyphne.DefaultText = "";
            this.txtcompanyphne.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcompanyphne.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcompanyphne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcompanyphne.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcompanyphne.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcompanyphne.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10F);
            this.txtcompanyphne.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcompanyphne.IconRight = global::Golabgiri.App.Properties.Resources.icons8_Cell_Phone_64px;
            this.txtcompanyphne.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtcompanyphne.IconRightSize = new System.Drawing.Size(23, 23);
            this.txtcompanyphne.Location = new System.Drawing.Point(23, 220);
            this.txtcompanyphne.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtcompanyphne.Name = "txtcompanyphne";
            this.txtcompanyphne.PlaceholderText = "شماره تلفن یا موبایل";
            this.txtcompanyphne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcompanyphne.SelectedText = "";
            this.txtcompanyphne.Size = new System.Drawing.Size(728, 99);
            this.txtcompanyphne.TabIndex = 14;
            this.txtcompanyphne.Visible = false;
            // 
            // txtcompanny
            // 
            this.txtcompanny.Animated = true;
            this.txtcompanny.BackColor = System.Drawing.Color.Transparent;
            this.txtcompanny.BorderRadius = 12;
            this.txtcompanny.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcompanny.DefaultText = "";
            this.txtcompanny.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcompanny.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcompanny.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcompanny.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcompanny.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcompanny.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompanny.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcompanny.IconRight = global::Golabgiri.App.Properties.Resources.icons8_company_64px;
            this.txtcompanny.IconRightSize = new System.Drawing.Size(23, 23);
            this.txtcompanny.Location = new System.Drawing.Point(19, 79);
            this.txtcompanny.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtcompanny.Name = "txtcompanny";
            this.txtcompanny.PlaceholderText = "نام شرکت";
            this.txtcompanny.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcompanny.SelectedText = "";
            this.txtcompanny.Size = new System.Drawing.Size(728, 77);
            this.txtcompanny.TabIndex = 13;
            this.txtcompanny.Visible = false;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::Golabgiri.App.Properties.Resources.icons8_close_24px;
            this.btnclose.ImageRotate = 0F;
            this.btnclose.Location = new System.Drawing.Point(716, 12);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(31, 34);
            this.btnclose.TabIndex = 4;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            this.btnclose.MouseHover += new System.EventHandler(this.btnclose_MouseHover);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtname;
            this.requiredFieldValidator1.ErrorMessage = "نام طرف حساب را وارد کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtfamily;
            this.requiredFieldValidator2.ErrorMessage = "فامیلی طرف حساب را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtphonenumber;
            this.requiredFieldValidator3.ErrorMessage = "شماره تلفن طرف حساب را وارد کنید";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.txtAddress;
            this.requiredFieldValidator4.ErrorMessage = "آدرس طرف حساب را وارد کنید";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // frmAddOrEditcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(770, 617);
            this.Controls.Add(this.lblcompanyphne);
            this.Controls.Add(this.lblcompany);
            this.Controls.Add(this.txtcompanyphne);
            this.Controls.Add(this.txtcompanny);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblpersonfamily);
            this.Controls.Add(this.btnsabt);
            this.Controls.Add(this.lblsubject);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.txtname);
            this.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddOrEditcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddOrEditcustomer";
            this.Load += new System.EventHandler(this.frmAddOrEditcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox btnclose;
        private System.Windows.Forms.Label lblpersonfamily;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblsubject;
        public Guna.UI2.WinForms.Guna2TextBox txtfamily;
        public Guna.UI2.WinForms.Guna2TextBox txtname;
        public Guna.UI2.WinForms.Guna2TextBox txtAddress;
        public Guna.UI2.WinForms.Guna2TextBox txtphonenumber;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private System.Windows.Forms.Label lblcompanyphne;
        private System.Windows.Forms.Label lblcompany;
        public Guna.UI2.WinForms.Guna2TextBox txtcompanyphne;
        public Guna.UI2.WinForms.Guna2TextBox txtcompanny;
        public Guna.UI2.WinForms.Guna2Button btnsabt;
    }
}
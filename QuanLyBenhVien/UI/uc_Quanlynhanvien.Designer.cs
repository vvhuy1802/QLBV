
namespace QuanLyBenhVien.UI
{
    partial class uc_Quanlynhanvien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Quanlynhanvien));
            this.dgvStaffList = new System.Windows.Forms.DataGridView();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.cbStaffSex = new System.Windows.Forms.ComboBox();
            this.dtpStaffBirth = new System.Windows.Forms.DateTimePicker();
            this.txbStaffCountry = new System.Windows.Forms.TextBox();
            this.txbStaffNum = new System.Windows.Forms.TextBox();
            this.txbStaffName = new System.Windows.Forms.TextBox();
            this.txbStaffCMND = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbStaffLocate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStaffPosition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStaffCancel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStaffRank = new System.Windows.Forms.ComboBox();
            this.txbStaffSupportMoney = new System.Windows.Forms.TextBox();
            this.nupStaffLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudStaffExp = new System.Windows.Forms.NumericUpDown();
            this.txbStaffSalary = new System.Windows.Forms.TextBox();
            this.txbStaffRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.btnStaffEdit = new System.Windows.Forms.Button();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStaffLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStaffExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaffList
            // 
            this.dgvStaffList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCMND,
            this.colStaffName,
            this.colImage,
            this.colBirthDate,
            this.colSex,
            this.colEx,
            this.colAddress,
            this.colCountry,
            this.colNum,
            this.colIDPosition,
            this.colRank,
            this.colLevel,
            this.colSalary,
            this.colRate,
            this.colSupMoney});
            this.dgvStaffList.Location = new System.Drawing.Point(12, 70);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.RowHeadersWidth = 51;
            this.dgvStaffList.Size = new System.Drawing.Size(830, 216);
            this.dgvStaffList.TabIndex = 0;
            this.dgvStaffList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffList_CellClick);
            // 
            // colCMND
            // 
            this.colCMND.DataPropertyName = "CMND";
            this.colCMND.HeaderText = "CMND";
            this.colCMND.MinimumWidth = 6;
            this.colCMND.Name = "colCMND";
            this.colCMND.Width = 125;
            // 
            // colStaffName
            // 
            this.colStaffName.DataPropertyName = "Ten";
            this.colStaffName.HeaderText = "Họ và tên";
            this.colStaffName.MinimumWidth = 6;
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.Width = 200;
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "Hinh";
            this.colImage.HeaderText = "Ảnh ";
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.Width = 125;
            // 
            // colBirthDate
            // 
            this.colBirthDate.DataPropertyName = "NgaySinh";
            this.colBirthDate.HeaderText = "Ngày sinh";
            this.colBirthDate.MinimumWidth = 6;
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Width = 125;
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "GioiTinh";
            this.colSex.HeaderText = "Giới tính";
            this.colSex.MinimumWidth = 6;
            this.colSex.Name = "colSex";
            this.colSex.Width = 125;
            // 
            // colEx
            // 
            this.colEx.DataPropertyName = "Ex";
            this.colEx.HeaderText = "Kinh nghiệm";
            this.colEx.MinimumWidth = 6;
            this.colEx.Name = "colEx";
            this.colEx.Width = 125;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "DiaChi";
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.Width = 125;
            // 
            // colCountry
            // 
            this.colCountry.DataPropertyName = "QuocTich";
            this.colCountry.HeaderText = "Quốc tịch";
            this.colCountry.MinimumWidth = 6;
            this.colCountry.Name = "colCountry";
            this.colCountry.Width = 125;
            // 
            // colNum
            // 
            this.colNum.DataPropertyName = "SDT";
            this.colNum.HeaderText = "Số điện thoại";
            this.colNum.MinimumWidth = 6;
            this.colNum.Name = "colNum";
            this.colNum.Width = 125;
            // 
            // colIDPosition
            // 
            this.colIDPosition.DataPropertyName = "IDchucvu";
            this.colIDPosition.HeaderText = "ID chức vụ";
            this.colIDPosition.MinimumWidth = 6;
            this.colIDPosition.Name = "colIDPosition";
            this.colIDPosition.Width = 125;
            // 
            // colRank
            // 
            this.colRank.DataPropertyName = "Hang";
            this.colRank.HeaderText = "Hạng";
            this.colRank.MinimumWidth = 6;
            this.colRank.Name = "colRank";
            this.colRank.Width = 70;
            // 
            // colLevel
            // 
            this.colLevel.DataPropertyName = "Bac";
            this.colLevel.HeaderText = "Bậc";
            this.colLevel.MinimumWidth = 6;
            this.colLevel.Name = "colLevel";
            this.colLevel.Width = 50;
            // 
            // colSalary
            // 
            this.colSalary.DataPropertyName = "LuongCB";
            this.colSalary.HeaderText = "Lương cơ bản";
            this.colSalary.MinimumWidth = 6;
            this.colSalary.Name = "colSalary";
            this.colSalary.Width = 125;
            // 
            // colRate
            // 
            this.colRate.DataPropertyName = "HeSo";
            this.colRate.HeaderText = "Hệ số";
            this.colRate.MinimumWidth = 6;
            this.colRate.Name = "colRate";
            this.colRate.Width = 125;
            // 
            // colSupMoney
            // 
            this.colSupMoney.DataPropertyName = "TroCap";
            this.colSupMoney.HeaderText = "Trợ cấp";
            this.colSupMoney.MinimumWidth = 6;
            this.colSupMoney.Name = "colSupMoney";
            this.colSupMoney.Width = 125;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddStaff.Image = global::QuanLyBenhVien.Properties.Resources._309049_add_user_human_person_plus_icon;
            this.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.Location = new System.Drawing.Point(457, 178);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(107, 42);
            this.btnAddStaff.TabIndex = 112;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // cbStaffSex
            // 
            this.cbStaffSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffSex.FormattingEnabled = true;
            this.cbStaffSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbStaffSex.Location = new System.Drawing.Point(127, 143);
            this.cbStaffSex.Name = "cbStaffSex";
            this.cbStaffSex.Size = new System.Drawing.Size(125, 24);
            this.cbStaffSex.TabIndex = 109;
            // 
            // dtpStaffBirth
            // 
            this.dtpStaffBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStaffBirth.Location = new System.Drawing.Point(127, 76);
            this.dtpStaffBirth.Name = "dtpStaffBirth";
            this.dtpStaffBirth.Size = new System.Drawing.Size(205, 22);
            this.dtpStaffBirth.TabIndex = 108;
            this.dtpStaffBirth.ValueChanged += new System.EventHandler(this.dtpStaffBirth_ValueChanged);
            // 
            // txbStaffCountry
            // 
            this.txbStaffCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStaffCountry.Location = new System.Drawing.Point(128, 178);
            this.txbStaffCountry.Name = "txbStaffCountry";
            this.txbStaffCountry.Size = new System.Drawing.Size(123, 22);
            this.txbStaffCountry.TabIndex = 106;
            // 
            // txbStaffNum
            // 
            this.txbStaffNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStaffNum.Location = new System.Drawing.Point(127, 110);
            this.txbStaffNum.Name = "txbStaffNum";
            this.txbStaffNum.Size = new System.Drawing.Size(205, 22);
            this.txbStaffNum.TabIndex = 105;
            // 
            // txbStaffName
            // 
            this.txbStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStaffName.Location = new System.Drawing.Point(127, 49);
            this.txbStaffName.Name = "txbStaffName";
            this.txbStaffName.Size = new System.Drawing.Size(205, 22);
            this.txbStaffName.TabIndex = 104;
            // 
            // txbStaffCMND
            // 
            this.txbStaffCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStaffCMND.Location = new System.Drawing.Point(127, 18);
            this.txbStaffCMND.Name = "txbStaffCMND";
            this.txbStaffCMND.ReadOnly = true;
            this.txbStaffCMND.Size = new System.Drawing.Size(205, 22);
            this.txbStaffCMND.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 101;
            this.label8.Text = "Quốc tịch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 99;
            this.label6.Text = "Số điện thoại:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 98;
            this.label5.Text = "Giới tính:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 97;
            this.label4.Text = "Ngày sinh:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 95;
            this.label2.Text = "Họ và tên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 94;
            this.label1.Text = "CMND:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnSearchStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStaff.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchStaff.Location = new System.Drawing.Point(11, 29);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(91, 29);
            this.btnSearchStaff.TabIndex = 116;
            this.btnSearchStaff.Text = "Tìm kiếm";
            this.btnSearchStaff.UseVisualStyleBackColor = false;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimkiem.Location = new System.Drawing.Point(130, 29);
            this.txbtimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbtimkiem.Multiline = true;
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(351, 30);
            this.txbtimkiem.TabIndex = 115;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.txbtimkiem_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 18);
            this.label10.TabIndex = 117;
            this.label10.Text = "Năm kinh nghiệm:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txbStaffLocate
            // 
            this.txbStaffLocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStaffLocate.Location = new System.Drawing.Point(127, 211);
            this.txbStaffLocate.Multiline = true;
            this.txbStaffLocate.Name = "txbStaffLocate";
            this.txbStaffLocate.Size = new System.Drawing.Size(301, 31);
            this.txbStaffLocate.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 119;
            this.label11.Text = "Địa chỉ:";
            // 
            // cbStaffPosition
            // 
            this.cbStaffPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffPosition.FormattingEnabled = true;
            this.cbStaffPosition.Items.AddRange(new object[] {
            "Lễ tân",
            "Bác sĩ",
            "Quản lý"});
            this.cbStaffPosition.Location = new System.Drawing.Point(511, 87);
            this.cbStaffPosition.Name = "cbStaffPosition";
            this.cbStaffPosition.Size = new System.Drawing.Size(114, 24);
            this.cbStaffPosition.TabIndex = 122;
            this.cbStaffPosition.SelectedIndexChanged += new System.EventHandler(this.cbStaffPosition_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 121;
            this.label7.Text = "Chức vụ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnStaffCancel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbStaffRank);
            this.panel1.Controls.Add(this.txbStaffSupportMoney);
            this.panel1.Controls.Add(this.nupStaffLevel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.nudStaffExp);
            this.panel1.Controls.Add(this.txbStaffSalary);
            this.panel1.Controls.Add(this.txbStaffRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cbStaffPosition);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnAddStaff);
            this.panel1.Controls.Add(this.btnStaffDelete);
            this.panel1.Controls.Add(this.btnStaffEdit);
            this.panel1.Controls.Add(this.txbStaffCMND);
            this.panel1.Controls.Add(this.txbStaffName);
            this.panel1.Controls.Add(this.txbStaffLocate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txbStaffCountry);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbStaffNum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpStaffBirth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbStaffSex);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 313);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 263);
            this.panel1.TabIndex = 123;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Image = global::QuanLyBenhVien.Properties.Resources._171273_backup_guardar_safe_save_store_icon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(469, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 39);
            this.btnSave.TabIndex = 137;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStaffCancel
            // 
            this.btnStaffCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnStaffCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStaffCancel.Image = global::QuanLyBenhVien.Properties.Resources._211652_close_icon;
            this.btnStaffCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffCancel.Location = new System.Drawing.Point(747, 178);
            this.btnStaffCancel.Name = "btnStaffCancel";
            this.btnStaffCancel.Size = new System.Drawing.Size(70, 38);
            this.btnStaffCancel.TabIndex = 136;
            this.btnStaffCancel.Text = "Hủy";
            this.btnStaffCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffCancel.UseVisualStyleBackColor = false;
            this.btnStaffCancel.Click += new System.EventHandler(this.btnStaffCancel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(630, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 18);
            this.label15.TabIndex = 135;
            this.label15.Text = "VNĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(630, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 127;
            this.label9.Text = "Hạng:";
            // 
            // cbStaffRank
            // 
            this.cbStaffRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffRank.FormattingEnabled = true;
            this.cbStaffRank.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.cbStaffRank.Location = new System.Drawing.Point(682, 85);
            this.cbStaffRank.Name = "cbStaffRank";
            this.cbStaffRank.Size = new System.Drawing.Size(38, 24);
            this.cbStaffRank.TabIndex = 126;
            // 
            // txbStaffSupportMoney
            // 
            this.txbStaffSupportMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStaffSupportMoney.Location = new System.Drawing.Point(511, 54);
            this.txbStaffSupportMoney.Name = "txbStaffSupportMoney";
            this.txbStaffSupportMoney.Size = new System.Drawing.Size(114, 22);
            this.txbStaffSupportMoney.TabIndex = 134;
            this.txbStaffSupportMoney.TextChanged += new System.EventHandler(this.txbStaffSupportMoney_TextChanged);
            // 
            // nupStaffLevel
            // 
            this.nupStaffLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupStaffLevel.Location = new System.Drawing.Point(777, 81);
            this.nupStaffLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupStaffLevel.Name = "nupStaffLevel";
            this.nupStaffLevel.Size = new System.Drawing.Size(32, 26);
            this.nupStaffLevel.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(734, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 124;
            this.label3.Text = "Bậc:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(399, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 18);
            this.label16.TabIndex = 133;
            this.label16.Text = "Trợ cấp:";
            // 
            // nudStaffExp
            // 
            this.nudStaffExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStaffExp.Location = new System.Drawing.Point(394, 143);
            this.nudStaffExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudStaffExp.Name = "nudStaffExp";
            this.nudStaffExp.Size = new System.Drawing.Size(40, 26);
            this.nudStaffExp.TabIndex = 123;
            // 
            // txbStaffSalary
            // 
            this.txbStaffSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStaffSalary.Location = new System.Drawing.Point(511, 18);
            this.txbStaffSalary.Name = "txbStaffSalary";
            this.txbStaffSalary.Size = new System.Drawing.Size(114, 22);
            this.txbStaffSalary.TabIndex = 129;
            this.txbStaffSalary.TextChanged += new System.EventHandler(this.txbStaffSalary_TextChanged);
            // 
            // txbStaffRate
            // 
            this.txbStaffRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStaffRate.Location = new System.Drawing.Point(747, 18);
            this.txbStaffRate.Name = "txbStaffRate";
            this.txbStaffRate.Size = new System.Drawing.Size(63, 22);
            this.txbStaffRate.TabIndex = 132;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(399, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 18);
            this.label12.TabIndex = 128;
            this.label12.Text = "Lương cơ bản:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(691, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 131;
            this.label14.Text = "Hệ số:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(630, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 18);
            this.label13.TabIndex = 130;
            this.label13.Text = "VNĐ";
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnStaffDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStaffDelete.Image = global::QuanLyBenhVien.Properties.Resources._4781812_bin_delete_file_garbage_recycle_icon__2_;
            this.btnStaffDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffDelete.Location = new System.Drawing.Point(570, 179);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(86, 38);
            this.btnStaffDelete.TabIndex = 113;
            this.btnStaffDelete.Text = "Xóa";
            this.btnStaffDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffDelete.UseVisualStyleBackColor = false;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // btnStaffEdit
            // 
            this.btnStaffEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnStaffEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStaffEdit.Image = global::QuanLyBenhVien.Properties.Resources._7030152_ui_basic_write_pen_pencil_edit_icon__2_;
            this.btnStaffEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffEdit.Location = new System.Drawing.Point(662, 178);
            this.btnStaffEdit.Name = "btnStaffEdit";
            this.btnStaffEdit.Size = new System.Drawing.Size(79, 39);
            this.btnStaffEdit.TabIndex = 114;
            this.btnStaffEdit.Text = "Sửa";
            this.btnStaffEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffEdit.UseVisualStyleBackColor = false;
            this.btnStaffEdit.Click += new System.EventHandler(this.btnStaffEdit_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6});
            this.barManager1.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(885, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 650);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(885, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 626);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(885, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 626);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Lưu";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Sửa";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Hủy";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Thêm";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // uc_Quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.txbtimkiem);
            this.Controls.Add(this.dgvStaffList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_Quanlynhanvien";
            this.Size = new System.Drawing.Size(885, 650);
            this.Load += new System.EventHandler(this.uc_Quanlynhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStaffLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStaffExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.Button btnStaffEdit;
        private System.Windows.Forms.Button btnStaffDelete;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.ComboBox cbStaffSex;
        private System.Windows.Forms.DateTimePicker dtpStaffBirth;
        private System.Windows.Forms.TextBox txbStaffCountry;
        private System.Windows.Forms.TextBox txbStaffNum;
        private System.Windows.Forms.TextBox txbStaffName;
        private System.Windows.Forms.TextBox txbStaffCMND;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.TextBox txbtimkiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbStaffLocate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStaffPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudStaffExp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbStaffRank;
        private System.Windows.Forms.NumericUpDown nupStaffLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbStaffRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbStaffSalary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbStaffSupportMoney;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnStaffCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupMoney;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    }
}

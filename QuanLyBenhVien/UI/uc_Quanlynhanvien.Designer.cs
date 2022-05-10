
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
            this.label15 = new System.Windows.Forms.Label();
            this.txbStaffSupportMoney = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbStaffRate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbStaffSalary = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStaffRank = new System.Windows.Forms.ComboBox();
            this.nupStaffLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudStaffExp = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStaffCancel = new System.Windows.Forms.Button();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.btnStaffEdit = new System.Windows.Forms.Button();
            this.pbStaffImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStaffLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStaffExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaffList
            // 
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
            this.dgvStaffList.Location = new System.Drawing.Point(35, 75);
            this.dgvStaffList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.RowHeadersWidth = 51;
            this.dgvStaffList.Size = new System.Drawing.Size(753, 543);
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
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(65, 481);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(84, 38);
            this.btnAddStaff.TabIndex = 112;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // cbStaffSex
            // 
            this.cbStaffSex.FormattingEnabled = true;
            this.cbStaffSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbStaffSex.Location = new System.Drawing.Point(155, 192);
            this.cbStaffSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStaffSex.Name = "cbStaffSex";
            this.cbStaffSex.Size = new System.Drawing.Size(165, 24);
            this.cbStaffSex.TabIndex = 109;
            // 
            // dtpStaffBirth
            // 
            this.dtpStaffBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStaffBirth.Location = new System.Drawing.Point(293, 101);
            this.dtpStaffBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStaffBirth.Name = "dtpStaffBirth";
            this.dtpStaffBirth.Size = new System.Drawing.Size(272, 30);
            this.dtpStaffBirth.TabIndex = 108;
            this.dtpStaffBirth.ValueChanged += new System.EventHandler(this.dtpStaffBirth_ValueChanged);
            // 
            // txbStaffCountry
            // 
            this.txbStaffCountry.Location = new System.Drawing.Point(157, 235);
            this.txbStaffCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStaffCountry.Name = "txbStaffCountry";
            this.txbStaffCountry.Size = new System.Drawing.Size(163, 22);
            this.txbStaffCountry.TabIndex = 106;
            // 
            // txbStaffNum
            // 
            this.txbStaffNum.Location = new System.Drawing.Point(293, 144);
            this.txbStaffNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStaffNum.Name = "txbStaffNum";
            this.txbStaffNum.Size = new System.Drawing.Size(272, 22);
            this.txbStaffNum.TabIndex = 105;
            // 
            // txbStaffName
            // 
            this.txbStaffName.Location = new System.Drawing.Point(293, 68);
            this.txbStaffName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStaffName.Name = "txbStaffName";
            this.txbStaffName.Size = new System.Drawing.Size(272, 22);
            this.txbStaffName.TabIndex = 104;
            // 
            // txbStaffCMND
            // 
            this.txbStaffCMND.Location = new System.Drawing.Point(293, 30);
            this.txbStaffCMND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStaffCMND.Name = "txbStaffCMND";
            this.txbStaffCMND.ReadOnly = true;
            this.txbStaffCMND.Size = new System.Drawing.Size(272, 22);
            this.txbStaffCMND.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 101;
            this.label8.Text = "Quốc tịch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 99;
            this.label6.Text = "Số điện thoại:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 98;
            this.label5.Text = "Giới tính:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 97;
            this.label4.Text = "Ngày sinh:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 95;
            this.label2.Text = "Họ và tên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 94;
            this.label1.Text = "CMND:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStaff.Location = new System.Drawing.Point(35, 25);
            this.btnSearchStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(121, 36);
            this.btnSearchStaff.TabIndex = 116;
            this.btnSearchStaff.Text = "Tìm kiếm";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimkiem.Location = new System.Drawing.Point(163, 32);
            this.txbtimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(309, 26);
            this.txbtimkiem.TabIndex = 115;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.txbtimkiem_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(341, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 23);
            this.label10.TabIndex = 117;
            this.label10.Text = "Năm kinh nghiệm:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txbStaffLocate
            // 
            this.txbStaffLocate.Location = new System.Drawing.Point(155, 276);
            this.txbStaffLocate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStaffLocate.Multiline = true;
            this.txbStaffLocate.Name = "txbStaffLocate";
            this.txbStaffLocate.Size = new System.Drawing.Size(400, 37);
            this.txbStaffLocate.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 283);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 119;
            this.label11.Text = "Địa chỉ:";
            // 
            // cbStaffPosition
            // 
            this.cbStaffPosition.FormattingEnabled = true;
            this.cbStaffPosition.Items.AddRange(new object[] {
            "Lễ tân",
            "Bác sĩ",
            "Quản lý"});
            this.cbStaffPosition.Location = new System.Drawing.Point(157, 323);
            this.cbStaffPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStaffPosition.Name = "cbStaffPosition";
            this.cbStaffPosition.Size = new System.Drawing.Size(150, 24);
            this.cbStaffPosition.TabIndex = 122;
            this.cbStaffPosition.SelectedIndexChanged += new System.EventHandler(this.cbStaffPosition_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 324);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 121;
            this.label7.Text = "Chức vụ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnStaffCancel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txbStaffSupportMoney);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txbStaffRate);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txbStaffSalary);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbStaffRank);
            this.panel1.Controls.Add(this.nupStaffLevel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudStaffExp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbStaffPosition);
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
            this.panel1.Controls.Add(this.pbStaffImage);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbStaffNum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpStaffBirth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbStaffSex);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(795, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 543);
            this.panel1.TabIndex = 123;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(316, 405);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 23);
            this.label15.TabIndex = 135;
            this.label15.Text = "VNĐ";
            // 
            // txbStaffSupportMoney
            // 
            this.txbStaffSupportMoney.Location = new System.Drawing.Point(157, 405);
            this.txbStaffSupportMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStaffSupportMoney.Name = "txbStaffSupportMoney";
            this.txbStaffSupportMoney.Size = new System.Drawing.Size(150, 22);
            this.txbStaffSupportMoney.TabIndex = 134;
            this.txbStaffSupportMoney.TextChanged += new System.EventHandler(this.txbStaffSupportMoney_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 405);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 23);
            this.label16.TabIndex = 133;
            this.label16.Text = "Trợ cấp:";
            // 
            // txbStaffRate
            // 
            this.txbStaffRate.Location = new System.Drawing.Point(472, 366);
            this.txbStaffRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStaffRate.Name = "txbStaffRate";
            this.txbStaffRate.Size = new System.Drawing.Size(83, 22);
            this.txbStaffRate.TabIndex = 132;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(397, 366);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 23);
            this.label14.TabIndex = 131;
            this.label14.Text = "Hệ số:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(316, 366);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 23);
            this.label13.TabIndex = 130;
            this.label13.Text = "VNĐ";
            // 
            // txbStaffSalary
            // 
            this.txbStaffSalary.Location = new System.Drawing.Point(157, 366);
            this.txbStaffSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStaffSalary.Name = "txbStaffSalary";
            this.txbStaffSalary.Size = new System.Drawing.Size(150, 22);
            this.txbStaffSalary.TabIndex = 129;
            this.txbStaffSalary.TextChanged += new System.EventHandler(this.txbStaffSalary_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 366);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 23);
            this.label12.TabIndex = 128;
            this.label12.Text = "Lương cơ bản:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(316, 323);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 23);
            this.label9.TabIndex = 127;
            this.label9.Text = "Hạng:";
            // 
            // cbStaffRank
            // 
            this.cbStaffRank.FormattingEnabled = true;
            this.cbStaffRank.Items.AddRange(new object[] {
            "I",
            "II",
            "III"});
            this.cbStaffRank.Location = new System.Drawing.Point(385, 321);
            this.cbStaffRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStaffRank.Name = "cbStaffRank";
            this.cbStaffRank.Size = new System.Drawing.Size(50, 24);
            this.cbStaffRank.TabIndex = 126;
            // 
            // nupStaffLevel
            // 
            this.nupStaffLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupStaffLevel.Location = new System.Drawing.Point(512, 316);
            this.nupStaffLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupStaffLevel.Name = "nupStaffLevel";
            this.nupStaffLevel.Size = new System.Drawing.Size(43, 30);
            this.nupStaffLevel.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 124;
            this.label3.Text = "Bậc:";
            // 
            // nudStaffExp
            // 
            this.nudStaffExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStaffExp.Location = new System.Drawing.Point(512, 192);
            this.nudStaffExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudStaffExp.Name = "nudStaffExp";
            this.nudStaffExp.Size = new System.Drawing.Size(53, 30);
            this.nudStaffExp.TabIndex = 123;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::QuanLyBenhVien.Properties.Resources._171273_backup_guardar_safe_save_store_icon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(65, 476);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 43);
            this.btnSave.TabIndex = 137;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStaffCancel
            // 
            this.btnStaffCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffCancel.Image = global::QuanLyBenhVien.Properties.Resources._211652_close_icon;
            this.btnStaffCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffCancel.Location = new System.Drawing.Point(401, 478);
            this.btnStaffCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffCancel.Name = "btnStaffCancel";
            this.btnStaffCancel.Size = new System.Drawing.Size(91, 41);
            this.btnStaffCancel.TabIndex = 136;
            this.btnStaffCancel.Text = "Hủy";
            this.btnStaffCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffCancel.UseVisualStyleBackColor = true;
            this.btnStaffCancel.Click += new System.EventHandler(this.btnStaffCancel_Click);
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDelete.Image = global::QuanLyBenhVien.Properties.Resources._4781812_bin_delete_file_garbage_recycle_icon__2_;
            this.btnStaffDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffDelete.Location = new System.Drawing.Point(170, 476);
            this.btnStaffDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(92, 43);
            this.btnStaffDelete.TabIndex = 113;
            this.btnStaffDelete.Text = "Xóa";
            this.btnStaffDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffDelete.UseVisualStyleBackColor = true;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // btnStaffEdit
            // 
            this.btnStaffEdit.BackColor = System.Drawing.Color.White;
            this.btnStaffEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffEdit.Image = global::QuanLyBenhVien.Properties.Resources._7030152_ui_basic_write_pen_pencil_edit_icon__2_;
            this.btnStaffEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffEdit.Location = new System.Drawing.Point(277, 476);
            this.btnStaffEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffEdit.Name = "btnStaffEdit";
            this.btnStaffEdit.Size = new System.Drawing.Size(100, 43);
            this.btnStaffEdit.TabIndex = 114;
            this.btnStaffEdit.Text = "Sửa";
            this.btnStaffEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffEdit.UseVisualStyleBackColor = false;
            this.btnStaffEdit.Click += new System.EventHandler(this.btnStaffEdit_Click);
            // 
            // pbStaffImage
            // 
            this.pbStaffImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStaffImage.Location = new System.Drawing.Point(21, 30);
            this.pbStaffImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbStaffImage.Name = "pbStaffImage";
            this.pbStaffImage.Size = new System.Drawing.Size(105, 136);
            this.pbStaffImage.TabIndex = 107;
            this.pbStaffImage.TabStop = false;
            this.pbStaffImage.Click += new System.EventHandler(this.pbStaffImage_Click);
            // 
            // uc_Quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.txbtimkiem);
            this.Controls.Add(this.dgvStaffList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_Quanlynhanvien";
            this.Size = new System.Drawing.Size(1572, 656);
            this.Load += new System.EventHandler(this.uc_Quanlynhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStaffLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStaffExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffImage)).EndInit();
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
        private System.Windows.Forms.PictureBox pbStaffImage;
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
    }
}

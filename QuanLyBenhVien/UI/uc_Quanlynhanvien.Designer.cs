
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
            this.btnStaffEdit = new System.Windows.Forms.Button();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.cbStaffSex = new System.Windows.Forms.ComboBox();
            this.dtpStaffBirth = new System.Windows.Forms.DateTimePicker();
            this.pbStaffImage = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStaffLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStaffExp)).BeginInit();
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
            this.dgvStaffList.Location = new System.Drawing.Point(26, 61);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.RowHeadersWidth = 51;
            this.dgvStaffList.Size = new System.Drawing.Size(589, 441);
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
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "GioiTinh";
            this.colSex.HeaderText = "Giới tính";
            this.colSex.MinimumWidth = 6;
            this.colSex.Name = "colSex";
            // 
            // colEx
            // 
            this.colEx.DataPropertyName = "Ex";
            this.colEx.HeaderText = "Kinh nghiệm";
            this.colEx.MinimumWidth = 6;
            this.colEx.Name = "colEx";
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
            // btnStaffEdit
            // 
            this.btnStaffEdit.Location = new System.Drawing.Point(181, 393);
            this.btnStaffEdit.Name = "btnStaffEdit";
            this.btnStaffEdit.Size = new System.Drawing.Size(75, 23);
            this.btnStaffEdit.TabIndex = 114;
            this.btnStaffEdit.Text = "Sửa";
            this.btnStaffEdit.UseVisualStyleBackColor = true;
            this.btnStaffEdit.Click += new System.EventHandler(this.btnStaffEdit_Click);
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.Location = new System.Drawing.Point(100, 393);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStaffDelete.TabIndex = 113;
            this.btnStaffDelete.Text = "Xóa";
            this.btnStaffDelete.UseVisualStyleBackColor = true;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(19, 393);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
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
            this.cbStaffSex.Location = new System.Drawing.Point(91, 141);
            this.cbStaffSex.Name = "cbStaffSex";
            this.cbStaffSex.Size = new System.Drawing.Size(99, 21);
            this.cbStaffSex.TabIndex = 109;
            // 
            // dtpStaffBirth
            // 
            this.dtpStaffBirth.Location = new System.Drawing.Point(178, 80);
            this.dtpStaffBirth.Name = "dtpStaffBirth";
            this.dtpStaffBirth.Size = new System.Drawing.Size(160, 20);
            this.dtpStaffBirth.TabIndex = 108;
            // 
            // pbStaffImage
            // 
            this.pbStaffImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStaffImage.Location = new System.Drawing.Point(16, 24);
            this.pbStaffImage.Name = "pbStaffImage";
            this.pbStaffImage.Size = new System.Drawing.Size(79, 111);
            this.pbStaffImage.TabIndex = 107;
            this.pbStaffImage.TabStop = false;
            this.pbStaffImage.Click += new System.EventHandler(this.pbStaffImage_Click);
            // 
            // txbStaffCountry
            // 
            this.txbStaffCountry.Location = new System.Drawing.Point(91, 171);
            this.txbStaffCountry.Name = "txbStaffCountry";
            this.txbStaffCountry.Size = new System.Drawing.Size(247, 20);
            this.txbStaffCountry.TabIndex = 106;
            // 
            // txbStaffNum
            // 
            this.txbStaffNum.Location = new System.Drawing.Point(178, 105);
            this.txbStaffNum.Name = "txbStaffNum";
            this.txbStaffNum.Size = new System.Drawing.Size(160, 20);
            this.txbStaffNum.TabIndex = 105;
            // 
            // txbStaffName
            // 
            this.txbStaffName.Location = new System.Drawing.Point(178, 58);
            this.txbStaffName.Name = "txbStaffName";
            this.txbStaffName.Size = new System.Drawing.Size(160, 20);
            this.txbStaffName.TabIndex = 104;
            // 
            // txbStaffCMND
            // 
            this.txbStaffCMND.Location = new System.Drawing.Point(178, 35);
            this.txbStaffCMND.Name = "txbStaffCMND";
            this.txbStaffCMND.ReadOnly = true;
            this.txbStaffCMND.Size = new System.Drawing.Size(160, 20);
            this.txbStaffCMND.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Quốc tịch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "CMND:";
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(26, 23);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStaff.TabIndex = 116;
            this.btnSearchStaff.Text = "Tìm kiếm";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimkiem.Location = new System.Drawing.Point(122, 23);
            this.txbtimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(180, 22);
            this.txbtimkiem.TabIndex = 115;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.txbtimkiem_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 117;
            this.label10.Text = "Năm kinh nghiệm:";
            // 
            // txbStaffLocate
            // 
            this.txbStaffLocate.Location = new System.Drawing.Point(91, 201);
            this.txbStaffLocate.Multiline = true;
            this.txbStaffLocate.Name = "txbStaffLocate";
            this.txbStaffLocate.Size = new System.Drawing.Size(247, 49);
            this.txbStaffLocate.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
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
            this.cbStaffPosition.Location = new System.Drawing.Point(91, 261);
            this.cbStaffPosition.Name = "cbStaffPosition";
            this.cbStaffPosition.Size = new System.Drawing.Size(73, 21);
            this.cbStaffPosition.TabIndex = 122;
            this.cbStaffPosition.SelectedIndexChanged += new System.EventHandler(this.cbStaffPosition_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
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
            this.panel1.Location = new System.Drawing.Point(620, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 441);
            this.panel1.TabIndex = 123;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 137;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStaffCancel
            // 
            this.btnStaffCancel.Location = new System.Drawing.Point(262, 393);
            this.btnStaffCancel.Name = "btnStaffCancel";
            this.btnStaffCancel.Size = new System.Drawing.Size(75, 23);
            this.btnStaffCancel.TabIndex = 136;
            this.btnStaffCancel.Text = "Hủy";
            this.btnStaffCancel.UseVisualStyleBackColor = true;
            this.btnStaffCancel.Click += new System.EventHandler(this.btnStaffCancel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(178, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 135;
            this.label15.Text = "vnđ";
            // 
            // txbStaffSupportMoney
            // 
            this.txbStaffSupportMoney.Location = new System.Drawing.Point(91, 324);
            this.txbStaffSupportMoney.Name = "txbStaffSupportMoney";
            this.txbStaffSupportMoney.Size = new System.Drawing.Size(74, 20);
            this.txbStaffSupportMoney.TabIndex = 134;
            this.txbStaffSupportMoney.TextChanged += new System.EventHandler(this.txbStaffSupportMoney_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 327);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 133;
            this.label16.Text = "Trợ cấp:";
            // 
            // txbStaffRate
            // 
            this.txbStaffRate.Location = new System.Drawing.Point(266, 294);
            this.txbStaffRate.Name = "txbStaffRate";
            this.txbStaffRate.Size = new System.Drawing.Size(72, 20);
            this.txbStaffRate.TabIndex = 132;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 131;
            this.label14.Text = "Hệ số:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 130;
            this.label13.Text = "vnđ";
            // 
            // txbStaffSalary
            // 
            this.txbStaffSalary.Location = new System.Drawing.Point(91, 294);
            this.txbStaffSalary.Name = "txbStaffSalary";
            this.txbStaffSalary.Size = new System.Drawing.Size(73, 20);
            this.txbStaffSalary.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 128;
            this.label12.Text = "Lương cơ bản:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
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
            this.cbStaffRank.Location = new System.Drawing.Point(220, 261);
            this.cbStaffRank.Name = "cbStaffRank";
            this.cbStaffRank.Size = new System.Drawing.Size(37, 21);
            this.cbStaffRank.TabIndex = 126;
            // 
            // nupStaffLevel
            // 
            this.nupStaffLevel.Location = new System.Drawing.Point(305, 262);
            this.nupStaffLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupStaffLevel.Name = "nupStaffLevel";
            this.nupStaffLevel.Size = new System.Drawing.Size(32, 20);
            this.nupStaffLevel.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "Bậc:";
            // 
            // nudStaffExp
            // 
            this.nudStaffExp.Location = new System.Drawing.Point(297, 141);
            this.nudStaffExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudStaffExp.Name = "nudStaffExp";
            this.nudStaffExp.Size = new System.Drawing.Size(40, 20);
            this.nudStaffExp.TabIndex = 123;
            // 
            // uc_Quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.txbtimkiem);
            this.Controls.Add(this.dgvStaffList);
            this.Name = "uc_Quanlynhanvien";
            this.Size = new System.Drawing.Size(1356, 533);
            this.Load += new System.EventHandler(this.uc_Quanlynhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStaffLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStaffExp)).EndInit();
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

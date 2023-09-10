namespace EF_Sinav
{
    partial class UserPanel
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
            lvTexts = new ListView();
            txtTitle = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lvTexts
            // 
            lvTexts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lvTexts.FullRowSelect = true;
            lvTexts.GridLines = true;
            lvTexts.Location = new Point(597, 16);
            lvTexts.Name = "lvTexts";
            lvTexts.Size = new Size(474, 215);
            lvTexts.TabIndex = 5;
            lvTexts.UseCompatibleStateImageBehavior = false;
            lvTexts.View = View.Details;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(68, 44);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(190, 25);
            txtTitle.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(304, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Kaydet";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(304, 90);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 40);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 136);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 485);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Paneli";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(597, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(474, 236);
            dataGridView1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(68, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 25);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(68, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(68, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 25);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(68, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(190, 25);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(68, 198);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(190, 25);
            textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(68, 229);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(190, 25);
            textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(68, 260);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(190, 25);
            textBox7.TabIndex = 1;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 549);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(lvTexts);
            Name = "UserPanel";
            Text = "UserPanel";
            Load += UserPanel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListView lvTexts;
        private TextBox txtTitle;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
namespace MHWIBDamageCalc
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboWeapon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attackDamageLabel = new System.Windows.Forms.Label();
            this.comboWeaponMulti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WeaponMultiLabel = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculatedLabel = new System.Windows.Forms.Label();
            this.comboBulletIncreased = new System.Windows.Forms.ComboBox();
            this.comboTokusha = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.buttonSqlConnection = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAttackDamage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboWeapon
            // 
            this.comboWeapon.FormattingEnabled = true;
            this.comboWeapon.Location = new System.Drawing.Point(21, 28);
            this.comboWeapon.Name = "comboWeapon";
            this.comboWeapon.Size = new System.Drawing.Size(138, 20);
            this.comboWeapon.TabIndex = 0;
            this.comboWeapon.SelectedValueChanged += new System.EventHandler(this.comboWeapon_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "攻撃力：";
            // 
            // attackDamageLabel
            // 
            this.attackDamageLabel.AutoSize = true;
            this.attackDamageLabel.Location = new System.Drawing.Point(118, 54);
            this.attackDamageLabel.Name = "attackDamageLabel";
            this.attackDamageLabel.Size = new System.Drawing.Size(41, 12);
            this.attackDamageLabel.TabIndex = 2;
            this.attackDamageLabel.Text = "未選択";
            // 
            // comboWeaponMulti
            // 
            this.comboWeaponMulti.FormattingEnabled = true;
            this.comboWeaponMulti.Location = new System.Drawing.Point(179, 27);
            this.comboWeaponMulti.Name = "comboWeaponMulti";
            this.comboWeaponMulti.Size = new System.Drawing.Size(141, 20);
            this.comboWeaponMulti.TabIndex = 3;
            this.comboWeaponMulti.SelectedValueChanged += new System.EventHandler(this.comboWeaponMulti_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "武器係数：";
            // 
            // WeaponMultiLabel
            // 
            this.WeaponMultiLabel.AutoSize = true;
            this.WeaponMultiLabel.Location = new System.Drawing.Point(279, 54);
            this.WeaponMultiLabel.Name = "WeaponMultiLabel";
            this.WeaponMultiLabel.Size = new System.Drawing.Size(41, 12);
            this.WeaponMultiLabel.TabIndex = 5;
            this.WeaponMultiLabel.Text = "未選択";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(737, 488);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "計算";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Clicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "計算結果：";
            // 
            // CalculatedLabel
            // 
            this.CalculatedLabel.AutoSize = true;
            this.CalculatedLabel.Location = new System.Drawing.Point(670, 493);
            this.CalculatedLabel.Name = "CalculatedLabel";
            this.CalculatedLabel.Size = new System.Drawing.Size(11, 12);
            this.CalculatedLabel.TabIndex = 9;
            this.CalculatedLabel.Text = "0";
            // 
            // comboBulletIncreased
            // 
            this.comboBulletIncreased.FormattingEnabled = true;
            this.comboBulletIncreased.Location = new System.Drawing.Point(356, 27);
            this.comboBulletIncreased.Name = "comboBulletIncreased";
            this.comboBulletIncreased.Size = new System.Drawing.Size(30, 20);
            this.comboBulletIncreased.TabIndex = 10;
            // 
            // comboTokusha
            // 
            this.comboTokusha.FormattingEnabled = true;
            this.comboTokusha.Location = new System.Drawing.Point(356, 53);
            this.comboTokusha.Name = "comboTokusha";
            this.comboTokusha.Size = new System.Drawing.Size(30, 20);
            this.comboTokusha.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "弾強化";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "特射強化";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(450, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(450, 56);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 16);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(450, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 16);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(450, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 16);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(450, 125);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 16);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // buttonSqlConnection
            // 
            this.buttonSqlConnection.Location = new System.Drawing.Point(737, 459);
            this.buttonSqlConnection.Name = "buttonSqlConnection";
            this.buttonSqlConnection.Size = new System.Drawing.Size(75, 23);
            this.buttonSqlConnection.TabIndex = 19;
            this.buttonSqlConnection.Text = "接続";
            this.buttonSqlConnection.UseVisualStyleBackColor = true;
            this.buttonSqlConnection.Click += new System.EventHandler(this.connectionButtonClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(563, 244);
            this.dataGridView1.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 20);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.testSelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "攻撃力：";
            // 
            // labelAttackDamage
            // 
            this.labelAttackDamage.AutoSize = true;
            this.labelAttackDamage.Location = new System.Drawing.Point(120, 168);
            this.labelAttackDamage.Name = "labelAttackDamage";
            this.labelAttackDamage.Size = new System.Drawing.Size(41, 12);
            this.labelAttackDamage.TabIndex = 23;
            this.labelAttackDamage.Text = "未選択";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 523);
            this.Controls.Add(this.labelAttackDamage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSqlConnection);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTokusha);
            this.Controls.Add(this.comboBulletIncreased);
            this.Controls.Add(this.CalculatedLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.WeaponMultiLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboWeaponMulti);
            this.Controls.Add(this.attackDamageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboWeapon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboWeapon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label attackDamageLabel;
        private System.Windows.Forms.ComboBox comboWeaponMulti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WeaponMultiLabel;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CalculatedLabel;
        private System.Windows.Forms.ComboBox comboBulletIncreased;
        private System.Windows.Forms.ComboBox comboTokusha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button buttonSqlConnection;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAttackDamage;
    }
}


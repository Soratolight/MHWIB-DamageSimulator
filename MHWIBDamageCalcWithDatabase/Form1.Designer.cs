namespace MHWIBDamageCalcWithDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboWeapon = new System.Windows.Forms.ComboBox();
            this.comboWeaponType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAttackDamage = new System.Windows.Forms.Label();
            this.pictureWeapon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelElement = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelElementType = new System.Windows.Forms.Label();
            this.pictureElementType = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCritical = new System.Windows.Forms.Label();
            this.labelDefenceBonus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelWeaponMulti = new System.Windows.Forms.Label();
            this.labelCalculate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBulletBuff = new System.Windows.Forms.ComboBox();
            this.comboPurePhysBuff = new System.Windows.Forms.ComboBox();
            this.comboTokushaBuff = new System.Windows.Forms.ComboBox();
            this.comboHuntlingBuff = new System.Windows.Forms.ComboBox();
            this.pictureRandomized = new System.Windows.Forms.PictureBox();
            this.comboCustomPhys = new System.Windows.Forms.ComboBox();
            this.comboCustomEle = new System.Windows.Forms.ComboBox();
            this.comboNekomeshi = new System.Windows.Forms.ComboBox();
            this.comboCriticalBoost = new System.Windows.Forms.ComboBox();
            this.comboKijin = new System.Windows.Forms.ComboBox();
            this.comboAttackInc = new System.Windows.Forms.ComboBox();
            this.comboKairiki = new System.Windows.Forms.ComboBox();
            this.checkNekoShageki = new System.Windows.Forms.CheckBox();
            this.checkDodgeBuff = new System.Windows.Forms.CheckBox();
            this.checkNonCritical = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkGofu = new System.Windows.Forms.CheckBox();
            this.checkTsume = new System.Windows.Forms.CheckBox();
            this.comboMotion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureElementType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRandomized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboWeapon
            // 
            this.comboWeapon.FormattingEnabled = true;
            this.comboWeapon.Location = new System.Drawing.Point(142, 50);
            this.comboWeapon.Name = "comboWeapon";
            this.comboWeapon.Size = new System.Drawing.Size(172, 20);
            this.comboWeapon.TabIndex = 0;
            this.comboWeapon.SelectedValueChanged += new System.EventHandler(this.WeaponSelectedValueChanged);
            // 
            // comboWeaponType
            // 
            this.comboWeaponType.FormattingEnabled = true;
            this.comboWeaponType.Location = new System.Drawing.Point(21, 50);
            this.comboWeaponType.Name = "comboWeaponType";
            this.comboWeaponType.Size = new System.Drawing.Size(106, 20);
            this.comboWeaponType.TabIndex = 1;
            this.comboWeaponType.SelectedValueChanged += new System.EventHandler(this.WeaponTypeSelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "武器種";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "攻撃力：";
            // 
            // labelAttackDamage
            // 
            this.labelAttackDamage.AutoSize = true;
            this.labelAttackDamage.Location = new System.Drawing.Point(193, 35);
            this.labelAttackDamage.Name = "labelAttackDamage";
            this.labelAttackDamage.Size = new System.Drawing.Size(41, 12);
            this.labelAttackDamage.TabIndex = 4;
            this.labelAttackDamage.Text = "未選択";
            // 
            // pictureWeapon
            // 
            this.pictureWeapon.Location = new System.Drawing.Point(330, 12);
            this.pictureWeapon.Name = "pictureWeapon";
            this.pictureWeapon.Size = new System.Drawing.Size(59, 58);
            this.pictureWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWeapon.TabIndex = 5;
            this.pictureWeapon.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "属性値：";
            // 
            // labelElement
            // 
            this.labelElement.AutoSize = true;
            this.labelElement.Location = new System.Drawing.Point(193, 12);
            this.labelElement.Name = "labelElement";
            this.labelElement.Size = new System.Drawing.Size(41, 12);
            this.labelElement.TabIndex = 7;
            this.labelElement.Text = "未選択";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "属性";
            // 
            // labelElementType
            // 
            this.labelElementType.AutoSize = true;
            this.labelElementType.Location = new System.Drawing.Point(273, 9);
            this.labelElementType.Name = "labelElementType";
            this.labelElementType.Size = new System.Drawing.Size(41, 12);
            this.labelElementType.TabIndex = 9;
            this.labelElementType.Text = "未選択";
            // 
            // pictureElementType
            // 
            this.pictureElementType.Location = new System.Drawing.Point(284, 25);
            this.pictureElementType.Name = "pictureElementType";
            this.pictureElementType.Size = new System.Drawing.Size(21, 22);
            this.pictureElementType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureElementType.TabIndex = 10;
            this.pictureElementType.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "会心率：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "防御力ボーナス：";
            // 
            // labelCritical
            // 
            this.labelCritical.AutoSize = true;
            this.labelCritical.Location = new System.Drawing.Point(485, 22);
            this.labelCritical.Name = "labelCritical";
            this.labelCritical.Size = new System.Drawing.Size(11, 12);
            this.labelCritical.TabIndex = 13;
            this.labelCritical.Text = "0";
            // 
            // labelDefenceBonus
            // 
            this.labelDefenceBonus.AutoSize = true;
            this.labelDefenceBonus.Location = new System.Drawing.Point(485, 50);
            this.labelDefenceBonus.Name = "labelDefenceBonus";
            this.labelDefenceBonus.Size = new System.Drawing.Size(11, 12);
            this.labelDefenceBonus.TabIndex = 14;
            this.labelDefenceBonus.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(511, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(601, 422);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 17;
            this.buttonCalculate.Text = "計算";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.CalculateButtonClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "武器係数：";
            // 
            // labelWeaponMulti
            // 
            this.labelWeaponMulti.AutoSize = true;
            this.labelWeaponMulti.Location = new System.Drawing.Point(80, 34);
            this.labelWeaponMulti.Name = "labelWeaponMulti";
            this.labelWeaponMulti.Size = new System.Drawing.Size(41, 12);
            this.labelWeaponMulti.TabIndex = 19;
            this.labelWeaponMulti.Text = "未選択";
            // 
            // labelCalculate
            // 
            this.labelCalculate.AutoSize = true;
            this.labelCalculate.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCalculate.Location = new System.Drawing.Point(537, 423);
            this.labelCalculate.Name = "labelCalculate";
            this.labelCalculate.Size = new System.Drawing.Size(24, 28);
            this.labelCalculate.TabIndex = 20;
            this.labelCalculate.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(446, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "計算結果：";
            // 
            // comboBulletBuff
            // 
            this.comboBulletBuff.FormattingEnabled = true;
            this.comboBulletBuff.Location = new System.Drawing.Point(402, 154);
            this.comboBulletBuff.Name = "comboBulletBuff";
            this.comboBulletBuff.Size = new System.Drawing.Size(106, 20);
            this.comboBulletBuff.TabIndex = 22;
            // 
            // comboPurePhysBuff
            // 
            this.comboPurePhysBuff.FormattingEnabled = true;
            this.comboPurePhysBuff.Location = new System.Drawing.Point(21, 128);
            this.comboPurePhysBuff.Name = "comboPurePhysBuff";
            this.comboPurePhysBuff.Size = new System.Drawing.Size(116, 20);
            this.comboPurePhysBuff.TabIndex = 23;
            // 
            // comboTokushaBuff
            // 
            this.comboTokushaBuff.FormattingEnabled = true;
            this.comboTokushaBuff.Location = new System.Drawing.Point(525, 154);
            this.comboTokushaBuff.Name = "comboTokushaBuff";
            this.comboTokushaBuff.Size = new System.Drawing.Size(106, 20);
            this.comboTokushaBuff.TabIndex = 24;
            // 
            // comboHuntlingBuff
            // 
            this.comboHuntlingBuff.FormattingEnabled = true;
            this.comboHuntlingBuff.Location = new System.Drawing.Point(21, 180);
            this.comboHuntlingBuff.Name = "comboHuntlingBuff";
            this.comboHuntlingBuff.Size = new System.Drawing.Size(127, 20);
            this.comboHuntlingBuff.TabIndex = 25;
            // 
            // pictureRandomized
            // 
            this.pictureRandomized.Image = ((System.Drawing.Image)(resources.GetObject("pictureRandomized.Image")));
            this.pictureRandomized.Location = new System.Drawing.Point(330, 194);
            this.pictureRandomized.Name = "pictureRandomized";
            this.pictureRandomized.Size = new System.Drawing.Size(350, 219);
            this.pictureRandomized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRandomized.TabIndex = 30;
            this.pictureRandomized.TabStop = false;
            // 
            // comboCustomPhys
            // 
            this.comboCustomPhys.FormattingEnabled = true;
            this.comboCustomPhys.Location = new System.Drawing.Point(21, 76);
            this.comboCustomPhys.Name = "comboCustomPhys";
            this.comboCustomPhys.Size = new System.Drawing.Size(127, 20);
            this.comboCustomPhys.TabIndex = 31;
            // 
            // comboCustomEle
            // 
            this.comboCustomEle.FormattingEnabled = true;
            this.comboCustomEle.Location = new System.Drawing.Point(154, 76);
            this.comboCustomEle.Name = "comboCustomEle";
            this.comboCustomEle.Size = new System.Drawing.Size(126, 20);
            this.comboCustomEle.TabIndex = 32;
            // 
            // comboNekomeshi
            // 
            this.comboNekomeshi.FormattingEnabled = true;
            this.comboNekomeshi.Location = new System.Drawing.Point(21, 154);
            this.comboNekomeshi.Name = "comboNekomeshi";
            this.comboNekomeshi.Size = new System.Drawing.Size(85, 20);
            this.comboNekomeshi.TabIndex = 35;
            // 
            // comboCriticalBoost
            // 
            this.comboCriticalBoost.FormattingEnabled = true;
            this.comboCriticalBoost.Location = new System.Drawing.Point(148, 102);
            this.comboCriticalBoost.Name = "comboCriticalBoost";
            this.comboCriticalBoost.Size = new System.Drawing.Size(112, 20);
            this.comboCriticalBoost.TabIndex = 36;
            // 
            // comboKijin
            // 
            this.comboKijin.FormattingEnabled = true;
            this.comboKijin.Location = new System.Drawing.Point(112, 154);
            this.comboKijin.Name = "comboKijin";
            this.comboKijin.Size = new System.Drawing.Size(134, 20);
            this.comboKijin.TabIndex = 37;
            // 
            // comboAttackInc
            // 
            this.comboAttackInc.FormattingEnabled = true;
            this.comboAttackInc.Location = new System.Drawing.Point(21, 102);
            this.comboAttackInc.Name = "comboAttackInc";
            this.comboAttackInc.Size = new System.Drawing.Size(121, 20);
            this.comboAttackInc.TabIndex = 38;
            // 
            // comboKairiki
            // 
            this.comboKairiki.FormattingEnabled = true;
            this.comboKairiki.Location = new System.Drawing.Point(252, 154);
            this.comboKairiki.Name = "comboKairiki";
            this.comboKairiki.Size = new System.Drawing.Size(121, 20);
            this.comboKairiki.TabIndex = 39;
            // 
            // checkNekoShageki
            // 
            this.checkNekoShageki.AutoSize = true;
            this.checkNekoShageki.Location = new System.Drawing.Point(311, 132);
            this.checkNekoShageki.Name = "checkNekoShageki";
            this.checkNekoShageki.Size = new System.Drawing.Size(88, 16);
            this.checkNekoShageki.TabIndex = 40;
            this.checkNekoShageki.Text = "ネコの射撃術";
            this.checkNekoShageki.UseVisualStyleBackColor = true;
            this.checkNekoShageki.CheckedChanged += new System.EventHandler(this.NekoShagekiBuffCheckedChanged);
            // 
            // checkDodgeBuff
            // 
            this.checkDodgeBuff.AutoSize = true;
            this.checkDodgeBuff.Location = new System.Drawing.Point(291, 80);
            this.checkDodgeBuff.Name = "checkDodgeBuff";
            this.checkDodgeBuff.Size = new System.Drawing.Size(82, 16);
            this.checkDodgeBuff.TabIndex = 41;
            this.checkDodgeBuff.Text = "回避の装衣";
            this.checkDodgeBuff.UseVisualStyleBackColor = true;
            this.checkDodgeBuff.CheckedChanged += new System.EventHandler(this.DodgeCheckedChanged);
            // 
            // checkNonCritical
            // 
            this.checkNonCritical.AutoSize = true;
            this.checkNonCritical.Location = new System.Drawing.Point(266, 106);
            this.checkNonCritical.Name = "checkNonCritical";
            this.checkNonCritical.Size = new System.Drawing.Size(67, 16);
            this.checkNonCritical.TabIndex = 42;
            this.checkNonCritical.Text = "会心なし";
            this.checkNonCritical.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(398, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "ガンナー用";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(293, 226);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // checkGofu
            // 
            this.checkGofu.AutoSize = true;
            this.checkGofu.Location = new System.Drawing.Point(148, 132);
            this.checkGofu.Name = "checkGofu";
            this.checkGofu.Size = new System.Drawing.Size(70, 16);
            this.checkGofu.TabIndex = 45;
            this.checkGofu.Text = "力の護符";
            this.checkGofu.UseVisualStyleBackColor = true;
            this.checkGofu.CheckedChanged += new System.EventHandler(this.GofuCheckedChanged);
            // 
            // checkTsume
            // 
            this.checkTsume.AutoSize = true;
            this.checkTsume.Location = new System.Drawing.Point(213, 132);
            this.checkTsume.Name = "checkTsume";
            this.checkTsume.Size = new System.Drawing.Size(58, 16);
            this.checkTsume.TabIndex = 46;
            this.checkTsume.Text = "力の爪";
            this.checkTsume.UseVisualStyleBackColor = true;
            this.checkTsume.CheckedChanged += new System.EventHandler(this.TsumeCheckedChanged);
            // 
            // comboMotion
            // 
            this.comboMotion.FormattingEnabled = true;
            this.comboMotion.Location = new System.Drawing.Point(525, 102);
            this.comboMotion.Name = "comboMotion";
            this.comboMotion.Size = new System.Drawing.Size(121, 20);
            this.comboMotion.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 12);
            this.label10.TabIndex = 48;
            this.label10.Text = "モーション選択";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(509, 1);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 12);
            this.linkLabel1.TabIndex = 49;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mhworld.kiranico.com/ja";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDataBase);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(455, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 12);
            this.label11.TabIndex = 50;
            this.label11.Text = "Database:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 457);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboMotion);
            this.Controls.Add(this.checkTsume);
            this.Controls.Add(this.checkGofu);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkNonCritical);
            this.Controls.Add(this.checkDodgeBuff);
            this.Controls.Add(this.checkNekoShageki);
            this.Controls.Add(this.comboKairiki);
            this.Controls.Add(this.comboAttackInc);
            this.Controls.Add(this.comboKijin);
            this.Controls.Add(this.comboCriticalBoost);
            this.Controls.Add(this.comboNekomeshi);
            this.Controls.Add(this.comboCustomEle);
            this.Controls.Add(this.comboCustomPhys);
            this.Controls.Add(this.pictureRandomized);
            this.Controls.Add(this.comboHuntlingBuff);
            this.Controls.Add(this.comboTokushaBuff);
            this.Controls.Add(this.comboPurePhysBuff);
            this.Controls.Add(this.comboBulletBuff);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelCalculate);
            this.Controls.Add(this.labelWeaponMulti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDefenceBonus);
            this.Controls.Add(this.labelCritical);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureElementType);
            this.Controls.Add(this.labelElementType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelElement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureWeapon);
            this.Controls.Add(this.labelAttackDamage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboWeaponType);
            this.Controls.Add(this.comboWeapon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MHW:Iceborne Damage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureElementType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRandomized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboWeapon;
        private System.Windows.Forms.ComboBox comboWeaponType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAttackDamage;
        private System.Windows.Forms.PictureBox pictureWeapon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelElement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelElementType;
        private System.Windows.Forms.PictureBox pictureElementType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCritical;
        private System.Windows.Forms.Label labelDefenceBonus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWeaponMulti;
        private System.Windows.Forms.Label labelCalculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBulletBuff;
        private System.Windows.Forms.ComboBox comboPurePhysBuff;
        private System.Windows.Forms.ComboBox comboTokushaBuff;
        private System.Windows.Forms.ComboBox comboHuntlingBuff;
        private System.Windows.Forms.PictureBox pictureRandomized;
        private System.Windows.Forms.ComboBox comboCustomPhys;
        private System.Windows.Forms.ComboBox comboCustomEle;
        private System.Windows.Forms.ComboBox comboNekomeshi;
        private System.Windows.Forms.ComboBox comboCriticalBoost;
        private System.Windows.Forms.ComboBox comboKijin;
        private System.Windows.Forms.ComboBox comboAttackInc;
        private System.Windows.Forms.ComboBox comboKairiki;
        private System.Windows.Forms.CheckBox checkNekoShageki;
        private System.Windows.Forms.CheckBox checkDodgeBuff;
        private System.Windows.Forms.CheckBox checkNonCritical;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkGofu;
        private System.Windows.Forms.CheckBox checkTsume;
        private System.Windows.Forms.ComboBox comboMotion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
    }
}


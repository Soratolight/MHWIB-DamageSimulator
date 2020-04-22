using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MHWIBDamageCalcWithDatabase
{
    public partial class Form1 : Form
    {
        //データを格納するテーブル作成

        //モーションテーブル　
        private DataTable lsMotionTable = new DataTable();

        //バフテーブル
        private DataTable buffBulletTable = new DataTable();

        private DataTable buffHuntlingTable = new DataTable();
        private DataTable buffTokushaTable = new DataTable();
        private DataTable buffPurePhysTable = new DataTable();
        private DataTable buffCustomPhysTable = new DataTable();
        private DataTable buffCustomEleTable = new DataTable();
        private DataTable buffNekomeshiTable = new DataTable();
        private DataTable buffKijinTable = new DataTable();
        private DataTable buffKairikiTable = new DataTable();
        private DataTable buffAttackIncTable = new DataTable();
        private DataTable buffCriticalBoost = new DataTable();

        //武器種テーブル
        private DataTable weaponTypeTable = new DataTable();

        //武器テーブル
        private DataTable longSwordTable = new DataTable();

        private DataTable greatSwordTable = new DataTable();
        private DataTable SnSTable = new DataTable();
        private DataTable bowTable = new DataTable();
        private DataTable dualBladesTable = new DataTable();
        private DataTable hammerTable = new DataTable();
        private DataTable huntlingHornTable = new DataTable();
        private DataTable lanceTable = new DataTable();
        private DataTable gunLanceTable = new DataTable();
        private DataTable switchAxeTable = new DataTable();
        private DataTable chargeBladeTable = new DataTable();
        private DataTable insectGlaiveTable = new DataTable();
        private DataTable lightBowgunTable = new DataTable();
        private DataTable heavyBowgunTable = new DataTable();

        private double nekoShagekiBuff = 1.0;
        private double dodgeBuff = 1.0;
        private int gofuBuff = 0;
        private int tsumeBuff = 0;
        int motionvalue = 1;

        public Form1()
        {
            InitializeComponent();

            //DataTableに列を追加
            buffBulletTable.Columns.Add("name", typeof(string));
            buffBulletTable.Columns.Add("multi", typeof(double));
            buffHuntlingTable.Columns.Add("name", typeof(string));
            buffHuntlingTable.Columns.Add("multi", typeof(double));
            buffPurePhysTable.Columns.Add("name", typeof(string));
            buffPurePhysTable.Columns.Add("multi", typeof(double));
            buffTokushaTable.Columns.Add("name", typeof(string));
            buffTokushaTable.Columns.Add("multi", typeof(double));
            buffCustomPhysTable.Columns.Add("name", typeof(string));
            buffCustomPhysTable.Columns.Add("inc", typeof(int));
            buffCustomEleTable.Columns.Add("name", typeof(string));
            buffCustomEleTable.Columns.Add("inc", typeof(int));
            buffNekomeshiTable.Columns.Add("name", typeof(string));
            buffNekomeshiTable.Columns.Add("inc", typeof(int));
            buffKijinTable.Columns.Add("name", typeof(string));
            buffKijinTable.Columns.Add("inc", typeof(int));
            buffKairikiTable.Columns.Add("name", typeof(string));
            buffKairikiTable.Columns.Add("inc", typeof(int));
            buffAttackIncTable.Columns.Add("name", typeof(string));
            buffAttackIncTable.Columns.Add("inc", typeof(int));
            buffCriticalBoost.Columns.Add("name", typeof(string));
            buffCriticalBoost.Columns.Add("multi", typeof(double));

            //配列の用意
            string[,] rowBuffBullet = { { "【弾強化】", "1" }, { "弾強化 I ", "1.1" }, { "弾強化 II ", "1.2" } };
            string[,] rowBuffHuntling = { { "【笛の旋律】", "1" }, { "笛の旋律強化 I ", "1.1" }, { "笛の旋律強化 II ", "1.15" }, { "笛の旋律強化 III ", "1.2" } };
            string[,] rowBuffPurePhys = { { "【無属性強化】", "1" }, { "無属性強化", "1.05" }, { "無属性強化(弓)", "1.05" } };
            string[,] rowBuffTokusha = { { "【特殊射撃強化】", "1" }, { "特殊射撃強化 I ", "1.1" }, { "特殊射撃強化 II ", "1.2" } };
            string[,] rowBuffCustomInc = { { "【カスタム強化(攻撃)】", "0" }, { "攻撃カスタム I ", "6" }, { "攻撃カスタム II ", "12" }, { "攻撃カスタム III ", "24" } };
            string[,] rowBuffCustomEle = { { "【カスタム強化(属性)】", "0" }, { "属性カスタム I ", "30" }, { "属性カスタム II ", "60" }, { "属性カスタム III ", "90" } };
            string[,] rowBuffNekomeshi = { { "【食事】", "0" }, { "食事小|+5", "5" }, { "食事中|+10", "10" }, { "食事大|+15", "15" } };
            string[,] rowBuffKijin = { { "【鬼人薬】", "0" }, { "鬼人薬/ニトロダケ|+5", "5" }, { "鬼人薬G|+7", "7" } };
            string[,] rowBuffKairiki = { { "【種/丸薬】", "0" }, { "怪力の種|+10", "10" }, { "ネコの休憩術|+15", "15" }, { "怪力の丸薬|+25", "25" } };
            string[,] rowBuffAttackInc =
                { { "【攻撃珠】", "0" },{"攻撃Lv1|+3","3" }, { "攻撃Lv2|+6", "6" }, { "攻撃Lv3|+9", "9" },
                {"攻撃Lv4|+12","12" },{"攻撃Lv5|+15","15" },{"攻撃Lv6|+18","18" },{"攻撃Lv7|+21","21" } };
            string[,] rowBuffCriticalBoost = { { "【超会心|補正】", "1.25" }, { "超会心Lv1|1.3", "1.3" }, { "超会心Lv2|1.35", "1.35"},
                { "超会心Lv3|1.4", "1.4"} };
            for (int i = 0; i < rowBuffBullet.GetLength(0); i++)
            {
                DataRow row = buffBulletTable.NewRow();
                row["name"] = rowBuffBullet[i, 0];
                row["multi"] = rowBuffBullet[i, 1];
                buffBulletTable.Rows.Add(row);
            }
            for (int i = 0; i < rowBuffHuntling.GetLength(0); i++)
            {
                DataRow row = buffHuntlingTable.NewRow();
                row["name"] = rowBuffHuntling[i, 0];
                row["multi"] = rowBuffHuntling[i, 1];
                buffHuntlingTable.Rows.Add(row);
            }
            for (int i = 0; i < rowBuffPurePhys.GetLength(0); i++)
            {
                DataRow row = buffPurePhysTable.NewRow();
                row["name"] = rowBuffPurePhys[i, 0];
                row["multi"] = rowBuffPurePhys[i, 1];
                buffPurePhysTable.Rows.Add(row);
            }
            for (int i = 0; i < rowBuffTokusha.GetLength(0); i++)
            {
                DataRow row = buffTokushaTable.NewRow();
                row["name"] = rowBuffTokusha[i, 0];
                row["multi"] = rowBuffTokusha[i, 1];
                buffTokushaTable.Rows.Add(row);
            }
            for (int i = 0; i < rowBuffCustomInc.GetLength(0); i++)
            {
                DataRow row = buffCustomPhysTable.NewRow();
                row["name"] = rowBuffCustomInc[i, 0];
                row["inc"] = rowBuffCustomInc[i, 1];
                buffCustomPhysTable.Rows.Add(row);
            }
            for (int i = 0; i < rowBuffCustomEle.GetLength(0); i++)
            {
                DataRow row = buffCustomEleTable.NewRow();
                row["name"] = rowBuffCustomEle[i, 0];
                row["inc"] = rowBuffCustomEle[i, 1];
                buffCustomEleTable.Rows.Add(row);
            }
            for (int i = 0; i < rowBuffNekomeshi.GetLength(0); i++)
            {
                DataRow row = buffNekomeshiTable.NewRow();
                row["name"] = rowBuffNekomeshi[i, 0];
                row["inc"] = rowBuffNekomeshi[i, 1];
                buffNekomeshiTable.Rows.Add(row);
            }
            for (int i = 0; i < rowBuffKijin.GetLength(0); i++)
            {
                DataRow row = buffKijinTable.NewRow();
                row["name"] = rowBuffKijin[i, 0];
                row["inc"] = rowBuffKijin[i, 1];
                buffKijinTable.Rows.Add(row);
            }
            for (int i = 0; i < rowBuffKairiki.GetLength(0); i++)
            {
                DataRow row = buffKairikiTable.NewRow();
                row["name"] = rowBuffKairiki[i, 0];
                row["inc"] = rowBuffKairiki[i, 1];
                buffKairikiTable.Rows.Add(row);
            }
            for (int i = 0; i < rowBuffAttackInc.GetLength(0); i++)
            {
                DataRow row = buffAttackIncTable.NewRow();
                row["name"] = rowBuffAttackInc[i, 0];
                row["inc"] = rowBuffAttackInc[i, 1];
                buffAttackIncTable.Rows.Add(row);
            }
            for (int i = 0; i < rowBuffCriticalBoost.GetLength(0); i++)
            {
                DataRow row = buffCriticalBoost.NewRow();
                row["name"] = rowBuffCriticalBoost[i, 0];
                row["multi"] = rowBuffCriticalBoost[i, 1];
                buffCriticalBoost.Rows.Add(row);
            }

            buffBulletTable.AcceptChanges();
            buffHuntlingTable.AcceptChanges();
            buffPurePhysTable.AcceptChanges();
            buffTokushaTable.AcceptChanges();
            buffCustomPhysTable.AcceptChanges();
            buffCustomEleTable.AcceptChanges();
            buffNekomeshiTable.AcceptChanges();
            buffKijinTable.AcceptChanges();
            buffKairikiTable.AcceptChanges();
            buffAttackIncTable.AcceptChanges();
            buffCriticalBoost.AcceptChanges();

            comboBulletBuff.DataSource = buffBulletTable;
            comboHuntlingBuff.DataSource = buffHuntlingTable;
            comboPurePhysBuff.DataSource = buffPurePhysTable;
            comboTokushaBuff.DataSource = buffTokushaTable;
            comboCustomPhys.DataSource = buffCustomPhysTable;
            comboCustomEle.DataSource = buffCustomEleTable;
            comboNekomeshi.DataSource = buffNekomeshiTable;
            comboKijin.DataSource = buffKijinTable;
            comboKairiki.DataSource = buffKairikiTable;
            comboAttackInc.DataSource = buffAttackIncTable;
            comboCriticalBoost.DataSource = buffCriticalBoost;

            comboBulletBuff.DisplayMember = "name";
            comboHuntlingBuff.DisplayMember = "name";
            comboPurePhysBuff.DisplayMember = "name";
            comboTokushaBuff.DisplayMember = "name";
            comboCustomPhys.DisplayMember = "name";
            comboCustomEle.DisplayMember = "name";
            comboNekomeshi.DisplayMember = "name";
            comboKijin.DisplayMember = "name";
            comboKairiki.DisplayMember = "name";
            comboAttackInc.DisplayMember = "name";
            comboCriticalBoost.DisplayMember = "name";

            comboBulletBuff.ValueMember = "multi";
            comboHuntlingBuff.ValueMember = "multi";
            comboPurePhysBuff.ValueMember = "multi";
            comboTokushaBuff.ValueMember = "multi";
            comboCustomPhys.ValueMember = "inc";
            comboCustomEle.ValueMember = "inc";
            comboNekomeshi.ValueMember = "inc";
            comboKijin.ValueMember = "inc";
            comboKairiki.ValueMember = "inc";
            comboAttackInc.ValueMember = "inc";
            comboCriticalBoost.ValueMember = "multi";
        }

        //フォームのロード時処理

        private void Form1_Load(object sender, EventArgs e)
        {
            string Login = "Host=localhost; database = mhwib_db; userid=root; password=root;";

            try
            {
                //接続用のインスタンスを作成し接続までを実行
                MySqlConnection conn = new MySqlConnection(Login);
                conn.Open();
                MessageBox.Show("接続しました");

                //SQL文を実行
                MySqlDataAdapter dawt = new MySqlDataAdapter("SELECT name, weaponmultipiler FROM weapontype", conn);

                MySqlDataAdapter dals = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM longsword", conn);
                MySqlDataAdapter dags = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM greatsword", conn);
                MySqlDataAdapter dass = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM swordandshield", conn);
                MySqlDataAdapter dadb = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM dualblades", conn);
                MySqlDataAdapter dabo = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM bow", conn);
                MySqlDataAdapter dacb = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM chargeblade", conn);
                MySqlDataAdapter dagl = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM gunlance", conn);
                MySqlDataAdapter dahm = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM hammer", conn);
                MySqlDataAdapter dahb = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM heavybowgun", conn);
                MySqlDataAdapter dahh = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM huntlinghorn", conn);
                MySqlDataAdapter daig = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM insectglaive", conn);
                MySqlDataAdapter daln = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM lance", conn);
                MySqlDataAdapter dalb = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM lightbowgun", conn);
                MySqlDataAdapter dasa = new MySqlDataAdapter("SELECT name, damage, element, elementtype, critical, defencebonus FROM switchaxe", conn);
                MySqlDataAdapter dalsm = new MySqlDataAdapter("SELECT name, motionvalue, renki FROM longswordmotion", conn);

                //データを取得
                dawt.Fill(weaponTypeTable);

                dags.Fill(greatSwordTable);
                dals.Fill(longSwordTable);
                dass.Fill(SnSTable);
                dadb.Fill(dualBladesTable);
                dabo.Fill(bowTable);
                dacb.Fill(chargeBladeTable);
                dagl.Fill(gunLanceTable);
                dahm.Fill(hammerTable);
                dahb.Fill(heavyBowgunTable);
                dahh.Fill(huntlingHornTable);
                daig.Fill(insectGlaiveTable);
                daln.Fill(lanceTable);
                dalb.Fill(lightBowgunTable);
                dasa.Fill(switchAxeTable);

                dalsm.Fill(lsMotionTable);

                //データ表示
                comboWeaponType.DataSource = weaponTypeTable;
                //表示される値
                comboWeaponType.DisplayMember = "name";
                //対応する値
                comboWeaponType.ValueMember = "weaponmultipiler";

                conn.Close();
            }
            catch (MySqlException me)
            {
                MessageBox.Show("Error: " + me.Message);
            }
        }

        //comboWeaponTypeの値の切り替え時処理

        private void WeaponTypeSelectedValueChanged(object sender, EventArgs e)
        {
            labelWeaponMulti.Text = comboWeaponType.SelectedValue.ToString();
            //武器種で表示する武器名を絞り込む
            if (comboWeaponType.Text == "太刀")
            {
                //データを登録
                comboWeapon.DataSource = longSwordTable;
                //表示される値
                comboWeapon.DisplayMember = "name";
                //対応する値
                comboWeapon.ValueMember = "damage";
                //モーションを選択された武器種のものに
                comboMotion.DataSource = lsMotionTable;
                comboMotion.DisplayMember = "name";
                comboMotion.ValueMember = "motionvalue";

                //選択された武器種の画像を表示する
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\longsword.png";
            }
            else if (comboWeaponType.Text == "片手剣")
            {
                comboWeapon.DataSource = SnSTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\swordandshield.png";
            }
            else if (comboWeaponType.Text == "大剣")
            {
                comboWeapon.DataSource = greatSwordTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\greatsword.png";
            }
            else if (comboWeaponType.Text == "双剣")
            {
                comboWeapon.DataSource = dualBladesTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\dualblades.png";
            }
            else if (comboWeaponType.Text == "スラッシュアックス")
            {
                comboWeapon.DataSource = switchAxeTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\switchaxe.png";
            }
            else if (comboWeaponType.Text == "チャージアックス")
            {
                comboWeapon.DataSource = chargeBladeTable;
                comboWeapon.SelectedValue = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\chargeblade.png";
            }
            else if (comboWeaponType.Text == "ハンマー")
            {
                comboWeapon.DataSource = hammerTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\hammer.png";
            }
            else if (comboWeaponType.Text == "操虫棍")
            {
                comboWeapon.DataSource = insectGlaiveTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\insectglaive.png";
            }
            else if (comboWeaponType.Text == "狩猟笛")
            {
                comboWeapon.DataSource = huntlingHornTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\huntlinghorn.png";
            }
            else if (comboWeaponType.Text == "ランス")
            {
                comboWeapon.DataSource = lanceTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\lance.png";
            }
            else if (comboWeaponType.Text == "ガンランス")
            {
                comboWeapon.DataSource = gunLanceTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\gunlance.png";
            }
            else if (comboWeaponType.Text == "ライトボウガン")
            {
                comboWeapon.DataSource = lightBowgunTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\lightbowgun.png";
            }
            else if (comboWeaponType.Text == "ヘビィボウガン")
            {
                comboWeapon.DataSource = heavyBowgunTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\heavybowgun.png";
            }
            else if (comboWeaponType.Text == "弓")
            {
                comboWeapon.DataSource = bowTable;
                comboWeapon.DisplayMember = "name";
                comboWeapon.ValueMember = "damage";
                pictureWeapon.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\bow.png";
            }
        }

        //comboWeaponの値の切り替え時処理

        private void WeaponSelectedValueChanged(object sender, EventArgs e)
        {
            labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();

            //属性値
            if (comboWeaponType.Text == "太刀")
            {
                labelElement.Text = longSwordTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = longSwordTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = longSwordTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = longSwordTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "片手剣")
            {
                labelElement.Text = SnSTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = SnSTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = SnSTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = SnSTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "大剣")
            {
                labelElement.Text = greatSwordTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = greatSwordTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = greatSwordTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = greatSwordTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "双剣")
            {
                labelElement.Text = dualBladesTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = dualBladesTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = dualBladesTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = dualBladesTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "スラッシュアックス")
            {
                labelElement.Text = switchAxeTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = switchAxeTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = switchAxeTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = switchAxeTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "チャージアックス")
            {
                labelElement.Text = chargeBladeTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = chargeBladeTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = chargeBladeTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = chargeBladeTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "ハンマー")
            {
                labelElement.Text = hammerTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = hammerTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = hammerTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = hammerTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "狩猟笛")
            {
                labelElement.Text = huntlingHornTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = huntlingHornTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = huntlingHornTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = huntlingHornTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "ランス")
            {
                labelElement.Text = lanceTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = lanceTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = lanceTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = lanceTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "ガンランス")
            {
                labelElement.Text = gunLanceTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = gunLanceTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = gunLanceTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = gunLanceTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "操虫棍")
            {
                labelElement.Text = insectGlaiveTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = insectGlaiveTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = insectGlaiveTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = insectGlaiveTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "ライトボウガン")
            {
                labelElement.Text = lightBowgunTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = lightBowgunTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = lightBowgunTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = lightBowgunTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "ヘビィボウガン")
            {
                labelElement.Text = heavyBowgunTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = heavyBowgunTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = heavyBowgunTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = heavyBowgunTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }
            else if (comboWeaponType.Text == "弓")
            {
                labelElement.Text = bowTable.Rows[comboWeapon.SelectedIndex]["element"].ToString();
                labelElementType.Text = bowTable.Rows[comboWeapon.SelectedIndex]["elementtype"].ToString();
                labelCritical.Text = bowTable.Rows[comboWeapon.SelectedIndex]["critical"].ToString() + "%";
                labelDefenceBonus.Text = bowTable.Rows[comboWeapon.SelectedIndex]["defencebonus"].ToString();
                labelAttackDamage.Text = comboWeapon.SelectedValue.ToString();
            }

            //属性種別で属性画像を切り替える
            if (labelElementType.Text == "火")
            {
                pictureElementType.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\element_1.png";
            }
            else if (labelElementType.Text == "水")
            {
                pictureElementType.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\element_2.png";
            }
            else if (labelElementType.Text == "氷")
            {
                pictureElementType.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\element_3.png";
            }
            else if (labelElementType.Text == "雷")
            {
                pictureElementType.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\element_4.png";
            }
            else if (labelElementType.Text == "龍")
            {
                pictureElementType.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\element_5.png";
            }
            else if (labelElementType.Text == "毒")
            {
                pictureElementType.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\element_6.png";
            }
            else if (labelElementType.Text == "麻痺")
            {
                pictureElementType.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\element_7.png";
            }
            else if (labelElementType.Text == "睡眠")
            {
                pictureElementType.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\element_8.png";
            }
            else if (labelElementType.Text == "爆破")
            {
                pictureElementType.ImageLocation = @"C:\Users\81908\Source\Repos\MHWIBDamageCalcWithDatabase\img\element_9.png";
            }
            else
            {
                pictureElementType.ImageLocation = null;
            }
        }

        private void CalculateButtonClicked(object sender, EventArgs e)
        {
            //必要な変数を先に用意しておく
            int weaponDamage = (int)comboWeapon.SelectedValue;
            int customInc = (int)comboCustomPhys.SelectedValue;
            double weaponMulti = (double)comboWeaponType.SelectedValue;
            double bulletBuff = (double)comboBulletBuff.SelectedValue;
            double tokushaBuff = (double)comboTokushaBuff.SelectedValue;
            double purePhysBuff = (double)comboPurePhysBuff.SelectedValue;
            int attackIncBuff = (int)comboAttackInc.SelectedValue;
            int nekomeshiBuff = (int)comboNekomeshi.SelectedValue;
            int kijinBuff = (int)comboKijin.SelectedValue;
            int kairikiBuff = (int)comboKairiki.SelectedValue;
            double huntlingBuff = (double)comboHuntlingBuff.SelectedValue;
            

            double critical;
            //クリティカルなしをチェックしている場合クリティカルの倍率を1.0にする
            if (checkNonCritical.Checked)
            {
                critical = 1.0;
            }
            else
            {
                critical = (double)comboCriticalBoost.SelectedValue;
            }

            //武器攻撃力の計算式　※未完
            //計算式をいちいちみるのが面倒なのでここに記す
            //武器基礎攻撃力(表示攻撃力+カスタム強化)/武器係数*弾強化~笛の攻撃旋律までの
            //掛け算 + 攻撃珠+ネコの短期催眠術までの加算補正 * モーション値 / 100 * 肉質 /100
            // * 会心補正 通常であれば1.25 * ビン補正 * 距離補正 * 状態異常補正 * 怒り補正 = x が与物理ダメージの求め方

            //モーション値は太刀の縦切り 23を固定値に
            //肉質はドスジャグラスを斬属性 満腹状態の腹を斬った時の肉質70に

            //ここからややこしい計算式
            //モーション値、肉質などの情報を集めるのが面倒なのでモーション値と肉質などは固定の値を持つこととする
            //このあたりはスクレイピングなどでとって    きた情報で後で改良する

            int weaponDamageResult =
                (int)(((((((weaponDamage + customInc) / weaponMulti) * purePhysBuff * dodgeBuff * huntlingBuff) + attackIncBuff + nekomeshiBuff + kijinBuff + kairikiBuff + tsumeBuff + gofuBuff) * motionvalue / 100) * 70 / 100) * critical);

            labelCalculate.Text = weaponDamageResult.ToString();

            //属性ダメージの計算式は属性強化した上の武器の属性値 / 10 * 属性会心補正(なければ1.0倍)
            // * ため補正(モーション値) * 肉質 / 100 * 状態異常補正 * 怒り補正 = xが属性ダメの求め方
            //今回は属性ダメージ計算はしないようにする
        }

        private void NekoShagekiBuffCheckedChanged(object sender, EventArgs e)
        {
            if (checkNekoShageki.Checked)
            {
                nekoShagekiBuff = 1.1;
            }
            else
            {
                nekoShagekiBuff = 1.0;
            }
        }

        private void DodgeCheckedChanged(object sender, EventArgs e)
        {
            if (checkDodgeBuff.Checked)
            {
                dodgeBuff = 1.3;
            }
            else
            {
                dodgeBuff = 1.0;
            }
        }

        private void GofuCheckedChanged(object sender, EventArgs e)
        {
            if (checkGofu.Checked)
            {
                gofuBuff = 6;
            }
            else
            {
                gofuBuff = 0;
            }
        }

        private void TsumeCheckedChanged(object sender, EventArgs e)
        {
            if (checkTsume.Checked)
            {
                tsumeBuff = 9;
            }
            else
            {
                tsumeBuff = 0;
            }
        }

        private void linkDataBase(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //リンク先に移動したことにする
            linkLabel1.LinkVisited = true;
            //ブラウザで開く
            System.Diagnostics.Process.Start("https://mhworld.kiranico.com/ja");
        }
    }
}
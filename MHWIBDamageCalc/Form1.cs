using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MHWIBDamageCalc
{
    public partial class Form1 : Form
    {
        
        //DataTableオブジェクトを用意
        private DataTable weaponTable = new DataTable();
        private DataTable weaponMultiTable = new DataTable();
        private DataTable bulletIncTable = new DataTable();
        private DataTable tokushaTable = new DataTable();
        private DataTable testTable = new DataTable();
        private DataTable weaponLongswordTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            //-------------------------配列---------------------------------

            //DataTableに列を追加
            weaponTable.Columns.Add("NAME", typeof(string));
            weaponTable.Columns.Add("ATTACKDAMAGE", typeof(int));
            weaponMultiTable.Columns.Add("NAME", typeof(string));
            weaponMultiTable.Columns.Add("WEAPONMULTI", typeof(double));
            bulletIncTable.Columns.Add("AMOUNT", typeof(int));
            bulletIncTable.Columns.Add("BULLETMULTIPLE", typeof(double));
            tokushaTable.Columns.Add("AMOUNT", typeof(int));
            tokushaTable.Columns.Add("TOKUSHAMULTIPLE", typeof(double));

            //配列の用意
            //武器・攻撃力をまとめた配列
            string[,] rowWeaponDataArray =
                {{" ", "0" },
                {"天上天下天地無双刀","924"},
                {"debug","999" } };
            //武器種・武器係数をまとめた配列
            string[,] rowWeaponMultiDataArray =
            {{" ", "0" },
            {"太刀","3.3"},
            {"大剣","4.8"}};

            //弾強化・特射強化をまとめた配列
            string[,] rowBulletIncDataArray =
                {{"0","1"},{"1","1.1"},{"2","1.2"} };
            string[,] rowTokushaDataArray =
                {{"0", "1"},{"1", "1.1"},{"2","1.2"} };

            //---------------------ここまで配列------------------------------

            //------------------------------------------------------------

            //武器名・攻撃力
            for (int i = 0; i < rowWeaponDataArray.GetLength(0); i++)
            {
                //新しい行を作成
                DataRow row = weaponTable.NewRow();
                //各列に値をセット
                row["NAME"] = rowWeaponDataArray[i, 0];
                row["ATTACKDAMAGE"] = rowWeaponDataArray[i, 1];

                //DataTableに行を追加
                weaponTable.Rows.Add(row);
            }
            //武器種・武器係数
            for (int i = 0; i < rowWeaponMultiDataArray.GetLength(0); i++)
            {
                DataRow row = weaponMultiTable.NewRow();

                row["NAME"] = rowWeaponMultiDataArray[i, 0];
                row["WEAPONMULTI"] = rowWeaponMultiDataArray[i, 1];

                weaponMultiTable.Rows.Add(row);
            }
            //弾強化倍率
            for (int i = 0; i < rowBulletIncDataArray.GetLength(0); i++)
            {
                DataRow row = bulletIncTable.NewRow();

                row["AMOUNT"] = rowBulletIncDataArray[i, 0];
                row["BULLETMULTIPLE"] = rowBulletIncDataArray[i, 1];

                bulletIncTable.Rows.Add(row);
            }
            //特射倍率
            for (int i = 0; i < rowTokushaDataArray.GetLength(0); i++)
            {
                DataRow row = tokushaTable.NewRow();

                row["AMOUNT"] = rowBulletIncDataArray[i, 0];
                row["TOKUSHAMULTIPLE"] = rowTokushaDataArray[i, 1];

                tokushaTable.Rows.Add(row);
            }
            //---------------------------------------------------------------------

            //おまじない
            weaponTable.AcceptChanges();
            weaponMultiTable.AcceptChanges();
            bulletIncTable.AcceptChanges();
            tokushaTable.AcceptChanges();

            //ComboBoxのDataSourceにDataTableを割り当てる
            comboWeapon.DataSource = weaponTable;
            comboWeaponMulti.DataSource = weaponMultiTable;
            comboBulletIncreased.DataSource = bulletIncTable;
            comboTokusha.DataSource = tokushaTable;

            //表示される値はDataTableのNAME列
            comboWeapon.DisplayMember = "NAME";
            comboWeaponMulti.DisplayMember = "NAME";
            comboBulletIncreased.DisplayMember = "AMOUNT";
            comboTokusha.DisplayMember = "AMOUNT";

            //対応する値はDataTableの列
            comboWeapon.ValueMember = "ATTACKDAMAGE";
            comboWeaponMulti.ValueMember = "WEAPONMULTI";
            comboBulletIncreased.ValueMember = "BULLETMULTIPLE";
            comboTokusha.ValueMember = "TOKUSHAMULTIPLE";

        }

        private void comboWeapon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboWeapon.SelectedIndex != -1)
            {
                //ラベルに表示
                attackDamageLabel.Text = comboWeapon.SelectedValue.ToString();
            }
        }

        private void comboWeaponMulti_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboWeaponMulti.SelectedIndex != -1)
            {
                WeaponMultiLabel.Text = comboWeaponMulti.SelectedValue.ToString();
            }
        }

        private void buttonCalculate_Clicked(object sender, EventArgs e)
        {
            //物理ダメージの計算式

            //武器基礎攻撃力 + カスタム強化 / 武器係数　　※カスタム強化未実装
            int weaponDamage = (int)comboWeapon.SelectedValue;
            double weaponMulti = (double)comboWeaponMulti.SelectedValue;
            int totalAttackDamage = (int)(weaponDamage / weaponMulti);

            //各種バフ等　弾強化・特殊射撃強化・無属性強化・ネコの射撃術・回避の装衣・笛の攻撃旋律の掛け算
            //はこのタイミングで行う
            double bulletBuff = (double)comboBulletIncreased.SelectedValue;
            double tokushaBuff = (double)comboTokusha.SelectedValue;

            int buffTotalAttackDamage =
                (int)(totalAttackDamage * bulletBuff * tokushaBuff);

            CalculatedLabel.Text = buffTotalAttackDamage.ToString();
        }


        private void connectionButtonClicked(object sender, EventArgs e)
        {
            string Login = "Host=localhost; database = mhw_db; userid=root; password=root;";

            try
            {
                //接続用のインスタンスを作成し接続までを実行
                MySqlConnection conn = new MySqlConnection(Login);
                conn.Open();
                MessageBox.Show("接続しました");

                //SQL文を実行
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM mhw_test_table");

                //データを格納するテーブル作成
                testTable = new DataTable();
                weaponLongswordTable = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM mhw_test_table", conn);
                MySqlDataAdapter wda = new MySqlDataAdapter("SELECT name, damage FROM weapon_longsword", conn);
                //データを取得
                da.Fill(testTable);
                wda.Fill(weaponLongswordTable);

                //データ表示
                dataGridView1.DataSource = testTable;
                comboBox1.DataSource = weaponLongswordTable;

                //表示される値
                comboBox1.DisplayMember = "name";

                //対応する値
                comboBox1.ValueMember = "damage";

                conn.Close();
            } catch(MySqlException me)
            {
                MessageBox.Show("Error: " + me.Message);
            }
        }

        private void testSelectedValueChanged(object sender, EventArgs e)
        {
            labelAttackDamage.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
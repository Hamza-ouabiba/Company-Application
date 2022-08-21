using System;
using System.Data;
using System.Data.SqlClient;
namespace RNetApp
{
    public partial class ArticleMod : UserControl
    {
        AdoNet ado2 = new AdoNet();
        public ArticleMod()
        {
            InitializeComponent();
        }
        private void ArticleMod_Load(object sender, EventArgs e)
        {
            ado2.Cmd.CommandText = $"Select * from CLIENT";
            ado2.Cmd.Connection = ado2.Connection;
            ado2.Adapter.SelectCommand = ado2.Cmd;
            ado2.Adapter.Fill(ado2.Dt);
            comboClt.DataSource = ado2.Dt;
            comboClt.DisplayMember = ado2.Dt.Columns["NOM"].ToString();
            comboClt.ValueMember = ado2.Dt.Columns["IDCLIENT"].ToString();
        }
        private void enreBtn_Click(object sender, EventArgs e)
        {
            AdoNet ado2 = new AdoNet();
            SqlCommandBuilder sql = new SqlCommandBuilder(ado2.Adapter);
            ado2.Cmd.CommandText = $"Select * from changer";
            ado2.Cmd.Connection = ado2.Connection;
            ado2.Adapter.SelectCommand = ado2.Cmd;
            ado2.Adapter.Fill(ado2.Dt);
            try
            {
                DataRow dr = ado2.Dt.NewRow();
                //insertion des 35 lignes dans la dataTable changer  :
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "draps_double";
                dr[2] = int.Parse(textBox1.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "housse_couette_pm";
                dr[2] = int.Parse(textBox2.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "housse_couette_gm";
                dr[2] = int.Parse(textBox3.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "draps_housse_pm";
                dr[2] = int.Parse(textBox4.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "draps_housse_gm";
                dr[2] = int.Parse(textBox5.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "taie_oreiller_pm";
                dr[2] = int.Parse(textBox6.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "taie_oreiller_gm";
                dr[2] = int.Parse(textBox7.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "serviette_eponge";
                dr[2] = int.Parse(textBox8.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "draps_bain";
                dr[2] = int.Parse(textBox9.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "serviette_piscine";
                dr[2] = int.Parse(textBox10.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "tapis_sol";
                dr[2] = int.Parse(textBox11.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "draps_simple";
                dr[2] = int.Parse(textBox12.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "tapis_bain";
                dr[2] = int.Parse(textBox13.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "peignoir";
                dr[2] = int.Parse(textBox14.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "oreiller";
                dr[2] = int.Parse(textBox15.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "serviette_toilette_spa";
                dr[2] = int.Parse(textBox16.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "aleze";
                dr[2] = int.Parse(textBox17.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "draps_bain_spa";
                dr[2] = int.Parse(textBox18.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "tapis_m2";
                dr[2] = int.Parse(textBox19.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "serviette_table";
                dr[2] = int.Parse(textBox20.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "rideau_gm_m2";
                dr[2] = int.Parse(textBox21.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "housse_coussin_pm";
                dr[2] = int.Parse(textBox22.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "housse_coussin_gm";
                dr[2] = int.Parse(textBox23.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "taie_kiria";
                dr[2] = int.Parse(textBox24.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "housse_canape";
                dr[2] = int.Parse(textBox25.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "devant";
                dr[2] = int.Parse(textBox26.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "chemin_table";
                dr[2] = int.Parse(textBox27.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "nappe";
                dr[2] = int.Parse(textBox28.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "chemin_lit";
                dr[2] = int.Parse(textBox29.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "fouteille";
                dr[2] = int.Parse(textBox30.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "matlant";
                dr[2] = int.Parse(textBox31.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "torchon";
                dr[2] = int.Parse(textBox32.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "couverture";
                dr[2] = int.Parse(textBox33.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "couette";
                dr[2] = int.Parse(textBox34.Text);
                ado2.Dt.Rows.Add(dr);
                dr = ado2.Dt.NewRow();
                dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                dr[0] = "couette";
                dr[2] = int.Parse(textBox35.Text);
                ado2.Dt.Rows.Add(dr);
                //mise a jour de la base de donnée : 
                sql.GetInsertCommand();
                ado2.Adapter.Update(ado2.Dt);
                MessageBox.Show("Prix Insérée avec succées");
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Vous avez deja fixé les prix pour ce client");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

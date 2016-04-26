using Oracle.DataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Personal_Video_Manager
{
    public partial class Form1 : Form
    {
        public String[] cat= {"Animation","Comedy","Horror","Documentary","Music","Sports","Misc."};
        OpenFileDialog dlg;
        public Form1()
        {
            InitializeComponent();
            var list = Categori.Items;
            for (int i = 0; i < cat.Length; i++)
            {
                list.Add(cat[i]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlg = new OpenFileDialog();
            dlg.Title = "Open";
            dlg.ShowDialog();
            path.Text = dlg.FileName;
            button1.Left += path.Width-65;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String tmp = Tags.Text;
            ArrayList tagslist=new ArrayList();
            while (tmp.IndexOf(';') != -1)
            {
                tagslist.Add(tmp.Substring(0, tmp.IndexOf(';')));
                tmp = tmp.Substring(tmp.IndexOf(';') + 1);
            }
            ArrayList cats = new ArrayList(Categori.CheckedIndices);
            IWMPMedia mediainfo=Player.newMedia(dlg.FileName);
            VideoFile NewOne = new VideoFile(dlg.FileName,Description.Text,Rating.Value,tagslist,cats,DateTime.Now,mediainfo.duration);
            try
            {
                NewOne.Insert();
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message);
                return;
            }
            MessageBox.Show("Added");
            RefreshMainlist();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshMainlist();
        }

        private void listView1_MouseDoubleClick(object sender, EventArgs e)
        {
            Player.URL = listView1.FocusedItem.SubItems[4].Text;
            tabControl1.SelectedIndex = 1;
            Player.Ctlcontrols.play();
            Player.Ctlcontrols.next();
        }

        private void RefreshMainlist()
        {
            OracleConnection conn;
            OracleDataAdapter da;
            DataSet ds;
            DataTable dt;
            DataRow dr;
            OracleCommand comm;
            conn = new OracleConnection("Data Source=hpprobook440g2;User ID=system;Password=qazwsx");
            conn.Open();
            comm = new OracleCommand();
            comm.CommandText = "select * from mainlist";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "mainlist");
            dt = ds.Tables["mainlist"];
            foreach (ListViewItem item in listView1.Items)
            {
                listView1.Items.Remove(item);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                ListViewItem itm = new ListViewItem(new String[] { dr["filename"].ToString().Substring(dr["filename"].ToString().LastIndexOf('\\') + 1), dr["description"].ToString(), dr["rating"].ToString(), dr["duration"].ToString(), dr["filename"].ToString() });
                listView1.Items.Add(itm);
            }
        }
    }
}

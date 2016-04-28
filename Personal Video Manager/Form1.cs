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
        OracleConnection conn;
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

        public void Connect()
        {
            conn = new OracleConnection("Data Source=hpprobook440g2;User ID=system;Password=qazwsx");
            conn.Open();
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
            path.Text = "Select file ...";
            button1.Location = new Point(114,21);
            RefreshMainlist();
            RefreshLabels();
            RefreshDel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshMainlist();
            RefreshLabels();
            RefreshDel();
        }

        private void listView1_MouseDoubleClick(object sender, EventArgs e)
        {
            
        }

        private void RefreshMainlist()
        {
            Refreshlist("select * from mainlist");   
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String cmd = "select * from mainlist where filename like '%" + bSearch.Text + "%' or description like '%" + bSearch.Text + "%'";
            Refreshlist(cmd);
        }

        public void Refreshlist(String cmd)
        {
            OracleDataAdapter da;
            DataSet ds;
            DataTable dt;
            DataRow dr;
            OracleCommand comm;
            Connect();
            comm = new OracleCommand();
            comm.CommandText = cmd;
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
                ListViewItem itm = new ListViewItem(new String[] { dr["filename"].ToString().Substring(dr["filename"].ToString().LastIndexOf('\\') + 1), dr["description"].ToString(), dr["rating"].ToString(), dr["duration"].ToString(), dr["filename"].ToString(), dr["video_id"].ToString()});
                listView1.Items.Add(itm);
            }
            conn.Close();
        }

        public void RefreshDel()
        {
            OracleDataAdapter da;
            DataSet ds;
            DataTable dt;
            DataRow dr;
            OracleCommand comm;
            Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from mainlist";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "mainlist");
            dt = ds.Tables["mainlist"];
            foreach (ListViewItem item in listView2.Items)
            {
                listView2.Items.Remove(item);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                ListViewItem itm = new ListViewItem(new String[] { dr["filename"].ToString().Substring(dr["filename"].ToString().LastIndexOf('\\') + 1), dr["description"].ToString(), dr["rating"].ToString(), dr["duration"].ToString(), dr["filename"].ToString(), dr["video_id"].ToString() });
                listView2.Items.Add(itm);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Refreshlist("select * from mainlist where video_id in (select video_id from categorytree where cat_id =0)");
            tabControl1.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Refreshlist("select * from mainlist where video_id in (select video_id from categorytree where cat_id =1)");
            tabControl1.SelectedIndex = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Refreshlist("select * from mainlist where video_id in (select video_id from categorytree where cat_id =2)");
            tabControl1.SelectedIndex = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Refreshlist("select * from mainlist where video_id in (select video_id from categorytree where cat_id =3)");
            tabControl1.SelectedIndex = 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Refreshlist("select * from mainlist where video_id in (select video_id from categorytree where cat_id =4)");
            tabControl1.SelectedIndex = 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Refreshlist("select * from mainlist where video_id in (select video_id from categorytree where cat_id =5)");
            tabControl1.SelectedIndex = 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Refreshlist("select * from mainlist where video_id in (select video_id from categorytree where cat_id =6)");
            tabControl1.SelectedIndex = 2;
        }

        public int ReturnCount(int ID)
        {
            OracleDataAdapter da;
            DataSet ds;
            DataTable dt;
            DataRow dr;
            OracleCommand comm;
            Connect();
            comm = new OracleCommand();
            comm.CommandText = "select number_of_videos from category where cat_id=" + ID.ToString();
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "category");
            dt = ds.Tables["category"];
            dr = dt.Rows[0];
            return Convert.ToInt32(dr["number_of_videos"].ToString());
        }

        public void RefreshLabels()
        {
            OracleDataAdapter da;
            DataSet ds;
            DataTable dt;
            DataRow dr;
            OracleCommand comm;
            Connect();
            comm = new OracleCommand();
            comm.CommandText = "select cat_id,number_of_videos from category";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "category");
            dt = ds.Tables["category"];
            lCount0.Text = dt.Rows[0]["number_of_videos"].ToString();
            lCount1.Text = dt.Rows[1]["number_of_videos"].ToString();
            lCount2.Text = dt.Rows[2]["number_of_videos"].ToString();
            lCount3.Text = dt.Rows[3]["number_of_videos"].ToString();
            lCount4.Text = dt.Rows[4]["number_of_videos"].ToString();
            lCount5.Text = dt.Rows[5]["number_of_videos"].ToString();
            lCount6.Text = dt.Rows[6]["number_of_videos"].ToString();

        }

        private void bSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button10_Click(sender, e);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Player.URL = listView1.FocusedItem.SubItems[4].Text;

            // Adding to the database
            // Add to History
            OracleCommand comm;
            Connect();
            comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "INSERT INTO HISTORY VALUES(:VID,:FN,:PTH)";
            OracleParameter vid = new OracleParameter();
            vid.ParameterName = "VID";
            vid.DbType = DbType.Int32;
            vid.Value = Convert.ToInt32(listView1.FocusedItem.SubItems[5].Text);
            OracleParameter fn = new OracleParameter();
            fn.ParameterName = "FN";
            fn.DbType = DbType.String;
            fn.Value = (listView1.FocusedItem.SubItems[0].Text);
            OracleParameter pth = new OracleParameter();
            pth.ParameterName = "PTH";
            pth.DbType = DbType.String;
            pth.Value = (listView1.FocusedItem.SubItems[4].Text);
            comm.Parameters.Add(vid);
            comm.Parameters.Add(fn);
            comm.Parameters.Add(pth);
            comm.ExecuteNonQuery();


            //Add to RecentlyWatchedList
            DateTime date = DateTime.Now;
            comm.Parameters.Clear();
            comm.CommandText = "INSERT INTO RECENTLYWATCHED VALUES(" + Convert.ToInt32(listView1.FocusedItem.SubItems[5].Text) + ",'28-APRIL-2016'," + date.Hour + "," + date.Minute + "," + date.Second + ",'" + listView1.FocusedItem.SubItems[0].Text + "','" + listView1.FocusedItem.SubItems[4].Text + "')";
            /*
            OracleParameter dt = new OracleParameter();
            //dt.ParameterName = "DT";
            dt.DbType = DbType.String;
            
            dt.Value = "26-JANUARY-2016";//date.ToString("s");
            OracleParameter th = new OracleParameter();
            th.ParameterName = "TH";
            th.DbType = DbType.Int32;
            th.Value = date.Hour;
            OracleParameter tm = new OracleParameter();
            tm.ParameterName = "TM";
            tm.DbType = DbType.Int32;
            tm.Value = date.Minute;
            OracleParameter ts = new OracleParameter();
            ts.ParameterName = "TS";
            ts.DbType = DbType.Int32;
            ts.Value = date.Second;
            vid = new OracleParameter();
            vid.ParameterName = "VID";
            vid.DbType = DbType.Int32;
            vid.Value = Convert.ToInt32(listView1.FocusedItem.SubItems[5].Text);
            fn = new OracleParameter();
            fn.ParameterName = "FN";
            fn.DbType = DbType.String;
            fn.Value = (listView1.FocusedItem.SubItems[0].Text);
            pth = new OracleParameter();
            pth.ParameterName = "PTH";
            pth.DbType = DbType.String;
            pth.Value = (listView1.FocusedItem.SubItems[4].Text);
            comm.Parameters.Add(vid);
            //comm.Parameters.Add(dt);
            comm.Parameters.Add(th);
            comm.Parameters.Add(tm);
            comm.Parameters.Add(ts);
            comm.Parameters.Add(fn);
            comm.Parameters.Add(pth);*/
            try
            {
                comm.ExecuteNonQuery();
            }
            catch(OracleException oe)
            {

            }

            // Insert into Most Watched
            comm.CommandText = "UPDATE MOSTWATCHED SET FREQUENCY = FREQUENCY + 1 WHERE VIDEO_ID = :VID";
            comm.Parameters.Add(vid);
            comm.ExecuteNonQuery();
            // Switch and play the video
            tabControl1.SelectedIndex = 1;
            Player.Ctlcontrols.play();
            Player.Ctlcontrols.next();
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OracleCommand comm;
            Connect();
            comm = new OracleCommand();
            comm.CommandText = "vid_del";
            //MessageBox.Show(comm.CommandText);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add(new OracleParameter("id", listView2.FocusedItem.SubItems[5].Text));
            comm.Connection = conn;
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message);
                return;
            }
            RefreshMainlist();
            RefreshLabels();
            RefreshDel();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Refreshlist("SELECT * FROM RECENTLYWATCHED ,MAINLIST WHERE MAINLIST.VIDEO_ID = RECENTLYWATCHED.VIDEO_ID order by time_hour,time_min,time_sec desc");
            tabControl1.SelectedIndex = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Refreshlist("SELECT  * FROM MAINLIST , HISTORY WHERE MAINLIST.VIDEO_ID = HISTORY.VIDEO_ID");
            tabControl1.SelectedIndex = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Refreshlist("SELECT * FROM MAINLIST, MOSTWATCHED WHERE MAINLIST.VIDEO_ID = MOSTWATCHED.VIDEO_ID ORDER BY FREQUENCY DESC");
            tabControl1.SelectedIndex = 2;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

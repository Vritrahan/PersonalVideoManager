using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace Personal_Video_Manager
{
    class VideoFile
    {
        String path;
        String desc;
        int rating;
        ArrayList tags;
        ArrayList CatID;
        DateTime uploadDate;
        int duration;
        public String[] cat = { "Animation", "Comedy", "Horror", "Documentary", "Music", "Sports", "Misc." };
        public VideoFile(String path, String desc,int rating,ArrayList tags,ArrayList CatID,DateTime uploadDate,double duration)
        {
            this.path=path;
            this.desc = desc;
            this.rating = rating;
            this.tags = tags;
            this.CatID = CatID;
            this.uploadDate = uploadDate;
            this.duration = (int)(duration);
        }
        public void Insert()
        {
            OracleConnection conn;
            OracleCommand comm;
            conn = new OracleConnection("Data Source=hpprobook440g2;User ID=system;Password=qazwsx");
            conn.Open();
            comm = new OracleCommand();
            String tmp = "insert into mediainfo values(seq_idm.nextval,'" + path + "','" + path.Substring(path.LastIndexOf('\\')+1) + "'," + duration + ",'','','','','')";
            //System.Windows.Forms.MessageBox.Show(tmp);
            comm.CommandText = tmp;
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            comm = new OracleCommand();
            tmp = "insert into mainlist values(seq_id.nextval,'" + path + "'," + duration + ",'" + desc + "'," + rating + ")";
            //System.Windows.Forms.MessageBox.Show(tmp);
            comm.CommandText = tmp;
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            OracleDataAdapter da;
            DataSet ds;
            DataTable dt;
            DataRow dr;
            for (int i = 0; i < CatID.Count; i++)
            {
                comm = new OracleCommand();
                comm.CommandText = "select * from Category where Cat_ID="  + Convert.ToInt32(CatID[i].ToString());
                //System.Windows.Forms.MessageBox.Show(comm.CommandText);
                comm.CommandType = CommandType.Text;
                ds = new DataSet();
                da = new OracleDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "Category");
                dt = ds.Tables["Category"];
                dr = dt.Rows[0];
                comm = new OracleCommand();
                if (i == 0)
                {
                    tmp = "insert into CategoryTree values(" + Convert.ToInt32(CatID[i].ToString()) + ",'" + cat[(int)CatID[i]] + "'," + Convert.ToInt32(dr["number_of_videos"].ToString()) + "," + Convert.ToInt32(dr["c_rating"].ToString()) + ",seq_idc.nextval,'" + path + "'," + rating + ",'" + desc + "')";
                }
                else
                {
                    tmp = "insert into CategoryTree values(" + Convert.ToInt32(CatID[i].ToString()) + ",'" + cat[(int)CatID[i]] + "'," + Convert.ToInt32(dr["number_of_videos"].ToString()) + "," + Convert.ToInt32(dr["c_rating"].ToString()) + ",seq_idc.currval,'" + path + "'," + rating + ",'" + desc + "')";
                }
                //System.Windows.Forms.MessageBox.Show(tmp);
                comm.CommandText = tmp;
                comm.CommandType = CommandType.Text;
                comm.Connection = conn;
                comm.ExecuteNonQuery();
            }
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "INSERT INTO MOSTWATCHed VALUES(seq_idw.nextVal,:FN,:PTH,0)";
            cm.CommandType = CommandType.Text;
            OracleParameter fn = new OracleParameter();
            fn.ParameterName = "FN";
            fn.DbType = DbType.String;
            fn.Value = path.Substring(path.LastIndexOf('\\') + 1);
            OracleParameter pth = new OracleParameter();
            pth.ParameterName = "PTH";
            pth.DbType = DbType.String;
            pth.Value = path;
            cm.Parameters.Add(fn);
            cm.Parameters.Add(pth);
            cm.Connection = conn;
            cm.ExecuteNonQuery();
            conn.Close();
        }
    }
}

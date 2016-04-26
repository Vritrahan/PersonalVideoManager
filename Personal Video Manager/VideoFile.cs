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
            System.Windows.Forms.MessageBox.Show(tmp);
            comm.CommandText = tmp;
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            comm = new OracleCommand();
            tmp = "insert into mainlist values(seq_id.nextval,'" + path + "'," + duration + ",'" + desc + "'," + rating + ")";
            System.Windows.Forms.MessageBox.Show(tmp);
            comm.CommandText = tmp;
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}

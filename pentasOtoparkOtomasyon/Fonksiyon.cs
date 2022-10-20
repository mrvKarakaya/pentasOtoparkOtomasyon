using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pentasOtoparkOtomasyon
{
    class Fonksiyon
    {

        public SqlConnection Baglan()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F0TFDIA;Initial Catalog=pentasOtopark;Integrated Security=True");
            //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QJRV95P\\SQLEXPRESS;Initial Catalog=PendikKultur;Integrated Security=True");
            //SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["pentasOtopark"].ToString());
            baglanti.Open();
            return (baglanti);
        }

        public int cmd(string sqlcumle)
        {
            SqlConnection baglan = this.Baglan();
            SqlCommand sorgu = new SqlCommand(sqlcumle, baglan);
            int sonuc = 0;

            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + " (" + sqlcumle + ")");
            }
            sorgu.Dispose();
            baglan.Close();
            baglan.Dispose();
            return (sonuc);
        }

        public DataTable GetDataTable(string sql)
        {
            SqlConnection baglanti = this.Baglan();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglanti);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + " (" + sql + ")");
            }
            adapter.Dispose();
            baglanti.Close();
            baglanti.Dispose();
            return dt;
        }

        public DataSet GetDataSet(string sql)
        {
            SqlConnection baglanti = this.Baglan();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + " (" + sql + ")");
            }
            adapter.Dispose();
            baglanti.Close();
            baglanti.Dispose();
            return ds;
        }

        public DataRow GetDataRow(string sql)
        {
            DataTable table = GetDataTable(sql);
            if (table.Rows.Count == 0) return null;
            return table.Rows[0];
        }

        public string GetDataCell(string sql)
        {
            DataTable table = GetDataTable(sql);
            if (table.Rows.Count == 0) return null;
            return table.Rows[0][0].ToString();
        }

    }


}

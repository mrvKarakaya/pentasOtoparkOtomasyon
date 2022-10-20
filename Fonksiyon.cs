using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;


/// <summary>
/// Summary description for Fonksiyon
/// </summary>
public class Fonksiyon
{
    FileUpload DosyaIsmi;
   
   

    public Fonksiyon()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public SqlConnection baglan()
    {
        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QJRV95P\\SQLEXPRESS;Initial Catalog=PendikKultur;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Pesem"].ToString());
        baglanti.Open();
        return (baglanti);
    }

    public int cmd(string sqlcumle)
    {
        SqlConnection baglan = this.baglan();
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
        SqlConnection baglanti = this.baglan();
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
        SqlConnection baglanti = this.baglan();
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


    //JSON VERİ ÇEKMEK İÇİN KULLANDIK
    public string ConvertDataTabletoString(string sql)
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = this.baglan())
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                Dictionary<string, object> row;
                foreach (DataRow dr in dt.Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        row.Add(col.ColumnName, dr[col]);
                    }
                    rows.Add(row);
                }
                return serializer.Serialize(rows);
            }
        }
    }

    public static string youtubeUrltoID(string url)
    {
        System.Uri url1 = new Uri(url);

        var dic = System.Web.HttpUtility.ParseQueryString(url1.Query);

        return dic["v"];

    }


    public static string KodOlustur(string Text)
    {
        try
        {
            string strReturn = Text.Trim();
            strReturn = strReturn.Replace("ğ", "g");
            strReturn = strReturn.Replace("Ğ", "G");
            strReturn = strReturn.Replace("ü", "u");
            strReturn = strReturn.Replace("Ü", "U");
            strReturn = strReturn.Replace("ş", "s");
            strReturn = strReturn.Replace("Ş", "S");
            strReturn = strReturn.Replace("ı", "i");
            strReturn = strReturn.Replace("İ", "I");
            strReturn = strReturn.Replace("ö", "o");
            strReturn = strReturn.Replace("Ö", "O");
            strReturn = strReturn.Replace("ç", "c");
            strReturn = strReturn.Replace("Ç", "C");
            strReturn = strReturn.Replace("-", "+");
            strReturn = strReturn.Replace(" ", "+");
            strReturn = strReturn.Trim();
            strReturn = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9+]").Replace(strReturn, "");
            strReturn = strReturn.Trim();
            strReturn = strReturn.Replace("+", "-");
            return strReturn;
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

}
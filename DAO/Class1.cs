using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class sqlConnectionData
    {
        public static SqlConnection KetNoi()
        {
            SqlConnection cnn = new SqlConnection("server=.; Initial Catalog=QLBH;Integrated Security=SSPI");
            return cnn;
        }

    }
    public class DON_HANG_DAO
    {
        public static DataTable Load_DSDH()
        {
            SqlConnection cnn = sqlConnectionData.KetNoi();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("XEM_DS_DONHANG_SP", cnn);
            //cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
          //  cmd.ExecuteNonQuery();
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            cnn.Close();
            return dtb;
        }
    
   
        public static int DSDH_CHOXULY()
        {
            SqlConnection cnn = sqlConnectionData.KetNoi();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SL_DONHANG_CHOXULY_SP", cnn);
            //cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            
            cnn.Close();
            return result;
        }
       
    }
    public class NHAN_VIEN_DAO
    {
        public static DataTable NVGH()
        {
            SqlConnection cnn = sqlConnectionData.KetNoi();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("DS_NVGH_SP", cnn);
            //cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //  cmd.ExecuteNonQuery();
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            cnn.Close();
            return dtb;
        }
    }
}

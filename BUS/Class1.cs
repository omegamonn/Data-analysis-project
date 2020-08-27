using System;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;
namespace BUS
{
    public class DON_HANG_BUS
    {
        public static DataTable Load_DSDH()
        {
            return DON_HANG_DAO.Load_DSDH();
        }
        public static int DSDH_CHOXULY()
        {
            return DON_HANG_DAO.DSDH_CHOXULY();
        }
        
    }
    public class NHAN_VIEN_BUS
    {
        public static DataTable NVGH()
        {
            return NHAN_VIEN_DAO.NVGH();
        }
    }
}

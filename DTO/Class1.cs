using System;

namespace DTO
{
   
    public class DONHANG_DTO
    {
        private string maDONHANG;

        public string MaDONHANG { get => maDONHANG; set => maDONHANG = value; }
        private string nvBANHANG;
        public string NvBANHANG { get => nvBANHANG; set => nvBANHANG = value; }
        public string MaKHACHHANG { get => maKHACHHANG; set => maKHACHHANG = value; }
        public string NvGIAOHANG { get => nvGIAOHANG; set => nvGIAOHANG = value; }
        public DateTime NGAYMUA { get => nGAYMUA; set => nGAYMUA = value; }
        public string DcGIAO { get => dcGIAO; set => dcGIAO = value; }
        public string TrangthaiDONGIAO { get => trangthaiDONGIAO; set => trangthaiDONGIAO = value; }
        public float TongTIEN { get => tongTIEN; set => tongTIEN = value; }
        public string HtTHANHTOAN { get => htTHANHTOAN; set => htTHANHTOAN = value; }
        public string MaTHE { get => maTHE; set => maTHE = value; }
        public string TrangthaiTHANHTOAN { get => trangthaiTHANHTOAN; set => trangthaiTHANHTOAN = value; }
        public DateTime NgayGIAOHANG { get => ngayGIAOHANG; set => ngayGIAOHANG = value; }

        private string maKHACHHANG;
        private string nvGIAOHANG;
        private DateTime nGAYMUA;
        private string dcGIAO;
        private string trangthaiDONGIAO;
        private float tongTIEN;
        private string htTHANHTOAN;
        private string maTHE;
        private string trangthaiTHANHTOAN;
        private DateTime ngayGIAOHANG;
        public DONHANG_DTO(string maDH, string NvBH, string MaKH, string NvGH, DateTime NgMua, string dcGiao,
            string TrangthaiDG, float TTien, string HtTT, string MaThe, string TrangthaiTT, DateTime NgGiao)
        {
            MaDONHANG = maDH;
            NvBANHANG = NvBH;
            MaKHACHHANG = MaKH;
            NvGIAOHANG = NvGH;
            NGAYMUA = NgMua;
            DcGIAO = dcGiao;
            TrangthaiDONGIAO = TrangthaiDG;
            TongTIEN = TTien;
            HtTHANHTOAN = HtTT;
            MaTHE = MaThe;
            TrangthaiTHANHTOAN = TrangthaiTT;
            NgayGIAOHANG = NgGiao;
        }

    }

    public class CT_DONHANG_DTO
    {
        private string maDONHANG;

        public string MaDONHANG { get => maDONHANG; set => maDONHANG = value; }
        public string MaMATHANG { get => maMATHANG; set => maMATHANG = value; }
        public int SoLUONGMUA { get => soLUONGMUA; set => soLUONGMUA = value; }
        public float ThanhTIEN { get => thanhTIEN; set => thanhTIEN = value; }

        private string maMATHANG;
        private int soLUONGMUA;
        private float thanhTIEN;
        public CT_DONHANG_DTO(string maDH, string maMH, int slMUA, float TT)
        {
            MaDONHANG = maDH;
            MaMATHANG = maMH;
            SoLUONGMUA = slMUA;
            ThanhTIEN = TT;
        }
    }

    public class HANGHOA_DTO
    {
        private string maMATHANG;

        public string MaMATHANG { get => maMATHANG; set => maMATHANG = value; }
        public string MaNHANVIEN { get => maNHANVIEN; set => maNHANVIEN = value; }
        public string MaDOITAC { get => maDOITAC; set => maDOITAC = value; }
        public string TenMATHANG { get => tenMATHANG; set => tenMATHANG = value; }
        public int SoLUONGTON { get => soLUONGTON; set => soLUONGTON = value; }
        public float GiaNHAP { get => giaNHAP; set => giaNHAP = value; }
        public string TrangTHAI { get => trangTHAI; set => trangTHAI = value; }
        public string DvTINH { get => dvTINH; set => dvTINH = value; }
        public int LuongTOITHIEU { get => luongTOITHIEU; set => luongTOITHIEU = value; }

        private string maNHANVIEN;
        private string maDOITAC;
        private string tenMATHANG;
        private int soLUONGTON;
        private float giaNHAP;
        private string trangTHAI;
        private string dvTINH;
        private int luongTOITHIEU;
        public HANGHOA_DTO(string MaMH, string MaNV, string MaDT, string tenMH, int slTON, float giaNH, string TThai, string dv, int LuongTT)
        {
            MaMATHANG = MaMH;
            MaNHANVIEN = MaNV;
            MaDOITAC = MaDT;
            TenMATHANG = tenMH;
            SoLUONGTON = slTON;
            GiaNHAP = giaNH;
            TrangTHAI = TThai;
            DvTINH = dv;
            LuongTOITHIEU = LuongTT;
        }
    }
}

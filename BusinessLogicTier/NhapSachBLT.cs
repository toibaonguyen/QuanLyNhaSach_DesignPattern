using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CNPM.DataAccessTier;

namespace CNPM
{
    // Interface định nghĩa các chiến lược xử lý nhập sách
    interface INhapSachStrategy
    {
        bool KiemTraDieuKien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns);
        void ThucHien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns);
    }

    // Chiến lược mặc định, kiểm tra điều kiện và thực hiện các thao tác nhập sách
    class DefaultNhapSachStrategy : INhapSachStrategy
    {
        private SachBLT objSach = new SachBLT();
        private ThamSoDAT objThamSo = new ThamSoDAT();
        private NhapSachDAT objNhapSach = new NhapSachDAT();

        public bool KiemTraDieuKien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            for (int i = 0; i < list_ctns.Count; i++)
            {
                if (list_ctns[i].SoLuongNhap < objThamSo.GetQD1A())
                    return false;
                Sach sach = objSach.getSachbyID(list_ctns[i].MaSach);
                if (sach == null || sach.SoLuongTon > objThamSo.GetQD1B())
                    return false;
            }
            return true;
        }

        public void ThucHien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            nhapSach.MaPhieuNhap = objNhapSach.ThemPhieuNhap(nhapSach);
            for (int i = 0; i < list_ctns.Count; i++)
            {
                list_ctns[i].MaPhieuNhap = nhapSach.MaPhieuNhap;
                objNhapSach.ThemChiTietNhapSach(list_ctns[i]);
                Sach sach = objSach.getSachbyID(list_ctns[i].MaSach);
                sach.SoLuongTon += list_ctns[i].SoLuongNhap;
                objSach.Sua(sach);
            }
        }
    }

    // Chiến lược backup, nếu không đạt điều kiện thì không thực hiện nhập sách
    class BackupNhapSachStrategy : INhapSachStrategy
    {
        private Logger logger;

        public BackupNhapSachStrategy(Logger logger)
        {
            this.logger = logger;
        }

        public bool KiemTraDieuKien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            for (int i = 0; i < list_ctns.Count; i++)
            {
                if (list_ctns[i].SoLuongNhap < 0)
                {
                    logger.Log("Số lượng nhập sách không hợp lệ.");
                    return false;
                }
            }
            return true;
        }

        public void ThucHien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            logger.Log("Không thực hiện nhập sách do không đạt điều kiện.");
        }
    }

    class NhapSachBLT
    {
        private INhapSachStrategy strategy;

        public NhapSachBLT(INhapSachStrategy strategy)
        {
            this.strategy = strategy;
        }

        public bool Them(NhapSach nhap_sach, List<ChiTietNhapSach> list_ctns)
        {
            if (strategy.KiemTraDieuKien(nhap_sach, list_ctns))
            {
                strategy.ThucHien(nhap_sach, list_ctns);
                return true;
            }
            return false;
        }
    }

    // Logger để ghi nhật ký
    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine("LOG: " + message);
        }
    }
}

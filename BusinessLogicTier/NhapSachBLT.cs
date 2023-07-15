using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CNPM.DataAccessTier;

namespace CNPM
{

    //This is NOT STRATEGYYYYYYYYYYYYYYYYYYYYYYYY
    interface INhapSachStrategy
    {
        bool KiemTraDieuKien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns);
        void ThucHien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns);
    }

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

    class BackupNhapSachStrategy : INhapSachStrategy
    {
        private SachBLT objSach = new SachBLT();
        private ThamSoDAT objThamSo = new ThamSoDAT();
        private NhapSachDAT objNhapSach = new NhapSachDAT();

        public bool KiemTraDieuKien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            for (int i = 0; i < list_ctns.Count; i++)
            {
                if (list_ctns[i].SoLuongNhap < objThamSo.GetQD2A())
                    return false;
                Sach sach = objSach.getSachbyID(list_ctns[i].MaSach);
                if (sach == null || sach.SoLuongTon > objThamSo.GetQD2B())
                    return false;
            }
            return true;
        }

        public void ThucHien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            nhapSach.MaPhieuNhap = objNhapSach.ThemPhieuNhap(nhapSach);
            for (int i = list_ctns.Count; i >0; --i)
            {
                list_ctns[i].MaPhieuNhap = nhapSach.MaPhieuNhap;
                objNhapSach.ThemChiTietNhapSach(list_ctns[i]);
                Sach sach = objSach.getSachbyID(list_ctns[i].MaSach);
                sach.SoLuongTon += list_ctns[i].SoLuongNhap;
                objSach.Sua(sach);
            }
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

}

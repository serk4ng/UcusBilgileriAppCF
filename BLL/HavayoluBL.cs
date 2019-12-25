using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class HavayoluBL : IDisposable
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);

        UcusDbContext ctx = new UcusDbContext();
        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }
        public bool Ekle(Havayolu h)
        {
            ctx.Havayollari.Add(h);
            return ctx.SaveChanges() > 0;

        }
        public bool Sil(Havayolu h)
        {
            Havayolu hh = ctx.Havayollari.Find(h.Id_Havayolu);
            ctx.Havayollari.Remove(hh);
            return ctx.SaveChanges() > 0;

        }
        public bool Guncelle(Havayolu h)
        {
            Havayolu hh = ctx.Havayollari.Find(h.Id_Havayolu);
            ctx.Havayollari.Remove(hh);
            ctx.Havayollari.Add(h);
            return ctx.SaveChanges() > 0;
        }
        public DataTable GetDataTable(string cmdtext)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable HavayollariTable() => GetDataTable("Select * from tblHavayollari");
        public DataTable HavayollariEnvanterTable() => GetDataTable("Select hy.Havayolu_Adi, u.Ucak_Adi, he.[Adet],u.Id_Ucak,hy.Id_Havayolu,he.Id_Havayolu,he.Id_Ucak from tblHavayoluEnvanter he,tblHavayollari hy,tblUcak u where he.Id_Havayolu=hy.Id_Havayolu and he.Id_Ucak=u.Id_Ucak");

    }

}

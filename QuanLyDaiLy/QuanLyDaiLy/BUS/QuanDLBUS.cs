using QuanLyDaiLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy.BUS
{
    class QuanDLBUS
    {
        QuanDLDTO dataq;
         public QuanDLBUS()
        {
            dataq = new QuanDLDTO();
        }
        public DataTable getQuan()
        {
            return dataq.getQuan();
        }
        public DataTable getQuan1()
        {
            return dataq.getQuan1();
        }
        public bool InsertQuan(QuanDLdata q)
        {
            return dataq.InserQuan(q);
        }
        public bool UpDateQuan(QuanDLdata q)
        {
            return dataq.UpDateQuan(q);
        }
        public bool DeleteQuan(QuanDLdata q)
        {
            return dataq.DeleteQuan(q);
        }
    }
}

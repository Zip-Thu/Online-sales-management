using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Quyen
    {
        private int iMaQuyen;
        private string sTenQuyen;

        public DTO_Quyen(int iMaQuyen, string sTenQuyen)
        {
            this.iMaQuyen = iMaQuyen;
            this.sTenQuyen = sTenQuyen;
        }

        public DTO_Quyen()
        {
          
        }

        public int IMaQuyen { get => iMaQuyen; set => iMaQuyen = value; }
        public string STenQuyen { get => sTenQuyen; set => sTenQuyen = value; }
    }
}

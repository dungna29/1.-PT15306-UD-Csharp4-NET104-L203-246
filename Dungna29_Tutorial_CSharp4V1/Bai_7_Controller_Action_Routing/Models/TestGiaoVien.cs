using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_7_Controller_Action_Routing.Models
{
    public class TestGiaoVien
    {
        public List<GiaoVien> _lstGiaoViens;

        public TestGiaoVien()
        {
            _lstGiaoViens = new List<GiaoVien>()
            {
                new GiaoVien() {MaGV = "dungna29",Ten = "Dũng",Email = "Dungna29@fe.edu.vn",Image = "/images/img1.jpg"},
                new GiaoVien() {MaGV = "minhdq",Ten = "Minh",Email = "Minh@fe.edu.vn",Image = "/images/img1.jpg"},
                new GiaoVien() {MaGV = "thienth",Ten = "Thiện",Email = "thienth@fe.edu.vn",Image = "/images/img1.jpg"},
                new GiaoVien() {MaGV = "tiennh",Ten = "Tiến",Email = "tiennh@fe.edu.vn",Image = "/images/img1.jpg"},
                new GiaoVien() {MaGV = "datlt",Ten = "Đạt",Email = "datlt@fe.edu.vn",Image = "/images/img1.jpg"},
            };
        }
    }
}

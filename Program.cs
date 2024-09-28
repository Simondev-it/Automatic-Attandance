using StudentTester.Entities;

//IMPORT     JAVA UNTIL.*;

namespace StudentTester
{

    // TRONG MỌOT NAMESPACE CÓ NHIÊUF CLASS
    // CLASS THUỘC NAMESPACE - ỨNG 1 THƯ MỤC CHỨA NÓ 
    // TRONG NAMESPACE BẠN CÓ QUYỀN GÕ NHỮNG THỨ SAU : 
    //CLASS VÀ NHỮNG THỨ NGANG CƠ VỚI CLASS : INTERFACE , DELEGARES 

    // LỜI NKHUYEEN : TA KHÔNG NÊN GỘP CÁC CLASS VÀ CHUNG MỘT TẬP TIN VẬT LÝ NHƯ CÁC ĐOẠN CODE PHÍA DƯỚI MÀ NÊN TÁCH TỪNG MỖI CLASS LÀ 1 TẬP TIN RIÊNG LẺ 
    //ĐIỀU NÀY GIÚP QUẢN LÍ CẤU TRÚC THƯ MỤC VÀ DANH SÁCH TẬP TIN CODE , DANH SÁCH CÁC CLASS DỄ DÀNG HƠN , TRỰC QUAN HƠN 


    //public class Lyric()
    //{

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chúng TA LUÔN ĐẶT TÊN CHO MỌI THỨ QUANH TA DÙ CHO PHỨC TẠP HAY ĐƠN GIẢN 

            // BIẾN LÀ TÊN GỌI CHO 1 VALUE 
            //3,14 ->pi 
            double pi = 3.14;
            //10% GỌI LÀ DISCOUNT ,VAT 
            double vat = 0.1;
            //NTT , 1994 , TB , NVTPHCM , HT , CTCTL -> SẾP 
            //singer sep = new Singer (NTT , 1994 , TB , NVTPHCM , HT , CTCTL);

            Student an = new Student("SE1", "AN NGUYỄN " , 2004,8.4);

            an.FlexProfile();
        }
    }
}

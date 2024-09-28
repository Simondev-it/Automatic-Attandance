using System.Xml.Serialization;

namespace NullableTester
{

    // 1 namespace chứa nhiều classs , các class có thể nằm rải rác , riêng rẽ trên từng tâpj tin khác nhauu 
    // hoặc có thể nằm trong 1 tập tin vật lý như ở dưới đây : class student và class program chung nhau namespace 
    //NullableTester chung nhau 1 tập tin vật lý 
    // anh em cuối tuần về chung một nhà 
    // trong 1 namespace có nhiều class và mấy đứa ngang cơ với class - cungf hạng class : Interface , abstract Class , Delegates

    //KHUYÊN DÙNG : NẾU KHÔNG CÓ GÌ QUÁ ĐẶC BIỆT , THÌ TA NÊN TÁCH MỖI CLASS RA TỪNG FILE RIÊNG LẺ ĐỂ DỄ DÀNG QUẢN LÍ CÁC TẬP TIN , QUẢN LÍ DANH SÁCH CÁC CLASS Ở GÓC ĐỘ DỄ NHÌN , DỄ THỐNG KÊ SỐ LƯỢNG ; KHÔNG NƠI CHƠI GỘP !!!
    public interface Comparator { }
    public class Student
    {
        //MÌNH THỬ VIẾT CLASS MÀ KHÔNG CHƠI ENCAPSULATION 
        // KHÔNG ENCAPSULATION NGHĨA LÀ MẶC ÁO XUYÊN THẤU 
        // GIỐNG PH , Đ DI BĂNG : NHÀ CÓ BAO NHIÊU SỔ ĐỎ KHOE LÊN MẠNG --> PUBLIC 
        public string id;  // Id :.............
        public string name;//Name:..............
        public int yob;//YOB: ..................
        public double gpa;//GPA :...............

        // class giống như FORM , biểu mẫu , template , BLUE - PRINT , BẢN THIẾT KẾ BẢN PHÁC THẢO, CÁI KHUÔN 
        // CÓ NHIỀU KHOẢNG HỞ ĐỂ LÁY HỒI FILL VẬT LIỆU VÀO ĐỂ CÓ ĐƯỢC 1 OBJECT , 1 BẢN COPY
        //ĐỂ CÓ 1 BIỂU MẪU CHO RIÊNG MÌNH - OBJECT (CĂN CƯỚC CÔNG DÂN CỦA MÌNH )TA CẦN PHOTO 1 BẢN FORM - NEW 
        // SAU ĐÓ TA CẦN ĐỔ INFO VÀO (...)-> CÁI PHỄU PARAMETER --> CONTRUCTOR 
        // SAU KHI ĐỔ VẬT LIỆU VÀO , ĐIÊN VÒA CÁI FORM ĐƯỢC PHOTO CLONE 
        // TA CÓ 1 OBJECT VÀ TA NGỒI NHÒM NGÓ NÓ , LẤY TỜ GIẤY XEM LẠI COI ỔN KH -> GET 
        // SAU ĐÓ TA LẤY GÔM TẨY XÓA XÍU XIU ---> SET/SETTING CHỈNH SỬA TRÊN SẢN PHẨN TRÊN OBJECT 


        // CONTRUCTOR , GET/SET   

        //NẾU 1 CLASS KHÔNG LÀM CONTRUCTOR TỨC LÀ KHÔNG LÀM CÁI PHỄU ĐỂ HỨNG VẬT LIỆU ĐƯA VÀO THÌ TA VẪN LUÔN ĐÚC ĐƯỢC 1 OBJECT DEFAULT , OBJECT KHÔNG KHÍ LẤP ĐẦY CÁI KHUÔN , TA CÓ 1 TỜ GIẤY TRẮNG PHOTO CHỪA CHỖ CHO TA GÕ
        // NẾU CLASS CÁI KHUÔN KHÔNG CÓ CONTRUCTOR , RUNTIME SẼ TỰ TẠO GIÚP TA 1 CÁI PHỄU DEFAULT , PHỄU RỖNG , PHỄU EMPTY NGHĨA LÀ KHÔNG NHẬN ĐẦU VÀO , KHÔNG CÓ CODE BÊN TRONG 
        public Student() { }

        // SAU KHI CÓ PHỄU / CONTRUCTOR DÙNG ĐỂ NHẬN INFO , OBJECT ĐƯƠC LẤP ĐẦY VẬT LIỆU / INFO , TA CÓ THỂ XEM CHÚNG , FLEX CHÚNG , TRUNG BÀY CHÚNG 
        public void FlexProfile()
        {
            Console.WriteLine($"ID:{id} | NAME:{name} | YOB {yob }  | GPA : {gpa}"   );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student();
            an.FlexProfile();
            an.id = "SE1";
            an.name = "An Nguyễn ";
            an.yob = 2004;
            an.gpa = 3.98;
            an.FlexProfile() ;

            an = null;
            an.FlexProfile();
        }
    }
}

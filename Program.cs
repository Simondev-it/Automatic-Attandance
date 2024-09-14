namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBmi(70, 1.7);
        }

        // CHALLENGE : TÍNH VÀ IN RA CHỈ SỐ BMI CỦA AI ĐÓ .
        // BMI ĐO TÌNH TRẠNG MẬP ỐM DỰA TRÊN CÂN NẶNG KG , VÀ CHIỀU CAO M
        // BMI = CÂN NẶNG / (CHIỀU CAO)^2
        //BMI [18.5 ..... 24.9]--> CHUẨN 


        // TRIẾT LÝ THIẾT KẾ HÀM MLEM : HÀM MLEM LÀ HÀM NHẬN VÀO VÀ TRẢ RA 
        // HÀM NHẬN VÀO VÀ TRẢ RA LÀ HÀM SẼ DỄ DÀNG SỬ DỤNG Ở NHIỀU NƠI DO NÓ CHỈ LÀ MỘT GIÁ TRỊ NÊN LÀ NÓ SẼ ĐƯỢC TÍNH HỢP VÀO CÁC BIỂU THỨC TÍNH TOÁN KHÁC 

        //HÀM .SQRT(25) CHỈ TRẢ VỀ SỐ 5 , KHÔNG IN RA KẾT QUẢ 
        // SQRT(25)+ SQRT(100)

        //KĨ THUẬT CÒN CÁI DÂY NỊT 
        //GetBmiV2 GỌI LÀ TÊN HÀM - SIGNATURE OF A METHOD , DUY NHẤT 

        //{  CODE TRONG HÀM ĐƯỢC GỌI LÀ - THÂN HÀM BODY OF METHOD }
        //{ IMPLEMENTATION OF A METHOD } 
        // KĨ THUẬT CHỈ CÒN CÁI DÂY NỊT 
        // NẾU MÔTJ HÀM MÀ CHỈ CÓ DUY NHẤT 1 LỆNH , TA ĐƯỢC PHÉP RÚT GỌN THÂN HÀM 

        // BỎ LUÔN { BỎ LUÔN CHỮ RETURN , BỎ LUÔN  }
        // NỐI TÊN HÀM VÀ THÂN HÀM ĐÃ BỊ BỎ GẦN KẾT DÙNG KÍ TỰ ==> 
        //KĨ THUẬT NÀY ĐƯỢC GỌI LÀ EXPRESSION BODIED , EXPRESSION BODY 
        // THÂN HÀM NHÌN NHƯ BIỂU THỨC 

        // CẤM TUYỆT ĐỐI KO ĐƯỢC NHẦM LẪN VỚI BIỂU THỨC LAMDA , LAMDA EXPRESSION CŨNG XÀI => NHƯNG Ý NGHĨA KHÁC 
        // HỌC SAU !!!! 
        static double GetBmiV2(double weight, double height) => weight / Math.Pow(height, 2);
            
        static double GetBmi(double weight , double height)
        {
            double bmi = weight / Math.Pow(height, 2);
            return bmi;
            return weight / Math.Pow(height, 2);
        }
        static void PrintBmiV2(double weight, double height)
        {
            double bmi = weight / Math.Pow(height,2 );
            Console.WriteLine("BMI (w : {0} ; h : {1}) = {2}", weight, height, bmi);
            Console.WriteLine($"BMI (w : {weight} ; h : {height}) = {bmi}");
        }
        static void PrintBmi(double weight ,double height )
        {
            double bmi = weight / (height * height);
            Console.WriteLine("BMI (w : {0} ; h : {1}) = {2}", weight,height,bmi);
            Console.WriteLine($"BMI (w : {weight} ; h : {height}) = {bmi}");
        }
    }
}

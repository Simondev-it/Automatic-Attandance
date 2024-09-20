namespace NumbersTeser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumOddEvens();
        }

        //CHALLENGE #2 : VIẾT HÀM TÍNH TỔNG CÁC SỐ CHẴN TỪ 1 .. 10
        //                        TÍNH TỔNG CÁCH SỐ LẺ TỪ 1.10
        // 1 , 3 ,5 ,7 ,9 EXPETED-> 25
        // 2 , 4 ,6 ,8 ,10 EXPETED-> 30
        // 
        static void SumOddEvens()
        {
            var SumE = 0;
            var SumO = 0;
            for (int i = 1; i <= 10 ; i++)
            {
                if (i % 2  == 0)
                
                    SumE += i;
                else
                    SumO += i;
            }
            Console.WriteLine("Sum odd number: " + SumO);
            Console.WriteLine("Sum even number: " + SumE);
        }

        //CHALLENGE #1 : VIẾT HÀM IN RA CÁC SỐ TỪ 1 ĐẾN 100 SAU ĐÓ TÍNH TỔNG CÁC SỐ CỦA CHÚNG , IN RA TỔNG CỦA CHÚNG LUÔN

        static void PrintIntergerList()
        {
            Console.WriteLine("The list of number from 1..100");
            for (int i = 1; i <=100; i++)
               // Console.WriteLine(i + " ");
               // Console.WriteLine("{0}" + i);
                Console.WriteLine($"{i}");
            // for , if else được quyền bỏ ngoặc nhọn nếu chỉ có 1 lệnh
            // tính tổng hoy 
            // y chang java 
            int sum = 0;
            for (int i = 1; i <=100; i++)
            {
                sum += i;
                
            }// app hi vọng trả về 5050 . EXPECTED VALUE 
            // Lát hồi chạy xem ra số mấy . ACTUAL VALUE 
            //NẾU EXPECTED = ACTUAL -> HÀM NGON MLEM 
            //             /=       -> BUG 
            //UNIT TESTING TRONG SWT301 
            Console.WriteLine("tổng của các số từ 1 tới 100 là " + sum);
        }
        static void PlayWithVarriables()
        {
            //khai báo biến 
            //biến là một vùng ram được đặt tên chiếm một số byte để lưu data 
            int a = 5, b = 10;// declare variables and assign value 
            int c = 5;
            int d = 10;

            int e; // khai báo trước 
            e = 15;// gán value 

            var f = 20;// làm biếng khai báo kiểu dữ liệu 
                       // f sẽ được suy ra có datatype dựa trên value ngta cho nó . vậy f là int trong tình huống này do 20 là int 
                       //f = 3,14 ; vỡ mặt , biến int là đi gán float, ăn đòn 

            // var g;
            //g = 25;// báo lỗi do cpu không biết kích thước biến đẻe bố trí ram cho phù hợp , do đó dùng var phải gán ngay value 


            // kĩ thuật khai báo biến mà làm biếng chỉ ra data type sẽ được suy luận từ value gán cho nó , gọi là sự suy luận kiểu - TYPE INFERRANCE 
        }
    }
}

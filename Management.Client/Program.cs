using Management.Application.Services;
internal class Program
{
	static StudentService studentService = new StudentService();
	const int imkoniyatlar = 3;
	const int max = 12;

	static void Main(string[] args)
	{
		int imkoniyatlar = 0;
		bool access = false;

		do
		{
			Console.Clear();
			Console.WriteLine("TIZIMGA KIRISH");
			Console.Write("Parolngizni kiriting: ");
			string password = Console.ReadLine();

			if (password == "9999")
			{
				access = true;
				Console.WriteLine("\nXush kelibsiz");
				Console.ReadLine();
				break;
			}
			else
			{
				imkoniyatlar++;
				Console.WriteLine($"Parol noto‘g‘ri! Qolgan urinishlar: {imkoniyatlar - imkoniyatlar}");
				Console.ReadLine();
			}

		} while (imkoniyatlar < imkoniyatlar);

		if (!access)
		{
			Console.WriteLine("\nUrinishlar soni tugadi. Dastur yopildi!");
			return;
		}

		string option;
		do
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      TALABALAR QABULI       ");
			Console.WriteLine("  1  Yangi talaba qo‘shish   ");
			Console.WriteLine("  2  Talabalar ro‘yxati      ");
			Console.WriteLine("  3  Qabul statistikasi      ");
			Console.WriteLine("  0  Chiqish                 ");
			Console.ResetColor();
			Console.Write("Tanlang: ");
			option = Console.ReadLine();

			switch (option)
			{
				case "1":
					RegisterStudent();
					break;
				case "2":
					ShowStudents();
					break;
				case "3":
					ShowStatistics();
					break;
				case "0":
					Console.WriteLine("\n Dastur tugadi. Xayr!");
					break;
				default:
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(" Noto‘g‘ri tanlov!");
					Console.ReadLine();
					Console.ResetColor();
					break;
			}

		} while (option != "0");
	}

	static void RegisterStudent()
	{
		Console.Clear();

		if (studentService.DbContext.StudentCount >= max)
		{
			Console.WriteLine(" QABUL YOPIQ! Maksimal 12 ta talaba qabul qilinadi.");
			Console.ReadLine();
			return;
		}

		Console.Write(" Talaba ismini kiriting\n ISM: ");
		string firstName = Console.ReadLine();

		Console.Write(" Talaba familiyasini kiriting\n FAMILYA: ");
		string lastName = Console.ReadLine();

		studentService.AddStudent(firstName, lastName);

		var addedStudent = studentService.DbContext.Students[studentService.DbContext.StudentCount - 1];
		Console.WriteLine($"\n {addedStudent.FirstName} {addedStudent.LastName} muvaffaqiyatli ro‘yxatdan o‘tdingiz!");
		Console.WriteLine($" TALABA ID: {addedStudent.Id}");
		Console.ReadLine();
	}

	static void ShowStudents()
	{
		Console.Clear();
		if (studentService.DbContext.StudentCount == 0)
		{
			Console.WriteLine(" Hech qanday talaba yo‘q.");
		}
		else
		{
			Console.WriteLine(" Talabalar ro‘yxati:\n");
			for (int i = 0; i < studentService.DbContext.StudentCount; i++)
			{
				var students = studentService.DbContext.Students[i];  
				Console.WriteLine($"{i + 1}. {students.FirstName} {students.LastName} | ID: {students.Id}");
			}
		}
		Console.ReadLine();
	}

	static void ShowStatistics()
	{
		Console.Clear();
		int count = studentService.DbContext.StudentCount;
		Console.WriteLine("QABUL STATISTIKASI\n");
		Console.WriteLine($"Qabul qilinganlar: {count} ta");
		Console.WriteLine($"Maksimal sig‘im: {max} ta");
		Console.WriteLine($"Bo‘sh joylar: {max - count} ta");
		Console.ReadLine();
	}
}   
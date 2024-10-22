// using System;

// namespace TaskManager;

// class Program
// {
//     // Task 1: Student Attendance System
//     static void StudentAttendanceSystem()
//     {
//         string[] students = new string[5];
//         int count = 0;
//         while (count < 5)
//         {
//             Console.Write("Kun uchun ishtirokni kiriting: ");
//             string student = Console.ReadLine()!;
//             Console.WriteLine($"Ishtirokchi {student} mavjudmi? (1 - Ha, 0 - Yo'q)");
//             int isPresent = Convert.ToInt32(Console.ReadLine());
//             if (isPresent == 1)
//             {
//                 students[count] = student!;
//                 count++;
//             }
//             else
//             {
//                 Console.WriteLine("Ishtirokchi mavjud emas.");
//             }
//         }
//         Console.WriteLine("Ishtirokchilar ro'yxati:");
//         foreach (var student in students)
//         {
//             Console.WriteLine(student);
//         }
//     }

//     // Task 2: Voting System
//     static void VotingSystem()
//     {
//         string[] candidates = { "Ali", "Bobur", "Said" };
//         int[] votes = new int[3];
//         int voteCount = 0;
//         do
//         {
//             Console.WriteLine("Nomzodlarni tanlang:");
//             for (int i = 0; i < candidates.Length; i++)
//             {
//                 Console.WriteLine($"{i + 1}. {candidates[i]}");
//             }
//             Console.Write("Tanlovingizni kiriting: ");
//             int vote = Convert.ToInt32(Console.ReadLine()) - 1;
//             if (vote >= 0 && vote < candidates.Length)
//             {
//                 votes[vote]++;
//                 voteCount++;
//             }
//             else
//             {
//                 Console.WriteLine("Noto'g'ri tanlov.");
//             }
//             Console.WriteLine("Yana ovoz berishni xohlaysizmi? (1 - Ha, 0 - Yo'q)");
//         } while (Convert.ToInt32(Console.ReadLine()) == 1);

//         Console.WriteLine("Natijalar:");
//         for (int i = 0; i < candidates.Length; i++)
//         {
//             Console.WriteLine($"{candidates[i]}: {votes[i]} ovoz");
//         }
//     }

//     // Task 3: Course Enrollment System
//     static void CourseEnrollmentSystem()
//     {
//         string[] courses = { "Matematika", "Ingliz tili", "Fizika" };
//         bool[] enrollment = new bool[3];
//         do
//         {
//             Console.WriteLine("Kurslarni tanlang:");
//             for (int i = 0; i < courses.Length; i++)
//             {
//                 Console.WriteLine($"{i + 1}. {courses[i]}");
//             }
//             Console.Write("Tanlangan kursni kiriting: ");
//             int courseIndex = Convert.ToInt32(Console.ReadLine()) - 1;
//             if (courseIndex >= 0 && courseIndex < courses.Length)
//             {
//                 if (!enrollment[courseIndex])
//                 {
//                     enrollment[courseIndex] = true;
//                     Console.WriteLine($"{courses[courseIndex]} kursiga yozildingiz.");
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Siz {courses[courseIndex]} kursiga yozildingiz.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Noto'g'ri kurs.");
//             }
//             Console.WriteLine("Yana yozilishni xohlaysizmi? (1 - Ha, 0 - Yo'q)");
//         } while (Convert.ToInt32(Console.ReadLine()) == 1);
//     }

//     // Task 4: Gradebook Search System
//     static void GradebookSearch()
//     {
//         string[] students = { "Ali", "Bobur", "Said" };
//         double[] grades = { 85, 92, 78 };
//         Console.Write("Talaba ismini kiriting: ");
//         string studentName = Console.ReadLine()!;
//         int index = Array.IndexOf(students, studentName);
//         if (index >= 0)
//         {
//             Console.WriteLine($"{studentName}ning bahosi: {grades[index]}");
//         }
//         else
//         {
//             Console.WriteLine("Talaba topilmadi.");
//         }
//     }

//     // Task 5: Bank Account System
//     static void BankAccountSystem()
//     {
//         double balance = 0;
//         int transaction;
//         do
//         {
//             Console.WriteLine($"Hisob raqamingizdagi mablag': {balance} so'm");
//             Console.WriteLine("1. Mablag' qo'shish");
//             Console.WriteLine("2. Mablag' yechish");
//             Console.WriteLine("3. Chiqish");
//             transaction = Convert.ToInt32(Console.ReadLine());
//             switch (transaction)
//             {
//                 case 1:
//                     Console.Write("Mablag' kiriting: ");
//                     balance += Convert.ToDouble(Console.ReadLine());
//                     break;
//                 case 2:
//                     Console.Write("Mablag' yechish: ");
//                     double withdrawal = Convert.ToDouble(Console.ReadLine());
//                     if (withdrawal <= balance)
//                     {
//                         balance -= withdrawal;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Hisobda yetarli mablag' yo'q.");
//                     }
//                     break;
//                 case 3:
//                     Console.WriteLine("Tizimdan chiqilyapti...");
//                     break;
//                 default:
//                     Console.WriteLine("Noto'g'ri tanlov.");
//                     break;
//             }
//         } while (transaction != 3);
//     }

//     // Task 6: Employee Payroll System
//     static void EmployeePayrollSystem()
//     {
//         string[] employees = { "Ali", "Bobur", "Said" };
//         double[] salaries = { 5000, 5500, 4500 };
//         for (int i = 0; i < employees.Length; i++)
//         {
//             Console.WriteLine($"{employees[i]}ning maoshi: {salaries[i]} so'm");
//         }
//     }

//     // Task 7: Library Management System
//     static void LibraryManagementSystem()
//     {
//         string[] books = { "Kitob A", "Kitob B", "Kitob C" };
//         bool[] availability = { true, true, true };
//         do
//         {
//             Console.WriteLine("Kutubxona kitoblari:");
//             for (int i = 0; i < books.Length; i++)
//             {
//                 string status = availability[i] ? "Mavjud" : "Mavjud emas";
//                 Console.WriteLine($"{i + 1}. {books[i]} - {status}");
//             }
//             Console.Write("Kitobni tanlang: ");
//             int bookIndex = Convert.ToInt32(Console.ReadLine()) - 1;
//             if (bookIndex >= 0 && bookIndex < books.Length)
//             {
//                 if (availability[bookIndex])
//                 {
//                     availability[bookIndex] = false;
//                     Console.WriteLine($"{books[bookIndex]} kitobi olingan.");
//                 }
//                 else
//                 {
//                     Console.WriteLine($"{books[bookIndex]} kitobi hozirda mavjud emas.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Noto'g'ri kitob.");
//             }
//             Console.WriteLine("Yana kitob olishni xohlaysizmi? (1 - Ha, 0 - Yo'q)");
//         } while (Convert.ToInt32(Console.ReadLine()) == 1);
//     }

//     // Task 8: Inventory Tracking System
//     static void InventoryTrackingSystem()
//     {
//         string[] products = { "Mahsulot A", "Mahsulot B", "Mahsulot C" };
//         int[] quantities = { 10, 20, 15 };
//         do
//         {
//             Console.WriteLine("Mahsulotlar ro'yxati:");
//             for (int i = 0; i < products.Length; i++)
//             {
//                 Console.WriteLine($"{i + 1}. {products[i]} - {quantities[i]} ta");
//             }
//             Console.Write("Mahsulotni tanlang: ");
//             int productIndex = Convert.ToInt32(Console.ReadLine()) - 1;
//             if (productIndex >= 0 && productIndex < products.Length)
//             {
//                 Console.Write("Sotish miqdorini kiriting: ");
//                 int saleQuantity = Convert.ToInt32(Console.ReadLine());
//                 if (saleQuantity <= quantities[productIndex])
//                 {
//                     quantities[productIndex] -= saleQuantity;
//                     Console.WriteLine($"Sotildi: {saleQuantity} ta {products[productIndex]}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Yetarli mahsulot mavjud emas.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Noto'g'ri mahsulot.");
//             }
//             Console.WriteLine("Yana sotishni xohlaysizmi? (1 - Ha, 0 - Yo'q)");
//         } while (Convert.ToInt32(Console.ReadLine()) == 1);
//     }

//     // Task 9: Quiz Application
//     static void QuizApplication()
//     {
//         string[] questions = { "5 + 3?", "10 - 2?", "3 * 4?" };
//         int[] answers = { 8, 8, 12 };
//         int score = 0;

//         for (int i = 0; i < questions.Length; i++)
//         {
//             Console.WriteLine($"{i + 1}. {questions[i]}");
//             int userAnswer = Convert.ToInt32(Console.ReadLine());
//             if (userAnswer == answers[i])
//             {
//                 score++;
//             }
//         }

//         Console.WriteLine($"Sizning ballaringiz: {score}/{questions.Length}");
//     }

//     // Task 10: ATM Simulation System
//     static void ATMSimulationSystem()
//     {
//         double balance = 10000;
//         int transaction;
//         do
//         {
//             Console.WriteLine($"Hisobingizdagi mablag': {balance} so'm");
//             Console.WriteLine("1. Mablag' qo'shish");
//             Console.WriteLine("2. Mablag' yechish");
//             Console.WriteLine("3. Chiqish");
//             transaction = Convert.ToInt32(Console.ReadLine());
//             switch (transaction)
//             {
//                 case 1:
//                     Console.Write("Mablag' kiriting: ");
//                     balance += Convert.ToDouble(Console.ReadLine());
//                     break;
//                 case 2:
//                     Console.Write("Mablag' yechish: ");
//                     double withdrawal = Convert.ToDouble(Console.ReadLine());
//                     if (withdrawal <= balance)
//                     {
//                         balance -= withdrawal;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Hisobda yetarli mablag' yo'q.");
//                     }
//                     break;
//                 case 3:
//                     Console.WriteLine("Tizimdan chiqilyapti...");
//                     break;
//                 default:
//                     Console.WriteLine("Noto'g'ri tanlov.");
//                     break;
//             }
//         } while (transaction != 3);
//     }

//     // Task 11: Online Store Checkout System
//     static void OnlineStoreCheckoutSystem()
//     {
//         string[] products = { "Telefon", "Televizor", "Noutbuk" };
//         double[] prices = { 2000, 5000, 1500 };
//         double totalAmount = 0;
//         do
//         {
//             Console.WriteLine("Mahsulotlar ro'yxati:");
//             for (int i = 0; i < products.Length; i++)
//             {
//                 Console.WriteLine($"{i + 1}. {products[i]} - {prices[i]} so'm");
//             }
//             Console.Write("Mahsulotni tanlang: ");
//             int productIndex = Convert.ToInt32(Console.ReadLine()) - 1;
//             if (productIndex >= 0 && productIndex < products.Length)
//             {
//                 totalAmount += prices[productIndex];
//                 Console.WriteLine($"{products[productIndex]} qo'shildi.");
//             }
//             else
//             {
//                 Console.WriteLine("Noto'g'ri mahsulot.");
//             }
//             Console.WriteLine("Yana mahsulot qo'shishni xohlaysizmi? (1 - Ha, 0 - Yo'q)");
//         } while (Convert.ToInt32(Console.ReadLine()) == 1);

//         Console.WriteLine($"Umumiy summa: {totalAmount} so'm");
//     }

//     // Task 12: Calendar Date Checker
//     static void CalendarDateChecker()
//     {
//         Console.Write("Sana kiriting (yyyy-mm-dd formatida): ");
//         DateTime inputDate = Convert.ToDateTime(Console.ReadLine());
//         if (inputDate.DayOfWeek == DayOfWeek.Saturday || inputDate.DayOfWeek == DayOfWeek.Sunday)
//         {
//             Console.WriteLine($"Sana {inputDate.DayOfWeek} kuniga to'g'ri keladi.");
//         }
//         else
//         {
//             Console.WriteLine($"Sana {inputDate.DayOfWeek} kuniga to'g'ri keladi.");
//         }
//     }

//     // Task 13: Contact Book System
//     static void ContactBookSystem()
//     {
//         string[] names = { "Ali", "Bobur", "Said" };
//         string[] phones = { "998911234567", "998922345678", "998933456789" };
//         do
//         {
//             Console.WriteLine("Kontaktlar ro'yxati:");
//             for (int i = 0; i < names.Length; i++)
//             {
//                 Console.WriteLine($"{i + 1}. {names[i]} - {phones[i]}");
//             }
//             Console.WriteLine("Yangi kontakt qo'shish uchun 1 ni bosing.");
//             if (Convert.ToInt32(Console.ReadLine()) == 1)
//             {
//                 Console.Write("Ismni kiriting: ");
//                 string newName = Console.ReadLine()!;
//                 Console.Write("Telefon raqamini kiriting: ");
//                 string newPhone = Console.ReadLine()!;
//                 Array.Resize(ref names, names.Length + 1);
//                 Array.Resize(ref phones, phones.Length + 1);
//                 names[names.Length - 1] = newName!;
//                 phones[phones.Length - 1] = newPhone!;
//                 Console.WriteLine($"Kontakt qo'shildi: {newName} - {newPhone}");
//             }
//             Console.WriteLine("Kontaktlar ro'yxatini ko'rishni davom ettirishni xohlaysizmi? (1 - Ha, 0 - Yo'q)");
//         } while (Convert.ToInt32(Console.ReadLine()) == 1);
//     }

//     // Task 14: Reservation System
//     static void ReservationSystem()
//     {
//         string[] rooms = { "101", "102", "103", "104" };
//         bool[] reserved = { false, false, false, false };
//         do
//         {
//             Console.WriteLine("Xonalar ro'yxati:");
//             for (int i = 0; i < rooms.Length; i++)
//             {
//                 string status = reserved[i] ? "Band" : "Mavjud";
//                 Console.WriteLine($"{i + 1}. Xona {rooms[i]} - {status}");
//             }
//             Console.Write("Xonani tanlang: ");
//             int roomIndex = Convert.ToInt32(Console.ReadLine()) - 1;
//             if (roomIndex >= 0 && roomIndex < rooms.Length)
//             {
//                 if (!reserved[roomIndex])
//                 {
//                     reserved[roomIndex] = true;
//                     Console.WriteLine($"Xona {rooms[roomIndex]} band qilindi.");
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Xona {rooms[roomIndex]} band.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Noto'g'ri xona.");
//             }
//             Console.WriteLine("Yana xona bron qilishni xohlaysizmi? (1 - Ha, 0 - Yo'q)");
//         } while (Convert.ToInt32(Console.ReadLine()) == 1);
//     }

//     // Task 15: Student Grade Calculation System
//     static void StudentGradeCalculationSystem()
//     {
//         string[] students = { "Ali", "Bobur", "Said" };
//         double[] grades = new double[3];
//         for (int i = 0; i < students.Length; i++)
//         {
//             Console.WriteLine($"{students[i]} uchun baho kiriting:");
//             grades[i] = Convert.ToDouble(Console.ReadLine());
//         }
//         double average = grades.Average();
//         Console.WriteLine($"O'rtacha baho: {average}");
//     }

//     static void Main(string[] args)
//     {

//         StudentAttendanceSystem();
//         // VotingSystem();
//         // CourseEnrollmentSystem();
//         // GradebookSearch();
//         // BankAccountSystem();
//         // EmployeePayrollSystem();
//         // LibraryManagementSystem();
//         // InventoryTrackingSystem();
//         // QuizApplication();
//         // ATMSimulationSystem();
//         // OnlineStoreCheckoutSystem();
//         // CalendarDateChecker();
//         // ContactBookSystem();
//         // ReservationSystem();
//         // StudentGradeCalculationSystem();
//     }
// }


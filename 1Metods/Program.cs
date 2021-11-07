// void WriteHelloJo() //метод
// {
//     Console.WriteLine("Hello Jo"); //что делает метод
// }
// void WriteHelloSam()
// {
//     Console.WriteLine("Hello Sam");
// }
// void WriteHelloYou()
// {
//     Console.WriteLine("Hello You");
// }
// WriteHelloJo(); //вызов метода
// WriteHelloSam();
// WriteHelloYou();



// void WriteHello(string someName) //метод общий для всех вариантов
// {  //Код в скобках (string someName) называется параметром. 
//     //Параметр позволяет подставлять значение в метод при его вызове.
//     Console.WriteLine("Hello " + someName);
// }
// WriteHello("Jo");
// WriteHello("Sam");
// WriteHello("You");
// // Фактически мы говорим: «Каждый раз при вызове этого метода 
// // я буду подставлять строку символов с каким-либо именем. 
// // Любая подставляемая строка должна выводиться после слова
// // «Hello».



// void WriteHello(string firstName, string lastName)
// // несколько параметров метода выделяются запятыми
// {
//     Console.WriteLine("Hello "+ firstName +" "+ lastName);
//     // " "-пробел, + firstName + - добавление параметра к тексту
// }
// WriteHello("Petr", "Ivanov");



// //тут был эпический пример с 38 стр с "public" и т.п.
// //но компилятор ругался!!! сократил до минимума, заработало!
// void LuckyNumber(int numberOfTeeth, int age)
// {
//     Console.WriteLine("Счастливое число "
//     + numberOfTeeth * age);
// }
// LuckyNumber(24, 14);




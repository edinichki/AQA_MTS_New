﻿// See https://aka.ms/new-console-template for more information

using Abstraction;
using Encapsulation;

Client client1 = new Client();                      //создаем объекты со своими свойствами
client1.Id = 1;
client1.PhoneNumber = "+375 29 12345678";
client1.Email = "client1@test.com";
client1.Activate();

Client client2 = new Client();
client2.Id = 2;
client2.PhoneNumber = "+375 29 12345679";
client2.Email = "client2@test.com";
client2.Activate();
client2.Pause();

Console.Out.WriteLine(client1.Id);
Console.Out.WriteLine(client1.PhoneNumber);

Console.Out.WriteLine(client2.Id);
Console.Out.WriteLine(client2.PhoneNumber);

State state = new State();
// переменная publicVar общедоступна

Console.WriteLine(state.publicVar);
state.PrintPublic();


// state.internalVar = ""; - Ошибка
// state.PrintInternal(); - Ошибка
// state.PrintProtectedInternal(); - Ошибка
// state.PrintProtectedPrivate();  - Ошибка